using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Customer
    {   //            FirstName and LastName are required and have a maximum length of 50 characters each.
        //            PhoneNumber is required and follows a valid phone number format.
        //            Email is required and follows a valid email format.
        [Required(ErrorMessage ="FirstName is required")]
        [StringLength(50,ErrorMessage ="maximum 50 characters")]
        public string FirstName {  get; set; }
        [Required(ErrorMessage = "LasttName is required")]
        [StringLength(50, ErrorMessage = "maximum 50 characters")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Phone Number is Required")]
        [RegularExpression(@"^[\d]{10}$")]
        public string PhoneNumber {  get; set; }
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="invaid email address")]
        public string Email { get; set; }
    }
}
