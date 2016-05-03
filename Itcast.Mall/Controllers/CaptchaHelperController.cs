using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Itcast.Mall.Utility;
namespace Itcast.Mall.Controllers
{
    public class CaptchaHelperController : Controller
    {
        // GET: CaptchaHelper
        public void GetCaptch()
        {
            var captch = CaptchaHelper.DrawImage(CaptchaHelper.CreateRandomCode(4),20,background:System.Drawing.Color.White);
            Response.AddHeader("Content-Type", "img/jpeg");
            Response.BinaryWrite(captch);
            Response.End();
        }
    }
}