using System;
using StrategyPattern.Model;

namespace StrategyPattern;

public class CashService : IPaymentService
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} using Cash");
    }
} 
