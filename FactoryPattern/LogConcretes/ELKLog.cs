using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.LogConcretes
{
    public class ELKLog : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("ELK Log: " + message);    
        }
    }
}
