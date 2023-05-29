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
    public partial class Form7 : Form
    {
        public static int novouk = 0;
        public Form7()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            novouk = 7;
            textBox1.Text = Convert.ToString(novouk);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            novouk = 7;
            textBox1.Text = Convert.ToString(novouk);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            novouk = 7;
            textBox1.Text = Convert.ToString(novouk);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            novouk = 8;
            textBox1.Text = Convert.ToString(novouk);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            novouk = 8;
            textBox1.Text = Convert.ToString(novouk);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            novouk = 8;
            textBox1.Text = Convert.ToString(novouk);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            novouk = 6;
            textBox1.Text = Convert.ToString(novouk);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            novouk = 6;
            textBox1.Text = Convert.ToString(novouk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            novouk = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 f8 = new Form8();
            f8.Show();
        }
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
