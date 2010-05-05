using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EirikurN.Utilities;

namespace Constructor
{
    public partial class Compile : Form
    {
        public DataRegistry registry;
        public DataRegistry cregistry;
        public Compile()
        {
            InitializeComponent();
        }

        private void Compile_Load(object sender, EventArgs e)
        {
            step_one();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Height < 300)
                this.Height = 530;
            else
                this.Height = 280;
        }

        /// <summary>
        /// //////////////////////////////////////////////////
        /// </summary>

        public static string RelativePath(string absPath, string relTo)
        {
            string[] absDirs = absPath.Split('\\');
            string[] relDirs = relTo.Split('\\');

            // Get the shortest of the two paths
            int len = absDirs.Length < relDirs.Length ? absDirs.Length : relDirs.Length;

            // Use to determine where in the loop we exited
            int lastCommonRoot = -1;
            int index;

            // Find common root
            for (index = 0; index < len; index++)
            {
                if (absDirs[index] == relDirs[index]) lastCommonRoot = index;
                else break;
            }

            // If we didn't find a common prefix then throw
            if (lastCommonRoot == -1)
            {
                throw new ArgumentException("Paths do not have a common base");
            }

            // Build up the relative path
            StringBuilder relativePath = new StringBuilder();

            // Add on the ..
            for (index = lastCommonRoot + 1; index < absDirs.Length; index++)
            {
                if (absDirs[index].Length > 0) relativePath.Append("..\\");
            }

            // Add on the folders
            for (index = lastCommonRoot + 1; index < relDirs.Length - 1; index++)
            {
                relativePath.Append(relDirs[index] + "\\");
            }
            relativePath.Append(relDirs[relDirs.Length - 1]);

            return relativePath.ToString();
        }

        private void step_one()
        {
            step_counter.Text = "1 / 5";
            total_text.Text = "Копирование дистрибутива";
            total_progress.Value = 1;

            cregistry = new DataRegistry(registry);

            step_one_bw.RunWorkerAsync();
        }
        private void step_two()
        {
            step_counter.Text = "2 / 5";
            total_text.Text = "Копирование контента";
            total_progress.Value = 2;

            step_two_bw.RunWorkerAsync();
        }
        private void step_three()
        {
            step_counter.Text = "3 / 5";
            total_text.Text = "Копирование миниатюр";
            total_progress.Value = 3;

            step_three_bw.RunWorkerAsync();
        }
        private void step_four()
        {
            step_counter.Text = "4 / 5";
            total_text.Text = "Копирование дизайна";
            total_progress.Value = 4;

            step_four_bw.RunWorkerAsync();
        }
        private void step_five()
        {
            step_counter.Text = "5 / 5";
            total_text.Text = "Компиляция";
            total_progress.Value = 5;

            step_five_bw.RunWorkerAsync();
        }

