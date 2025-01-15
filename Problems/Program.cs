using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Create a User class with properties Username, Password, Email, and DateOfBirth. Use data annotations to ensure:
            //            Username is required and has a maximum length of 20 characters.
            //            Password is required and has a minimum length of 6 characters.
            //            Email is required and follows a valid email format.
            //            DateOfBirth is required and the user must be at least 18 years old."
            User user = new User();
            Console.WriteLine("Enter the UserName");
            user.Name = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            user.Email = Console.ReadLine();
            Console.WriteLine("Enter the password");
            user.Password = Console.ReadLine();
            Console.WriteLine("Enter the Date of birth");
            user.DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter your age");
            user.Age= Console.ReadLine();
            var content = new ValidationContext(user);
            var result = new List<ValidationResult>();
            bool isvaild = Validator.TryValidateObject(user, content, result, true);
            if (isvaild)
            {
                Console.WriteLine("Everything is vaild");
            }
            else
            {
                Console.WriteLine("Validator error are:");
                foreach (var err in result)
                {
                    Console.WriteLine(err.ErrorMessage);
                }
            }
            //"
            //            Create a Customer class with properties FirstName, LastName, PhoneNumber, and Email.Use data annotations to ensure:
            //            FirstName and LastName are required and have a maximum length of 50 characters each.
            //            PhoneNumber is required and follows a valid phone number format.
            //            Email is required and follows a valid email format.
            Customer customer = new Customer();
            Console.WriteLine("Enter the FirstName");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the lastname");
            customer.LastName= Console.ReadLine();
            Console.WriteLine("Enter the PhoneNumber");
            customer.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            customer.Email = Console.ReadLine();
            
            var contentInCustomer = new ValidationContext(customer);
            var resultInCustomer = new List<ValidationResult>();
            bool isvaildInCustomer = Validator.TryValidateObject(customer,contentInCustomer,resultInCustomer,true);
            if (isvaildInCustomer)
            {
                Console.WriteLine("Everything is vaild");
            }
            else
            {
                Console.WriteLine("Validator error are:");
                foreach (var err in result)
                {
                    Console.WriteLine(err.ErrorMessage);
                }
            }
        }
    }
}
