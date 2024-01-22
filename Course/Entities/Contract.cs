using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double  TotalValue { get; set; }

        public List<Installment> List { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddContract(Installment installment)
        {
            List.Add(installment);
        }

        public void RemoverContract(Installment installment)
        {
            List.Remove(installment);
        }
    }
}
