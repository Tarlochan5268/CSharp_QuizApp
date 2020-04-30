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
    public partial class Test : Form
    {
        int i,score=0;
        string correctOption;
        public Test()
        {
            InitializeComponent();
        }
        ReturnClass rc = new ReturnClass();

        private void Test_Load(object sender, EventArgs e)
        {
            i = Convert.ToInt32(rc.scalarReturn("select min(ques_id) from questions"));
            label1.Text = rc.scalarReturn("select ques_title from questions where ques_id = " + i);
            radioButton1.Text = rc.scalarReturn("select ques_option1 from questions where ques_id = "+i);
            radioButton2.Text = rc.scalarReturn("select ques_option2 from questions where ques_id = " + i);
            radioButton3.Text = rc.scalarReturn("select ques_option3 from questions where ques_id = " + i);
            radioButton4.Text = rc.scalarReturn("select ques_option4 from questions where ques_id = " + i);
            correctOption = rc.scalarReturn("select ques_correct from questions where ques_id = " + i);
            label2.Text = "Score : " + score;
            label3.Text = "Time : 00 : 00";
        }
        string s,selectedValue;
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                selectedValue = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                selectedValue = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                selectedValue = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                selectedValue = radioButton4.Text;
            }
            else
            {
                MessageBox.Show("Please Select one Option");
            }

            if(selectedValue.Equals(correctOption))
            {
                score++;
                label2.Text = "Score : " + score;
            }


            s = rc.scalarReturn("select min(ques_id) from questions where ques_id>" + i);
            if(s.Equals(""))
            {
                MessageBox.Show("Quiz Over");
                button1.Enabled = false;
            }
            else
            {
                i = Convert.ToInt32(s);
                label1.Text = rc.scalarReturn("select ques_title from questions where ques_id = " + i);
                radioButton1.Text = rc.scalarReturn("select ques_option1 from questions where ques_id = " + i);
                radioButton2.Text = rc.scalarReturn("select ques_option2 from questions where ques_id = " + i);
                radioButton3.Text = rc.scalarReturn("select ques_option3 from questions where ques_id = " + i);
                radioButton4.Text = rc.scalarReturn("select ques_option4 from questions where ques_id = " + i);
                correctOption = rc.scalarReturn("select ques_correct from questions where ques_id = " + i);
                label3.Text = "Time : 00 : 00";
                radiobtnDeselect();
            }
        }
        public void radiobtnDeselect()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

    }
}