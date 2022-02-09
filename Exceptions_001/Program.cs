using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Enter the first number");
            calculator.FirstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sign (+,-,*,/)");
            char sign = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            calculator.SecondNum = double.Parse(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    calculator.Sum();
                    break;
                case '-':
                    calculator.Sub();
                    break;
                case '*':
                    calculator.Mult();
                    break;
                case '/':
                    try
                    {
                        calculator.Div();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("incorrect sign!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
