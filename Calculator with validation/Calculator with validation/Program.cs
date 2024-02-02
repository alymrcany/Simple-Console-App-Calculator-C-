using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_with_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator with validation\n\n");

            double num1, num2, result = 0;

            while (true)
            {
                Console.Write("Enter first number: ");
                string input1 = Console.ReadLine();

                Console.Write("Enter second number: ");
                string input2 = Console.ReadLine();
                

                if(double.TryParse(input1, out num1) && double.TryParse(input2, out num2))
                {

                    Console.Write("Choose Operation ( +, -, *, /, %) :");

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
                            Console.WriteLine($"Quotient: {num1} + {num2} = " + result);
                            break;

                        case "%":
                            result = num1 % num2;
                            Console.WriteLine($"Modulo: {num1} % {num2} = " + result);
                            break;

                        default:
                            Console.WriteLine("Invalid Operation.");
                            break;
                    }

                    break;

                }
                else
                {
                    Console.WriteLine("\nInput is not a number. Try again. \n");
                }
                 
            }

            

            

           
            

            Console.ReadKey();
        }
    }
}
