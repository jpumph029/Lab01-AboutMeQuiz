using System;

namespace About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QuestionOne();
            QuestionTwo();
            QuestionThree();
            Console.ReadLine();
        }
        static int QuestionOne()
        {
            Console.Write("How old am I? ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 22)
                Console.WriteLine("You are correct.");
            else
                Console.WriteLine("You are incorrect.");
            return input;
        }
        static int QuestionTwo()
        {
            Console.Write("How many pets do I have? ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 0)
                Console.WriteLine("You are correct.");
            else
                Console.WriteLine("You are incorrect.");
            return input;
        }
        static int QuestionThree()
        {
            Console.Write("How many months have I lived in Seattle? ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 5)
                Console.WriteLine("You are correct.");
            else
                Console.WriteLine("You are incorrect.");
            return input;
        }
        static string QuestionFour()
        {
            Console.Write("Where do I live? ");
            string input = Console.ReadLine();
            if (input == Seattle || seattle)
            {

            }
            return input;
        }

    }
}
