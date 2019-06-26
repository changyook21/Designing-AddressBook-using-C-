using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PhoneNumber 
    {
        private string cellPhoneNumber;
        private string homePhoneNumber;
        public PhoneNumber(string phoneNumber)
        {
            this.HomePhoneNumber = phoneNumber;
        }
        public string CellPhoneNumber
        {
            get
            {
                return this.cellPhoneNumber;
            }
            set
            {
                if (value.All(char.IsDigit))
                {
                    this.cellPhoneNumber = value;
                }
            }
        }
        public string HomePhoneNumber
        {
            get
            {
                return this.homePhoneNumber;
            }
            set
            {
                if (value.All(char.IsDigit))
                {
                    this.homePhoneNumber = value;
                }
            }


        }
    }
}
