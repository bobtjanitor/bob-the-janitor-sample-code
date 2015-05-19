using System.Web.Mvc;
using SampleApplication.Models;

namespace SampleApplication.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UpdatePartial()
        {
            var model = new PartialModel {Text = "was updated"};
            return View("Partial", model);
        }

    }
}
