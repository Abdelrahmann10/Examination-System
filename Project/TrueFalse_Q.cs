using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class TrueFalse_Q : Question
    {

        public override string Header => " True or False question ";


        public TrueFalse_Q()
        {
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers(1, " True  ");
            AnswerList[1] = new Answers(2, " False ");
        }




        public override void AddQuestion()
        {
            int mark;
            bool Flag;


            Console.WriteLine(" True Or False question ");



            Console.WriteLine("   Enter The Body Of Question :  ");
            Body = Console.ReadLine();




            do
            {
                Console.WriteLine("  Enter The Mark Of Question :  ");
                Flag = int.TryParse(Console.ReadLine(), out mark);  //False

            }
            while
            (!Flag || mark < 1);


            Mark = mark;





            int RightAnswerId;
            do
            {
                Console.WriteLine(" Enter The Right Answer Of Question ( 1 for True and 2 for False ) : ");
                Flag = int.TryParse(Console.ReadLine(), out RightAnswerId); // Flase
            }
            while
            (!Flag || RightAnswerId < 1 || RightAnswerId > 2);



            RightAnswer.AnswerId = RightAnswerId;
            RightAnswer.AnswerText = AnswerList[RightAnswerId - 1].AnswerText;


            Console.Clear();
        }


    }
}
