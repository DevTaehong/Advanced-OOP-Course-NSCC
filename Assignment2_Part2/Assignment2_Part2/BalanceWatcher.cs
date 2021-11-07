using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    public class BalanceWatcher
    {
        // This is another implementation of the event balanceChanged
        public void balanceWatch(decimal amount)
        {
            if (amount > 500.0m)
                Console.WriteLine("You reached your savings goal! You have {0}", amount);
        }
    }
}
