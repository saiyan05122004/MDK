using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace batsaev
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                label2.Text = "800,000р";
            { pictureBox1.Image = Image.FromFile (@"D:\batsaev\1.jpg"); }

            if (checkBox2.Checked)
            {
                label2.Text = "3,000,000р";

                { pictureBox1.Image = Image.FromFile(@"D:\batsaev\2.jpg"); }
            }
            if (checkBox3.Checked)
            {
                label2.Text = "15,000,000р";

                { pictureBox1.Image = Image.FromFile(@"D:\batsaev\3.jpg"); }
            }
        }
    }
}
