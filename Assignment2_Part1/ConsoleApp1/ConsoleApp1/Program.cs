using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(ref decimal arg1);
    class Program
    {
        static void Main(string[] args)
        {
            ShippingFeesDelegate theDel;
            ShippingDestination theDest;

            //Added an anonymous delegate called f that decerase the fee by $10 
            MyDelegate f = delegate (ref decimal fee)
            {
                Console.WriteLine("The shipping fees are: {0}", fee-10);
            };

            string theZone;
            do
            {
                // get the destination zone
                Console.WriteLine("What is the destination zone?");
                theZone = Console.ReadLine();

                // if the user wrote "exit" then terminate the program,
                // otherwise continue 
                if (!theZone.Equals("exit"))
                {
                    // given the zone, retrieve the associated shipping info
                    theDest = ShippingDestination.getDestinationInfo(theZone);

                    // if there's no associated info, then the user entered
                    // an invalid zone, otherwise continue
                    if (theDest != null)
                    {
                        
                        decimal itemPrice;//A variable for do-while loop
                        do
                        {
                            // ask for the price and convert the string to a decimal number
                            Console.WriteLine("What is the item price?");
                            string thePriceStr = Console.ReadLine();
                            itemPrice = decimal.Parse(thePriceStr);
                            if (itemPrice > 0)// check if the user enters itemPrice greater than 0 
                            {
                                // Each ShippingDestination object has a function called calcFees,
                                // use that as the delegate for calculating the fee
                                theDel = theDest.calcFees;

                                // For high-risk zones, we tack on the delegate that adds more
                                if (theDest.m_isHighRisk)
                                {
                                    theDel += delegate (decimal thePrice, ref decimal itemFee)
                                    {
                                        itemFee += 25.0m;
                                    };
                                }
                                // now all that is left to do is call the delegate and output
                                // the shipping fee to the Console
                                decimal theFee = 0.0m;
                                theDel(itemPrice, ref theFee);
                                //After calculating fees if the fees are greater than $100, use the anonymous delegate I made.
                                if(!theDest.m_isHighRisk && theFee > 100)
                                {
                                    f(ref theFee);
                                }
                                else //if the fees are less than $100
                                {
                                    Console.WriteLine("The shipping fees are: {0}", theFee);
                                }
                            }
                            else
                            {
                                Console.WriteLine("The item price should be greater than zero.");
                            }
                        } while (itemPrice <= 0);  //Kepp looping if itemPrice less then 0                   
                    }
                    else
                    {
                        Console.WriteLine("Hmm, you seem to have entered an uknown destination. Try again or 'exit'");
                    }
                }
            } while (theZone != "exit");
        }
    }
}
