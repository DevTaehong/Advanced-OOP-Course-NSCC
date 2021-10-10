using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public interface IWorker
    {
        string CalculateWeeklySalary(int weeklyHours, int wage);     
    }
}
