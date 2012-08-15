using System.Web.Mvc;
using System.Xml.Serialization;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    public class CustomActionDemoController : Controller
    {
        public ActionResult Index()
        {
            var model = new BasicDemoModel();
            return new XmlResult(model);
        }
    }

    public class XmlResult : ActionResult
    {
        private readonly object _item;

        public XmlResult(object item)
        {
            _item = item;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (_item != null)
            {
                var xs = new XmlSerializer(_item.GetType());
                context.HttpContext.Response.ContentType = "text/xml";
                xs.Serialize(context.HttpContext.Response.Output, _item);
            }
        }
    }
}