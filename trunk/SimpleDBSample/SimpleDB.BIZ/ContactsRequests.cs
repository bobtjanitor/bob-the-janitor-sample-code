using System;
using SimpleDB.Objects;

namespace SimpleDB.BIZ
{
    public class ContactsRequests : IContactsRequests
    {
        private IContactData contactDataInterface;
        public IContactData ContactDataInterface
        {
            get
            {
                if (contactDataInterface==null)
                {
                    contactDataInterface = DataFactories.GetContactInterface();
                }
                return contactDataInterface;
            }
            set
            {
                contactDataInterface = value;
            }
        }


        public Contacts SearchContactsByName(string contactName)
        {
            Contacts myContacts = new Contacts();

            if (contactName.Length>0)
            {
                myContacts = ContactDataInterface.GetContactsByName(contactName);
            }

            return myContacts;
        }
        public Contacts GetContacts()
        {
            Contacts myContacts = ContactDataInterface.GetContacts();
            return myContacts;
        }

        public bool AddContact(Contact newContact)
        {
            return ContactDataInterface.SaveContact(newContact);
        }
    }
}
