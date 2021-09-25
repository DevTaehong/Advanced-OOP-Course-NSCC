
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());
            var perStudent = 2;
            var students = new string[studentCount, perStudent];


            for (int row = 0; row < studentCount; row++)
            {

                Console.WriteLine("Enter Student Name: ");
                students[row, 0] = Console.ReadLine();

                Console.WriteLine("Enter grade: ");
                students[row, 1] = Console.ReadLine();

            }

            for (int row = 0; row < studentCount; row++)
            {
                Console.WriteLine("Student {0} Name and Grade {1} {2}", row, students[row, 0], students[row, 1]);
            }

        }
    }
}
