using System;
namespace IPRF.Models
{
    public class CompleteTaxCalculous: SimpleTaxCalculous
    {
        private static double calculous(User u)
        {
            double calculousBase = u.getTotalIncome() - u.getContrPrev();
            double dependentTaxDiscount = 0.0;
            if (u.getAge() < 65)
            {
                if ((u.getNumberOfDependents() > 0) && (u.getNumberOfDependents() <= 2))
                {
                    dependentTaxDiscount = 0.02;
                }
                else if ((u.getNumberOfDependents() > 2) && (u.getNumberOfDependents() <= 5))
                {
                    dependentTaxDiscount = 0.035;
                }
                else if (u.getNumberOfDependents() > 5)
                {
                    dependentTaxDiscount = 0.05;
                }
            }
            else
            {
                if ((u.getNumberOfDependents() > 0) && (u.getNumberOfDependents() <= 2))
                {
                    dependentTaxDiscount = 0.03;
                }
                else if ((u.getNumberOfDependents() > 2) && (u.getNumberOfDependents() <= 5))
                {
                    dependentTaxDiscount = 0.045;
                }
                else if (u.getNumberOfDependents() > 5)
                {
                    dependentTaxDiscount = 0.06;
                }
            }
            double dependentDiscount = calculousBase * dependentTaxDiscount;
            calculousBase = calculousBase - dependentDiscount;
            double finalTax;
            if (calculousBase <= 12000.0)
            {
                finalTax = 0;
            }
            else if ((calculousBase >= 12000.0) && (calculousBase < 24000.0))
            {
                finalTax = (calculousBase - 12000.0) * 0.15;
            }
            else
            {
                double tax1 = (23999.0 - 12000.0) * 0.15;
                double tax2 = (calculousBase - 23999.0) * 0.275;
                finalTax = tax1 + tax2;
            }
            return (finalTax);
        }
    }
}