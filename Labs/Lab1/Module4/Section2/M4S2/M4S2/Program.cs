using System;

namespace outreference
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2;

            Console.WriteLine(x);

            Five(out x);

            Console.WriteLine(x);
            /////// New Modifications # 1 ////////////

            Double(ref x);

            Console.WriteLine(x);
            /////// New Modifications # 1 ////////////
            /////// New Modifications # 2 ////////////

            var test = "1.5";
            var outDouble = 0.0;

            Console.WriteLine("Result: {0}", ParseDouble(test, out outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            Console.WriteLine("Test value is {0}", outDouble); // adition from me to the lab1 indtructions
            test = "Ronan";
            outDouble = 0.0;
            Console.WriteLine("Result: {0}", ParseDouble(test, out outDouble));
            Console.WriteLine("Test value is {0}", outDouble);


            /////// New Modifications # 2 ////////////
        }

        static void Five(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        ////// New Modificatios //////
        static void Double(ref int a)
        {
            a = a * 2; // When using out it will not accept variable 'a' without initializing it. 
                       // So it is better to use ref instead of out in this function
            Console.WriteLine(a);
        }

        static bool ParseDouble(string testString, out double outDouble)
        {
            outDouble = 0.0; // Should be initialized here as we use 'out' in the function signature
            bool result = false;
            try
            {
                if (double.Parse(testString).GetType() == outDouble.GetType())
                {
                    outDouble = double.Parse(testString);
                    result = true;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;

        }

    }
}
