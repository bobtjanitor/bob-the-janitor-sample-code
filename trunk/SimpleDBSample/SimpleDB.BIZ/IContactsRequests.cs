using SimpleDB.Objects;

namespace SimpleDB.BIZ
{
    public interface IContactsRequests
    {
        Contacts SearchContactsByName(string contactName);
        Contacts GetContacts();
        bool AddContact(Contact newContact);
    }
}