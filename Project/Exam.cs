using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumOfQuestion { get; set; }

        public Question[] ListOfQuestions { get; set; }

        public Exam(int Time_, int NumOfQuestion_)
        {
            Time = Time_;
            NumOfQuestion = NumOfQuestion_;
        }
        public Exam() { }

        // The Show will not be the same for each exam (make it abstract)

        public abstract void ShowExam();

        public abstract void CreateListOfQuestions();

    }
}
