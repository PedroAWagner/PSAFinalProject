using System;
namespace IPRF.Models
{
    public class TaxCalculation
    {
        public interface TaxCalculous
        {
            double calculous(User user);
        }

        internal double calculous(User user)
        {
            throw new NotImplementedException();
        }
    }
}
