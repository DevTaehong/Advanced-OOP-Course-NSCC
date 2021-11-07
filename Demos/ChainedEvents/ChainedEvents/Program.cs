using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedEvents
{
    // define a delegate for the eventHandler.
    // Any event will be declared based on this delegate.
    public delegate void myEventHandler(string value);

    class MyClass
    {
        private string theVal;
        // declare the event handler
        public event myEventHandler valueChanged;

        public event EventHandler<ObjChangeEventArgs> objChanged;

        public string Val
        {
            set
            {
                this.theVal = value;
                // when the value changes, fire the event
                this.valueChanged(theVal);
                // To trigger the fourth event which bases on .NET Framework guidlines,
                // write the following: 
                this.objChanged(this, new ObjChangeEventArgs() { propChanged = "Val" });
                // this keyword inside the round brackets refers to this class "MyClass" Object
                // Then creating a new ObjChangeEventArgs class object which is a sub-class of
                // EventArgs parent class.

                // new ObjChangeEventArgs()


                // I am going to fire an object changed event "ObjChangeEventArgs",
                // by saying that the name of the property changed
                // is the public property named Val. This is done by the following: 

                // { propChanged = "Val"} 
            }
        }
    }
    // This predefined class in used with the fourth evenet handler basaed on
    // .NET frameworks guidliens. 
    // It is a sub-class the inherits the predefined parent class called EventArgs
    //So, I am creating my own class called "ObjChangeEventArgs" which inherits from 
    // EventArgs
    class ObjChangeEventArgs : EventArgs // EventArgs is a predefined .NET Framework class
    {
        // declaring a new property or member variable called propChanged
        public string propChanged;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create the test class
            MyClass obj = new MyClass();

            // ---------- User Defined Events 1,2 & 3 ------------------------------//
            // Connect multiple event handlers
            // They are ready to be triggered once any action happens.
            // Chained Events
            obj.valueChanged += changeListener1; // First event handler
            obj.valueChanged += changeListener2; // Second event handler

            // Use an anonymous delegate as the event handler
            obj.valueChanged += delegate (string s) { // Third event handler
                Console.WriteLine("This came from the anonymous handler!");
            };

            //  -----   The forth event handler. --------------------------------//
            // Which depends on the .NET framework guidlines
            // So, to handle the fourth event handler we will write the following:

            obj.objChanged += delegate (object sender, ObjChangeEventArgs e) {
                Console.WriteLine("{0} had the '{1}' property changed", sender.GetType(), e.propChanged);
                // The default object is sender that is representing the object which changed
                // ObjChangeEventArgs is my custom class which indicates which property changed
                // in that object

            };

            string str;
            do
            {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                {
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
        // Two functions to be used by the event handler.
        static void changeListener1(string value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }
        static void changeListener2(string value)
        {
            Console.WriteLine("I also listen to the event, and got {0}", value);
        }
    }
}
