using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    public class PiggyBank
    {
        private decimal m_bankBalance;
        // Declaring a public event called balancedChanged which is referd to it
        // using the delegate BalanceEventHandler
        // This is considered as an action listener referd to it using
        // the delegate BalanceEventHandler
        public event BalanceEventHandler balanceChanged;

        public event EventHandler<BalanceArgs> negBalanceChanged;

        // public getter and setter for the private member variable m_bankBalance property
        public decimal theBalance
        {
            set // Once setting the value of the balance then trigger the 
                // event balanceChanged to update the new bank account balance
            {
                m_bankBalance = value; //value is the received argument from the place where we
                                       // pass this value (PSVM)
                balanceChanged(value);// Any new value posted (being set), trigger the event.

                if (value < 0)
                {
                    negBalanceChanged(this, new BalanceArgs() { balance = value });
                }
                
            }
            get
            {
                return m_bankBalance;
            }
        }
    }
}
