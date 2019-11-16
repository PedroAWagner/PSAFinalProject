using System;
namespace IPRF.Models
{
    public class SimpleTaxCalculous : SimpleTaxCalculous
    {
        public double calculous(User u)
        {
            double calculousBase = u.getTotRend() - u.getContrPrev();
            double defaultDiscount = calculousBase * 0.5;
            calculousBase -= defaultDiscount;
            double finalTax;

            if (calculousBase <= 12000.0)
            {
                finalTax = 0;
            }
            else if ((calculousBase >= 12000.0) && (calculousBase < 24000.0)) {
                    finalTax = (calculousBase - 12000.0) * 0.15;
            }
            else
            {
                double tax1 = (23999.0 - 12000.0) * 0.15;
                double tax2 = (calculousBase - 23999.0) * 0.275;
                finalTax = tax1 + tax2;
            }
            return finalTax;
        }
    }
}
