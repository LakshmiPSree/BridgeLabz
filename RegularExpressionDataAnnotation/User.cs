using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegularExpressionDataAnnotation
{
    public class User
    {
        [Required(ErrorMessage = "Name has to be written")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter the name with alteast 3 characters and maximum 50 characters.")]
        [RegularExpression(@"[a-zA-Z]+$")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Invalid email")]
        public string Email { get; set; }
        [Range(18,60,ErrorMessage ="Age should be between 18 to 60")]
        public int Age {  get; set; }
        public string PasswordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[\d])(?=.*[!@#$%^&*])[a-zA-Z\d!@#$%^&*]{8,13}$";
        public string Password { get; set; }
        public string PhoneNoRegex = @"(^[\d]{10}$)|(^\+[\d]{2}\s[\d]{10}$)|(^[\d]{3}\s-\s[\d]{4}\s-\s[\d]{4}$)";
        public string PhoneNumber {  get; set; }

    }
}
