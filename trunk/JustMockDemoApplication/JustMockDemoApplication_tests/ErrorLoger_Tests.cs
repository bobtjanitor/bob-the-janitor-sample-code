using System;
using System.Web;
using JustMockDemoApplication;
using NUnit.Framework;
using Telerik.JustMock;

namespace JustMockDemoApplication_tests
{
    [TestFixture]
    public class ErrorLoger_Tests
    {
        ErrorLoger target;
        private const string TestError = "Test Error";
        public MockILogger MockLogger;

        [SetUp]
        public void Setup()
        {
            target = new ErrorLoger();
            HttpContext mockContext = Mock.Create<HttpContext>();
            Mock.Arrange(() => mockContext.Error).Returns(new Exception(TestError));
            target.Context = mockContext;
            MockLogger = new MockILogger();
            target.LoggerInterface = MockLogger;
        }
       
       [Test]    
        public void LogError_SetsLoggerMessageEqualToContextErrorMessage_Test()
        {
           target.LogError();

           Assert.AreEqual(TestError,MockLogger.Message);
        }
    }

    public class MockILogger: ILogger
    {
        public string Message
        {
            get; set;
        }
    }
}
