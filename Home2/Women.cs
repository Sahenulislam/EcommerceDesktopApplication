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
    public partial class Women : Form
    {
        public Women()
        {
            InitializeComponent();
            this.MinimumSize = new Size(20, 10000);
            this.CenterToScreen();
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "select *from add_product where pro_category='women';";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader.GetString(2));
            }
            conn.Close();
        }

        private void Women_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1ob = new Form1();
            form1ob.Show();


        }
    }
}
