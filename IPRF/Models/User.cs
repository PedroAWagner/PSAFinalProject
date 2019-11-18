using System;
using System.Text;

namespace IPRF.Models
{
    public class User
    {
        private String name { get; set; }
        private String cpf { get; set; }
        private int age { get; set; }
        private int numberDep { get; set; }
        private double prev { get; set; }
        private double totalIncome { get; set; }
        private SimpleTaxCalculous tax { get; set; }
        public int userID { get; set; }
        public int age { get; set; }
        public Declaration declaration { get; set; }

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
    }
}
