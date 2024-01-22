using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    abstract class Payer
    {
        public string Name { get;  set; }
        public double AnnualIncome { get; set; }


        public Payer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }



        abstract public double TaxCalculation();
        

    }
}
