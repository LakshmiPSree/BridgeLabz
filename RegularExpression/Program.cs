using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Enter the Email");
            user.Email = Console.ReadLine();
            Console.WriteLine("Enter the phone Number");
            user.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the password");
            user.PassWord = Console.ReadLine();
            Console.WriteLine("Enter Date");
            user.Date = Console.ReadLine();
            //Match Credit Card Number
            // Write a regex pattern to validate a credit card number. The number should be 16 digits long, grouped into four groups of four digits separated by spaces or dashes.
            Console.WriteLine("Enter the credit Card Number");
            user.CreditCardNumber = Console.ReadLine();

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
        }
    }
}
