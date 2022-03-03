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
    }
}
