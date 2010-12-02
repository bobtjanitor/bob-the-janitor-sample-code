using System.Net;
using System.Web.Mvc;
using ajaxMadeEasy.Models;

namespace ajaxMadeEasy.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UserModel userModel = new UserModel(){UserId = 1,Type = UserTypes.User};

            return View(userModel);
        }

        [AcceptVerbs(WebRequestMethods.Http.Post)]
        public ActionResult UpdateUserType(UpdateUser input)
        {
            var result = new {Succss = true, Message = "Updated"};
            return Json(result);
       }
    }
}
