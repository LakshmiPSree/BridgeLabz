using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class User
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression(@"^[a-zA-z\d._]+@gmail\.com", ErrorMessage = "Please enter a valid Gmail address (e.g., username@gmail.com).")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Phone Number Required")]
        [RegularExpression(@"^\([\d]{3}\)\s[\d]{3}-[\d]{4}$|^[\d]{3}-[\d]{3}-[\d]{4}$" , ErrorMessage = "Please enter a valid Phone number (eg. (XXX) XXX-XXXX or XXX-XXX-XXXX )")]
        public string PhoneNumber {  get; set; }

        [Required(ErrorMessage ="Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[\d])(?=.*[!@#$%^&*])[a-zA-Z\d!@#$%^&*]{8,13}$",ErrorMessage ="Enter Valid Password")]
        public string PassWord {  get; set; }

        [Required(ErrorMessage ="Date is must")]
        //[RegularExpression(@"^(0[1-9]|1[0-2])/(0[1-9]|[12][1-9]|3[01])/\d{4}$")]   This is just the format of date without validaing the leap year.
      

        [RegularExpression(@"^(?:(?:02/(?:29/(?:\d{2}(?:0[48]|[2468][048]|[13579][26])|(?:[02468][048]|[13579][26])00))|02/(?:0[1-9]|1[0-9]|2[0-8])/\d{4})|(?:0[13-9]|1[0-2])/(?:0[1-9]|[12][0-9]|3[01])/\d{4}|(?:04|06|09|11)/(?:0[1-9]|[12][0-9]|30)/\d{4})$")]
        public string Date {  get; set; }

        [RegularExpression(@"(?:\d{4}[\s-]?){3}\d{4}",ErrorMessage = "The number should be 16 digits long, grouped into four groups of four digits separated by spaces or dashes")]
        public string CreditCardNumber {  get; set; }

        
    }
}
