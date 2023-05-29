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
    public partial class Form10 : Form
    {
        public static double slano;
        public static double slatko;
        public static double novo;
        public Form10()
        {
            InitializeComponent();
            slano = Form3.uk;
            slatko = Form6.slatuk;
            novo = Form7.novouk;
            if (slano != 0)
            {
                textBox1.Text = Convert.ToString(slano);
            }
            if (slatko != 0)
            {
                textBox1.Text = Convert.ToString(slatko);
            }
            if (novo != 0)
            {
                textBox1.Text = Convert.ToString(novo);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (slano != 0)
                {
                    slano = slano + 2;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko + 2;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo + 2;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
            if (checkBox1.Checked == false)
            {
                if (slano != 0)
                {
                    slano = slano - 2;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko - 2;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo - 2;
                    textBox1.Text = Convert.ToString(novo);
                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (slano != 0)
                {
                    slano = slano + 3;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko + 3;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo + 3;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
            if (checkBox2.Checked == false)
            {
                if (slano != 0)
                {
                    slano = slano - 3;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko - 3;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo - 3;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                if (slano != 0)
                {
                    slano = slano + 2;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko + 2;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo + 2;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
            if (checkBox3.Checked == false)
            {
                if (slano != 0)
                {
                    slano = slano - 2;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko - 2;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo - 2;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                if (slano != 0)
                {
                    slano = slano + 3;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko + 3;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo + 3;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
            if (checkBox4.Checked == false)
            {
                if (slano != 0)
                {
                    slano = slano - 3;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko - 3;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo - 3;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                if (slano != 0)
                {
                    slano = slano + 2;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko + 2;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo + 2;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
            if (checkBox5.Checked == false)
            {
                if (slano != 0)
                {
                    slano = slano - 2;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko - 2;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo - 2;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                if (slano != 0)
                {
                    slano = slano + 3;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko + 3;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo + 3;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
            if (checkBox6.Checked == false)
            {
                if (slano != 0)
                {
                    slano = slano - 3;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko - 3;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo - 3;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                if (slano != 0)
                {
                    slano = slano + 3;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko + 3;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo + 3;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
            if (checkBox7.Checked == false)
            {
                if (slano != 0)
                {
                    slano = slano - 3;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko - 3;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo - 3;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                if (slano != 0)
                {
                    slano = slano + 3;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko + 3;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo + 3;
                    textBox1.Text = Convert.ToString(novo);
                }
            }
            if (checkBox8.Checked == false)
            {
                if (slano != 0)
                {
                    slano = slano - 3;
                    textBox1.Text = Convert.ToString(slano);
                }
                if (slatko != 0)
                {
                    slatko = slatko - 3;
                    textBox1.Text = Convert.ToString(slatko);
                }
                if (novo != 0)
                {
                    novo = novo - 3;
                    textBox1.Text = Convert.ToString(novo);
                }
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
            slano = Form3.uk;
            slatko = Form6.slatuk;
            novo = Form7.novouk; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form12 f12 = new Form12();
            f12.Show();
        }
    }
}
