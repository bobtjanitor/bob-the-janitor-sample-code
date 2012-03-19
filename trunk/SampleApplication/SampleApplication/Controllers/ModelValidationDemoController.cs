using System.Web.Mvc;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    public class ModelValidationDemoController : Controller
    {
        //
        // GET: /ModelValidationDemo/

        public ActionResult Index()
        {
            ValidationDemoModel model = new ValidationDemoModel();
            return View(model);
        }


        public ActionResult Submit(ValidationDemoModel model)
        {
            return View("index", model);
        }
    }
}
