using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cONTACKbOOK
{
    internal class Program
    {  
        public class Contact
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public int postcode { get; set; }
            public string state { get; set; }

            public Contact(string firstName, string lastName, string email, string address, string city, string state, int postcode)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.email = email;
                this.address = address;
                this.city = city;
                this.state = state;
                this.postcode = postcode;
                
            }
        }
        public class AddressBook
        {
            List<Contact> contacts = new List<Contact>();
            //Add a new Contact.
            public void AddContact(Contact contact)
            {
                contacts.Add(contact);
                Console.WriteLine("Added Contact Successfully");
            }
            //Delete a contact.
            public void RemoveContact() {
                Console.WriteLine("Enter the first name you want to edit.");
                string FName = Console.ReadLine();
                Console.WriteLine("Enter the last name you want to edit.");
                string lName = Console.ReadLine();
                Contact aabc = null;
                foreach (Contact name in contacts)
                {
                    if (name.firstName == FName && name.lastName == lName)
                    {
                        aabc=name;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("There is No Same name present in the Address Book");
                    }
                }
                contacts.Remove(aabc);
            }

            //Edit a contact using the name element.
            public void EditContact() {

                Console.WriteLine("Enter the first name you want to edit.");
                string FName = Console.ReadLine();
                Console.WriteLine("Enter the last name you want to edit.");
                string lName = Console.ReadLine();
                foreach (Contact name in contacts)
                {
                    if (name.firstName == FName && name.lastName == lName)
                    {
                        Console.WriteLine("Enter the new FirstName");
                        string FirstName = Console.ReadLine();
                        Console.WriteLine("Enter the new LastName");
                        string LastName = Console.ReadLine();
                        name.firstName = FirstName;
                        name.lastName = LastName;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("There is No Same name present in the Address Book");
                    }
                }
                

            }
            //Display the contact.
            public void DisplayContact()
            {
                if (contacts.Count == 0)
                {
                    Console.WriteLine("There is no contact prsent in the address book");
                    return;
                }
                else {
                
                    foreach (var item in contacts)
                    {
                        Console.WriteLine($"Name is:{item.firstName} {item.lastName},Email is :{item.email},Address is:{item.address},City is :{item.city} ,State is:{item.state},PinCode is:{item.postcode}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            AddressBook book = new AddressBook();
            Console.WriteLine("Welcome to the Contact Address Book");
            while (true) { 
            Console.WriteLine("******************Menu******************");
            Console.WriteLine("1.Add one Contact");
            Console.WriteLine("2.Edit Contact");
            Console.WriteLine("3.Delete Contact");
            Console.WriteLine("4.Display all Contacts");
            Console.WriteLine("5.exit");
            Console.WriteLine("Enter the choice");
            int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Adding a contact");
                        Console.WriteLine("Enter the First Name:");
                        string FirstName = Console.ReadLine();
                        Console.WriteLine("Enter the Last Name:");
                        string LastName = Console.ReadLine();
                        Console.WriteLine("Enter the Email id:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter the address:");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter the city:");
                        string city = Console.ReadLine();
                        Console.WriteLine("Enter the state:");
                        string state = Console.ReadLine();
                        Console.WriteLine("Enter the Postcode");
                        int postcode = int.Parse(Console.ReadLine());
                        Contact contact = new Contact(FirstName, LastName, email, address, city, state, postcode);
                        book.AddContact(contact);
                        break;
                    case 2:
                        Console.WriteLine("Editing the contact");
                        book.EditContact();
                        break;
                    case 3:
                        Console.WriteLine("Deleting the contact");
                        book.RemoveContact();
                        break;
                    case 4:
                        Console.WriteLine("Displaying all the contacts.");
                        book.DisplayContact();
                        break;
                    case 5:
                        Console.WriteLine("Thankyou for using the Address Book");
                        return;
                    default:
                        Console.WriteLine("Enter the valid choice");
                        break;
                }
            }

        }
    }
}
