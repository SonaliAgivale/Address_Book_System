using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystems
{
    internal class Contact
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public int Zip_Code;
        public long Phone_No;
        public string Email;

        public Contact(string First_Name, string Last_Name, string Address, string City, string State, int Zip_Code, long Phone_No, string Email)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip_Code = Zip_Code;
            this.Phone_No = Phone_No;
            this.Email = Email;
        }

        internal static void Add(Contact contactList)
        {
            throw new NotImplementedException();
        }

        public Contact()
        {
            GetContactInfo();
        }
        public void GetContactInfo()
        {
            int count=1;
            Console.Write("Enter First Name: ");
            First_Name = Console.ReadLine();
            Console.Write("Enter the Last Name: ");
            Last_Name = Console.ReadLine();
            Console.Write("Enter the Address: ");
            Address = Console.ReadLine();
            Console.Write("Enter the City: ");
            City = Console.ReadLine();
            Console.Write("Enter the State: ");
            State = Console.ReadLine();
            Console.Write("Enter the Zip_Code: ");
            Zip_Code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Phone_No: ");
            Phone_No = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Email: ");
            Email = Console.ReadLine();
            Console.WriteLine();
            count++;
        }
        
        public void Display()
        {
            Console.WriteLine("********* Contact List *********");
            Console.WriteLine("Full Name:" + First_Name + " " + Last_Name);
            Console.WriteLine("Address:" + Address);
            Console.WriteLine("city:" + City);
            Console.WriteLine("State:" + State);
            Console.WriteLine("Zip_Code:" + Zip_Code);
            Console.WriteLine("Phone_No:" + Phone_No);
            Console.WriteLine("Email:" + Email);
        }

    }
}
