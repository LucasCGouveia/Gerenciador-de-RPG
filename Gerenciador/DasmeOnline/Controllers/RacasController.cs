using Gerenciador.Business;
using Gerenciador.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasmeOnline.Controllers
{
    public class RacasController : Cookie
    {
        private readonly RacasBusiness racasBusiness;
        public RacasController()
        {
            racasBusiness = new RacasBusiness();
            ViewBag.LOGIN = base.RecuperarValorCookie("LOGIN");
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<TabRacas> listaTabRacas = racasBusiness.GetAll();
            ViewBag.TabRacas = listaTabRacas;

            return View();
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(TabRacas tabRacas)
        {
            racasBusiness.Adicionar(tabRacas);
            return RedirectToAction("Index");
        }
        public ActionResult Update(int Cod)
        {
            TabRacas tabRacas = racasBusiness.Listar(Cod);
            ViewBag.TabRacas = tabRacas;

            return View();
        }
        [HttpPost]
        public ActionResult Update(TabRacas tabRacas)
        {
            racasBusiness.Editar(tabRacas);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Cod)
        {
            TabRacas tabRacas = racasBusiness.Listar(Cod);
            ViewBag.TabRacas = tabRacas;

            return View();
        }
        [HttpPost]
        public ActionResult Delete(TabRacas tabRacas)
        {
            racasBusiness.Excluir(tabRacas.COD);
            return RedirectToAction("Index");
        }
    }
}