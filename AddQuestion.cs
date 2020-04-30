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
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizAppDataSet.quizes' table. You can move, or remove it, as needed.
            this.quizesTableAdapter.Fill(this.quizAppDataSet.quizes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Questions q = new Questions();
            q.ques_title = textBox1.Text;
            q.ques_option1 = textBox2.Text;
            q.ques_option2 = textBox3.Text;
            q.ques_option3 = textBox4.Text;
            q.ques_option4 = textBox5.Text;
            q.ques_correct = textBox6.Text;
            q.ques_addeddate = System.DateTime.Now.ToShortDateString();
            q.ques_fk_admin = AdminLogin.fk_ad;
            q.ques_fk_quiz = comboBox1.SelectedValue.ToString();
            InsertClass ic = new InsertClass();
            string msg = ic.insert_srecord(q);
            MessageBox.Show(msg+" "+q.ToString()+" "+comboBox1.SelectedValue.ToString());

        }
    }
}
