using System;
using System.Linq;
using CalculatorLogic;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {

            //read all types of operation
            Console.Write("Type the operation you want to execute (sum, subtract, multiply, divide): ... ");
            var result = Console.ReadLine();
            //read the first operation to excute
            Console.Write("Please type the first operand: ");
            var n1 = Console.ReadLine();
            //read the second operation to excute
            Console.Write("Now, Please type the second operand: ");
            var n2 = Console.ReadLine();

            var calculator = new Calculator();



            if (result == "sum")
            {
                calculator.color = ConsoleColor.Red;
                calculator.Sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
            }
            else
            {
                if (result == "subtract")
                {
                    calculator.color = ConsoleColor.Red;
                    calculator.Subtract(Convert.ToDouble(n1), Convert.ToDouble(n2));
                }
                else
                {
                    if (result == "multiply")
                    {
                        calculator.color = ConsoleColor.Red;
                        calculator.Multiply(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    }
                    else
                    {
                        if (result == "divide")
                        {
                            calculator.color = ConsoleColor.Red;
                            calculator.Divide(Convert.ToDouble(n1), Convert.ToDouble(n2));
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
