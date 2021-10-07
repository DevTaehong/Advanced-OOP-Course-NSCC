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
    }
}
