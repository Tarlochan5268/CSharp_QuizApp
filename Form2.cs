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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuestion ad = new AddQuestion();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetQuiz sq = new SetQuiz();
            sq.Show();
        }
    }
}
