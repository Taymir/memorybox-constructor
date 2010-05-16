using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Constructor
{
    public partial class FolderSelect : UserControl
    {
        public delegate void SelectedHandler(object sender, string filepath);

        public event SelectedHandler Selected;

        public FolderSelect()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.pathTextBox.Text = folderBrowserDialog.SelectedPath;

                if (this.Selected != null)
                    Selected(this, filepath);
            }
        }

        public string filepath
        {
            set
            {
                this.pathTextBox.Text = value;
                this.folderBrowserDialog.SelectedPath = value;
            }
            get
            {
                return this.pathTextBox.Text;
            }
        }
    }
}
