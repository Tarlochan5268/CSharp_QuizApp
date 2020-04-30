using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_QuizApp
{
    class Questions
    {
        public int ques_id { get; set; }
        public string ques_title { get; set; }
        public string ques_option1 { get; set; }
        public string ques_option2 { get; set; }
        public string ques_option3 { get; set; }
        public string ques_option4 { get; set; }
        public string ques_correct { get; set; }
        public string ques_addeddate { get; set; }
        public string ques_fk_admin { get; set; }
        public string ques_fk_quiz { get; set; }
    }
}
