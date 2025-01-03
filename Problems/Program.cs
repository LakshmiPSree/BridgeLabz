using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Write a C# program that takes a student's score as input and classifies it into grades (A, B, C, D, or F) based on the following criteria:

            //A: 90 - 100
            //B: 80 - 89
            //C: 70 - 79
            //D: 60 - 69
            //F: 0 - 59"
            Console.WriteLine("Enter the student score so that we can provide the grade for the marks");
            int marks =int.Parse(Console.ReadLine());
            if (marks <=100 && marks >= 90)
            {
                Console.WriteLine("You grade is :A");
            }else if (marks <= 89 && marks >= 80)
            {
                Console.WriteLine("You grade is :B");
            } else if (marks <= 79 && marks >= 70)
            {
                Console.WriteLine("You grade is :C");
            }else if (marks <= 69 && marks >= 60)
            {
                Console.WriteLine("You grade is :D");
            }
            else
            {
                Console.WriteLine("You grade is :F");
            }
            //Develop a C# program that converts temperatures between Fahrenheit and Celsius based on user input. Use conditional statements to determine the conversion formula based on the user's choice.
            Console.WriteLine("Enter the temperature :");
            float temp = float.Parse(Console.ReadLine());
            Console.WriteLine("Temperature is entered in celsius or fahrenheit");
            string degree = Console.ReadLine();
            if(degree == "celsius")
            {
                float fahrenheit = 0;
                fahrenheit=((temp *9)/5)+32;
                Console.WriteLine($"The temperature in fahrenheit is:{fahrenheit}");
            }else if(degree == "fahrenheit")
            {   
                float celsius = 0;
                celsius = ((temp - 32) * 5) / 9;
                Console.WriteLine($"The temperature in celsius is :{celsius}");
            }
            else
            {
                Console.WriteLine($"Enter the valid temperature degree");
            }
            //Write a C# program that calculates the price of a movie ticket based on the age of the customer and the time of the movie.
           
            }
        }
    }
}
