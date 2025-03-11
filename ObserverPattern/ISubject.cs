using System;

namespace ObserverPattern;

public interface ISubject
{
    public List<IObserver> Observers { get; set; }
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers(string message); 
}
