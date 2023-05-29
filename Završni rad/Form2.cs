using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Završni_rad
{
    public partial class Form2 : Form
    {
        public static double ukupno = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ukupno = 3;
            textBox1.Text = Convert.ToString(ukupno);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ukupno = 3;
            textBox1.Text = Convert.ToString(ukupno);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ukupno = 3.5;
            textBox1.Text = Convert.ToString(ukupno);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ukupno = 4;
            textBox1.Text = Convert.ToString(ukupno);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ukupno = 4;
            textBox1.Text = Convert.ToString(ukupno);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ukupno = 4;
            textBox1.Text = Convert.ToString(ukupno);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ukupno = 5;
            textBox1.Text = Convert.ToString(ukupno);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ukupno = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
