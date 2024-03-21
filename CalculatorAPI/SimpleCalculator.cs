using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPI
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public IDiagnostics diagnostics;

        public SimpleCalculator() { }
        public SimpleCalculator(IDiagnostics _diagnostic)
        {
            diagnostics = _diagnostic;
        }
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        public int Subtract(int start, int amount)
        {
            return start - amount;
        }

        public int Multiply(int start, int amount)
        {
            return start * amount;
        }

        public int Divide(int  start, int amount)
        {
            if (amount == 0 && diagnostics != null)
            {
                diagnostics.logString("Error: Cannot divide by zero");
                return 0;
            }
            return start / amount;
        }
    }
}
