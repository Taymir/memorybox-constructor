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
    public partial class FileSelect : UserControl
    {
        public delegate void SelectedHandler(object sender, string filename);

        public event SelectedHandler Selected;

        public FileSelect()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pathTextBox.Text = openFileDialog.FileName;

                if (this.Selected != null)
                    Selected(this, filename);
            }
        }

        public string filter
        {
            set
            {
                this.openFileDialog.Filter = value;
            }
            get
            {
                return this.openFileDialog.Filter;
            }
        }

        public string filename
        {
            set
            {
                this.pathTextBox.Text = value;
                this.openFileDialog.FileName = value;
            }
            get
            {
                return this.pathTextBox.Text;
            }
        }
    }
}
