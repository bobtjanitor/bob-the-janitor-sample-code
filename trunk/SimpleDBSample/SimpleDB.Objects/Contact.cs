using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SimpleDB.Objects
{
    public interface IContactData
    {
        Contacts GetContacts();
        Contacts GetContactsByName(string contactName);
        bool SaveContact(Contact contact);
    }

    public class Contact
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class Contacts : Collection<Contact>
    {

        public void AddRange(IEnumerable<Contact> myContacts)
        {
            foreach (Contact contact in myContacts)
            {
                Add(contact);
            }
        }
    }
}
