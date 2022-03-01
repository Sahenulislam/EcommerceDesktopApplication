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
    public partial class user_panel : Form
    {
        public user_panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 HomeObject = new Form1();
            HomeObject.Show();

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
