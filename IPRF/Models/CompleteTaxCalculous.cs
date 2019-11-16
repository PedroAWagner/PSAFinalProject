using System;
namespace IPRF.Models
{
    public class CompleteTaxCalculous: SimpleTaxCalculous
    {
        private static double calculous(User u)
        {
            double baseDeCalculo = u.getTotRend() - u.getContrPrev();
            double txDescDep = 0.0;
            if (u.getIdade() < 65)
            {
                if ((u.getNroDep() > 0) && (u.getNroDep() <= 2))
                {
                    txDescDep = 0.02;
                }
                else if ((u.getNroDep() > 2) && (u.getNroDep() <= 5))
                {
                    txDescDep = 0.035;
                }
                else if (u.getNroDep() > 5)
                {
                    txDescDep = 0.05;
                }
            }
            else
            {
                if ((u.getNroDep() > 0) && (u.getNroDep() <= 2))
                {
                    txDescDep = 0.03;
                }
                else if ((u.getNroDep() > 2) && (u.getNroDep() <= 5))
                {
                    txDescDep = 0.045;
                }
                else if (u.getNroDep() > 5)
                {
                    txDescDep = 0.06;
                }
            }
            double descDep = baseDeCalculo * txDescDep;
            baseDeCalculo = baseDeCalculo - descDep;
            double impPagar;
            if (baseDeCalculo <= 12000.0)
            {
                impPagar = 0;
            }
            else if ((baseDeCalculo >= 12000.0) && (baseDeCalculo < 24000.0))
            {
                impPagar = (baseDeCalculo - 12000.0) * 0.15;
            }
            else
            {
                double p1 = (23999.0 - 12000.0) * 0.15;
                double p2 = (baseDeCalculo - 23999.0) * 0.275;
                impPagar = p1 + p2;
            }
            return (impPagar);
        }
    }
}