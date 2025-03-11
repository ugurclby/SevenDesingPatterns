using System;

namespace AdapterPattern.Models;

public class Buzdolabı : IElektrikliEvAletleri
{
    private int Watt =220; 
    public int PrizeTakVeCalistir()
    {
        Console.WriteLine("Buzdolabı çalıştı.");
        return Watt;
    }
} 
