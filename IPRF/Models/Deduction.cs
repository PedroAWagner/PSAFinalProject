using System;
using System.Text;

namespace IPRF.Models
{
    public class Deduction
    {
        public int deductionID { get; set; }
        public TaxCalculationType type { get; set; }
        public double value { get; set; }

        public int declarationID { get; set; }
        public Declaration declaration { get; set; }
    }
}