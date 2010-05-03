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
    public partial class Compile : Form
    {
        public Compile()
        {
            InitializeComponent();
        }

        private void Compile_Load(object sender, EventArgs e)
        {

        }

        public string text
        {
            set
            {
                this.textBox1.Text = value;
            }
            get
            {
                return this.textBox1.Text;
            }
        }

        public double percent
        {
            set
            {
                this.progressBar1.Value = (int)(value * 100);
            }
            get
            {
                return (double)this.progressBar1.Value / 100;
            }
        }
    }
}
