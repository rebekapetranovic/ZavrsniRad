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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form12 f12 = new Form12();
            f12.Show();
        }

    }
}
