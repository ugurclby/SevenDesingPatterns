using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.LogConcretes
{
    public class LogFactory
    {
        public ILogger GetLogger(string loggerType)
        {
            
            return loggerType switch
            {
                "ELK" => new ELKLog(),
                "File" => new FileLog(),
                "DB" => new DBLog(),
                _ => throw new ArgumentException(nameof(loggerType)),
            }; 
        }
    }
}
