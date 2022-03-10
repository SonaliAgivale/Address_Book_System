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
        public void AddContact()
        {
            contactList.Add(new Contact());
        }
        public void ViewContact()
            {
                foreach (Contact contact in contactList)
                    contact.Display();
            }
    }
}
