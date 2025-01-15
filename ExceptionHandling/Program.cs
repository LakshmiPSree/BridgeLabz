using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find the Square root");
            double value =Double.Parse(Console.ReadLine());
            CalculateSquareRoot(value);    
        }

        public static void CalculateSquareRoot(double squareRoot)
        {
            try
            {
                if (squareRoot < 0)
                {
                    throw new NegativeValueException("Square root is not defined for negative numbers in real numbers");
                }
                double result = Math.Sqrt(squareRoot);
                Console.WriteLine($"The square root of the number {squareRoot} is {result}");
            }
            catch (NegativeValueException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
