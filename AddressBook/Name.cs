using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Name
    {
        private string firstName;
        private string lastName;
        public Name(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

       
        public string FirstName
        {
            get {
                return this.firstName; 
                }
            set
            {
                if (value.Length != 0)
                {
                    if (value[0] != ' ')
                    {
                        firstName = value;
                    }
                }
            }
        }
        
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length != 0)
                {
                    if (value[0] != ' ')
                    {
                        lastName = value;
                    }
                }
            }
        }
        
    }
}
