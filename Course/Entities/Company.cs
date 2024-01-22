using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Company : Payer
    {
        public int EmployeeNumber { get; set; }

        public Company(string name, double annualIncome, int employeeNumber) :base(name, annualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double TaxCalculation()
        {
            if ( EmployeeNumber > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
