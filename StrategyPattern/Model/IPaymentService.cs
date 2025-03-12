using System;

namespace StrategyPattern.Model;

public interface IPaymentService
{
    void Pay(decimal amount); 
}
