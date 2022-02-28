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
    public partial class Contact : Form
    {
        MySqlConnection connection = new MySqlConnection();
        public Contact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = textName.Text;
            string UserEmail = textEmail.Text;
            string UserMassage = textMassage.Text;
            MessageBox.Show(UserName);
            MessageBox.Show(UserEmail);
            MessageBox.Show(UserMassage);
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=.shop");
            conn.Open();
            string query = "insert into user_msg(Id,name,email,massage)values('NULL','" + UserName + "','" + UserEmail + "','" + UserMassage + "');";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
