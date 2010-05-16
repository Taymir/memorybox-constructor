using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace Constructor.Compilers
{
    class ImageMagick
    {
        public static int thumbnail_width = 150;
        public static int thumbnail_height = 120;

        private string[] file_list;
        private string filepath_to;

        public delegate void ProgressHandler(object sender, double progress, string filename);

        public event ProgressHandler Progress;

        public void single_convert(string filename_from, string filename_to)
        {
            if (!File.Exists(filename_from))
                return;

            MagickNet.Magick.Init();
            MagickNet.Image im = new MagickNet.Image(filename_from);

            im.Resize(calculateSize(im.Size));

            im.Write(filename_to);
            MagickNet.Magick.Term();
        }

        private void convert()
        {
            for (int i = 0; i < file_list.Length; ++i )
            {
                string cur_file = Path.GetFileName(file_list[i]);

                if (Progress != null)
                    Progress(
                        this,
                        (double)i / (double)(file_list.Length - 1),
                        cur_file
                        );

                MagickNet.Image im = new MagickNet.Image(file_list[i]);

                im.Resize(calculateSize(im.Size));

                string destination = Path.Combine(filepath_to, Path.GetFileName(file_list[i]));

                im.Write(destination);
            }
        }

        private Size calculateSize(Size original)
        {
            //Вычисление размеров
            Size result = new Size(thumbnail_width, thumbnail_height);

            if (original.Width > original.Height)
            {
                result.Height = (int)Math.Floor(original.Height * ((double)150 / original.Width));
            }
            else
            {
                result.Width = (int)Math.Floor(original.Width * ((double)150 / original.Height));
            }

            return result;
        }

        public void batch_convert(string filepath_from, string filepath_to)
        {
            if (!Directory.Exists(filepath_from))
                return;

            MagickNet.Magick.Init();

            file_list = Directory.GetFiles(filepath_from, "*.jpg");
            this.filepath_to = filepath_to;

            convert();

            MagickNet.Magick.Term();
        }
    }
}
