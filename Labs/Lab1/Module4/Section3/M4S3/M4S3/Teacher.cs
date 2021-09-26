using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4S3
{
    class Teacher : Member, IPayee
    {
        public string Subject;

        public void Pay()
        {
            Console.WriteLine("Paying Teacher");
        }
    }
}
