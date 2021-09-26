using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4S3
{
    interface IPayee
    {
        void Pay();
    }
    class PayRoll
    {
        Teacher teacher1 = new Teacher();
        Teacher teacher2 = new Teacher();
        Principal principal1 = new Principal();

        public void Payall()
        {
            teacher1.Pay();
            teacher2.Pay();
            principal1.Pay();
        }
    }
}
