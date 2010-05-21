using SimpleDB.BIZ;

namespace SimpleDBSample
{
    public static class Factories
    {
        public static IContactsRequests GetContactRequests()
        {
            return new ContactsRequests();
        }
    }
}
