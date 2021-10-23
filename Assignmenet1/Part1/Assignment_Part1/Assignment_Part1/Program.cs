using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Run as Clinet vs Server
            Console.WriteLine("Listening For Messages");

            // User Input mode. When I key pressed
            //Console.ReadLine();
            var userKey = Console.ReadKey();

            // Display Incoming message

            // Allow for input

            // Let the user quit
            Console.WriteLine($"\nYou Typed {userKey.Key}");
            Console.Beep();
        }
    }
}
