using System;

namespace ObserverPattern;

public class Article : ISubject
{  
    public List<IObserver> Observers { get; set; }

    public Article()
    {
        Observers = new List<IObserver>();
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in Observers)
        {
            observer.Update(message);
        }
    } 

    public void RegisterObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }
}
