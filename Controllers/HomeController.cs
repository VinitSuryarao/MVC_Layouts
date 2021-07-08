using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("Client")]
        public ActionResult GetClient()
        {
            return View();
        }

        [Route("Exchange")]
        public ActionResult GetExchange()
        {
            return View("GetExchange", "_LayoutHeaderFooter");
        }
    }
}