using System;

namespace CalculatorLogic
{
    public class Calculator
    {
        public ConsoleColor color = ConsoleColor.White;

        public double Sum(double a, double b)
        {
            var x = a + b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

        public double Subtract(double a, double b)
        {
            var x = a - b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

        public double Multiply(double a, double b)
        {
            var x = a * b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

        public double Divide(double a, double b)
        {
            var x = a / b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }
    }
}
