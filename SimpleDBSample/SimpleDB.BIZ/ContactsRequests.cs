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
            Contacts myContacts = new Contacts();

            if (contactName.Length>0)
            {
                for (int i = 0; i < 10; i++)
                {
                    Contact myContact = new Contact
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "Contact " + i,
                        Phone = "555-555-5555",
                        Email = string.Format("Test{0}.Test@test.com", i)
                    };
                    myContacts.Add(myContact);
                }
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
