using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayPalService.services
{
    class PaypalService : IOnlinePaymentService
    {
        private const  double FeePercentage = 0.02;
        private const double MonthInterest = 0.01;
        public double PaymentFee(double amount){
            return amount * FeePercentage;
        }
        public double Interest(double amount, int months){
            return amount * MonthInterest * months;
        }
    }
}