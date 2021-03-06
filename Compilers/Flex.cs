using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Constructor.Compilers
{
    class Flex
    {
        public static string Path_to_flex = Path.Combine(DataRegistry.program_path, @"libs\flex\bin\mxmlc.exe");

        public delegate void CompleteHandler(object sender);

        public event CompleteHandler Complete;

        public void compile(string filename_from, string filename_to)
        {
            Process proc = new Process
            {
                StartInfo =
                {
                    Arguments = string.Format("\"{0}\" -o \"{1}\"",
                                            filename_from,
                                            filename_to),
                    FileName = Path_to_flex,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false
                }
            };
            proc.EnableRaisingEvents = true;
            proc.Exited += new EventHandler(proc_Exited);

            proc.Start();
        }

        private void proc_Exited(object sender, EventArgs e)
        {
            if(Complete != null)
                Complete(this);
        }
    }
}
