using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class TaxData
    {
        public double ProvincialTaxWithheld { set; get; }
        public double FederalTaxWithheld { set; get; }
        public double DependentDeduction { set; get; }
        public double TotalWithheld { set; get; }
        public double TotalTakeHome { set; get; }

    }
}
