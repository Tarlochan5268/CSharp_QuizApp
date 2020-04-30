using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_QuizApp
{
    class ViewClass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["quiz"].ConnectionString;
        string querry;
        public ViewClass(string q)
        {
            this.querry = q;
        }

        public DataTable showrecord()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(querry, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    dt.Load(dr);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("no records were found!!");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
