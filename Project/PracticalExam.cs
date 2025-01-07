using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Practical : Exam
    {
        public Question[] Questions { get; set; }
        public Answers[] Answers { get; set; }


        public Practical() { }
        public Practical(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }


        public override void CreateListOfQuestions()
        {
            Questions = new MCQ_Q[NumOfQuestion];


            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i] = new MCQ_Q();

                Questions[i].AddQuestion();

                Console.Clear();
            }


        }



        public override void ShowExam()
        {

            int UserAnswer;
            int TotalMark = 0;
            int Grade = 0;
            bool Flag;


            foreach (var Question in Questions)
            {
                Console.WriteLine(Question);


                for (int i = 0; i < Question.AnswerList.Length; i++)
                {
                    Console.WriteLine(Question.AnswerList[i]);
                }


                Console.WriteLine("=========================================\n");

                do
                {
                    Console.WriteLine("  Enter Number Of Your Answer  :   ");
                    Flag = int.TryParse(Console.ReadLine(), out UserAnswer);  //False
                }
                while
                (!Flag || UserAnswer < 1 || UserAnswer > 3);



                Question.StudentAnswer.AnswerId = UserAnswer;
                Question.StudentAnswer.AnswerText = Question.AnswerList[UserAnswer - 1].AnswerText;


                Console.WriteLine("=========================================\n");


                Console.Clear();
                TotalMark += Question.Mark;

            }




            for (int i = 0; i < Questions.Length; i++)
            {

                if (Questions[i].RightAnswer.AnswerId == Questions[i].StudentAnswer.AnswerId)
                {
                    Grade += Questions[i].Mark;
                }

                Console.WriteLine($" The Question Is ( {i + 1}  )  \t:\t  {Questions[i].Body} ");
                Console.WriteLine();


                Console.WriteLine($" Your Answer Is  :\t {Questions[i].StudentAnswer.AnswerText}");
                Console.WriteLine();

                Console.WriteLine($" The Correct Answer Is   :\t {Questions[i].RightAnswer.AnswerText}");
                Console.WriteLine();

            }

            Console.WriteLine($" Your Grade is   {Grade}   \t / \t  {TotalMark}  ");
            Console.WriteLine();





        }


    }
}
