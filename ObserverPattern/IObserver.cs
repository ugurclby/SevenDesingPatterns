using System;

namespace ObserverPattern;

public interface IObserver
{
    void Update(string message); 
}
