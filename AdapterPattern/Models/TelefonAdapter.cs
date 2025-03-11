using System;

namespace AdapterPattern.Models;

public class TelefonAdapter : IElektrikliEvAletleri
{
    private Telefon _telefon;
    public TelefonAdapter(Telefon telefon)
    {
        _telefon = telefon;
    }
    public int PrizeTakVeCalistir()
    {
        Console.WriteLine("Telefon Adaptörü çalıştı.");
        return _telefon.PrizeTakVeCalistir();
    }
} 
