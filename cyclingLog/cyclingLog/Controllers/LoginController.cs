using System.Net;
using System.Web.Mvc;
using System.Web.Security;
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
            ViewData["AuthUserGuid"] = Request.ServerVariables.Get("AUTH_USER");
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
                FormsAuthentication.SetAuthCookie(AuthenticationInterface.AuthenticatedUserId.ToString(), false);

                result = RedirectToAction("Detail/" + AuthenticationInterface.AuthenticatedUserId, "Profiles"); 
            }
            else
            {
                result = View("index", AuthenticationInterface.ValidationErrors);
            }

            return result;
        }
    }
}
