﻿using System;
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 Form1Object = new Form1();
            Form1Object.Show();
        }

        private void add_product_Load(object sender, EventArgs e)
        {

        }
    }
}
