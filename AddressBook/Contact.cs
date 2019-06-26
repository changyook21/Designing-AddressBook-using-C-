using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Contact : AddressBook
    {
       
        private Name name;
        private PhoneNumber phone;
        private Address address;
        private Email email;
        public Contact (Name name, PhoneNumber phone, Address address, Email email)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.email = email;
        }
        
        public override string ToString()
        {
            return ("Contact is: " + this.name.FirstName + this.name.LastName + " Phone number: " + this.phone.HomePhoneNumber +
                             " Address: " + this.address.HomeAddr + " Email: " + this.email.EmailAddr);
         
        }
        
     
        

        

    }
}
