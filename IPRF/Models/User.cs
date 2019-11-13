using System;
using System.Text;

namespace IPRF.Models
{
    public class User
    {
        private String name;
        private String cpf;
        private int yearOfBirth;
        private int numberDep;
        private double prev;
        private double totalIncome;
        private TaxCalculation tax;

        public string getNome()
        {
            return this.name;
        }

        public void setNome(string value)
        {
            this.name = value;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(string value)
        {
            cpf = value;
        }

        public int getIdade()
        {
            return yearOfBirth;
        }

        public void setIdade(int value)
        {
            yearOfBirth = value;
        }

        public int getNroDep()
        {
            return numberDep;
        }

        public void setNroDep(int value)
        {
            numberDep = value;
        }

        public double getContrPrev()
        {
            return prev;
        }

        public void setContrPrev(double value)
        {
            prev = value;
        }

        public double getTotRend()
        {
            return totalIncome;
        }

        public void setTotRend(double value)
        {
            totalIncome = value;
        }

        public double getTax()
        {
            return tax.calculous(this);
        }


        public void setImpostoDevido(TaxCalculation value)
        {
            tax = value;
        }

        public User(String nome, String cpf, int idade,
                        int nroDep, double contrPrev, double totRend)
        {
            this.prev = contrPrev;
            this.cpf = cpf;
            this.yearOfBirth = idade;
            this.name = nome;
            this.numberDep = nroDep;
            this.totalIncome = totRend;
            this.tax = new CalculoIrpfSimplificado();
        }

        public void defineCalculo(TaxCalculation calc)
        {
            tax = calc;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            sb.Append(",");
            sb.Append(cpf);
            sb.Append(",");
            sb.Append(yearOfBirth);
            sb.Append(",");
            sb.Append(numberDep);
            sb.Append(",");
            sb.Append(prev);
            sb.Append(",");
            sb.Append(totalIncome);
            return (sb.ToString());
        }
    }
}
