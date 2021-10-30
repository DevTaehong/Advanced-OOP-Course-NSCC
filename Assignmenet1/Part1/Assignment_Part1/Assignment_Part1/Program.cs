using CharLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_Part1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*---------------Part 1---------------------------------------
           //Part 1
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
        --------------------------End Part 1---------------------------------------*/
            /*------------------------------Part 2---------------------------------------
            // Run as Clinet vs Server
            while (true)
            {

                Console.WriteLine("Listening For Messages");

                // User Input mode. When I key pressed
                //Console.ReadLine();
                ConsoleKeyInfo userKey = Console.ReadKey(); //Blocking statement

                // Display Incoming message

                // Allow for input

                // Let the user quit
                Console.WriteLine($"\nYou Typed {userKey.Key}");
                Console.Beep();
            }//end while
            --------------------------End Part 2 */

            /*---------------------------------Part 3--------------------------------

            // Run as Clinet vs Server
            while (true)
            {

                Console.WriteLine("Listening For Messages");
                if (Console.KeyAvailable)
                {
                    // User Input mode. When I key pressed
                    ConsoleKeyInfo userKey = Console.ReadKey(); //Blocking statement

                    // Display Incoming message

                    // Allow for input

                    // Let the user quit
                    Console.WriteLine($"\nYou Typed {userKey.Key}");
                    Thread.Sleep(500);
                }
            }//end while
            --------------------End Part 3-----------------------------------*/

            /*----------------------------------Part 4------------------------------------
            while (true)
            {

                Console.WriteLine("Listening For Messages");
                if (Console.KeyAvailable)
                {
                    // User Input mode. When I key pressed
                    ConsoleKeyInfo userKey = Console.ReadKey(); //Blocking statement
                    if(userKey.Key == ConsoleKey.I)
                    {
                        Console.Write("\nI is PRESSED >>");
                        Console.ReadLine();
                        //break;
                    }
                    else
                    {
                        Console.WriteLine($"\nYou Typed {userKey.Key}");
                        Thread.Sleep(500);
                    }
                    // Display Incoming message

                    // Allow for input

                    // Let the user quit
                    
                }
            }//end while
            ----------------------------------End Part 4--------------------------*/
            /*--------------------------------Part 5--------------------------------------------

            //Console.WriteLine(args[0]);
            if(args.Contains("-server")) // args[0] = "-server"
            {
                Console.WriteLine("Server");
            }
            else
            {
                Console.WriteLine("Client");
            }

            Console.ReadLine();//Blocking statement

            while (true)
            {

                Console.WriteLine("Listening For Messages");
                if (Console.KeyAvailable)
                {
                    // User Input mode. When I key pressed
                    ConsoleKeyInfo userKey = Console.ReadKey(); //Blocking statement
                    if (userKey.Key == ConsoleKey.I)
                    {
                        Console.Write("\nI is PRESSED >>");
                        Console.ReadLine();
                        //break;
                    }
                    else
                    {
                        Console.WriteLine($"\nYou Typed {userKey.Key}");
                        Thread.Sleep(500);
                    }
                    // Display Incoming message

                    // Allow for input

                    // Let the user quit

                }
            }//end while
            ------------------------End Part 5----------------------------------------------------*/

            //---------------------------------------------------Part 6---------------------------------------
            //Console.WriteLine(args[0]);
            if (args.Contains("-server")) // args[0] = "-server"
            {
                Console.WriteLine("Server");
                Server server = new Server(); // New Object
            }
            else
            {
                Console.WriteLine("Client");
                Client client = new Client(); // New Object
            }

            Console.ReadLine();//Blocking statement

            while (true)
            {

                Console.WriteLine("Listening For Messages");
                if (Console.KeyAvailable)
                {
                    // User Input mode. When I key pressed
                    ConsoleKeyInfo userKey = Console.ReadKey(); //Blocking statement
                    if (userKey.Key == ConsoleKey.I)
                    {
                        Console.Write("\nI is PRESSED >>");
                        Console.ReadLine();
                        //break;
                    }
                    else
                    {
                        Console.WriteLine($"\nYou Typed {userKey.Key}");
                        Thread.Sleep(500);
                    }
                    // Display Incoming message

                    // Allow for input

                    // Let the user quit

                }
            }//end while





        }//end Main
    }//end Program
}//end namespace
