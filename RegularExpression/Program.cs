using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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
