using Gerenciador.Business;
using Gerenciador.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasmeOnline.Controllers
{
    public class CampanhasController : Cookie
    {
        private readonly UsuarioBusiness usuarioBusiness;
        private readonly CampanhasBusiness campanhasBusiness;
        private readonly PersonagensBusiness personagensBusiness;

        public CampanhasController()
        {
            usuarioBusiness = new UsuarioBusiness();
            campanhasBusiness = new CampanhasBusiness();
            personagensBusiness = new PersonagensBusiness();
        }
        public ActionResult Index()
        {
            string cod = base.RecuperarValorCookie("COD");
            ViewBag.LOGIN = base.RecuperarValorCookie("LOGIN");

            TabUsuarios tabUsuarios = usuarioBusiness.Listar(Convert.ToInt32(cod));
            ViewBag.TabUsuarios = tabUsuarios;
            List<TabCampanhas> listaCampanhas = campanhasBusiness.ListarCampanhasMestre(Convert.ToInt32(cod));
            ViewBag.TabCampanhas = listaCampanhas;

            return View();
        }
        //======================================================================================================================================================
        //======================================================================================================================================================
        //======================================================================================================================================================
        //======================================================================================================================================================
        //======================================================================================================================================================
        [HttpGet]
        public ActionResult CampanhaNova()
        {
            string cod = base.RecuperarValorCookie("COD");

            ViewBag.Cod_Mestre = cod;
            return View();
        }
        [HttpPost]
        public ActionResult CampanhaNova(TabCampanhas tabCampanhas)
        {
            campanhasBusiness.Adicionar(tabCampanhas);
            return View();
        }
        [HttpGet]
        public ActionResult CampanhaEditar(int cod)
        {
            TabCampanhas tabCampanhas = campanhasBusiness.Listar(cod);

            ViewBag.TabCampanhas = tabCampanhas;
            return View();
        }
        [HttpPost]
        public ActionResult CampanhaEditar(TabCampanhas tabCampanhas)
        {
            campanhasBusiness.Editar(tabCampanhas);
            return RedirectToAction("Index");
        }
        public ActionResult CampanhaExcluir(int cod)
        {
            TabCampanhas tabCampanhas = campanhasBusiness.Listar(cod);

            ViewBag.TabCampanhas = tabCampanhas;
            return View();
        }
        [HttpPost]
        public ActionResult CampanhaExcluir(TabCampanhas tabCampanhas)
        {
            campanhasBusiness.Excluir(tabCampanhas.COD);
            return RedirectToAction("Index");
        }
        public ActionResult CampanhaGerenciar(int cod)
        {
            TabCampanhas tabCampanhas = campanhasBusiness.Listar(cod);
            ViewBag.TabCampanhas = tabCampanhas;

            List<TabPersonagens> listaTabPersonagens = personagensBusiness.ListarPersonagensCampanha(tabCampanhas.COD);
            ViewBag.listaTabPersonagens = listaTabPersonagens;

            return View();
        }
        //[HttpPost]
        //public ActionResult CampanhaGerenciar(TabCampanhas tabCampanhas)
        //{
        //    campanhasBusiness.Excluir(tabCampanhas.Cod);
        //    return RedirectToAction("Index");
        //}
        //======================================================================================================================================================
        //======================================================================================================================================================
        //======================================================================================================================================================
        //======================================================================================================================================================
        //======================================================================================================================================================
        [HttpGet]
        public ActionResult PersonagemAdicionar(int cod)
        {
            string Campanha = base.RecuperarValorCookie("Campanha");
            TabPersonagens tabPersonagens = personagensBusiness.Listar(cod);
            tabPersonagens.COD_CAMPANHA = Convert.ToInt32(Campanha);

            personagensBusiness.Editar(tabPersonagens);

            return RedirectToAction("CampanhaGerenciar/" + Campanha);
        }
        [HttpGet]
        public ActionResult PersonagemRemover(int cod)
        {
            string Campanha = base.RecuperarValorCookie("Campanha");
            TabPersonagens tabPersonagens = personagensBusiness.Listar(cod);
            tabPersonagens.COD_CAMPANHA = 0;

            personagensBusiness.Editar(tabPersonagens);

            return RedirectToAction("CampanhaGerenciar/" + Campanha);
        }
        [HttpGet]
        public ActionResult PersonagemBuscar(int cod)
        {
            base.SalvarCookie("CAMPANHA", Convert.ToString(cod));
            ViewBag.listaTabPersonagens = "";
            return View();
        }
        [HttpPost]
        public ActionResult PersonagemBuscar(TabPersonagens tabPersonagens)
        {
            List<TabPersonagens> listaTabPersonagens = personagensBusiness.BuscarPersonagensSemCampanha(tabPersonagens.NOME);

            ViewBag.COD_CAMPANHA = tabPersonagens.COD_CAMPANHA;

            ViewBag.listaTabPersonagens = listaTabPersonagens;
            return View();
        }
        [HttpGet]
        public ActionResult PersonagemEditar(int cod)
        {
            TabPersonagens tabPersonagens = personagensBusiness.Listar(cod);

            ViewBag.TabPersonagens = tabPersonagens;
            return View();
        }

        [HttpPost]
        public ActionResult PersonagemEditar(TabPersonagens tabPersonagens)
        {
            personagensBusiness.Editar(tabPersonagens);
            return RedirectToAction("CampanhaGerenciar/" + tabPersonagens.COD_CAMPANHA);
        }
        //======================================================================================================================================================
        //======================================================================================================================================================
        //======================================================================================================================================================
        //======================================================================================================================================================
        //======================================================================================================================================================
    }
}