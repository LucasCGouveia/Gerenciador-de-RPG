using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasmeOnline.Controllers
{
    [AllowAnonymous]
    public class DasmeController : Controller
    {
        // GET: Dasme
        public ActionResult Index()
        {
            return View();
        }
    }
}