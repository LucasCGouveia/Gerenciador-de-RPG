using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasmeOnline.Controllers
{
    public class UsuariosController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}