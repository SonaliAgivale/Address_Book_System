using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystems
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("-------------------------------");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("Sonali", "Agivale", "Kalyan", "Kalyan", "Maharashtra", 45678, 52345678, "sonali@gmail.com");
            addressBook.ViewContact();
            addressBook.DeleteContact();
            addressBook.ViewContact();
            Console.ReadLine();
        }
    }
}
