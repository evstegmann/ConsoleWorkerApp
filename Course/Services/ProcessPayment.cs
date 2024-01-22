using System;
using System.Collections.Generic;
using System.Text;
using Course.Services;
using Course.Entities;
using System.Globalization;

namespace Course.Services
{
    class ProcessPayment
    {
        public int Quantity { get; set; }

        private IPaymentService _paymentService;

        public ProcessPayment(int quantity, IPaymentService paymentService)
        {
            Quantity = quantity;
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract)
        {
            double value = contract.TotalValue / Quantity;
            DateTime date = contract.Date;
            Installment installment = new Installment(contract.Date, value);

            for (int i = 1; i <= Quantity; i++)
            {   
                contract.AddContract(new Installment(date.AddMonths(i), (_paymentService.Tax(value, i))));
            }
            
            foreach (Installment i in contract.List)
            {
                Console.WriteLine(i.DueDate.ToString("dd/MM/yyyy") + " - " + i.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
