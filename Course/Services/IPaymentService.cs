using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    interface IPaymentService
    {
        double Tax(double value, int quantity);
    }
}
