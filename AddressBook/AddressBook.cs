using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AddressBook
    {
        Dictionary<int, Contact> list = new Dictionary<int, Contact>();
        public int id = 0;
        public void AddContact (Contact contact)
        {
            list.Add(id, contact);
            id++;
        }
        
        public void RemoveContact(int id)
        {
            try
            {
                list.Remove(0);
            }
            catch
            {
                Console.WriteLine("Contact id does not exist");
            }
        }
        public Contact GetContact(int id)
        {
            try
            {
                return list[id];
            }
            catch
            {
                Console.WriteLine("Contact id does not exist");
                return null;
            }
        }

        public void Print()
        {
            int i = 0;
            while (list.Count > i)
            {
                Console.WriteLine(GetContact(i).ToString());
                i++;
            } 
        }

    }
}
