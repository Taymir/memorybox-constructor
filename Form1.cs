using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panelManager1.SelectedPanel = null;
            resetRegistry();

            setupPanels();
            setupDataBinding();

            treeView1.ExpandAll();

            treeView1.Enabled = false;
        }

        private void resetRegistry()
        {

            this.setupRegistry(new DataRegistry());
        }

        private void setupRegistry(DataRegistry reg)
        {
            this.registry = reg;
            data_source.DataSource = reg;
        }

        private Dictionary<string, Controls.ManagedPanel> panels;
        private void setupPanels()
        {
            panels = new Dictionary<string, Controls.ManagedPanel>(10);

            panels.Add("General", GeneralPanel);
            panels.Add("School", SchoolPanel);
            panels.Add("SchoolHistory", SchoolHistoryPanel);
            panels.Add("Schoolmates", SchoolmatesPanel);
            panels.Add("Teachers", TeachersPanel);
            panels.Add("Archive", ArchivePanel);
            panels.Add("Info", InfoPanel);

            panels.Add("Colors", ColorsPanel);
            panels.Add("Buttons", ButtonsPanel);
            panels.Add("Scrollbars", ScrollbarsPanel);
        }

        private DataRegistry registry;
        private void setupDataBinding()
        {
            /* GENERAL */
            general_intro_video.DataBindings.Add("filename", data_source, "general_intro_video");
            general_show_intro.DataBindings.Add("Checked", data_source, "general_show_intro");
            general_start_fullscreen.DataBindings.Add("Checked", data_source, "general_start_fullscreen");

            /* SCHOOL */
            school_name.DataBindings.Add("Text", data_source, "school_name");
            school_photo.DataBindings.Add("filename", data_source, "school_photo");

            school_contacts_phone.DataBindings.Add("Text", data_source, "school_contacts_phone");
            school_contacts_email.DataBindings.Add("Text", data_source, "school_contacts_email");
            school_contacts_links.DataBindings.Add("Text", data_source, "school_contacts_links");

            school_pictures_history.DataBindings.Add("filename", data_source, "school_pictures_history");
            school_pictures_director.DataBindings.Add("filename", data_source, "school_pictures_director");
            school_pictures_video.DataBindings.Add("filename", data_source, "school_pictures_video");

            school_history_html.DataBindings.Add("Text", data_source, "school_history_html");

            school_director_photo.DataBindings.Add("filename", data_source, "school_director_photo");
            school_director_name.DataBindings.Add("Text", data_source, "school_director_name");
            school_director_video.DataBindings.Add("filename", data_source, "school_director_video");

            school_video.DataBindings.Add("filename", data_source, "school_video");

            /* SCHOOLMATES */
            schoolmates_path.DataBindings.Add("filepath", data_source, "schoolmates_path");
            schoolmates_datasource.DataSource = data_source;
            schoolmates_datasource.DataMember = "schoolmates";
            
            schoolmates_list.DisplayMember = "name";
            
            schoolmate_name.DataBindings.Add("Text", schoolmates_datasource, "name");
            schoolmate_photo.DataBindings.Add("filename", schoolmates_datasource, "photo");
            schoolmate_birthday.DataBindings.Add("Value", schoolmates_datasource, "birthday", true, DataSourceUpdateMode.OnPropertyChanged);
            
            schoolmate_contacts_phone.DataBindings.Add("Text", schoolmates_datasource, "contacts_phone");
            schoolmate_contacts_cellphone.DataBindings.Add("Text", schoolmates_datasource, "contacts_cellphone");
            schoolmate_contacts_links.DataBindings.Add("Text", schoolmates_datasource, "contacts_links");

            schoolmate_photos.DataBindings.Add("filepath", schoolmates_datasource, "photos");
            schoolmate_videos.DataBindings.Add("filepath", schoolmates_datasource, "videos");
            

            /* TEACHERS */
            teachers_path.DataBindings.Add("filepath", data_source, "teachers_path");
            teachers_datasource.DataSource = data_source;
            teachers_datasource.DataMember = "teachers";
            teachers_list.DisplayMember = "name";

            teacher_name.DataBindings.Add("Text", teachers_datasource, "name");
            teacher_photo.DataBindings.Add("filename", teachers_datasource, "photo");
            teacher_discipline.DataBindings.Add("Text", teachers_datasource, "disipline");

            teacher_contacts_phone.DataBindings.Add("Text", teachers_datasource, "contacts_phone");
            teacher_contacts_cellphone.DataBindings.Add("Text", teachers_datasource, "contacts_cellphone");
            teacher_contacts_links.DataBindings.Add("Text", teachers_datasource, "contacts_links");

            teacher_photos.DataBindings.Add("filepath", teachers_datasource, "photos");
            teacher_videos.DataBindings.Add("filepath", teachers_datasource, "videos");
            
            /* ARCHIVE */
            archiveSections_path.DataBindings.Add("filepath", data_source, "archive_path");
            archiveSections_datasource.DataSource = data_source;
            archiveSections_datasource.DataMember = "archive";
            archiveSections_list.DisplayMember = "name";

            archiveSection_name.DataBindings.Add("Text", archiveSections_datasource, "name");
            archiveSection_photos.DataBindings.Add("filepath", archiveSections_datasource, "photos");  
            
            /* INFO */
            info_html.DataBindings.Add("Text", data_source, "info_html");

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String panelName = e.Node.Name;
            if(panels.ContainsKey(panelName))
                panelManager1.SelectedPanel = panels[e.Node.Name];
        }

        private void сохранитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(DataRegistry), new Type[] { typeof(User), typeof(ArchiveSection) });
            FileStream fStream = new System.IO.FileStream("text.xml", System.IO.FileMode.Create, System.IO.FileAccess.Write, FileShare.None);
            xml.Serialize(fStream, registry);
            fStream.Close();

        }

        private void открытьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelManager1.SelectedPanel = null;

            XmlSerializer xml = new XmlSerializer(typeof(DataRegistry), new Type[] { typeof(User), typeof(ArchiveSection) });
            FileStream fStream = File.OpenRead("text.xml");
            registry = (DataRegistry)xml.Deserialize(fStream);
            fStream.Close();

            data_source.DataSource = registry;
            treeView1.Enabled = true;
        }

        private void новыйПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*NewProject form = new NewProject();
            if (form.ShowDialog() == DialogResult.OK)
            {
                resetRegistry();

                this.registry.settings_project_path = form.projectPath;
                this.registry.settings_source_path = form.sourcePath;

                findAvailableDirectories(form.sourcePath);*/

                treeView1.Enabled = true;
                registry.teachers.Add(new User() { name = "БРЕД" });
            //}
        }

        private void findAvailableDirectories(string path)
        {
            if (path == "")
                return;

            /* SCHOOL */
            if (Directory.Exists(path + @"\school"))
            {
                if (Directory.Exists(path + @"\school\director"))
                {
                    if (File.Exists(path + @"\school\director\photo.jpg"))
                    {
                        registry.school_director_photo = path + @"\school\director\photo.jpg";
                    }
                    if (File.Exists(path + @"\school\director\video.flv"))
                    {
                        registry.school_director_video = path + @"\school\director\video.flv";
                    }
                }

                if (File.Exists(path + @"\school\photo.jpg"))
                {
                    registry.school_photo = path + @"\school\photo.jpg";
                }
                if (File.Exists(path + @"\school\video.flv"))
                {
                    registry.school_video = path + @"\school\video.flv";
                }

                if (File.Exists(path + @"\school\history.jpg"))
                {
                    registry.school_pictures_history = path + @"\school\history.jpg";
                }
                if (File.Exists(path + @"\school\director.jpg"))
                {
                    registry.school_pictures_director = path + @"\school\director.jpg";
                }
                if (File.Exists(path + @"\school\video.jpg"))
                {
                    registry.school_pictures_video = path + @"\school\video.jpg";
                }
            }

            /* SCHOOLMATES */
            if (Directory.Exists(path + @"\schoolmates"))
            {
                //registry.schoolmates_path = path + @"\schoolmates";

                //registry.schoolmates.AddRange(findAvailableUsersInDir(path + @"\schoolmates"));
            }

            /* TEACHERS */
            if (Directory.Exists(path + @"\teachers"))
            {
                registry.teachers_path = path + @"\teachers";

                //registry.teachers = findAvailableUsersInDir(path + @"\teachers");
            }

            /* ARCHIVE */
            if (Directory.Exists(path + @"\archive"))
            {
                registry.archive_path = path + @"\archive";

                //registry.archive = findAvailableArchiveSectionsInDir(path + @"\archive");
            }

            if (File.Exists(path + @"\intro.flv"))
            {
                registry.general_intro_video = path + @"\intro.flv";
            }

        }

        private List<ArchiveSection> findAvailableArchiveSectionsInDir(string path)
        {
            List<ArchiveSection> sections = new List<ArchiveSection>(Directory.GetDirectories(path).Count());
            foreach (string sec_dir in Directory.GetDirectories(path))
            {
                ArchiveSection sec = new ArchiveSection();
                sec.name = Path.GetDirectoryName(sec_dir);

                if (Directory.Exists(sec_dir))
                {
                    if (Directory.Exists(sec_dir + @"\thumbnails"))
                    {
                        //@TODO
                    }

                    //@TODO
                    sec.photos = sec_dir;
                }

                sections.Add(sec);
            }

            return sections;
        }

        private List<User> findAvailableUsersInDir(string path)
        {
            List<User> users = new List<User>(Directory.GetDirectories(path).Count());
            foreach (string user_dir in Directory.GetDirectories(path))
            {
                User user = new User();
                user.name = "123";// Path.GetDirectoryName(user_dir);

                if (Directory.Exists(user_dir + @"\photos"))
                {
                    if (Directory.Exists(user_dir + @"\photos\thumbnails"))
                    {
                        //@TODO
                    }

                    //@TODO
                    user.photos = user_dir + @"\photos";
                }

                if (Directory.Exists(user_dir + @"\videos"))
                {
                    if (Directory.Exists(user_dir + @"\videos\thumbnails"))
                    {
                        //@TODO
                    }

                    //@TODO
                    user.videos = user_dir + @"\videos";
                }

                if (File.Exists(user_dir + @"\photo.jpg"))
                {
                    user.photo = user_dir + @"\photo.jpg";
                }

                if (File.Exists(user_dir + @"\photo_thumbnail.jpg"))
                {
                    //@TODO
                }

                users.Add(user);
            }

            return users;
        }
    }
}
