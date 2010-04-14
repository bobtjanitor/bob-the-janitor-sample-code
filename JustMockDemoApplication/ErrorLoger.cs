using System;
using System.Web;

namespace JustMockDemoApplication
{
    public class ErrorLoger : IErrorLoger
    {
        public HttpContext Context { get; set; }

        public ILogger LoggerInterface { get; set; }
        public void LogError()
        {
            LoggerInterface.Message = Context.Error.Message;
        }
    }

    public interface ILogger
    {
        string Message { get; set; }
    }
}