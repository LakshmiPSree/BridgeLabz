using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class User
    {
        [Required(ErrorMessage ="name is required")]
        [StringLength(20,ErrorMessage ="Name can only be upto 20 characters")]
        public string Name {  get; set; }
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Invaid Email Address")]
        [RegularExpression(@"^[a-zA-z\d._]+@gmail/.com", ErrorMessage = "Please enter a valid Gmail address (e.g., username@gmail.com).")]
        public string Email {  get; set; }
        [Required(ErrorMessage = "password is required")]
        [StringLength(13,MinimumLength =6)]
        public string Password { get; set; }
        [Required(ErrorMessage ="date of birth is must")]

        public string DateOfBirth {  get; set; }
        [Range(18,100,ErrorMessage = "user must be at least 18 years old")]
        public string Age {  get; set; }
        
    }
}