        private void step_one_bw_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\MyProjects\MemoryBox\test\bin-debug");//@TMP: Distrib
            dirInfo.CopyTo(registry.settings_project_path, (p) => //@TMP: Project folder
            {
                step_one_bw.ReportProgress((int)((double)p.BytesTransferred * 100 / p.TotalBytes), p.CurrentFileName);
            });
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            current_progress.Value = e.ProgressPercentage;
            current_text.Text = (string)e.UserState;
        }

        private void step_one_bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            step_two();
        }

        private void step_two_bw_DoWork(object sender, DoWorkEventArgs e)
        {
            // Копирование контента
            string destination = registry.settings_project_path;

            cregistry.school_photo = @"school\photo.jpg";
            step_two_copy(registry.school_photo, cregistry.school_photo);

            cregistry.school_pictures_director = @"school\director.jpg";
            step_two_copy(registry.school_pictures_director, cregistry.school_pictures_director);
            cregistry.school_pictures_history = @"school\history.jpg";
            step_two_copy(registry.school_pictures_history, cregistry.school_pictures_history);
            cregistry.school_pictures_video = @"school\video.jpg";
            step_two_copy(registry.school_pictures_video, cregistry.school_pictures_video);

            cregistry.school_director_photo = @"school\director\photo.jpg";
            step_two_copy(registry.school_director_photo, cregistry.school_director_photo);
            cregistry.school_director_video = @"school\director\video.flv";
            step_two_copy(registry.school_director_video, cregistry.school_director_video);

            cregistry.school_video = @"school\director\video.flv";
            step_two_copy(registry.school_video, cregistry.school_video);

            // SCHOOLMATES 
            for (int i = 0; i < registry.schoolmates.Count; ++i)
            {
                User u = registry.schoolmates[i];
                User cu = cregistry.schoolmates[i];

                cu.photo = Path.Combine(Path.Combine(@"schoolmates", cu.name), @"photo.jpg");
                step_two_copy(u.photo, cu.photo);


                u.fill_photos_list();
                cu.photos_list = new string[u.photos_list.Count()];
                for (int ii = 0; ii < u.photos_list.Count(); ++ii)
                {
                    string item = u.photos_list[ii];
                    cu.photos_list[ii] = Path.Combine(Path.Combine(@"schoolmates", cu.name), Path.Combine(@"photos", Path.GetFileName(item)));
                    step_two_copy(item, cu.photos_list[ii]);
                }

                u.fill_videos_list();
                cu.videos_list = new string[u.videos_list.Count()];
                for (int ii = 0; ii < u.videos_list.Count(); ++ii)
                {
                    string item = u.videos_list[ii];
                    cu.videos_list[ii] = Path.Combine(Path.Combine(@"schoolmates", cu.name), Path.Combine(@"videos", Path.GetFileName(item)));
                    step_two_copy(item, cu.videos_list[ii]);
                }
            }
            // TEACHERS 
            for (int i = 0; i < registry.teachers.Count; ++i)
            {
                User u = registry.teachers[i];
                User cu = cregistry.teachers[i];

                cu.photo = Path.Combine(Path.Combine(@"teachers", cu.name), @"photo.jpg");
                step_two_copy(u.photo, cu.photo);


                u.fill_photos_list();
                cu.photos_list = new string[u.photos_list.Count()];
                for (int ii = 0; ii < u.photos_list.Count(); ++ii)
                {
                    string item = u.photos_list[ii];
                    cu.photos_list[ii] = Path.Combine(Path.Combine(@"teachers", cu.name), Path.Combine(@"photos", Path.GetFileName(item)));
                    step_two_copy(item, cu.photos_list[ii]);
                }

                u.fill_videos_list();
                cu.videos_list = new string[u.videos_list.Count()];
                for (int ii = 0; ii < u.videos_list.Count(); ++ii)
                {
                    string item = u.videos_list[ii];
                    cu.videos_list[ii] = Path.Combine(Path.Combine(@"teachers", cu.name), Path.Combine(@"videos", Path.GetFileName(item)));
                    step_two_copy(item, cu.videos_list[ii]);
                }
            }
            // ARCHIVE 
            for (int i = 0; i < registry.archive.Count(); ++i)
            {
                ArchiveSection a = registry.archive[i];
                ArchiveSection ca = cregistry.archive[i];

                a.fill_photos_list();
                ca.photos_list = new string[a.photos_list.Count()];
                for (int ii = 0; ii < a.photos_list.Count(); ++ii)
                {
                    string item = a.photos_list[ii];
                    ca.photos_list[ii] = Path.Combine(Path.Combine(@"archive", ca.name), Path.GetFileName(item));
                    step_two_copy(item, ca.photos_list[ii]);
                }
            }

            cregistry.general_intro_video = @"intro.flv";
            step_two_copy(registry.general_intro_video, cregistry.general_intro_video);
        }

        private void step_two_copy(string from, string to)
        {
            if (from == "")
                return;

            FileInfo file;
            file = new FileInfo(from);
            file.CopyTo(destinationPath(to), (p) =>
            {
                step_two_bw.ReportProgress((int)((double)p.BytesTransferred * 100 / p.TotalBytes), Path.GetFileName(from));
            });
        }

        private void createFoldersOnTheWay(string dest)
        {
            if (Path.GetExtension(dest) != string.Empty)
            {
                // FILE
                if (!Directory.Exists(Path.GetDirectoryName(dest)))
                    Directory.CreateDirectory(Path.GetDirectoryName(dest));
            }
            else
            {
                // DIRECTORY
                if (!Directory.Exists(dest))
                    Directory.CreateDirectory(dest);
            }
        }

        private void step_two_bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            step_three();
        }

        private void step_three_bw_DoWork(object sender, DoWorkEventArgs e)
        {
            // Копирование миниатюр

            // SCHOOLMATES
            for (int i = 0; i < registry.schoolmates.Count(); ++i)
            {
                User u = registry.schoolmates[i];
                User cu = cregistry.schoolmates[i];

                if (File.Exists(u.photo_thumbnail))
                {
                    step_three_copy(u.photo_thumbnail, cu.photo_thumbnail);
                }
                else
                {
                    image_convert(u.photo, cu.photo_thumbnail);
                }

                cu.photos = Path.Combine(Path.Combine("schoolmates", cu.name), "photos");
                if (u.fill_photos_thumbnails_list() != null)
                {
                    cu.photos_thumbnails_list = new string[u.photos_thumbnails_list.Length];
                    for (int ii = 0; ii < u.photos_thumbnails_list.Length; ++ii)
                    {
                        string item = u.photos_thumbnails_list[ii];
                        cu.photos_thumbnails_list[ii] = Path.Combine(Path.Combine(@"schoolmates", cu.name), Path.Combine(@"photos\thumbnails", Path.GetFileName(item)));
                        step_three_copy(item, cu.photos_thumbnails_list[ii]);
                    }
                }
                else
                {
                    cu.photos_thumbnails_list = populatePhotoThumbnailsList(u.photos, Path.Combine(Path.Combine(@"schoolmates", cu.name), @"photos\thumbnails"));
                    images_convert(u.photos, cu.photos_thumbnails);
                }

                cu.videos = Path.Combine(Path.Combine("schoolmates", cu.name), "videos");
                if (u.fill_videos_thumbnails_list() != null)
                {
                    cu.videos_thumbnails_list = new string[u.videos_thumbnails_list.Length];
                    for (int ii = 0; ii < u.videos_thumbnails_list.Length; ++ii)
                    {
                        string item = u.videos_thumbnails_list[ii];
                        cu.videos_thumbnails_list[ii] = Path.Combine(Path.Combine(@"schoolmates", cu.name), Path.Combine(@"videos\thumbnails", Path.GetFileName(item)));
                        step_three_copy(item, cu.videos_thumbnails_list[ii]);
                    }
                }
                else
                {
                    cu.videos_thumbnails_list = populateVideoThumbnailsList(u.photos, Path.Combine(Path.Combine(@"schoolmates", cu.name), @"videos\thumbnails"));
                    videos_convert(u.videos, cu.videos_thumbnails);
                }
            }
            
            // TEACHERS
            for (int i = 0; i < registry.teachers.Count(); ++i)
            {
                User u = registry.teachers[i];
                User cu = cregistry.teachers[i];

                if (File.Exists(u.photo_thumbnail))
                {
                    step_three_copy(u.photo_thumbnail, cu.photo_thumbnail);
                }
                else
                {
                    image_convert(u.photo, cu.photo_thumbnail);
                }

                cu.photos = Path.Combine(Path.Combine("teachers", cu.name), "photos");
                if (u.fill_photos_thumbnails_list() != null)
                {
                    cu.photos_thumbnails_list = new string[u.photos_thumbnails_list.Length];
                    for (int ii = 0; ii < u.photos_thumbnails_list.Length; ++ii)
                    {
                        string item = u.photos_thumbnails_list[ii];
                        cu.photos_thumbnails_list[ii] = Path.Combine(Path.Combine(@"teachers", cu.name), Path.Combine(@"photos\thumbnails", Path.GetFileName(item)));
                        step_three_copy(item, cu.photos_thumbnails_list[ii]);
                    }
                }
                else
                {
                    cu.photos_thumbnails_list = populatePhotoThumbnailsList(u.photos, Path.Combine(Path.Combine(@"teachers", cu.name), @"photos\thumbnails"));
                    images_convert(u.photos, cu.photos_thumbnails);
                }

                cu.videos = Path.Combine(Path.Combine("teachers", cu.name), "videos");
                if (u.fill_videos_thumbnails_list() != null)
                {
                    cu.videos_thumbnails_list = new string[u.videos_thumbnails_list.Length];
                    for (int ii = 0; ii < u.videos_thumbnails_list.Length; ++ii)
                    {
                        string item = u.videos_thumbnails_list[ii];
                        cu.videos_thumbnails_list[ii] = Path.Combine(Path.Combine(@"teachers", cu.name), Path.Combine(@"videos\thumbnails", Path.GetFileName(item)));
                        step_three_copy(item, cu.videos_thumbnails_list[ii]);
                    }
                }
                else
                {
                    cu.videos_thumbnails_list = populatePhotoThumbnailsList(u.photos, Path.Combine(Path.Combine(@"teachers", cu.name), @"videos\thumbnails"));
                    videos_convert(u.videos, cu.videos_thumbnails);
                }
            }

            // ARCHIVE
            for (int i = 0; i < registry.archive.Count(); ++i)
            {
                ArchiveSection a = registry.archive[i];
                ArchiveSection ca = cregistry.archive[i];

                ca.photos = Path.Combine("archive", ca.name);
                if (a.fill_photos_thumbnails_list() != null)
                {
                    ca.photos_thumbnails_list = new string[a.photos_thumbnails_list.Length];
                    for (int ii = 0; ii < a.photos_thumbnails_list.Length; ++ii)
                    {
                        string item = a.photos_thumbnails_list[ii];
                        ca.photos_thumbnails_list[ii] = Path.Combine(Path.Combine(@"archive", ca.name), Path.Combine(@"thumbnails", Path.GetFileName(item)));
                        step_three_copy(item, ca.photos_thumbnails_list[ii]);
                    }
                }
                else
                {
                    ca.photos_thumbnails_list = populatePhotoThumbnailsList(a.photos, Path.Combine(Path.Combine(@"archive", ca.name), @"thumbnails"));
                    images_convert(a.photos, ca.photos_thumbnails);
                }
            }
        }

        private string[] populateVideoThumbnailsList(string path, string pre_path)
        {
            string[] file_list = Directory.GetFiles(path, "*.flv");

            foreach (string file in file_list)
            {
                Path.Combine(pre_path, file + ".jpg");
            }

            return file_list;
        }

        private string[] populatePhotoThumbnailsList(string path, string pre_path)
        {
            string[] file_list = Directory.GetFiles(path, "*.jpg");

            foreach (string file in file_list)
            {
                Path.Combine(pre_path, file);
            }

            return file_list;
        }

        private void image_convert(string from, string to)
        {
            Compilers.ImageMagick im = new Compilers.ImageMagick();
            ff_Progress(this, 1.0, from);

            im.single_convert(from, destinationPath(to));
        }

        private void images_convert(string from, string to)
        {
            Compilers.ImageMagick im = new Compilers.ImageMagick();
            im.Progress += new Constructor.Compilers.ImageMagick.ProgressHandler(ff_Progress);

            im.batch_convert(from, destinationPath(to));
        }

        private void videos_convert(string from, string to)
        {
            Compilers.FFmpeg ff = new Constructor.Compilers.FFmpeg();
            ff.Progress += new Constructor.Compilers.FFmpeg.ProgressHandler(ff_Progress);

            ff.batch_convert(from, destinationPath(to));
        }

        void ff_Progress(object sender, double progress, string filename)
        {
            //try
            //{
                step_three_bw.ReportProgress((int)(progress * 100), Path.GetFileName(filename));
            //} catch (Exception e)
            //{
                // ignore exceptions
            //}
        }

        private string destinationPath(string to)
        {
            string dest = Path.Combine(registry.settings_project_path, to);
            createFoldersOnTheWay(dest);

            return dest;
        }

        private void step_three_copy(string from, string to)
        {
            if (from == "")
                return;

            FileInfo file;
            file = new FileInfo(from);
            file.CopyTo(destinationPath(to), (p) =>
            {
                step_three_bw.ReportProgress((int)((double)p.BytesTransferred * 100 / p.TotalBytes), Path.GetFileName(from));
            });
        }

        private void step_three_bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            step_four();
        }

        private void teachersFix()
        {
            foreach (User t in this.cregistry.teachers)
                t.isTeacher = true;
        }

        private void step_five_bw_DoWork(object sender, DoWorkEventArgs e)
        {
            teachersFix();
            exportDataRegistry export = new exportDataRegistry(cregistry);


            this.textBox1.Text = export.export();
        }

        private void step_four_bw_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void step_four_bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            step_five();
        }

        private void step_five_bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // TOTAL COMPLETE
        }

    }
}
