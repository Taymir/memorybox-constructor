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

                result[i].large_path = sections[i].large_path;

                if(sections[i].large_list != null)
                result[i].large_list = (string[])sections[i].large_list.Clone();
                if (sections[i].thumbnails_list != null)
                result[i].thumbnails_list = (string[])sections[i].thumbnails_list.Clone();

                result[i].videos_section = sections[i].videos_section;
            }

            return result;
        }

        public ArchiveSection()
        {
            this.name = string.Empty;

            this.large_path = string.Empty;

            this.large_list = new string[0];
            this.thumbnails_list = new string[0];

            this.videos_section = false;
        }

        public string name { get; set; }

        public string large_path { get; set; }

        /* NON-GUI PROPERTIES */
        public string thumbnails_path
        {
            get
            {
                if (large_path == string.Empty) return string.Empty;

                return Path.Combine(large_path, "thumbnails");
            }
        }

        public bool videos_section;

        /* FILE LISTS */
        public string[] large_list;
        public string[] thumbnails_list;

        public string[] fill_large_list()
        {
            if (!Directory.Exists(this.large_path))
                return null;

            String[] videos_list = Directory.GetFiles(this.large_path, "*.flv");
            String[] photos_list = Directory.GetFiles(this.large_path, "*.jpg");

            if (videos_list.Count() > photos_list.Count())
            {
                this.videos_section = true;
                this.large_list = videos_list;
            }
            else
            {
                this.videos_section = false;
                this.large_list = photos_list;
            }

            Array.Sort(large_list);
            return large_list;
        }

        public string[] fill_thumbnails_list()
        {
            if (!Directory.Exists(this.thumbnails_path))
                return null;

            thumbnails_list = Directory.GetFiles(this.thumbnails_path, "*.jpg");
            Array.Sort(thumbnails_list);

            return thumbnails_list;
        }
    }
}
