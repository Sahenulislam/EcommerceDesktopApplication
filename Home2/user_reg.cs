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
    public partial class user_reg : Form
    {
        public user_reg()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;
            string Email = email.Text;
            string ConfirmPassword = conformpassword.Text;
            if(Password!=ConfirmPassword)
            {
                MessageBox.Show("Password did't Match");
                user_reg ob = new user_reg();
                ob.Show();   
            }
        }
    }
}
