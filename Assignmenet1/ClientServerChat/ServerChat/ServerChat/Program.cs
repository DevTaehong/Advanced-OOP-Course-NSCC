using ChatLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerChat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*--------------------------Part 1 --------------------------------*/
            Console.WriteLine(args[0]);
            Console.ReadLine(); // Blocking statement

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

            /* ------Part 2------------------------------------------------------------
            while (true)
            {

                Console.WriteLine("Listening For Messages");

                // User Input mode. When I key pressed
                //Console.ReadLine();
                var userKey = Console.ReadKey();

                // Display Incoming message

                // Allow for input

                // Let the user quit
                Console.WriteLine($"\nYou Typed {userKey.Key}");
                //Console.Beep();
               
            }
            -------------------Part 2 Ends---------------------*/

            /*----------------- Part 3
            // Run as Client vs Server
            if (args.Contains("-server"))
            {
                Console.WriteLine("Server Mode");
                Server server = new Server();
            }
            else
            {
                Console.WriteLine("Client Mode");
                Client client = new Client();
            }

            Console.ReadLine();
            while (true)
            {

                Console.WriteLine("Listening For Messages");

                // User Input mode. When I key pressed
                //Console.ReadLine();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userKey = Console.ReadKey();

                    // Display Incoming message

                    // Allow for input

                    // Let the user quit
                    Console.WriteLine($"\nYou Typed {userKey.Key}");
                    //Console.Beep();
                    Thread.Sleep(1000);
                }


            }
            -----------------------Part 3 --------*/
        }
    }
}
