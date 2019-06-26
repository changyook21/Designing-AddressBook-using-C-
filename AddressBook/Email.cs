using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Email 
    {

        private string emailAddr;

        public Email (string emailAddr)
        {
            this.EmailAddr = emailAddr;
        }
        public string EmailAddr {
            get
            {
                return this.emailAddr;
            }
            set
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(value);
                    if (addr.Address == value)
                    {
                        this.emailAddr = value;
                    }
                }
                catch
                {
                    Console.WriteLine("Insert proper email address");
                }
            }
        }
    }
}
