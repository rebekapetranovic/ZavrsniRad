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
    public partial class Form4 : Form
    {
        public static double slukupno = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            slukupno = 0.5;
            textBox1.Text = Convert.ToString(slukupno);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            slukupno = 0.5;
            textBox1.Text = Convert.ToString(slukupno);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            slukupno = 0.5;
            textBox1.Text = Convert.ToString(slukupno);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            slukupno = 0.5;
            textBox1.Text = Convert.ToString(slukupno);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            slukupno = 0.5;
            textBox1.Text = Convert.ToString(slukupno);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            slukupno = 0.5;
            textBox1.Text = Convert.ToString(slukupno);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            slukupno = 0.5;
            textBox1.Text = Convert.ToString(slukupno);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            slukupno = 0.5;
            textBox1.Text = Convert.ToString(slukupno);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            slukupno = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
