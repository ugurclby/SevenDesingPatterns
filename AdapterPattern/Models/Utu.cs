using System;

namespace AdapterPattern.Models;

public class Utu : IElektrikliEvAletleri
{
    private int Watt = 220;
    public int PrizeTakVeCalistir()
    {
        Console.WriteLine("Ütü çalıştı.");
        return Watt;
    }
} 
