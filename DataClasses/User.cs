using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Constructor
{
    public class User
    {
        public User()
        {
            this.birthday = new DateTime(1987, 01, 01);
        }

        public string name { get; set; }

        public string photo { get; set; }

        public bool isTeacher { get; set; }
        public DateTime birthday { get; set; }
        public string disipline { get; set; }

        public string contacts_cellphone { get; set; }
        public string contacts_phone { get; set; }
        public string contacts_links { get; set; }

        public string photos { get; set; }

        public string videos { get; set; }

        /* NON-GUI PROPERTIES */
        public string photo_thumbnail
        {
            get
            {
                return
                Path.Combine(
                    Path.GetDirectoryName(photo),
                    Path.GetFileNameWithoutExtension(photo)
                    + "_thumbnail" +
                    Path.GetExtension(photo)
                    );
            }
        }

        public string photos_thumbnails
        {
            get
            {
                return Path.Combine(photos, "thumbnails");
            }
        }

        public string videos_thumbnails
        {
            get
            {
                return Path.Combine(videos, "thumbnails");
            }
        }

        /* FILE LISTS */
        public string[] photos_list;
        public string[] photos_thumbnails_list;

        public string[] videos_list;
        public string[] videos_thumbnails_list;

        public string[] fill_photos_list()
        {
            if (!Directory.Exists(this.photos))
                return null;

            photos_list = Directory.GetFiles(this.photos, "*.jpg");

            return photos_list;
        }
        public string[] fill_photos_thumbnails_list()
        {
            if (!Directory.Exists(this.photos_thumbnails))
                return null;

            photos_thumbnails_list = Directory.GetFiles(this.photos_thumbnails, "*.jpg");

            return photos_thumbnails_list;
        }

        public string[] fill_videos_list()
        {
            if (!Directory.Exists(this.videos))
                return null;

            videos_list = Directory.GetFiles(this.videos, "*.flv");

            return videos_list;
        }
        public string[] fill_videos_thumbnails_list()
        {
            if (!Directory.Exists(this.videos_thumbnails))
                return null;

            videos_thumbnails_list = Directory.GetFiles(this.videos_thumbnails, "*.jpg");

            return videos_thumbnails_list;
        }
    }
}
