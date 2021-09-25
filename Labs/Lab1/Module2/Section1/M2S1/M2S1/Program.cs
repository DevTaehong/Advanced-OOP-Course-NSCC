using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S1
{
    class Data
    {
        private string Name;
        private int Age;
        private int Month;
        private int Date;
        public string name
        {
            set { Name = value; }
            get { return Name; }
        }

        public int month
        {
            set { Month = value; }
            get { return Month; }
        }

        public int age
        {
            set { Age = value; }
            get { return Age; }
        }

        public int date
        {
            set { Date = value; }
            get { return Date; }
        }

        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Month);
            Console.WriteLine("Your birth date is: {0}", Date);

            switch (Month)
            {
                case 3:
                    if(Date >= 21)
                    {
                        Console.WriteLine("you are an Aries.");
                    }
                    else if(Date <= 20)
                    {
                        Console.WriteLine("you are an Pisces.");
                    }
                    break;
                case 4:
                    if(Date <= 19)
                    {
                        Console.WriteLine("you are an Aries.");
                    }
                    else if (Date >= 20)
                    {
                        Console.WriteLine("you are a Taurus.");
                    }
                    break;
                case 5:
                    if(Date <= 20)
                    {
                        Console.WriteLine("you are a Taurus.");
                    }
                    else if(Date >= 21)
                    {
                        Console.WriteLine("you are a Gemini.");
                    }
                    break;
                case 6:
                    if(Date <= 21)
                    {
                        Console.WriteLine("you are a Gemini.");
                    }
                    else if(Date >= 22)
                    {
                        Console.WriteLine("you are a Cancer.");
                    }
                    break;
                case 7:
                    if(Date <= 22)
                    {
                        Console.WriteLine("you are a Cancer.");
                    }
                    else if(Date >= 23)
                    {
                        Console.WriteLine("you are a Leo.");
                    }
                    break;
                case 8:
                    if(Date <= 22)
                    {
                        Console.WriteLine("you are a Leo.");
                    }
                    else if(Date >= 23)
                    {
                        Console.WriteLine("you are a Virgo.");
                    }
                    break;
                case 9:
                    if(Date <= 22)
                    {
                        Console.WriteLine("you are a Virgo.");
                    }
                    else if(Date >= 23)
                    {
                        Console.WriteLine("you are a Libra.");
                    }
                    break;
                case 10:
                    if(Date <= 23)
                    {
                        Console.WriteLine("you are a Libra.");
                    }
                    else if (Date >= 24)
                    {
                        Console.WriteLine("you are a Scorpius.");
                    }
                    break;
                case 11:
                    if(Date <= 21)
                    {
                        Console.WriteLine("you are a Scorpius.");
                    }
                    else if (Date >= 22)
                    {
                        Console.WriteLine("you are a Sagittarius.");
                    }
                    break;
                case 12:
                    if (Date <= 21)
                    {
                        Console.WriteLine("you are a Sagittarius.");
                    }
                    else if (Date >= 22)
                    {
                        Console.WriteLine("you are a Capricornus.");
                    }
                    break;
                case 1:
                    if (Date <= 19)
                    {
                        Console.WriteLine("you are a Capricornus.");
                    }
                    else if (Date >= 20)
                    {
                        Console.WriteLine("you are a Aquarius.");
                    }
                    break;
                case 2:
                    if (Date <= 18)
                    {
                        Console.WriteLine("you are a Aquarius.");
                    }
                    else if (Date >= 19)
                    {
                        Console.WriteLine("you are a Pisces.");
                    }
                    break;
            }

            
          }
    }

        class Program
        {
            static void Main(string[] args)
            {
                var data = new Data();
                Console.WriteLine("What is your name?");
                data.name = TryAnswer();

                Console.WriteLine("What is your age?");
                data.age = int.Parse(TryAnswer());

                Console.WriteLine("What month were you born in?");
                data.month = int.Parse(TryAnswer());

                Console.WriteLine("What date were you born in?");
                data.date = int.Parse(TryAnswer());

                data.Display();


            }

            static string TryAnswer()
            {
                var question = Console.ReadLine();

            if (question == "")
                {
                    Console.WriteLine("You didn't type anything, please try again:");
                    return Console.ReadLine();
                }
                return question;
            }
        }
 }

