using System;

namespace About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //runs the methods 
            //catches expetions
            try
            {
                QuestionOne();
                QuestionTwo();
                QuestionThree();
                QuestionFour();
                QuestionFive();
            }
            catch (Exception)
            {
                Console.WriteLine("Something bad happend");

            }
            finally
            {
                Console.WriteLine("Congrats");
            }

            Console.ReadLine();
        }
        // writes a message, takes input converts input to a new var if 
        // uses if and else to compare input vs set data to see if the input is the same as the set data and displays a message 
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
        // writes a message, takes input converts input to a new var if 
        // uses if and else to compare input vs set data to see if the input is the same as the set data and displays a message
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
        // writes a line, takes input converts input to a new var if 
        // uses if and else to compare input vs set data to see if the input is the same as the set data and displays a message
        static string QuestionThree()
        {
            Console.Write("Where do I live? ");
            string input = Console.ReadLine();
            string formattedInput = input.ToUpper();
            if (formattedInput == "SEATTLE")
                Console.WriteLine("You are correct.");
            else
                Console.WriteLine("You are incorrect.");
            return input;
        }
        // writes a message, takes input converts input to a new var if 
        // uses if and else to compare input vs set data to see if the input is the same as the set data and displays a message
        static bool QuestionFour()
        {
            Console.Write("How many months have I lived in Seattle? ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 5)
            {
                Console.WriteLine("You are correct.");
                return true;
            }  
            else
            {
                Console.WriteLine("You are incorrect.");
                return false;
            }
        }
        // writes a line, takes input converts input to a new var if 
        // uses if and else to compare input vs set data to see if the input is the same as the set data and displays a message
        static string QuestionFive()
        {
            Console.Write("What is my favorite food? ");
            string input = Console.ReadLine();
            string formattedInput = input.ToUpper();
            if (formattedInput == "FOOD")
                Console.WriteLine("You are correct.");
            else
                Console.WriteLine("You are incorrect.");
            return input;
        }

    }
}

