using System;
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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            string userdb, passworddb,user_id;

            ReturnClass rc = new ReturnClass();
            userdb = rc.scalarReturn("select count(user_id) from user_record where user_name='" + user + "'");
            // ad_id -> admin_id ad_name -> ad_user

            if (userdb.Equals("0"))
            {
                MessageBox.Show("Invalid user name!");
            }
            else
            {
                passworddb = rc.scalarReturn("select user_password from user_record where user_name='" + user + "'");

                if (passworddb.Equals(password))
                {
                    user_id = rc.scalarReturn("select user_id from user_record where user_name='" + user + "'");

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
