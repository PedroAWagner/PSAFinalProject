using System;
using System.Text;

namespace IPRF.Models
{
    public class User
    {
        private String name;
        private String cpf;
        private int age;
        private int numberDep;
        private double prev;
        private double totalIncome;
        private SimpleTaxCalculous tax;

        public string getName()
        {
            return this.name;
        }

        public void setName(string value)
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

        public int getAge()
        {
            return age;
        }

        public void setAge(int value)
        {
            age = value;
        }

        public int getNumberOfDependents()
        {
            return numberDep;
        }

        public void setNumberOfDependents(int value)
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

        public double getTotalIncome()
        {
            return totalIncome;
        }

        public void setTotalIncome(double value)
        {
            totalIncome = value;
        }

        public double getTax()
        {
            return tax.calculous(this);
        }


        public void setOwedTax(SimpleTaxCalculous value)
        {
            tax = value;
        }

        public User(String name, String cpf, int age,
                        int numberOfDependents, double contrPrev, double totalIncome)
        {
            this.prev = contrPrev;
            this.cpf = cpf;
            this.age = age;
            this.name = name;
            this.numberDep = numberOfDependents;
            this.totalIncome = totalIncome;
            this.tax = new SimpleTaxCalculous();
        }

        public void defineCalculous(SimpleTaxCalculous calc)
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
            sb.Append(age);
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
