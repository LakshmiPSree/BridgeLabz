using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LambdaAndLinq
{
    internal class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Department { get; set; }
        }
        public class Product
        {
            public Double price { get; set; }
            public String name { get; set; }
            public Product(Double price, String name)
            {
                this.price = price;
                this.name = name;
            }
        }
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>
            {
                new Employee{Id=1,Name="Lakshmi",Age=25,Department="Computer"},
                new Employee{Id=2,Name="Raj",Age=40,Department="Ecs"},
                new Employee{Id=3,Name="Sakshi",Age=48,Department="Automobile"},
                new Employee{Id=4,Name="Ambruta",Age=26,Department="IT"},
                new Employee{Id=6,Name="Ayesha",Age=35,Department="Computer"},
                new Employee{Id=7,Name="Viji",Age=50,Department="Ecs"},
                new Employee{Id=8,Name="Soham",Age=34,Department="Computer"},
                new Employee{Id=9,Name="Pranita",Age=23,Department="IT"},
                new Employee{Id=10,Name="Pranshu", Age=39,Department="IT"}, 
                new Employee{Id=11,Name="Kiran",Age=21,Department="Literature"}
            };

            var result = list.Where(e => e.Age>30).OrderBy(o => o.Name);
            foreach (var e in result)
            {
                Console.WriteLine($"Employee name is:{e.Name} and age is {e.Age}");
            }


            //Solving other problems 
            //1.Write a program that counts the occurrences of a specific character in a list of strings using a lambda expression.
            Console.WriteLine("Enter any statement");
            string statement= Console.ReadLine();
            Console.WriteLine("Enter the character which you want to count in the above given statement");
            char character=char.Parse(Console.ReadLine());
            int count = statement.Count(e => e == character);
            Console.WriteLine($"The character {character} appears {count} times.");

            //2.Write a program that performs various aggregate operations (sum, average, minimum, maximum)
            //on a list of numbers using lambda expressions.
            int[] arr = new int[] { 6, 9, 12, 45, 2, 8, 6, 3, };

            Console.WriteLine("Calculating the sum of the numbers in the array { 6, 9, 12, 45, 2, 8, 6, 3, }");
            int sum=arr.Sum(x=>x);
            Console.WriteLine(sum);
            Console.WriteLine("Calculating the average of the same numbers");
            double avg = arr.Average(x=>x);
            Console.WriteLine(avg);
            Console.WriteLine("Calculating the Minimum of the numbers");
            int min=arr.Min(x=>x);
            Console.WriteLine(min);
            Console.WriteLine("Calculating the maximum of the numbers");
            int max= arr.Max(x=>x);
            Console.WriteLine(max);

            //3.Write a program that finds all words in a list that start with the letter 'A' using LINQ.
            Console.WriteLine("Names that start with A");
            var startwith = list.Where(word => word.Name.StartsWith("A")).Select(word => word.Name).ToList();
            foreach (var e in startwith) Console.WriteLine(e);
            //4.Write a program that finds the top 3 highest scores from a list of integers using LINQ.
            Console.WriteLine("Top 3 scores");
            var scores = list.OrderByDescending(word => word.Age).Select(word=>word.Age).Take(3);
            foreach (var e in scores) Console.WriteLine(e);
            //5.Write a program that groups a list of Person objects by their age using LINQ.
            var person = list.Where(e=>e.Age == 50).Select(word => word.Name);
            foreach (var e in person) Console.WriteLine(e);
            //6.Write a program that filters a list of Product objects to find those with a price greater than $100
            //and then sorts them by name using LINQ.Each Product object has Name and Price properties.
            List<Product> products = new List<Product>();
            products.Add(new Product(35.2, "Cone IceCream"));
            products.Add(new Product(1999, "Wide Jeans"));
            products.Add(new Product(112.5, "Vanilla Family Pack"));
            products.Add(new Product(95, "Coke"));
            products.Add(new Product(59, "Chicps"));
            products.Add(new Product(200, "Cheese"));
            products.Add(new Product(20, "Jam"));
            products.Add(new Product(599, "Top"));
            products.Add(new Product(10, "Chocolate"));

            var product = products.Where(e => e.price > 100).OrderBy(f => f.name);
            foreach (var e in product) Console.WriteLine(e.name);




        }
    }
}
