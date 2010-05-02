using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Constructor
{
    public partial class Form1 : Form
    {
        private List<User> schoolmates;
        private List<User> teachers;
        private Dictionary<string, Controls.ManagedPanel> panels;
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

            schoolmates = new List<User>();
            schoolmates.Add(new User() { name = "test" });
            schoolmates.Add(new User() { name = "test1" });
            schoolmates.Add(new User() { name = "tes2t" });
            schoolmates.Add(new User() { name = "test3" });
            schoolmates.Add(new User() { name = "test4" });

            bindingSource1.DataSource = schoolmates;
            schoolmates_list.DisplayMember = "name";
            schoolmate_name.DataBindings.Add("text", bindingSource1, "name");
            schoolmate_name.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            schoolmate_birthday.DataBindings.Add("value", bindingSource1, "birthday");
            schoolmate_birthday.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            schoolmate_contacts_cellphone.DataBindings.Add("text", bindingSource1, "contacts_cellphone");
            schoolmate_contacts_cellphone.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            schoolmate_contacts_phone.DataBindings.Add("text", bindingSource1, "contacts_phone");
            schoolmate_contacts_phone.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            

            schoolmate_contacts_links.DataBindings.Add(new Binding("text", bindingSource1, "contacts_links"));
            schoolmate_contacts_links.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            schoolmate_photo.DataBindings.Add("filename", bindingSource1, "photo_large");
            schoolmate_photo.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            

            treeView1.ExpandAll();


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String panelName = e.Node.Name;
            if(panels.ContainsKey(panelName))
                panelManager1.SelectedPanel = panels[e.Node.Name];
        }
    }
}
