using System;
using StrategyPattern.Model;

namespace StrategyPattern;

public class PayPalService : IPaymentService
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} using PayPal");
    }
} 
