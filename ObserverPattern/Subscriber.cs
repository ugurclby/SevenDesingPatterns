using System;

namespace ObserverPattern;

public class Subscriber : IObserver
{
    public string Name { get; set; }

    public Subscriber(string name)
    {
        Name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{Name} received the message: {message}");
    }
} 