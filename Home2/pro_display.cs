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
    public partial class pro_display : UserControl
    {
        public pro_display()
        {
            InitializeComponent();
        }
        private string _title;
        [Category("customer props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; panel1.Text = value; }
        }

        private string _message;
        [Category("customer props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; panel2.Text = value; }
        }
        private string _quantity;
        [Category("customer props")]
        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; panel2.Text = value; }
        }
        private Image _icon;
        [Category("customer props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }

        }
    }
}
