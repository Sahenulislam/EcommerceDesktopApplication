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
            this.MinimumSize = new Size(20, 500);
            this.CenterToScreen();
        }
       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //populateitem();
        }
       

        private void Women_Load(object sender, EventArgs e)
        {
            populateitem();
        }
        public void populateitem()
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "select *from add_product where pro_category='women';";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            UserControl1[] usercontrol1 = new UserControl1[50];
            int i = 0;
            while (reader.Read())
            {
                  usercontrol1[i] = new UserControl1();
                  usercontrol1[i].Title = reader.GetString(2);
                usercontrol1[i].Message = reader.GetString(6);
               /* if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {*/
                    flowLayoutPanel1.Controls.Add(usercontrol1[i]);
                //}
                i++;
            }
           
        }

        private void Women_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1ob = new Form1();
            form1ob.Show();


        }
    }
}
