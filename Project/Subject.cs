using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Subject
    {
        public int SubId { get; set; }
        public string? SubName { get; set; }
        public Exam Exam { get; set; }
        //public Question question { get; set; }



        //public Subject()
        //{
        //}
        public Subject(int subId, string subName)
        {
            SubId = subId;
            SubName = subName;
        }



        int TypeOfQuestion;

        public void CreateExam()
        {
            int TypeOfExam, NumQuestions, time;
            do
            {
                Console.Write(" Enter The Type Of Exam You Want  ( 1 for practical and 2 for final )  : "); //Flase
            }while(!int.TryParse(Console.ReadLine(), out TypeOfExam) && TypeOfExam < 1 || TypeOfExam > 2);


            do
            {
                Console.Write(" Enter  Time Of The Exam : ");
            }while(!int.TryParse(Console.ReadLine(), out time));

            do
            {
                Console.Write(" Enter The Number Of Questions :  ");
            }while(!int.TryParse(Console.ReadLine(), out NumQuestions));



            Console.Clear();

            //Question[] questions = new Question[NumQuestions];


            if (TypeOfExam == 1)
            {
                Exam = new Practical(time, NumQuestions);
            }
            else
                Exam = new FinalExam(time, NumQuestions);
            Console.Clear();
            Exam.CreateListOfQuestions();
        }
    }
}
