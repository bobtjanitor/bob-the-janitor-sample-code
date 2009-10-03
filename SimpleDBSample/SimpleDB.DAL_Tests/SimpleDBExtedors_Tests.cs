using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Attribute=Amazon.SimpleDB.Model.Attribute;
using SimpleDB.DAL;

namespace SimpleDB.DAL_Tests
{
    [TestFixture]
    public class SimpleDBExtedors_Tests
    {
        public List<Attribute> TestAttributeList { get; set; }
        [SetUp]
        public void Setup()
        {
            TestAttributeList = new List<Attribute>
            {
                new Attribute() {Name = "TestName", Value = "TestValue"}
            };
        }
        
        [Test]
        public void GetValueByName_WithNonMatchingName()
        {
            string result = TestAttributeList.GetValueByName("somethingWrong");
            Assert.AreEqual(string.Empty,result);
        }

        [Test]
        public void GetValueByName_WithMatchingName()
        {
            string result = TestAttributeList.GetValueByName("TestName");
            Assert.AreEqual("TestValue", result);
        }
    }
}
