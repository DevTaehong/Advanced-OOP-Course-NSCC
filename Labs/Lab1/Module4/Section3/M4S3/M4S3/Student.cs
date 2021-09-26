using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4S3
{
    interface IGraduate
    {
        void graduate();
    }
    class Student : Member, IGraduate
    {
        

        static public int Count = 0;

        public int Grade;
        public string Birthday;
        public School School;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }

        public void graduate()
        {
            Console.WriteLine("Graduated");
        }

        
    }
}
