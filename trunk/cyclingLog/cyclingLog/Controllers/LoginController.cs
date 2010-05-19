using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cyclingLog.Models;

namespace cyclingLog.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(WebRequestMethods.Http.Post)]
        public ActionResult Login(Credentials credentials)
        {

            throw new NotImplementedException();
        }
    }
}
