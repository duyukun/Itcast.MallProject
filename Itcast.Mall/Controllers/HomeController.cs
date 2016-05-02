using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Itcast.Mall.BLL;
namespace Itcast.Mall.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var data = new CaptchaBusiness().GetList().ToList();
            return View();
        }
    }
}