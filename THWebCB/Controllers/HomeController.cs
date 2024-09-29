using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace THWebCB.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Bai2()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Bai2ab()
        {
            ViewBag.Message = "Gộp hàng và cột.";

            return View();
        }
        public ActionResult Bai3()
        {
            ViewBag.Message = "Xây dựng bảng.";

            return View();
        }
    }
}