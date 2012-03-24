using System.Web.Mvc;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    public class AjaxDemoController : Controller
    {

        public ActionResult Simple()
        {
            return View();
        }

        public JsonResult JsonRequest(int clickCount)
        {
            clickCount++;
            var model = new SimpleJsonModel{Count = clickCount, Message = "Clicked "+clickCount+" Times"};
            return Json(model);
        }

        public ActionResult ViewRequest()
        {
            var model = new PartialModel{Text = " Text from the action"};
            return PartialView("Partial", model);
        }

        [HttpGet]
        public ActionResult Form()
        {
            var model = new BasicDemoModel();

            return View(model);
        }

        [HttpPost]
        //[OutputCache(Duration = 10, VaryByParam = "none")]
        public ActionResult Form(BasicDemoModel model)
        {
            if (ModelState.IsValid)
            {
                model.Message = "It's All Good";
            }
            else
            {
                model.Message = "Something went wrong";
            }
            return PartialView("PartialForm",model);
        }
    }
}
