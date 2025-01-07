using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class MCQ_Q : Question
    {
        public override string Header  => "MCQ Question";
        public MCQ_Q()
        {
            AnswerList = new Answers[3];
        }


        public override void AddQuestion()
        {
            int mark;
            bool Flag;


            Console.WriteLine(" MCQ Question ");



            Console.WriteLine(" Enter Body Of The Question :   ");
            Body = Console.ReadLine();



            do
            {
                Console.WriteLine(" Enter Mark Of The Question :   ");
                Flag = int.TryParse(Console.ReadLine(), out mark);  // False
            }
            while
            (!Flag || mark < 1);

            Mark = mark;



            Console.WriteLine(" The Choise Of Question Is :  ");

            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answers
                {
                    AnswerId = i + 1
                };


                Console.Write($" Enter The Choise Of Question Number {i + 1}  :  ( {i + 1} ) ");

                AnswerList[i].AnswerText = Console.ReadLine();
            }





            int RightAnswerId;

            do
            {
                Console.WriteLine(" Enter The Right Answer Of Question (  1  or  2  or  3  )  :    ");
                Flag = int.TryParse(Console.ReadLine(), out RightAnswerId);   // False
            }
            while
            (!Flag || RightAnswerId < 1 || RightAnswerId > 3);


            RightAnswer.AnswerId = RightAnswerId;
            RightAnswer.AnswerText = AnswerList[RightAnswerId - 1].AnswerText;

            Console.Clear();


        }
    }
}
