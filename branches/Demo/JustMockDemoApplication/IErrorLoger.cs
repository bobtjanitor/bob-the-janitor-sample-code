using System.Web;

namespace JustMockDemoApplication
{
    public interface IErrorLoger
    {
        HttpContext Context { get; set; }
        void LogError();
    }
}