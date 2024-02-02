using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //2 number input
            double num1, num2;
            double result;

            Console.WriteLine("------------------");
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("------------------");


            Console.Write("Enter First Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operation: ");
            Console.Write("\t+ : Add");
            Console.Write("\t- : Subtract");
            Console.Write("\t* : Multiply");
            Console.Write("\t/ : Divide");
            Console.Write("\t/ :");


            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Sum: {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Difference: {num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Product: {num1} * {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Quotient: {num1} / {num2} = " + result);
                    break;
                default:
                    Console.WriteLine("Please Choose correct operation.");
                    break;
            }


            Console.ReadKey(); 

        }
    }
}
