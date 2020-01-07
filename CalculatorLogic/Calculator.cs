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
        {if (a != 0 && b != 0)
            {
                var x = a * b;
                Console.ForegroundColor = color;
                Console.WriteLine($"The result is: {x}");
                return x;
            }
            else
            {
                Console.WriteLine($"The result is: 0");
                return 0;
            }
            
        }

        public double Divide(double a, double b)
        {
            double x = 0;
            if (b != 0)
            {
                if (a != 0)
                {

                    x = a / b;
                    Console.ForegroundColor = color;
                    Console.WriteLine($"The result is: {x}");

                }
                else
                    Console.WriteLine($"The result is: 0");
            }
            else
                Console.WriteLine($"You couln't devide by zero");

            return x;
        }

       
    }
}
