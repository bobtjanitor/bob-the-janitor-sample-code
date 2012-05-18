using System.Web.Mvc;
using NetAdvantageProofs.Data;
using NetAdvantageProofs.Mappers;

namespace NetAdvantageProofs.Controllers
{
    public class HomeController : Controller
    {
        private AdventureWorks _adventureWorks;
        public AdventureWorks AdventureWorks
        {
            get{ return _adventureWorks ?? (Factories.GetAdventureWorks());}
            set { _adventureWorks = value; }
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult DataSource()
        {
            var products = AdventureWorks.Products.AsProductModels();
            return Json(products);
        }

    }
}
