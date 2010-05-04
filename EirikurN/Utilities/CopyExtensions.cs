using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace EirikurN.Utilities
{
    public static class CopyExtensions
    {
        public static void CopyTo(this FileInfo file, string toPath, Action<CopyProgressInfo> onProgress)
        {
            var progressInfo = new CopyProgressInfo() { TotalBytes = file.Length };
            CopyFileEx(file.FullName, toPath, t => { progressInfo.BytesTransferred = t; onProgress(progressInfo); });
        }

        public static void CopyTo(this DirectoryInfo directory, string toPath)
        {
            CopyTo(directory, toPath, null);
        }

        public static void CopyTo(this DirectoryInfo directory, string toPath, Action<DirectoryCopyProgressInfo> onProgress)
        {
            var progressInfo = new DirectoryCopyProgressInfo();
            long totalCopied = 0;
            var files = directory.GetFiles("*", SearchOption.AllDirectories);
            progressInfo.TotalBytes = files.Sum(f => f.Length);

            var progressHandler = new Action<long>(transferred =>
            {
                if (onProgress != null)
                {
                    progressInfo.CurrentFileTransferred = transferred;
                    progressInfo.BytesTransferred = totalCopied + transferred;
                    onProgress(progressInfo);
                }
            });

            foreach (var file in files)
            {
                progressInfo.CurrentFileName = file.FullName;
                progressInfo.CurrentFileSize = file.Length;

                var newFile = new FileInfo(Path.Combine(toPath, file.FullName.Replace(directory.FullName, "").TrimStart('\\')));
                if (!newFile.Directory.Exists)
                    newFile.Directory.Create();
                CopyFileEx(file.FullName, newFile.FullName, progressHandler);

                totalCopied += progressInfo.CurrentFileSize;
            }
        }

        #region Interop code
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CopyFileEx(string lpExistingFileName, string lpNewFileName,
           CopyProgressRoutine lpProgressRoutine, IntPtr lpData, ref Int32 pbCancel,
           CopyFileFlags dwCopyFlags);

        delegate CopyProgressResult CopyProgressRoutine(long TotalFileSize, long TotalBytesTransferred, long StreamSize,
                                                        long StreamBytesTransferred, uint dwStreamNumber,
                                                        CopyProgressCallbackReason dwCallbackReason, IntPtr hSourceFile,
                                                        IntPtr hDestinationFile, IntPtr lpData);

        enum CopyProgressResult : uint
        {
            PROGRESS_CONTINUE = 0,
            PROGRESS_CANCEL = 1,
            PROGRESS_STOP = 2,
            PROGRESS_QUIET = 3
        }

        enum CopyProgressCallbackReason : uint
        {
            CALLBACK_CHUNK_FINISHED = 0x00000000,
            CALLBACK_STREAM_SWITCH = 0x00000001
        }

        [Flags]
        enum CopyFileFlags : uint
        {
            COPY_FILE_FAIL_IF_EXISTS = 0x00000001,
            COPY_FILE_RESTARTABLE = 0x00000002,
            COPY_FILE_OPEN_SOURCE_FOR_WRITE = 0x00000004,
            COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 0x00000008
        }

        private static void CopyFileEx(string oldFile, string newFile, Action<long> progressHandler)
        {
            var routine = new CopyProgressRoutine((total, transferred, streamSize, streamByteTrans, dwStreamNumber, reason, hSource, hDest, lpData) =>
            {
                progressHandler(transferred);
                return CopyProgressResult.PROGRESS_CONTINUE;
            });
            int pbCancel = 0;
            CopyFileEx(oldFile, newFile, routine, IntPtr.Zero, ref pbCancel, CopyFileFlags.COPY_FILE_RESTARTABLE);
        }
        #endregion
    }

    public class CopyProgressInfo
    {
        public long BytesTransferred { get; set; }
        public long TotalBytes { get; set; }
    }
    public class DirectoryCopyProgressInfo : CopyProgressInfo
    {
        public string CurrentFileName { get; set; }
        public long CurrentFileTransferred { get; set; }
        public long CurrentFileSize { get; set; }
    }
}