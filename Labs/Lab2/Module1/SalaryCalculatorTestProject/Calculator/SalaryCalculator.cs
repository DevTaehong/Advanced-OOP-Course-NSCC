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
            if (hourlyWage <= 0)
            {
                throw new InvalidOperationException("Hourly wage must be greater than zero.");
            }
           return hourlyWage* HoursInYear;
        }

        public decimal GetHourlyWage(int annualSalary)
        {
            if(annualSalary <= 0)
            {
                throw new InvalidOperationException("Yearly salary must be greater than zero.");
            }
          return  annualSalary / HoursInYear;
        }

        public TaxData TaxWithheld(double weeklySalary, int numDependents)
        {
            if(numDependents <= -1)
            {
                throw new InvalidOperationException("Number dependents cannot be negative.");
            }

            else if (weeklySalary == 0)
            {
                throw new InvalidOperationException("Weekly salary must be greater than zero.");
            }
            else
            {
                TaxData objectOne = new TaxData();
                objectOne.ProvincialTaxWithheld = 0.06 * weeklySalary;
                objectOne.FederalTaxWithheld = 0.25 * weeklySalary;
                objectOne.DependentDeduction = 0.02 * weeklySalary * numDependents;
                objectOne.TotalWithheld = objectOne.ProvincialTaxWithheld + objectOne.FederalTaxWithheld - objectOne.DependentDeduction;
                objectOne.TotalTakeHome = weeklySalary - objectOne.TotalWithheld;

                return objectOne;
            }
            
        }
    }
}
