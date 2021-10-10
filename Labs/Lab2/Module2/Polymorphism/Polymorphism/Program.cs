using Moq;
using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Employee : IWorker
    {
        public string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            string result = $"This ANGRY EMPLOYEE worked {weeklyHours} hrs. " +
                            $"Paid for 40 hrs at $ {wage}" +
                            $"/hr = ${salary}";
            Console.WriteLine("\n" + result + " \n");
            Console.WriteLine("---------------------------------------------\n");
            return result;
        }//end CalculateWeeklySalary
    }//end Employee

    public class Contractor : IWorker
    {
        public string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            string result = $"This HAPPY CONTRACTOR worked {weeklyHours} hrs. " +
                            $"Paid for {weeklyHours} hrs at $ {wage}" +
                            $"/hr = ${salary} ";
            Console.WriteLine("\n" + result + " \n");
            return result;
        }//end CalculateWeeklySalary
    }//end Contractor

    public class Program
    {
        private static void Main(string[] args)
        {
            const int hours = 55, wage = 70;
            //List<Employee> employees = Utils.GetEmployees();

            var mock = new Mock<Utils>();
            mock.Setup(m => m.GetIWorkers()).Returns(() =>
            new List<IWorker> { new Contractor(), new Employee() });

            List<IWorker> IWorkers = mock.Object.GetIWorkers();

            foreach (var e in IWorkers)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
        }        
    }

    public class Utils {
        //public static List<Employee> GetEmployees()
        //{
        //    var someEmployee = new Employee();
        //    var someContractor = new Contractor();
        //    var everyone = new List<Employee> { someEmployee, someContractor };
        //    return everyone;
        //}

       public virtual List<IWorker> GetIWorkers()
        {
            throw new NotImplementedException();
        }
    }
}
