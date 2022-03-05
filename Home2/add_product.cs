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
    public partial class add_product : Form
    {
        public add_product()
        {
            InitializeComponent();
            this.MinimumSize = new Size(600, 500);
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_panel admin_panelObject= new admin_panel();
            admin_panelObject.Show();
        }

        private void add_product_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string ProName = proname.Text;
            string ProCategory = procategory.Text;
            string ProImage = proimage.Text;
            string ProVideo = provideo.Text;
            string Procode = procode.Text;
            string ProPrice = proprice.Text;
            string ProDiscount = prodiscount.Text;
            string ProPercent = propercent.Text;
            string ProDescription = prodescription.Text;
            string ProQuantity = proquantity.Text;
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "insert into add_product(id,pro_category,pro_name,pro_image,pro_video,pro_code,pro_price,pro_discount,pro_percent,pro_description,quantity)values('NULL','" + ProCategory + "','" + ProName + "','" + ProImage + "','" + ProVideo + "','" + Procode + "','" + ProPrice + "','" + ProDiscount + "','" + ProPercent + "','" + ProDescription + "','" + ProQuantity + "');";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            add_product add_productObject = new add_product();
            add_productObject.Show();
        
        }

        private void proname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
