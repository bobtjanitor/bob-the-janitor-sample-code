using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleDB.DAL;
using SimpleDB.Objects;

namespace SimpleDB.DAL_Tests
{
    /// <summary>
    /// Summary description for ContactRequests_Tests
    /// </summary>
    [TestClass]
    public class ContactRequests_Tests
    {
        /// <summary>
        ///A test for AddContact
        ///</summary>
        [TestMethod()]
        public void SaveContact_WithValidContact_Test()
        {
            ContactRequests target = new ContactRequests();
            Contact contact = new Contact() { Email = "test@test.com", Name = "test User", Phone = "555-555-5555" };
            bool expected = true;
            bool actual = target.SaveContact(contact);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetContacts_Test()
        {
            ContactRequests target = new ContactRequests();
            Contacts testContacts = target.GetContacts();
            Assert.IsTrue(testContacts.Count>0);
        }

        [TestMethod()]
        public void SearchContactsByName_EmptyName_Test()
        {
            ContactRequests target = new ContactRequests();
            Contacts testContacts = target.GetContactsByName("");
            Assert.AreEqual(0,testContacts.Count);
        }

        [TestMethod()]
        public void SearchContactsByName_InvalidName_Test()
        {
            ContactRequests target = new ContactRequests();
            Contacts testContacts = target.GetContactsByName("something");
            Assert.AreEqual(0, testContacts.Count);
        }

        [TestMethod()]
        public void SearchContactsByName_ValidName_Test()
        {
            ContactRequests target = new ContactRequests();
            Contacts testContacts = target.GetContactsByName("test User");
            Assert.IsTrue(testContacts.Count>0);
        }
    }
} 
