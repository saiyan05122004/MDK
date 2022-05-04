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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            { int summa = a * 500;
                textBox2.Text = summa.ToString();
            
            }
            if (radioButton2.Checked)
            { int summa = a * 200;
                textBox2.Text = summa.ToString();
            }

        }
    }
}
