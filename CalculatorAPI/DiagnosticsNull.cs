using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPI
{
    public class DiagnosticsNull : IDiagnostics
    {
        public void logString(string message) {}
    }
}
