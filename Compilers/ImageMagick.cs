﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Constructor.Compilers
{
    class ImageMagick
    {
        public static string Path_to_imagick = @"C:\MyProjects\MemoryBox\Constructor\libs\imagemagick\bin\convert";
        public string settings = " -resize 150x120";
 
        private string[] file_list;
        private int file_iterator;
        private string filepath_to;

        public delegate void ProgressHandler(object sender, double progress, string filename);

        public event ProgressHandler Progress;

        public void single_convert(string filename_from, string filename_to)
        {
            Process proc = new Process
            {
                StartInfo =
                {
                    Arguments = string.Format("{0} \"{1}\" \"{2}\"",
                                            settings,
                                            filename_from,
                                            filename_to),
                    FileName = Path_to_imagick,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false
                }
            };

            proc.Start();
        }

        private void convert(string filename_from, string filename_to)
        {
            Process proc = new Process
            {
                StartInfo =
                {
                    Arguments = string.Format("{0} \"{1}\" \"{2}\"",
                                            settings,
                                            filename_from,
                                            filename_to),
                    FileName = Path_to_imagick,
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

        private void convert_next()
        {
            this.convert(file_list[file_iterator], Path.Combine(filepath_to, Path.GetFileName(file_list[file_iterator])));
            file_iterator++;
        }

        private void proc_Exited(object sender, EventArgs e)
        {
            update_progress();

            if (file_iterator < file_list.Length)
                // continue
                convert_next();
        }

        private void update_progress()
        {
            string cur_file = "";

            if(file_iterator < file_list.Length)
                cur_file = Path.GetFileName(file_list[file_iterator]);

            Progress(
                this,
                (double)file_iterator / (double)file_list.Length,
                cur_file
                );
        }

        public void batch_convert(string filepath_from, string filepath_to)
        {
            file_list = Directory.GetFiles(filepath_from, "*.jpg");
            this.filepath_to = filepath_to;
            file_iterator = 0;

            update_progress();
            convert_next();
        }
    }
}
