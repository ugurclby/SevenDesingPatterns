using System;

namespace AdapterPattern.Models;

public class Telefon
{
    private int Watt = 5;
    public int PrizeTakVeCalistir()
    {
        Console.WriteLine("Telefon çalıştı.");
        return Watt;
    }
} 
