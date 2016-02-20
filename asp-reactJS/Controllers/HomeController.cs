using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_reactJS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult helloWorld()
        {
            return new JsonResult
            {
                Data = "Hello World. Reply from server side!",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}