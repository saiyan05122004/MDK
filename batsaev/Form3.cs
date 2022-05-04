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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            {
                int summa = a * 1500;
                textBox2.Text = summa.ToString();
            }

            if (radioButton2.Checked)
            {
                int summa = a * 800;
                textBox2.Text = summa.ToString();
            }

            if (radioButton3.Checked)
            {
                int summa = a * 3000;
                textBox2.Text = summa.ToString();
            }
        }
    }
}
