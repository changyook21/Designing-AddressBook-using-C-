using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Address 
    {
        private string homeAddr;
        private string workAddr;

        public Address(string homeAddr)
        {
            this.HomeAddr = homeAddr;
        }
        public string HomeAddr {
            get
            {
                return this.homeAddr;
            }
            set
            {
                try
                {
                    if (value.Length != 0)
                    {
                        this.homeAddr = value;
                    }
                }
                catch
                {
                    Console.WriteLine("Insert proper Home Address");
                }
            }
        }

        public string WorkAddr
        {
            get
            {
                return this.workAddr;
            }
            set
            {
                try
                {
                    if (value.Length != 0)
                    {
                        this.workAddr = value;
                    }
                }
                catch
                {
                    Console.WriteLine("Insert proper Work Address");
                }
            }
        }

    }
}
