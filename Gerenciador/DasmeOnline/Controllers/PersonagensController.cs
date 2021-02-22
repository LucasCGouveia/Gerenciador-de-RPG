using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasmeOnline.Controllers
{
    public class PersonagensController : Controller
    {
        // GET: Personagens
        public ActionResult Index()
        {
            return View();
        }
    }
}