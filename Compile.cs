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


        private void step_one()
        {
            step_counter.Text = "1 / 5";
            total_text.Text = "Копирование дистрибутива";
            total_progress.Value = 1;

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
        {/*
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\MyProjects\MemoryBox\test\bin-debug");//@TMP
            dirInfo.CopyTo(@"C:\MyProjects\MemoryBox\test\dest", (p) => //@TMP
            {
                step_one_bw.ReportProgress((int)((double)p.BytesTransferred * 100 / p.TotalBytes), p.CurrentFileName);
            });*/
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
            /*string destination = registry.settings_project_path; //@TMP

            step_two_copy(registry.school_photo, destination);

            step_two_copy(registry.school_pictures_director, destination);
            step_two_copy(registry.school_pictures_history, destination);
            step_two_copy(registry.school_pictures_video, destination);

            step_two_copy(registry.school_director_photo, destination);
            step_two_copy(registry.school_director_video, destination);

            step_two_copy(registry.school_video, destination);

            foreach (User u in registry.schoolmates)
            {
                step_two_copy(u.photo, destination);

                u.fill_photos_list();

                foreach (string item in u.photos_list)
                {
                    step_two_copy(item, destination);
                }

                u.fill_videos_list();

                foreach (string item in u.videos_list)
                {
                    step_two_copy(item, destination);
                }
            }
            foreach (User u in registry.teachers)
            {
                step_two_copy(u.photo, destination);

                u.fill_photos_list();

                foreach (string item in u.photos_list)
                {
                    step_two_copy(item, destination);
                }

                u.fill_videos_list();

                foreach (string item in u.videos_list)
                {
                    step_two_copy(item, destination);
                }
            }
            foreach (ArchiveSection a in registry.archive)
            {
                a.fill_photos_list();

                foreach (string item in a.photos_list)
                {
                    step_two_copy(item, destination);
                }
            }

            step_two_copy(registry.general_intro_video, destination);*/
        }

        private void step_two_copy(string from, string to)
        {
            if (from == "")
                return;

            FileInfo file;
            file = new FileInfo(from);//@TMP
            file.CopyTo(Path.Combine(to, Path.GetFileName(from)), (p) =>//@TMP
            {
                step_two_bw.ReportProgress((int)((double)p.BytesTransferred * 100 / p.TotalBytes), Path.GetFileName(from));
            });
        }

        private void step_two_bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            step_three_bw.RunWorkerAsync();
        }

        private void step_three_bw_DoWork(object sender, DoWorkEventArgs e)
        {
            string destination = registry.settings_project_path; //@TMP

            // SCHOOLMATES
            foreach (User u in registry.schoolmates)
            {
                if (File.Exists(u.photo_thumbnail))
                    step_three_copy(u.photo_thumbnail, destination);
                else
                    image_convert(u.photo, destination);

                if (u.fill_photos_thumbnails_list() != null)
                {
                    foreach (string item in u.photos_thumbnails_list)
                    {
                        step_three_copy(item, destination);
                    }
                }
                else
                {
                    images_convert(u.photos, destination);
                }

                if (u.fill_videos_thumbnails_list() != null)
                {
                    foreach (string item in u.videos_thumbnails_list)
                    {
                        step_three_copy(item, destination);
                    }
                }
                else
                {
                    videos_convert(u.videos, destination);
                }
            }

            // TEACHERS
            foreach (User u in registry.teachers)
            {
                if (File.Exists(u.photo_thumbnail))
                    step_three_copy(u.photo_thumbnail, destination);
                else
                    image_convert(u.photo, destination);

                if (u.fill_photos_thumbnails_list() != null)
                {
                    foreach (string item in u.photos_thumbnails_list)
                    {
                        step_three_copy(item, destination);
                    }
                }
                else
                {
                    images_convert(u.photos, destination);
                }

                if (u.fill_videos_thumbnails_list() != null)
                {
                    foreach (string item in u.videos_thumbnails_list)
                    {
                        step_three_copy(item, destination);
                    }
                }
                else
                {
                    videos_convert(u.videos, destination);
                }
            }

            // ARCHIVE
            foreach (ArchiveSection a in registry.archive)
            {
                if (a.fill_photos_thumbnails_list() != null)
                {
                    foreach (string item in a.photos_thumbnails_list)
                    {
                        step_three_copy(item, destination);
                    }
                }
                else
                {
                    images_convert(a.photos, destination);
                }
            }
        }

        private void image_convert(string from, string to)
        {
            /*Compilers.ImageMagick im = new Compilers.ImageMagick();
            ff_Progress(this, 1.0, from);

            im.single_convert(from, to);*/
        }

        private void images_convert(string from, string to)
        {
            Compilers.ImageMagick im = new Compilers.ImageMagick();
            im.Progress += new Constructor.Compilers.ImageMagick.ProgressHandler(ff_Progress);

            im.batch_convert(from, to);
        }

        private void videos_convert(string from, string to)
        {
            Compilers.FFmpeg ff = new Constructor.Compilers.FFmpeg();
            ff.Progress += new Constructor.Compilers.FFmpeg.ProgressHandler(ff_Progress);

            ff.batch_convert(from, to);
        }

        void ff_Progress(object sender, double progress, string filename)
        {
            try
            {
                step_three_bw.ReportProgress((int)(progress * 100), Path.GetFileName(filename));
            } catch (Exception e)
            {
                // ignore exceptions
            }
        }

        private void step_three_copy(string from, string to)
        {
            if (from == "")
                return;

            FileInfo file;
            file = new FileInfo(from);//@TMP
            file.CopyTo(Path.Combine(to, Path.GetFileName(from)), (p) =>//@TMP
            {
                step_three_bw.ReportProgress((int)((double)p.BytesTransferred * 100 / p.TotalBytes), Path.GetFileName(from));
            });
        }

    }
}
