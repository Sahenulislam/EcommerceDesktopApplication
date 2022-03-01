using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Women f1 = new Women();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Men f2 = new Men();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book f3 = new Book();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bag f4 = new Bag();
            f4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Shoe f5 = new Shoe();
            f5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Furniture f6 = new Furniture();
            f6.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Contact f7 = new Contact();
            f7.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            user_login f8 = new user_login();
            //this.Close();
            f8.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Side.Width == 225)
            {
                Side.Width = 33;
            }
            else
                Side.Width = 225;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            admin_login a1 = new admin_login();
            a1.Show();
        }
    }
}
