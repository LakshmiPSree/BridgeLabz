using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                new Employee{Id=9,Name="Pranita",Age=23,Department="IT"}
            };

            var result = list.Where(e => e.Age>30).OrderBy(o => o.Name).Select(v => new {v.Name,v.Age});
            foreach (var e in result)
            {
                Console.WriteLine($"Employee name is:{e.Name} and age is {e.Age}");
            }
        }
    }
}
