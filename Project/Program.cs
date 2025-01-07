using System.Diagnostics;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Subject sub = new Subject(1, " C# ");

            sub.CreateExam();

            Console.Clear();

            Console.Write(" Do you want to start the Exam ( Y | N ) :");

            char c = char.Parse(Console.ReadLine());
            Console.Clear();
            // As the user might enter small letter
            if (c == 'Y' || c == 'y')
            {
                Console.Clear();
                Stopwatch Sw = new Stopwatch();
                Sw.Start();
                sub.Exam.ShowExam();
                Console.WriteLine();

                Console.WriteLine($" Taken time is :\t {Sw.Elapsed}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(" Thank you :) ! ");
            }
        }
    }
}
// By Abdelrahman_Sorour :)
