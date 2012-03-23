using System.Web.Mvc;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    public class BasicDemoController : Controller
    {
        public ActionResult Index()
        {
            BasicDemoModel model = new BasicDemoModel();
            //model.City = "Boise";
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(BasicDemoModel model)
        {
            if (ModelState.IsValid)
            {
                model.Message = "It's All Good";
            }
            else
            {
                model.Message = "Something went wrong";
            }            
            return View(model);
        }
    }
}