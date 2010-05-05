using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Constructor
{
    public class ArchiveSection
    {
        public static List<ArchiveSection> cloneArchiveSections(List<ArchiveSection> sections)
        {
            List<ArchiveSection> result = new List<ArchiveSection>(sections.Count);

            for (int i = 0; i < sections.Count; ++i)
            {
                result.Insert(i, new ArchiveSection());
                result[i].name = sections[i].name;

                result[i].photos = sections[i].photos;

                if(sections[i].photos_list != null)
                result[i].photos_list = (string[])sections[i].photos_list.Clone();
                if (sections[i].photos_thumbnails_list != null)
                result[i].photos_thumbnails_list = (string[])sections[i].photos_thumbnails_list.Clone();
            }

            return result;
        }

        public string name { get; set; }

        public string photos { get; set; }

        /* NON-GUI PROPERTIES */
        public string photos_thumbnails
        {
            get
            {
                return Path.Combine(photos, "thumbnails");
            }
        }

        /* FILE LISTS */
        public string[] photos_list;
        public string[] photos_thumbnails_list;

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
    }
}
