using System;

namespace AdapterPattern.Models;

public class Priz
{
    public void ElektrikVer(IElektrikliEvAletleri elektrikliEvAleti)
    {
        int prizeTakVeCalistir = elektrikliEvAleti.PrizeTakVeCalistir();
        Console.WriteLine($"Prize takıldı ve çalıştı. Çekilen güç: {prizeTakVeCalistir}");
    }

}
