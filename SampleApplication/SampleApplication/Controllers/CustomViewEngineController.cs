﻿using System.Web.Mvc;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    public class CustomViewEngineController : Controller
    {
        public ActionResult TransformedView()
        {
            var model = new BasicDemoModel{Name = "Demo User"};
            return View(model);
        }

    }
}
