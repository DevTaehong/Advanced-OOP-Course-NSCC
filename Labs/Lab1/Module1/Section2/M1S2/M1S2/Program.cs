using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the pass code?");
            var code = Console.ReadLine();

            if (code != "secret")
            {
                Console.WriteLine("Not Authenticated");
            }

            if (code == "secret")
            {
                Console.WriteLine("Authenticated");

                Console.WriteLine("Change the pass code: ");
                code = Console.ReadLine();
                Console.WriteLine("New pass code is: {0}", code);

            }

            
            
            
            
            
        }
    }
}
