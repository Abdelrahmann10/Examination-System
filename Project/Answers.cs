using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }

        public Answers(int AnswerId_, string AnswerText_)
        {
            AnswerId = AnswerId_;
            AnswerText = AnswerText_;
        }
        public Answers(){ }
        public override string ToString()
        {
            return $" AnswerId -> {AnswerId} - AnswerText -> {AnswerText}";
        }
    }
}
