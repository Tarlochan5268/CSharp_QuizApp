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
    public partial class SetQuiz : Form
    {
        public SetQuiz()
        {
            InitializeComponent();
        }

        private void SetQuiz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizAppDataSet5.set_quiz' table. You can move, or remove it, as needed.
            this.set_quizTableAdapter.Fill(this.quizAppDataSet5.set_quiz);
            // TODO: This line of code loads data into the 'quizAppDataSet4.quizes' table. You can move, or remove it, as needed.
            this.quizesTableAdapter1.Fill(this.quizAppDataSet4.quizes);
            // TODO: This line of code loads data into the 'quizAppDataSet3.quizes' table. You can move, or remove it, as needed.
            this.quizesTableAdapter.Fill(this.quizAppDataSet3.quizes);
            // TODO: This line of code loads data into the 'quizAppDataSet2.user_record' table. You can move, or remove it, as needed.
            this.user_recordTableAdapter1.Fill(this.quizAppDataSet2.user_record);
            // TODO: This line of code loads data into the 'quizAppDataSet1.user_record' table. You can move, or remove it, as needed.
            this.user_recordTableAdapter.Fill(this.quizAppDataSet1.user_record);

            string q = "select * from user_record";
            ViewClass vc = new ViewClass(q);
            dataGridView1.DataSource = vc.showrecord();


            string q2 = "select * from quizes";
            ViewClass vc2 = new ViewClass(q2);
            dataGridView2.DataSource = vc2.showrecord();

            string q3 = "select * from set_quiz";
            ViewClass vc3 = new ViewClass(q3);
            dataGridView3.DataSource = vc3.showrecord();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertClass ic = new InsertClass();
            ic.insert_setquiz(System.DateTime.Now.ToShortDateString(),comboBox1.Text,comboBox4.Text);
            string q3 = "select * from set_quiz";
            ViewClass vc3 = new ViewClass(q3);
            dataGridView3.DataSource = vc3.showrecord();
        }
    }
}
