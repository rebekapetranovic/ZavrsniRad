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
    public partial class Form3 : Form
    {
        public static double uk = 0;
        public Form3()
        {
            InitializeComponent();
            uk = Form2.ukupno;
            textBox1.Text = Convert.ToString(uk);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox1.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        } 
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox2.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox3.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                uk = uk + 5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox4.Checked == false)
            {
                uk = uk - 5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox5.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox6.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox7.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox8.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox9.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                uk = uk + 1;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox10.Checked == false)
            {
                uk = uk - 1;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                uk = uk + 1;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox11.Checked == false)
            {
                uk = uk - 1;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox12.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox13.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox14.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox15.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox16.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox17.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox18.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox19.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox20.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox21.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                uk = uk + 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
            else if (checkBox22.Checked == false)
            {
                uk = uk - 0.5;
                textBox1.Text = Convert.ToString(uk);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            uk = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 f8 = new Form8();
            f8.Show();
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

      

    }
}
