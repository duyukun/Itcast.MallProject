using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itcast.Mall.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegsterStepOne()
        {
            return View();
        }

        public ActionResult RegsterStepTwo()
        {
            return View();
        }
    }
}