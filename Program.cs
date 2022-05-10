using System;
using System.Collections.Generic;
using GenericsWithDataStructures.GenericsPrograms;

namespace GenericsWithDataStructures
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Welcome to Generics Program----------");
            bool end = true;
            Console.WriteLine("\n1.Parentheses\n2.End Of Program ");
            while (end)
            {
                Console.WriteLine("\nEnter Option For Execute The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Parenthesis<int> parentheses = new Parenthesis<int>();
                        parentheses.ParenthesesChecking<int>();
                        break;
                    case 2:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option");
                        break;
                }
            }
        }
    }
}