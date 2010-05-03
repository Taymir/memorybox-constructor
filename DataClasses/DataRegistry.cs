using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    [Serializable]
    public class DataRegistry
    {
        /* SCHOOL PROPERTIES */
        public string school_name {get; set; }
        public string school_photo { get; set; }

        public string school_contacts_phone { get; set; }
        public string school_contacts_email { get; set; }
        public string school_contacts_links { get; set; }

        public string school_pictures_history { get; set; }
        public string school_pictures_director { get; set; }
        public string school_pictures_video { get; set; }

        public string school_history_html { get; set; }

        public string school_director_photo { get; set; }
        public string school_director_name { get; set; }
        public string school_director_video { get; set; }

        public string school_video { get; set; }

        /* SCHOOLMATES PROPERTIES */
        public List<User> schoolmates { get; set; }
        public string schoolmates_path { get; set; }

        /* TEACHERS PROPERTIES */
        public List<User> teachers { get; set; }
        public string teachers_path { get; set; }

        /* ARCHIVE PROPERTIES */
        public List<ArchiveSection> archive { get; set; }
        public string archive_path { get; set; }

        /* INFO PROPERTIES */
        public string info_html { get; set; }

        /* GENERAL PROPERTIES */
        public string general_intro_video { get; set; }

        public bool general_start_fullscreen { get; set; }
        public bool general_show_intro { get; set; }

        /* PROJECT SETTINGS */
        public string settings_project_path { get; set; }
        public string settings_source_path { get; set; }

        public DataRegistry()
        {
            this.school_name = string.Empty;
            this.school_photo = string.Empty;

            this.school_contacts_phone = string.Empty;
            this.school_contacts_email = string.Empty;
            this.school_contacts_links = string.Empty;

            this.school_pictures_history = string.Empty;
            this.school_pictures_director = string.Empty;
            this.school_pictures_video = string.Empty;

            this.school_history_html = string.Empty;

            this.school_director_name = string.Empty;
            this.school_director_photo = string.Empty;
            this.school_director_video = string.Empty;

            this.school_video = string.Empty;

            this.schoolmates = new List<User>();
            this.schoolmates_path = string.Empty;

            this.teachers = new List<User>();
            this.teachers_path = string.Empty;

            this.archive = new List<ArchiveSection>();
            this.archive_path = string.Empty;

            this.info_html = string.Empty;

            this.general_intro_video = string.Empty;
            this.general_start_fullscreen = false;
            this.general_show_intro = false;
        }
    }
}
