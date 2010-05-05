using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Constructor
{
    class exportDataRegistry
    {
        private DataRegistry registry;

        public exportDataRegistry(DataRegistry registry)
        {
            this.registry = registry;
        }

        private string escape(string str)
        {
            if (str == null)
                return string.Empty;
            return str.Replace("\"", "\\\"");
        }

        private string exportString(string name, string value)
        {
            return string.Format("public var {0} : String = {1};\r\n", name, exportString(value));
        }

        private string exportString(string value)
        {
            return string.Format("\"{0}\"", this.escape(value));
        }

        private string exportBoolean(string name, bool value)
        {
            return string.Format("public var {0} : Boolean = {1};\r\n", name, exportBoolean(value));
        }

        private string exportBoolean(bool value)
        {
            return value.ToString();
        }

        private string exportArray(string name, string value)
        {
            return string.Format("public var {0} : Array = {1};\r\n", name, exportArray(value));
        }

        private string exportArray(string value)
        {
            if (value == null)
                return string.Empty;
            string[] arr = Regex.Split(value, "\r\n");

            return exportArray(arr);
        }

        private string exportArray(string[] arr)
        {
            if (arr == null)
                return string.Empty;

            string res = "new Array(\r\n";

            for (int i = 0; i < arr.Length; ++i)
            {
                res += string.Format("\"{0}\"", escape(arr[i]));

                if (i < arr.Length - 1)
                    res += ",";

                res += "\r\n";
            }
            res += ")";

            return res;
        }

        private string exportMultilineString(string name, string value)
        {
            string res = string.Format("public var {0} : String = \r\n", name);

            if (value == null)
                return res + "\"\";\r\n";

            string[] arr = Regex.Split(value, "\r\n");

            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; ++i)
                {
                    res += string.Format("\"{0}\"", escape(arr[i]));

                    if (i < arr.Length - 1)
                    {
                        res += " + ";
                        res += "\r\n";
                    }
                }
            }
            else
            {
                res += "\"\"";
            }

            res += ";\r\n";

            return res;
        }

        private string exportSectionName(string name)
        {
            return string.Format("/* {0} PROPERTIES */\r\n", name.ToUpper());
        }

        private string exportEmptyString()
        {
            return "\r\n";
        }

        private string exportUser(User user)
        {
            string res =
                exportSectionName(user.name) +
                "new User(\r\n" +
                exportString(user.name) + ",\r\n" +

                exportString(user.photo) + ",\r\n" +
                //exportString(user.photo) + ",\r\n";  //@TMP: thumbnail
                exportString(user.photo_thumbnail) + ",\r\n";

            if (user.isTeacher)
                res += exportString(user.disipline) + ",\r\n";
            else
                res += exportString(user.birthday.ToString("dd/MM/yyyy")) + ",\r\n";

            res +=
                exportString(user.contacts_cellphone) + ",\r\n" +
                exportString(user.contacts_phone) + ",\r\n" +
                exportArray(user.contacts_links) + ",\r\n" +

                //exportString(user.photos) + ",\r\n" + //@TMP
                //exportString(user.photos) + ",\r\n" + //@TMP: thumbnail
                exportArray(user.photos_list) + ",\r\n" +
                exportArray(user.photos_thumbnails_list) + ",\r\n" + 


                //exportString(user.videos) + ",\r\n" + //@TMP
                //exportString(user.videos) + "\r\n" +  //@TMP: thumbnail
                exportArray(user.videos_list) + ",\r\n" +
                exportArray(user.videos_thumbnails_list) + "\r\n" + 
                ")";

            return res;
        }

        private string export_users(string name, List<User> users)
        {
            string res =
                string.Format("public var {0} : Array = new Array(\r\n", name);

            for (int i = 0; i < users.Count; ++i)
            {
                res += exportEmptyString() + exportUser(users[i]);

                if (i < users.Count - 1)
                    res += ",";

                res += "\r\n";
            }
            res += ")\r\n";

            return res;
        }

        private string exportArchiveSection(ArchiveSection section)
        {
            string res =
                exportSectionName(section.name) +
                "new ArchiveSection(\r\n" +
                exportString(section.name) + ",\r\n" +

                //exportString(section.photos) + ",\r\n" + //@TMP
                //exportString(section.photos) + "\r\n" +  //@TMP: thumbnail
                exportArray(section.photos_list) + ",\r\n" +
                exportArray(section.photos_thumbnails_list) + "\r\n" + 
                ")";

            return res;

        }

        private string export_archiveSections(List<ArchiveSection> sections)
        {
            string res =
                 "public var archive : Array = new Array(\r\n";

            for (int i = 0; i < sections.Count; ++i)
            {
                res += exportEmptyString() + exportArchiveSection(sections[i]);

                if (i < sections.Count - 1)
                    res += ",";

                res += "\r\n";
            }
            res += ")\r\n";

            return res;
        }

        private string export_header()
        {
            return @"package
{
	[Bindable]
	public final class DataRegistry
	{
		private static var _instance:DataRegistry = new DataRegistry();
		
		public function DataRegistry()
		{
			if(_instance != null)
			{
				throw new Error(""DataRegistry can only be accessed through DataRegistry.instance since it is a Singleton class"");
			}
		}
		
		public static function get instance() : DataRegistry
		{
			return _instance;
		}

";
        }

        private string export_footer()
        {
            return @"	}
}";
        }

        private string export_school()
        {
            return
                exportSectionName("school") +
                exportString("school_name", registry.school_name) +
                exportString("school_photo", registry.school_photo) +

                exportEmptyString() +
                exportString("school_contacts_phone", registry.school_contacts_phone) +
                exportString("school_contacts_email", registry.school_contacts_email) +
                exportArray("school_contacts_links", registry.school_contacts_links) +

                exportEmptyString() +
                exportString("school_pictures_history", registry.school_pictures_history) +
                exportString("school_pictures_director", registry.school_pictures_director) +
                exportString("school_pictures_video", registry.school_pictures_video) +

                exportEmptyString() +
                exportSectionName("school: history") +
                exportMultilineString("school_history_html", registry.school_history_html) +

                exportEmptyString() +
                exportSectionName("school: director") +
                exportString("school_director_photo", registry.school_director_photo) +
                exportString("school_director_name", registry.school_director_name) +
                exportString("school_director_video", registry.school_director_video) +

                exportEmptyString() +
                exportSectionName("school: video") +
                exportString("school_video", registry.school_video) +

                exportEmptyString();
        }

        private string export_schoolmates()
        {
            return
                exportSectionName("schoolmates") +
                export_users("schoolmates", registry.schoolmates);
        }

        private string export_teachers()
        {
            return
                exportSectionName("teachers") +
                export_users("teachers", registry.teachers);
        }

        private string export_archive()
        {
            return
                exportSectionName("archive") +
                export_archiveSections(registry.archive);
        }

        private string export_info()
        {
            return
                exportSectionName("info") +
                exportMultilineString("info_html", registry.info_html) +
                exportEmptyString();
        }

        private string export_general()
        {
            return
                exportSectionName("general") +
                exportString("general_intro_video", registry.general_intro_video) +

                exportEmptyString() +
                exportBoolean("general_start_fullscreen", registry.general_start_fullscreen) +
                exportBoolean("general_show_intro", registry.general_show_intro);
        }


        public string export()
        {
            return
                export_header() +
                export_school() +
                export_schoolmates() +
                export_teachers() +
                export_archive() +
                export_info() +
                export_general() +
                export_footer();

        }
    }
}
