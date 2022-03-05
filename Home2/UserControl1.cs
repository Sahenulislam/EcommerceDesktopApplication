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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private string _title;
        [Category("customer props")]
        public string Title
        {
            get { return _title; }
            set { _title = value;label1.Text = value; }
        }

        private string _message;
        [Category("customer props")]
        public string Message
        {
            get { return _message; }
            set { _message = value;label2.Text = value; }
        }
        private Image _icon;
        [Category("customer props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


       
    }
}
