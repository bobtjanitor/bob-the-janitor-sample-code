using System.Net;
using System.Web.Mvc;
using cyclingLog.Biz;
using cyclingLog.Models;

namespace cyclingLog.Controllers
{
    public class LoginController : Controller
    {
        private IAuthentication _authenticationInterface;
        IAuthentication AuthenticationInterface
        {
            get
            {
                if(_authenticationInterface==null)
                {
                    _authenticationInterface = Factories.AuthenticationFactory.GetAuthentication();
                }
                return _authenticationInterface;
            }
            set { _authenticationInterface = value; }
        }

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(WebRequestMethods.Http.Post)]
        public ActionResult Login(Credentials credentials)
        {
            AuthenticationInterface.Password = credentials.Password;
            AuthenticationInterface.Username = credentials.UserName;
            bool success = AuthenticationInterface.Authenticate();
            ActionResult result;
            if (success)
            {
                result = RedirectToAction("Index","Profiles"); 
            }
            else
            {
                result = View("index", AuthenticationInterface.ValidationErrors);
            }

            return result;
        }
    }
}
