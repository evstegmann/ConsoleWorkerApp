using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    class PayPalService : IPaymentService
    {
        public double Tax(double value, int quantity)
        {
            double percentage1 = (value * 0.01) * quantity + value;
            double percentage2 = percentage1 + (percentage1 * 0.02);

            return percentage2;
        }
    }
}
