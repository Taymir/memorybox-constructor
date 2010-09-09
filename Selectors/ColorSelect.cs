using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Constructor.Selectors
{
    public partial class ColorSelect : UserControl
    {
        public ColorSelect()
        {
            InitializeComponent();
        }

        public string color
        {
            get
            {
                if (this.textBox1.Text != "#")
                    return this.textBox1.Text;
                else
                    return string.Empty;
            }
            set
            {
                this.textBox1.Text = value;
                this.colorDialog1.Color = System.Drawing.ColorTranslator.FromHtml(value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.color = color;
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = System.Drawing.ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }
    }
}
