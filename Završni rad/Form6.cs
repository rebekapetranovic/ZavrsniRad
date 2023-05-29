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
    public partial class Form6 : Form
    {
        public static double slatuk = 0;
        public Form6()
        {
            InitializeComponent();
            slatuk = Form5.sluk;
            textBox1.Text = Convert.ToString(slatuk);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox1.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox2.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox3.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox4.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox5.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox5.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox6.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox6.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox7.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox7.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox8.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox8.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox9.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox9.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox10.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox10.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox11.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox11.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox12.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox12.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox13.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox13.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox14.Checked == true)
            {
                slatuk = slatuk + 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
            else if (checkBox14.Checked == false)
            {
                slatuk = slatuk - 0.5;
                textBox1.Text = Convert.ToString(slatuk);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            slatuk = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
