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
<<<<<<< HEAD
            this.MinimumSize = new Size(600, 600);
=======
<<<<<<< HEAD
=======
            this.MinimumSize = new Size(600, 500);
>>>>>>> 2aa37a697ae3341268dacf8ce9f0047421717060
>>>>>>> b1383ac81dfdeaad7cbf481eaeeb017453a14d06
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Women f1 = new Women();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
            Men f2 = new Men();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book f3 = new Book();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           this.Hide();
            Bag f4 = new Bag();
            f4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shoe f5 = new Shoe();
            f5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Furniture f6 = new Furniture();
            f6.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact f7 = new Contact();
            f7.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_login f8 = new user_login();
            f8.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Side.Width == 225)
            {
                Side.Width = 35;
            }
            else
                Side.Width = 225;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_login a1 = new admin_login();
            a1.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
