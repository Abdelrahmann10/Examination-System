using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public abstract class Question
    {
        public abstract string Header { get; }
        public string? Body { get; set; }
        public int Mark { get; set; }

        public Answers[] AnswerList { get; set; }
        public Answers RightAnswer { get; set; }
        public Answers StudentAnswer { get; set; }

        public Question()
        {
            RightAnswer = new Answers();
            StudentAnswer = new Answers();
        }

        public abstract void AddQuestion();
        public override string ToString()
        {
            return $"{Header} \t (Marks) {Mark} \n------\n{Body}";
        }
    }
}
