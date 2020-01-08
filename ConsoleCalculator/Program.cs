using System;
using System.Collections.Generic;
using System.Linq;
using CalculatorLogic;
using System.Resources;
using System.Threading;
using System.Globalization;
using System.Text;

namespace ConsoleCalculator
{
    public enum languages
    {
        Arabic = 1,
        Engilsh = 2
    }
    class Program
    {


        static void Main()
        {

            List<string> operationList = new List<string>() { "sum", "subtract", "multiply", "divide" };
            var consoleValuesArr = Enum.GetNames(typeof(ConsoleColor));
            var consoleValuesStr = string.Join(", ", consoleValuesArr).ToLower();

            #region Language
        Language:
            Console.Write("Type the Language \n" +
                "1 for Arabic \n" +
                "2 for English \n");

            if (int.TryParse(Console.ReadLine(), out int y))
            {
                CultureInfo cultureInfo = new CultureInfo("en");
                if (y == (int)languages.Arabic)
                    cultureInfo = new CultureInfo("ar");

                Thread.CurrentThread.CurrentCulture = cultureInfo;
                Thread.CurrentThread.CurrentUICulture = cultureInfo;
                CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
                CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            }
            else
                goto Language;

            #endregion
            #region Color
            Color:
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("مرحبا بك");

            Console.WriteLine(Properties.Resource.PickAColor + " \n");
            Console.Write($"9 = {Properties.Resource.Blue}\n12 = {Properties.Resource.Red}\n");            
            var colorcodestr = Console.ReadLine().ToLower().Trim();
            if (int.TryParse(colorcodestr, out int colorCode)) {                
                if (colorCode == (int)ConsoleColor.Red || colorCode == (int)ConsoleColor.Blue)
                {
                    Console.ForegroundColor = (ConsoleColor)colorCode;
                }
                else
                    goto Color;
            }
               else
                    goto Color;
            #endregion

            Start:
            Console.Write($"{Properties.Resource.TypeOfOperation} \n" +
                $" 1 = {Properties.Resource.SumOperation} \n" +
                $" 2 = {Properties.Resource.SubtractOperation} \n" +
                $" 3 = {Properties.Resource.MultiplyOperation} \n" +
                $" 4 = {Properties.Resource.DivideOperation}\n");

            var result = Console.ReadLine().Trim().ToLower();
            if (int.TryParse(result,out int operationNumber))
            {
                if (operationNumber >= 1 && operationNumber <= 4)
                {

                    
                    FirstOperand:
                        Console.Write($"{Properties.Resource.FirstOperand}\n");
                        var n1 = Console.ReadLine().Trim();
                        if (!string.IsNullOrWhiteSpace(n1) && double.TryParse(n1, out double xn1))
                        {
                        SecondOperand:
                             Console.Write($"{Properties.Resource.SecondOperand}\n");
                        var n2 = Console.ReadLine().Trim();
                            if (!string.IsNullOrWhiteSpace(n2) && double.TryParse(n2, out double xn2))
                            {
                                var calculator = new Calculator();
                                if (operationNumber == 1)
                                {
                                    calculator.Sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
                                }
                                else
                                {
                                    if (operationNumber == 2)
                                    {
                                        calculator.Subtract(Convert.ToDouble(n1), Convert.ToDouble(n2));
                                    }
                                    else
                                    {
                                        if (operationNumber == 3)
                                        {
                                            calculator.Multiply(Convert.ToDouble(n1), Convert.ToDouble(n2));
                                        }
                                        else
                                        {
                                            if (operationNumber == 4)
                                            {

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
                    

                }else
                goto Start;
            }
            
            else
                goto Start;

            Console.ReadLine();
        }
    }
}
