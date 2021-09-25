using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4S1
{
    enum monthCategory
    {
        January = 0,
        February = 1,
        March = 2,
        April = 3, 
        May = 4,
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            Console.WriteLine("January : 0\nFebruary : 1\nMarch : 2\nApril : 3\nMay : 4");
            Console.WriteLine("Enther one of those numbers");
            var month = int.Parse(TryAnswer());
            monthCategory monthName = (monthCategory) month;

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", monthName);

            switch (month)
            {
                case 0:
                    Console.WriteLine("You are a Capricornus");
                    break;
                case 1:
                    Console.WriteLine("You are a Auqarius");
                    break;
                case 2:
                    Console.WriteLine("You are an Aries");
                    break;
                case 3:
                    Console.WriteLine("you are a Taurus.");
                    break;
                case 4:
                    Console.WriteLine("you are a Gemini.");
                    break;
                default:
                    Console.WriteLine("Incorrect month number.");
                    break;
            }


            //if (month == "march")
            //{
            //    Console.WriteLine("you are an Aries.");
            //}
            //else if (month == "april")
            //{
            //    Console.WriteLine("you are a Taurus.");
            //}
            //else if (month == "may")
            //{
            //    Console.WriteLine("you are a Gemini.");
            //}
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }
    }
}

