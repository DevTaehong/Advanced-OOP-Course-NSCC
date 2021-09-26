using System;
using System.Collections.Generic;

namespace M4S3
{
    interface IPayee
    {
        void Pay();
    }
    class PayRoll
    {
        List<IPayee> payees = new List<IPayee>();
        //Default Constructor
        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }

        

        public void Payall()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
        }
    }
}
