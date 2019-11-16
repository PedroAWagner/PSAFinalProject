namespace IPRF.Models
{
    public class CalculationFactory
    {
        public static TaxCalculation instanceOf(TaxCalculationType type)
        {
            switch(type)
            {
                case TaxCalculationType.SIMPLE:
                    return new SimpleTaxCalculous();
                case TaxCalculationType.COMPLETE:
                    return new CompleteTaxCalculous();
            }
            return null;
        }
    }
}
