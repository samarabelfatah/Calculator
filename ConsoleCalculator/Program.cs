using System;
using System.Collections.Generic;
using System.Linq;
using CalculatorLogic;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            var operationList = new List<string>() { "sum", "subtract", "multiply", "divide" };
        Start:
            Console.Write("Type the operation you want to execute (sum, subtract, multiply, divide): ... ");
            var result = Console.ReadLine().Trim().ToLower();
            if (string.IsNullOrWhiteSpace(result) && operationList.Contains(result))
            {
            FirstOperand:
                Console.Write("Please type the first operand: ");
                var n1 = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(n1) && double.TryParse(n1, out double xn1))
                {
                SecondOperand:
                    Console.Write("Now, Please type the second operand: ");
                    var n2 = Console.ReadLine().Trim();
                    if (string.IsNullOrWhiteSpace(n2) && double.TryParse(n2, out double xn2))
                    {
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
                                    else
                                    {

                                    }
                                }
                            }
                        }

                    }
                    else
                        goto SecondOperand;
                }
                else
                    goto FirstOperand;
            }
            else
                goto Start;

            Console.ReadLine();
        }
    }
}
