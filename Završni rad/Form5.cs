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
    public partial class Form5 : Form
    {
        public static double sluk = 0;
        public Form5()
        {
            InitializeComponent();
            sluk = Form4.slukupno;
            textBox1.Text = Convert.ToString(sluk);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox1.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox2.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox3.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox4.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox5.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox6.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                sluk = sluk + 1;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox7.Checked == false)
            {
                sluk = sluk - 1;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox8.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                sluk = sluk + 1;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox9.Checked == false)
            {
                sluk = sluk - 1;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                sluk = sluk + 1;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox10.Checked == false)
            {
                sluk = sluk - 1;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox11.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox12.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                sluk = sluk + 1;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox13.Checked == false)
            {
                sluk = sluk - 1;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox14.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox15.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                sluk = sluk + 1;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox16.Checked == false)
            {
                sluk = sluk - 1;
                textBox1.Text = Convert.ToString(sluk);
            }
        }
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox17.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox18.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                sluk = sluk + 2;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox19.Checked == false)
            {
                sluk = sluk - 2;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                sluk = sluk + 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
            else if (checkBox20.Checked == false)
            {
                sluk = sluk - 0.5;
                textBox1.Text = Convert.ToString(sluk);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            sluk = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
