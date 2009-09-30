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
        public void AddContact_WithValidContact_Test()
        {
            ContactRequests target = new ContactRequests();
            Contact contact = new Contact() { Email = "test@test.com", Name = "test User", Phone = "555-555-5555" };
            bool expected = true;
            bool actual = target.AddContact(contact);
            Assert.AreEqual(expected, actual);
        }
    }
}
