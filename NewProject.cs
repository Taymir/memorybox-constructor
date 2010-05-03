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
    }
}
