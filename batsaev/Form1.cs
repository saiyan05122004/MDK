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
    public partial class Form1 : Form
    {
        int summa = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            if (comboBox1.SelectedIndex == 1)
            { summa = 8000 + 1000; }
            else if (comboBox1.SelectedIndex == 1)
            { summa = 8000 + 1500; }
            else label5.Visible = true;
            if (checkBox1.Checked)
            { summa = summa + 300; }
            if (checkBox2.Checked)
            { summa = summa + 2000; }
            if (checkBox3.Checked)
            { summa = summa + 500; }
            textBox3.Text = summa.ToString();
        }
    }
}
