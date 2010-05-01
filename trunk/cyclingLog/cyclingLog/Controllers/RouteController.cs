using System.Web.Mvc;
using cyclingLog.Models;

namespace cyclingLog.Controllers
{
    public class RouteController : Controller
    {

        public ActionResult Detail(int id)
        {
            RouteModel route = new RouteModel();
            return View(route);
        }

    }
}
