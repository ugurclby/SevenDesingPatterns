using System;
using StrategyPattern.Model;

namespace StrategyPattern;

public class PaymentService
{    
    public bool PayViaPaymentService (IPaymentService paymentService)
    { 
        
        switch (paymentService)
        {
            case CreditCardService _:
                paymentService.Pay(200);
                break;
            case CashService _:
                paymentService.Pay(300);
                break;
            case PayPalService _:
                paymentService.Pay(400);
                break;
            default:
                return false;
        }

        return true;
    }
}
