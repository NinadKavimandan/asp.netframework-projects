using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polly.CircuitBreaker;

namespace ClassLibrary1
{
    public class Class1
    {
        public string NameReturner()
        {
            CircuitState tmp = new CircuitState();
            Console.WriteLine(tmp.ToString());
            return "Name";
        }
    }
}
