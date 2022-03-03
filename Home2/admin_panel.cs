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
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
            this.MinimumSize = new Size(20, 20);
            this.CenterToScreen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 From1Object = new Form1();
            From1Object.Show();
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 From1Object = new Form1();
            From1Object.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_product add_productObject = new add_product();
            add_productObject.Show();
        }
    }
}
