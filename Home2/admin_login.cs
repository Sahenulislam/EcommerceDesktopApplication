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
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            this.MinimumSize = new Size(300, 100);
>>>>>>> 2aa37a697ae3341268dacf8ce9f0047421717060
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 Form1Object = new Form1();
            Form1Object.Show();
        }

        private void admin_login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Object = new Form1();
            Form1Object.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;
            if(Username==""||Password=="")
            {
                this.Hide();
                this.Show();
            }
            else
            {
                this.Hide();
                admin_panel admin_panelObject = new admin_panel();
                admin_panelObject.Show();
            }
        }
    }
}
