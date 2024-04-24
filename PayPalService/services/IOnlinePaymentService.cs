using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayPalService.services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}