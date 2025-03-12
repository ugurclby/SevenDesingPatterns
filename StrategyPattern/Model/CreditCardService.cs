using System;

namespace StrategyPattern.Model;

public class CreditCardService : IPaymentService
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} using Credit Card");
    }
} 
