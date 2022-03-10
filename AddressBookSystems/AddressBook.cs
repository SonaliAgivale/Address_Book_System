using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystems
{
    internal class AddressBook
    {
        private List<Contact> contactList;
        public AddressBook()
        {
            contactList = new List<Contact>();
        }
        // UC1 - Create Contacts in address book
        public void CreateContact()
        {
            int count = 1;
            contactList.Add(new Contact());
            count++;
        }
        public void ViewContact()
        {
            foreach (Contact contact in contactList)
                contact.Display();
        }
        //UC2-Add contact to contact list
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zipcode, long phoneNumber, string email)
        {
            Contact personDetails = new Contact(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
            contactList.Add(personDetails);
        }

        // UC3 - Edit Contact Details
        public void EditContact()
        {
            for (int i = 0; i < contactList.Count; i++)
            {
                Console.WriteLine("\n Choose What you want to edit " +
                    "\n 1. First Name \n 2 Last Name \n 3. Address \n 4. City \n 5. State \n 6. ZipCode \n 7. Phone Number \n 8. Email-ID");
                int edit = Convert.ToInt32(Console.ReadLine());
                switch (edit)
                {
                    case 1:
                        Console.WriteLine("Enter New First Name: ");
                        contactList[i].First_Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter New Last Name: ");
                        contactList[i].Last_Name = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter New Address: ");
                        contactList[i].Address = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter New City: ");
                        contactList[i].City = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Enter New State: ");
                        contactList[i].State = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter New ZipCode: ");
                        contactList[i].Zip_Code = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Enter New Phone Number: ");
                        contactList[i].Phone_No = Convert.ToInt64(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Enter New Email-ID: ");
                        contactList[i].Email = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
        //UC4 Delete Contact From Contact List
        public void DeleteContact()
        {
            for (int i = 0; i < contactList.Count; i++)
            {
                Console.WriteLine("Enter the Name to delete: ", contactList[i].First_Name, contactList[i].Last_Name);
                contactList[i].First_Name = Console.ReadLine();
                Console.WriteLine("Contact Deleted Successfully from Address Book.");
                contactList.RemoveAt(i);

            }
        }
    }
}
