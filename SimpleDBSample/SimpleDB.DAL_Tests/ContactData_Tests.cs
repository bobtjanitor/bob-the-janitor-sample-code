using NUnit.Framework;
using SimpleDB.DAL;
using SimpleDB.Objects;

namespace SimpleDB.DAL_Tests
{
    /// <summary>
    /// Summary description for ContactRequests_Tests
    /// </summary>
    [TestFixture]
    public class ContactData_Tests
    {
        /// <summary>
        ///A test for AddContact
        ///</summary>
        [Test()]
        public void SaveContact_WithValidContact_Test()
        {
            ContactData target = new ContactData();
            Contact contact = new Contact() { Email = "test@test.com", Name = "test User", Phone = "555-555-5555" };
            bool expected = true;
            bool actual = target.SaveContact(contact);
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void GetContacts_Test()
        {
            ContactData target = new ContactData();
            Contacts testContacts = target.GetContacts();
            Assert.IsTrue(testContacts.Count>0);
        }

        [Test()]
        public void SearchContactsByName_EmptyName_Test()
        {
            ContactData target = new ContactData();
            Contacts testContacts = target.GetContactsByName("");
            Assert.AreEqual(0,testContacts.Count);
        }

        [Test()]
        public void SearchContactsByName_InvalidName_Test()
        {
            ContactData target = new ContactData();
            Contacts testContacts = target.GetContactsByName("something");
            Assert.AreEqual(0, testContacts.Count);
        }

        [Test()]
        public void SearchContactsByName_ValidName_Test()
        {
            ContactData target = new ContactData();
            Contacts testContacts = target.GetContactsByName("test User");
            Assert.IsTrue(testContacts.Count>0);
        }

        
    }
} 
