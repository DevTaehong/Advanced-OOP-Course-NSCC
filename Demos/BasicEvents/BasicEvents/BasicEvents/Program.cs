using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEvents
{
    // define the delegate for the event handler
    public delegate void myEventHandler(string value);

    class EventPublisher
    {
        // Member variables
        private string theVal;

        // declare the event as the second property of this class
        public event myEventHandler valueChanged;

        public string Val // the setter of the property "theVal"
        {
            set
            {
                this.theVal = value;
                // When the value changes, fire or trigger the event "valueChanged"
                // be passing the new changed value "theVal"
                this.valueChanged(theVal);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            EventPublisher obj = new EventPublisher();
            // Method 1 for calling events : use a named function as an event handler
            // Creating the event's method (Triggering the event valueChanged). 
            // Using a user defined function called obj_valueChange
            obj.valueChanged += new myEventHandler(obj_valueChanged);

            // Method 2 for calling events:
            // Declare an anonymous delegate as an event handler
            
            obj.valueChanged += delegate (string val) {
                Console.WriteLine("From the anonymous delegate-->>>The value changed to {0}", val);
            };

            string str;
            do
            {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                {
                    // Setting the first property using its setter method
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }

        static void obj_valueChanged(string value)
        {
            Console.WriteLine("From the function-->>>The value changed to {0}", value);
        }
    }
}
