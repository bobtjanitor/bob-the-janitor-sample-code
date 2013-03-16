using System.Web.Mvc;

namespace SampleApplication.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
