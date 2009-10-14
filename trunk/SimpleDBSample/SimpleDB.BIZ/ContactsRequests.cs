using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleDB.Objects;

namespace SimpleDB.BIZ
{
    public class ContactsRequests
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
            throw new NotSupportedException("this isn't done yet");
        }

        public bool AddContact(Contact newContact)
        {
            throw new NotImplementedException("this isn't done yet");
        }
    }
}
