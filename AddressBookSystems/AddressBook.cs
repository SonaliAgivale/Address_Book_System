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
            contactList.Add(new Contact());
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
    }
}
