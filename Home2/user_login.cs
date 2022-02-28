using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Home2
{
    public partial class user_login : Form
    {
        public user_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_reg ob = new user_reg();
            ob.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            MySqlCommand Command=new MySqlCommand("select *from user_login");
            MySqlDataReader Reader = Command.ExecuteReader();
            while(Reader.Read())
            {

            }
            conn.Close();
            user_login ob = new user_login();
            ob.Show();
        }
    }
}
