using System;
using StrategyPattern.Model;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentService paymentService = new PaymentService(); 

paymentService.PayViaPaymentService(new CreditCardService());
paymentService.PayViaPaymentService(new CashService());
paymentService.PayViaPaymentService(new PayPalService());

            Console.WriteLine("Payments processed.");
        }
    }
}
 