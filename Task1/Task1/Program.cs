using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using System.Configuration;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            if (ConfigurationManager.AppSettings["usingResourcesFile"] == "true")
            {
                if (!GetParamsFromFile(out a, out b))
                {
                    Console.WriteLine("The parameters/parameter are not numbers. You should change the data in the file.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadLine();
                    return;
                }
            }
            else
            {
                a = GetParamsFromConsole(out b);
            }
            if (ConfigurationManager.AppSettings["usingLib"] == "true")
            {
                GetResultsUsingLib(a, b);
            }
            else
            {
                GetResultsWithoutUsingLib(a, b);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        public static bool GetParamsFromFile(out int a, out int b)
        {
            bool isNumber = false;
            a = 0;
            b = 0;
            isNumber = Int32.TryParse(Data.FirstNumber, out a);
            if (!isNumber)
            {
                return false;
            }
            isNumber = Int32.TryParse(Data.SecondNumber, out b);
            return isNumber;
        }

        public static int GetParamsFromConsole(out int b)
        {
            int a;
            bool isNumber;
            Console.WriteLine("Enter two numbers for calculation:");
            do
            {
                Console.Write("Enter the first number:");
                isNumber = Int32.TryParse(Console.ReadLine(), out a);
                if (!isNumber)
                    Console.WriteLine("The parameter must be a number.");
            } while (!isNumber);
            do
            {
                Console.Write("Enter the second number:");
                isNumber = Int32.TryParse(Console.ReadLine(), out b);
                if (!isNumber)
                    Console.WriteLine("The parameter must be a number.");
            } while (!isNumber);
            return a;
        }

        public static void GetResultsUsingLib(int a, int b)
        {
            long sum, sub, mult;
            double div;
            Calculator c = new Calculator();
            sum = c.Sum(a, b);
            sub = c.Subtract(a, b);
            mult = c.Multiply(a, b);
            div = c.Div(a, b);
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Result of addition = {sum}");
            Console.WriteLine($"Result of subtraction = {sub}");
            Console.WriteLine($"Result of multiplication = {mult}");
            if (double.IsInfinity(div))
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            else
            {
                Console.WriteLine($"Result of division = {div}");
            }
        }

        public static void GetResultsWithoutUsingLib(int a, int b)
        {
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Sum = {Sum(a,b)}");
        }

        public static long Sum(int a, int b)
        {
            return (long)a + (long)b;
        }
    }
}
