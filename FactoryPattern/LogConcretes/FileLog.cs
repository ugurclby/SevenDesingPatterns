using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.LogConcretes
{
    public class FileLog : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("File Log: " + message);    
        }
    }
}
