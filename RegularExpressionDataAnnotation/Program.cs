using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionDataAnnotation
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            User user1 = new User();
            Console.WriteLine("User Input validation using Data Annotation");
            Console.WriteLine("Enter Name");
            user1.Name=Console.ReadLine();
            Console.WriteLine("Enter Email");
            user1.Email=Console.ReadLine();
            Console.WriteLine("Enter your Age");
            user1.Age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the password");
            user1.Password=Console.ReadLine();
            Console.WriteLine("Enter phone number");
            user1.PhoneNumber=Console.ReadLine();

            var context =new ValidationContext(user1);
            var error = new List<ValidationResult>();
            bool Isvalid = Validator.TryValidateObject(user1,context,error,true);
            bool isValidPassword = Regex.IsMatch(user1.Password, user1.PasswordRegex);
            Console.WriteLine($"user provided Password:{user1.Password} and is valid:{isValidPassword}");
            bool isValidMobileNo = Regex.IsMatch(user1.PhoneNumber, user1.PhoneNoRegex);
            Console.WriteLine($"user provided Mobile Number:{user1.PhoneNumber} and is valid:{isValidMobileNo}");

            if (Isvalid)
            {
                Console.WriteLine("It is valid");
            }
            else
            {
                Console.WriteLine("validation errors are :");
                foreach(var err in error)
                {
                    Console.WriteLine(err.ErrorMessage);
                }

            }

        }
    }
}
