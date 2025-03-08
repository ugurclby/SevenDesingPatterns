using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public class ApiRequest
    {
        public string Url { get; set; }
        public HttpMethod Metod { get; set; }
        public Dictionary<string,string> Header { get; set; }
        public string Body { get; set; }
    }
}
