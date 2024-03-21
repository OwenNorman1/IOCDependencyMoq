using Autofac;
using CalculatorAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            String sign;
            int answer;
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<SimpleCalculator>().As<ISimpleCalculator>().SingleInstance();
            containerBuilder.RegisterType<DiagnosticsStored>().As<IDiagnostics>().SingleInstance();
            var container = containerBuilder.Build();
            var calc = container.Resolve<ISimpleCalculator>();
            while (true)
            {
                Console.WriteLine("--- Online Calculator ---");
                Console.WriteLine("Enter the first number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------");
                Console.WriteLine("Enter the second number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------");
                Console.WriteLine("Choose the sign (+, -, *, /)");
                sign = Console.ReadLine();
                Console.WriteLine("-------------------------");
                switch (sign)
                {
                    case ("+"):
                        answer = calc.Add(num1, num2);
                        break;
                    case ("-"):
                        answer = calc.Subtract(num1, num2);
                        break;
                    case ("*"):
                        answer = calc.Multiply(num1, num2);
                        break;
                    case ("/"):
                        answer = calc.Divide(num1, num2);
                        break;
                    default:
                        answer = 0;
                        Console.WriteLine("Please input a correct sign");
                        break;
                }
                Console.WriteLine("The answer is: " + answer);
            }
        }
    }
}
