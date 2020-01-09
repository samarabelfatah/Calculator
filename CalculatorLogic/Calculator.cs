using System;

namespace CalculatorLogic
{
    public class Calculator
    {


        public double Sum(double a, double b, string restext = "")
        {
            var x = a + b;
            Console.WriteLine($"{restext}: {x}");
            return x;
        }

        public double Subtract(double a, double b, string restext = "")
        {
            var x = a - b;
            Console.WriteLine($"{restext}: {x}");
            return x;
        }

        public double Multiply(double a, double b, string restext = "")
        {
            
                var x = a * b;
                Console.WriteLine($"{restext}: {x}");
                return x;
           

        }

        public double Divide(double a, double b, string restext = "")
        {
            double x = a / b;
            Console.WriteLine( !Double.IsInfinity(x) ? $"{restext}: {x}" : "");
            return x;
        }


    }
}
