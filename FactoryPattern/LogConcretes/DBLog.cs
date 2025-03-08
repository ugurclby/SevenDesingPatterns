using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.LogConcretes
{
    public class DBLog : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("DB Log: " + message);    
        }
    }
}
