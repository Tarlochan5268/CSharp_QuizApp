﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_QuizApp
{
    public partial class AdminLogin : Form
    {
        public static string fk_ad;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            string userdb, passworddb;

            ReturnClass rc = new ReturnClass();
            userdb = rc.scalarReturn("select count(admin_id) from admin_auth where ad_user='" + user + "'");
            // ad_id -> admin_id ad_name -> ad_user

            if (userdb.Equals("0"))
            {
                MessageBox.Show("Invalid user name!");
            }
            else
            {
                passworddb = rc.scalarReturn("select ad_password from admin_auth where ad_user='" + user + "'");

                if (passworddb.Equals(password))
                {
                    fk_ad = rc.scalarReturn("select admin_id from admin_auth where ad_user='" + user + "'");

                    Form2 f = new Form2();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Password!");
                }


            }
        }
    }
}
