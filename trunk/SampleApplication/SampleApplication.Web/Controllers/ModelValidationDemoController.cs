using System.Web.Mvc;
using SampleApplication.Models;
using SampleApplication.Web.Models;

namespace SampleApplication.Web.Controllers
{
    public class ModelValidationDemoController : Controller
    {
        //
        // GET: /ModelValidationDemo/

        public ActionResult Index()
        {
            var model = new ValidationDemoModel();
            return View(model);
        }


        public ActionResult Submit(ValidationDemoModel model)
        {
            return View("index", model);
        }
    }
}
