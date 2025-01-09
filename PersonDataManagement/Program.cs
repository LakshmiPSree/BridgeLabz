using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{   
    internal class Program
    {
        public class Person
        {
            public int SSN { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public int Age { get; set; }

            public Person(int ssn, string name, string address, int age)
            {
                this.SSN = ssn;
                this.Name = name;
                this.Address = address;
                this.Age = age;
            }
        }
        static void Main(string[] args)
        {   
            List<Person> list = new List<Person>();
            list.Add(new Person(1, "Rahul", "Mumbai", 45));
            list.Add(new Person(2, "Darshan", "Nerul", 78));
            list.Add(new Person(3, "Anita", "Vashi", 96));
            list.Add(new Person(4, "Prathamesh", "Panvel", 89));
            list.Add(new Person(5, "viji", "Mumbai", 13));
            list.Add(new Person(6, "vardhan", "Nerul", 38));
            list.Add(new Person(7, "Anagha", "Vashi", 15));
            list.Add(new Person(8, "Pratik", "Panvel", 19));
            list.Add(new Person(9, "Ramesh", " Navi Mumbai", 45));
            list.Add(new Person(10, "Deepak", "Nasik", 37));

            var top2 = list.Where(e => e.Age > 60).Take(2);
            Console.WriteLine("Retrieving top 2 records from the list whose age is less than 60");
            foreach (var person in top2) { 
                Console.WriteLine(person.Name);
            }

            var age13to18 = list.Where(e => e.Age >= 13 && e.Age <= 18);
            Console.WriteLine("Retrieving all records from the list whose age is between 13 and 18");
            foreach (var person in age13to18)
            {
                Console.WriteLine(person.Name);
            }

            var avg = list.Average(e => e.Age);
            Console.WriteLine($"Average of the ages present in the list is : {avg}");
        }
    }
}
