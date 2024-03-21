using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPI
{
    internal class Diagnostics : IDiagnostics
    {
        public void logString(string message)
        {
            Console.WriteLine($"Logging message: {message}");
        }
    }
}
