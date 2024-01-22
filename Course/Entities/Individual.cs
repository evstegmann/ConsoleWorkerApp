using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Individual : Payer
    {
        public double HealthSpent { get; set; }

        public Individual(string name, double annualIncome, double healthSpent) :base (name, annualIncome)
        {
            HealthSpent = healthSpent;
        }

        public override double TaxCalculation()
        {
            double tax = 0.0;
            if (AnnualIncome < 2000.00 && HealthSpent > 0)
            {
                tax =  (AnnualIncome * 0.15) - (HealthSpent * 0.50);
            }
            else
            {
                tax =  AnnualIncome - 0.15;
            }

            if(AnnualIncome > 2000.00 && HealthSpent > 0)
            {
                tax = (AnnualIncome * 0.25) - (HealthSpent * 0.50);
            }
            else
            {
                tax = AnnualIncome - 0.25;
            }

            return tax;

        }
    }
}
