using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleDB.Objects;

namespace SimpleDB.BIZ
{
    public class ContactsRequests
    {
        public Contacts SearchContactsByName(string contactName)
        {
            Contacts myContact = new Contacts();

            if (contactName.Length>0)
            {
                
            }

            return myContact;
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
