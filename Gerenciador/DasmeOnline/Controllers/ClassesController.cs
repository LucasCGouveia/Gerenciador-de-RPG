using Gerenciador.Business;
using Gerenciador.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasmeOnline.Controllers
{
    public class ClassesController : Cookie
    {
        private readonly ClassesBusiness classesBusiness;
        public ClassesController()
        {
            classesBusiness = new ClassesBusiness();
            ViewBag.LOGIN = base.RecuperarValorCookie("COD");
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<TabClasses> listaTabClasses = classesBusiness.GetAll();
            ViewBag.TabClasses = listaTabClasses;

            return View();
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(TabClasses tabClasses)
        {
            classesBusiness.Adicionar(tabClasses);
            return RedirectToAction("Index");
        }
        public ActionResult Update(int Cod)
        {
            TabClasses tabClasses = classesBusiness.Listar(Cod);
            ViewBag.TabClasses = tabClasses;

            return View();
        }
        [HttpPost]
        public ActionResult Update(TabClasses tabClasses)
        {
            classesBusiness.Editar(tabClasses);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Cod)
        {
            TabClasses tabClasses = classesBusiness.Listar(Cod);
            ViewBag.TabClasses = tabClasses;

            return View();
        }
        [HttpPost]
        public ActionResult Delete(TabRacas tabRacas)
        {
            classesBusiness.Excluir(tabRacas.COD);
            return RedirectToAction("Index");
        }
    }
}