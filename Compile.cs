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
using System.Text.RegularExpressions;
using Constructor.DataClasses;

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
            total_text.Text = "Сборка файла данных";
            total_progress.Value = 4;

            current_text.Text = "DataRegistry.as";
            current_progress.Value = 0;

            teachersFix();
            exportDataRegistry export = new exportDataRegistry(cregistry);
            saveToFile(export.export(), Path.Combine(DataRegistry.program_src_distro, "DataRegistry.as"));

            current_text.Text = "AeonGraphical2.css";

            exportCSS export_css = new exportCSS(cregistry);
            saveToFile(export_css.export(), Path.Combine(DataRegistry.program_src_distro, "AeonGraphical2.css"));

            step_four_bw.RunWorkerAsync();
        }
        private void step_five()
        {
            step_counter.Text = "5 / 5";
            total_text.Text = "Компиляция";
            total_progress.Value = 5;

            current_text.Text = "mxmlc MemoryBox.mxml";
            current_progress.Value = 0;
            timer1.Enabled = true;

            Constructor.Compilers.Flex flex = new Constructor.Compilers.Flex();
            flex.Complete += new Constructor.Compilers.Flex.CompleteHandler(flex_Complete);
            flex.compile(Path.Combine(DataRegistry.program_src_distro, "MemoryBox.mxml"), Path.Combine(registry.settings_project_path, "MemoryBox.swf"));

        }

        void flex_Complete(object sender)
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    timer1.Enabled = false;
                    current_progress.Value = 100;
                    MessageBox.Show(string.Format("Проект собран: {0}", registry.settings_project_path));
                }));
            }
        }

        private void step_one_bw_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(DataRegistry.program_bin_distro);
            dirInfo.CopyTo(registry.settings_project_path, (p) =>
            {
                step_one_bw.ReportProgress((int)((double)p.BytesTransferred * 100 / p.TotalBytes), p.CurrentFileName);
            });
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage >= current_progress.Minimum && e.ProgressPercentage <= current_progress.Maximum)
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

            cregistry.school_photo = if_not_empty(registry.school_photo, @"school\photo.jpg");
            step_two_copy(registry.school_photo, cregistry.school_photo);

            cregistry.school_pictures_director = if_not_empty(registry.school_pictures_director, @"school\director.jpg");
            step_two_copy(registry.school_pictures_director, cregistry.school_pictures_director);
            cregistry.school_pictures_history = if_not_empty(registry.school_pictures_history, @"school\history.jpg");
            step_two_copy(registry.school_pictures_history, cregistry.school_pictures_history);
            cregistry.school_pictures_video = if_not_empty(registry.school_pictures_video, @"school\video.jpg");
            step_two_copy(registry.school_pictures_video, cregistry.school_pictures_video);

            cregistry.school_director_photo = if_not_empty(registry.school_director_photo, @"school\director\photo.jpg");
            step_two_copy(registry.school_director_photo, cregistry.school_director_photo);
            cregistry.school_director_video = if_not_empty(registry.school_director_video, @"school\director\video.flv");
            step_two_copy(registry.school_director_video, cregistry.school_director_video);

            cregistry.school_video = if_not_empty(registry.school_video, @"school\video.flv");
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

                a.fill_large_list(); ca.videos_section = a.videos_section;
                ca.large_list = new string[a.large_list.Count()];
                for (int ii = 0; ii < a.large_list.Count(); ++ii)
                {
                    string item = a.large_list[ii];
                    ca.large_list[ii] = Path.Combine(Path.Combine(@"archive", ca.name), Path.GetFileName(item));
                    step_two_copy(item, ca.large_list[ii]);
                }
            }

            // GENERAL
            cregistry.general_intro_video = if_not_empty(registry.general_intro_video, @"intro.flv");
            step_two_copy(registry.general_intro_video, cregistry.general_intro_video);


            cregistry.general_music_school = if_not_empty(registry.general_music_school, Path.Combine("music", "school.mp3"));
            step_two_copy(registry.general_music_school, cregistry.general_music_school);

            // Если музыка одна для всех разделов
            if (registry.general_music_school == registry.general_music_schoolmates &&
                registry.general_music_teachers == registry.general_music_archive &&
                registry.general_music_info == registry.general_music_archive &&
                registry.general_music_school == registry.general_music_teachers)
            {
                cregistry.general_music_schoolmates =
                cregistry.general_music_teachers =
                cregistry.general_music_archive =
                cregistry.general_music_info =
                        cregistry.general_music_school;
            }
            else
            {
                cregistry.general_music_schoolmates = if_not_empty(registry.general_music_schoolmates, Path.Combine("music", "schoolmates.mp3"));
                step_two_copy(registry.general_music_schoolmates, cregistry.general_music_schoolmates);

                cregistry.general_music_teachers = if_not_empty(registry.general_music_teachers, Path.Combine("music", "teachers.mp3"));
                step_two_copy(registry.general_music_teachers, cregistry.general_music_teachers);

                cregistry.general_music_archive = if_not_empty(registry.general_music_archive, Path.Combine("music", "archive.mp3"));
                step_two_copy(registry.general_music_archive, cregistry.general_music_archive);

                cregistry.general_music_info = if_not_empty(registry.general_music_info, Path.Combine("music", "info.mp3"));
                step_two_copy(registry.general_music_info, cregistry.general_music_info);
            }

            // Копирование картинок для html-содержимого
            cregistry.school_history_html = normalizeHtml(extractImagesFromHtml(registry.school_history_html));
            cregistry.info_html = normalizeHtml(extractImagesFromHtml(registry.info_html));
        }




        private string normalizeHtml(string html)
        {
            Constructor.Compilers.TidyHtml tidy = new Constructor.Compilers.TidyHtml(html);
            html = tidy.tidy();

            html = html.Replace("STRONG", "b");
            html = html.Replace("strong", "b");
            html = html.Replace("EM", "i");
            html = html.Replace("em", "i");

            return html;
        }

        private string extractImagesFromHtml(string html)
        {
            string pattern = @"<IMG[^>]*?src\s*=\s*[""']([^'"">]+?)['""]>";

            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(html);

            foreach (Match match in matches)
            {
                string source_path = match.Groups[1].Value;

                // @TODO одноименные файлы затираются
                string dest_path = Path.Combine("html", Path.GetFileName(source_path));

                if (source_path.StartsWith("http"))
                {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    wc.DownloadFile(source_path, destinationPath(dest_path));
                }
                else
                {
                    step_two_copy(source_path, dest_path);
                }
                html = html.Replace(source_path, dest_path);
            }

            return html;
        }

        private String if_not_empty(String str_to_check, String value)
        {
            if (str_to_check != null && str_to_check != String.Empty)
                return value;
            return String.Empty;
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
                    cu.videos_thumbnails_list = populateVideoThumbnailsList(u.videos, Path.Combine(Path.Combine(@"schoolmates", cu.name), @"videos\thumbnails"));
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
                    cu.videos_thumbnails_list = populateVideoThumbnailsList(u.videos, Path.Combine(Path.Combine(@"teachers", cu.name), @"videos\thumbnails"));
                    videos_convert(u.videos, cu.videos_thumbnails);
                }
            }
            
            // ARCHIVE
            for (int i = 0; i < registry.archive.Count(); ++i)
            {
                ArchiveSection a = registry.archive[i];
                ArchiveSection ca = cregistry.archive[i];

                ca.large_path = Path.Combine("archive", ca.name);
                if (a.fill_thumbnails_list() != null)
                {
                    ca.thumbnails_list = new string[a.thumbnails_list.Length];
                    for (int ii = 0; ii < a.thumbnails_list.Length; ++ii)
                    {
                        string item = a.thumbnails_list[ii];
                        ca.thumbnails_list[ii] = Path.Combine(Path.Combine(@"archive", ca.name), Path.Combine(@"thumbnails", Path.GetFileName(item)));
                        step_three_copy(item, ca.thumbnails_list[ii]);
                    }
                }
                else
                {
                    if (a.videos_section)
                    {
                        ca.thumbnails_list = populateVideoThumbnailsList(a.large_path, Path.Combine(Path.Combine(@"archive", ca.name), @"thumbnails"));
                        videos_convert(a.large_path, ca.thumbnails_path);
                    }
                    else
                    {
                        ca.thumbnails_list = populatePhotoThumbnailsList(a.large_path, Path.Combine(Path.Combine(@"archive", ca.name), @"thumbnails"));
                        images_convert(a.large_path, ca.thumbnails_path);
                    }
                }
            }
        }

        private string[] populateVideoThumbnailsList(string path, string pre_path)
        {
            string[] file_list = Directory.GetFiles(path, "*.flv");

            for (int i = 0; i < file_list.Length; ++i)
            {
                file_list[i] = Path.Combine(pre_path, Path.GetFileName(file_list[i]) + ".jpg");
            }

            return file_list;
        }

        private string[] populatePhotoThumbnailsList(string path, string pre_path)
        {
            string[] file_list = Directory.GetFiles(path, "*.jpg");

            for (int i = 0; i < file_list.Length; ++i)
            {
                file_list[i] = Path.Combine(pre_path, Path.GetFileName(file_list[i]));
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
            try
            {
                step_three_bw.ReportProgress((int)(progress * 100), Path.GetFileName(filename));
            }
            catch (Exception e)
            {
            }
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

        private void step_four_bw_DoWork(object sender, DoWorkEventArgs e)
        {
            // Копирование css
            if (File.Exists(Path.Combine(registry.settings_source_path, "AeonGraphical2.css")))
                step_four_copy(Path.Combine(registry.settings_source_path, "AeonGraphical2.css"),
                    Path.Combine(DataRegistry.program_src_distro, "AeonGraphical2.css"));

            // Копирование assets
            if (Directory.Exists(Path.Combine(registry.settings_source_path, "assets")))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(Path.Combine(registry.settings_source_path, "assets"));
                dirInfo.CopyTo(Path.Combine(registry.settings_project_path, "assets"), (p) =>
                {
                    step_four_bw.ReportProgress((int)((double)p.BytesTransferred * 100 / p.TotalBytes), p.CurrentFileName);
                });
            }

        }

        private void step_four_bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            step_five();
        }

        private void step_four_copy(string from, string to)
        {
            if (from == "")
                return;

            FileInfo file;
            file = new FileInfo(from);
            file.CopyTo(destinationPath(to), (p) =>
            {
                step_four_bw.ReportProgress((int)((double)p.BytesTransferred * 100 / p.TotalBytes), Path.GetFileName(from));
            });
        }

        private void saveToFile(string data, string path)
        {
            FileInfo f = new FileInfo(path);
            StreamWriter w = f.CreateText();
            w.Write(data);
            w.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++current_progress.Value >= 99)
                current_progress.Value = 0;
        }

    }
}
