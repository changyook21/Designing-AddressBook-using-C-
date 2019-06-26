using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook book = new AddressBook();
            while (true)
            {
                
                Console.WriteLine("Type 'add' to add a new contact");
                Console.WriteLine("Type 'delete' to add a contact");
                Console.WriteLine("Type 'delete' to add a contact");

                if (Console.ReadLine() == "add")
                {
                    Console.WriteLine("Enter First Name of person: ");
                    Console.WriteLine("Enter Last Name of person: ");
                    Name name = new Name(Console.ReadLine(), Console.ReadLine());
                    Console.WriteLine("Enter Phone number of person: ");

                    PhoneNumber phone = new PhoneNumber(Console.ReadLine());
                    Console.WriteLine("Enter Address of person: ");
                    Address address = new Address(Console.ReadLine());
                    Console.WriteLine("Enter Email of person: ");
                    Email email = new Email(Console.ReadLine());
                    Contact conct = new Contact(name, phone, address, email);
                    book.AddContact(conct);
                    
                }
            }

            
           

           
            Console.ReadLine();
        }
    }
}
