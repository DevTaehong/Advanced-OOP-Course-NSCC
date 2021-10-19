using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            if(hourlyWage <= 0)
            {
                throw new InvalidOperationException("Hourly wage must not be less than zero.");
            }

            return hourlyWage * HoursInYear;
        }
            

        public decimal GetHourlyWage(int annualSalary)
        {
            if (annualSalary <= 0)
            {
                throw new InvalidOperationException("Yearly salary must be greater than zero.");
            }
            return annualSalary / HoursInYear;
        }
        
        public EmpData EmpAccount (double weeklySalary, int numDependents)
        {
            EmpData objectOne = new EmpData();
            objectOne.TaxAmount = 0.25 * weeklySalary;
            objectOne.DependentDeduction = 0.05 * weeklySalary * numDependents;
            objectOne.NetTaxAmount = objectOne.TaxAmount - objectOne.DependentDeduction;
            objectOne.TotalTakeHome = weeklySalary - objectOne.NetTaxAmount;
            return objectOne;
        }



    }
}
