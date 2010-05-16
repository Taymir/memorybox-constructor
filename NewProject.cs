using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Constructor
{
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
        }

        public string projectPath
        {
            get
            {
                return this.project.filepath;
            }
        }

        public string sourcePath
        {
            get
            {
                return this.source.filepath;
            }
        }

        private void NewProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (projectPath == string.Empty)
            {
                e.Cancel = true;
                MessageBox.Show("Необходимо указать путь для сохранения проекта.");
            }
            else if (sourcePath == string.Empty)
            {
                if (MessageBox.Show("Вы уверены, что НЕ ХОТИТЕ указать путь к контенту? Это усложнит дальнейшую работу с конструктором.", "Путь к контенту", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
