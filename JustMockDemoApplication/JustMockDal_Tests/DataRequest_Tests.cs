using System.Data.SqlClient;
using JustMockDal;
using System.Collections.Generic;
using NUnit.Framework;
using Telerik.JustMock;

namespace JustMockDal_Tests
{
    
    
    /// <summary>
    ///This is a test class for DataRequest_Tests and is intended
    ///to contain all DataRequest_Tests Unit Tests
    ///</summary>
    [TestFixture]
    public class DataRequest_Tests
    {
        private DataRequest target;
        private bool SqlConnectionOpened;

        [SetUp]
        public void Setup()
        {
            SqlConnectionOpened = false;
            target = new DataRequest();
            
            var mockSqlConnection = Mock.Create<SqlConnection>();
            Mock.Arrange(() => mockSqlConnection.Open()).DoNothing();
            target.Connection = mockSqlConnection;
        }

        /// <summary>
        ///A test for GetUserList
        ///</summary>
        [Test]
        public void GetUserList_Test()
        {           
            List<string> actual = target.GetUserList();
            Assert.AreEqual(true, SqlConnectionOpened);
        }
    }
}
