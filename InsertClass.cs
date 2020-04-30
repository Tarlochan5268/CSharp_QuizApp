using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CSharp_QuizApp
{
    class InsertClass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["quiz"].ConnectionString;
        public string insert_srecord(Questions q)
        {
            string msg = " ";
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("insert_questions", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ques_title", SqlDbType.NVarChar).Value = q.ques_title;
                cmd.Parameters.Add("@ques_option1", SqlDbType.NVarChar, 200).Value = q.ques_option1;
                cmd.Parameters.Add("@ques_option2", SqlDbType.NVarChar, 200).Value = q.ques_option2;
                cmd.Parameters.Add("@ques_option3", SqlDbType.NVarChar, 200).Value = q.ques_option3;
                cmd.Parameters.Add("@ques_option4", SqlDbType.NVarChar, 200).Value = q.ques_option4;
                cmd.Parameters.Add("@ques_correct", SqlDbType.NVarChar, 200).Value = q.ques_correct;
                cmd.Parameters.Add("@ques_addeddate", SqlDbType.NVarChar, 200).Value = q.ques_addeddate;
                cmd.Parameters.Add("@ques_fk_admin", SqlDbType.Int).Value = q.ques_fk_admin;
                cmd.Parameters.Add("@ques_fk_quiz", SqlDbType.Int).Value = q.ques_fk_quiz;

                conn.Open();
                cmd.ExecuteNonQuery();

                msg = "data successfully inserted!";
            }
            catch (Exception)
            {
                msg = "data is not successfully inserted!";
            }
            finally
            {
                conn.Close();
            }
            return msg;
        }

        public string insert_setquiz(string date,string usr_id,string quiz_id)
        {
            string msg = " ";
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT_SET_QUIZ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@set_quiz_date", SqlDbType.NVarChar).Value = date;
                cmd.Parameters.Add("@usr_id_fk", SqlDbType.Int).Value = usr_id;
                cmd.Parameters.Add("@quiz_id_fk", SqlDbType.Int).Value = quiz_id;

                conn.Open();
                cmd.ExecuteNonQuery();

                msg = "data successfully inserted!";
            }
            catch (Exception)
            {
                msg = "data is not successfully inserted!";
            }
            finally
            {
                conn.Close();
            }
            return msg;
        }
    }
}
