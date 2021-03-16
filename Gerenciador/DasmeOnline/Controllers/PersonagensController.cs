using Gerenciador.Business;
using Gerenciador.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasmeOnline.Controllers
{
    public class PersonagensController : Cookie
    {
        private readonly UsuarioBusiness usuarioBusiness;
        private readonly JogadoresBusiness jogadoresBusiness;
        private readonly PersonagensBusiness personagensBusiness;
        private readonly RacasBusiness racasBusiness;
        private readonly ClassesBusiness classesBusiness;

        public PersonagensController()
        {
            usuarioBusiness = new UsuarioBusiness();
            jogadoresBusiness = new JogadoresBusiness();
            personagensBusiness = new PersonagensBusiness();
            racasBusiness = new RacasBusiness();
            classesBusiness = new ClassesBusiness();
        }
        [HttpGet]
        public ActionResult PersonagemMestre()
        {
            string Cod = base.RecuperarValorCookie("COD");

            TabUsuarios tabUsuarios = usuarioBusiness.Listar(Convert.ToInt32(Cod));
            ViewBag.TabUsuarios = tabUsuarios;

            TabJogadores tabJogadores = jogadoresBusiness.ListarJogadorPorCodUsuario(Convert.ToInt32(Cod));
            ViewBag.TabJogadores = tabJogadores;

            if (tabJogadores == null)
            {
                TabJogadores tabJogadoresvazio = new TabJogadores();
                ViewBag.TabJogadores = tabJogadoresvazio;

                List<TabPersonagens> listaTabPersonagens = personagensBusiness.ListarPersonagensJogador(tabJogadoresvazio.COD);
                ViewBag.TabPersonagens = listaTabPersonagens;

                ViewBag.Message = "Para Criar personagem por favor va em configurações e conclua o cadastro";
            }
            else
            {
                List<TabPersonagens> listaTabPersonagens = personagensBusiness.ListarPersonagensJogador(tabJogadores.COD);
                ViewBag.TabPersonagens = listaTabPersonagens;
            }
            return View();
        }
        [HttpGet]
        public ActionResult PersonagemNovo(int Cod)
        {
            ViewBag.TabRacas = racasBusiness.GetAll();
            ViewBag.TabClasses = classesBusiness.GetAll();
            string COD_USUARIO = base.RecuperarValorCookie("COD");

            TabUsuarios tabUsuarios = usuarioBusiness.Listar(Convert.ToInt32(COD_USUARIO));
            ViewBag.TabUsuarios = tabUsuarios;

            ViewBag.COD_JOGADOR = Cod;

            return View();
        }
        [HttpPost]
        public ActionResult PersonagemNovo(TabPersonagens tabPersonagens)
        {
            tabPersonagens.DATAINCLUSAO = DateTime.Now;
            personagensBusiness.Adicionar(tabPersonagens);

            string TIPOUSER = base.RecuperarValorCookie("TIPOUSER");
            if (TIPOUSER == "M")
                return RedirectToAction("PersonagemMestre", "Personagens");
            else
                return RedirectToAction("Index", "Jogadores");
        }
        [HttpGet]
        public ActionResult PersonagemAdicionar(int cod)
        {
            string Campanha = base.RecuperarValorCookie("CAMPANHA");
            TabPersonagens tabPersonagens = personagensBusiness.Listar(cod);
            tabPersonagens.COD_CAMPANHA = Convert.ToInt32(Campanha);

            personagensBusiness.Editar(tabPersonagens);

            return RedirectToAction("CampanhaGerenciar/" + Campanha,"Campanhas");
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

            string TIPOUSER = base.RecuperarValorCookie("TIPOUSER");
            if (tabPersonagens.COD_CAMPANHA != 0)
            {
                if (TIPOUSER == "M")
                    return RedirectToAction("CampanhaGerenciar/" + tabPersonagens.COD_CAMPANHA, "Campanhas");
                else
                    return RedirectToAction("Index", "Jogadores");
            }
            else
            {
                if (TIPOUSER == "M")
                    return RedirectToAction("PersonagemMestre", "Personagens");
                else
                    return RedirectToAction("Index", "Jogadores");
            }
        }
    [HttpGet]
    public ActionResult PersonagemExcluir(int cod)
    {
        TabPersonagens tabPersonagens = personagensBusiness.Listar(cod);

        ViewBag.TabPersonagens = tabPersonagens;
        return View();
    }

    [HttpPost]
    public ActionResult PersonagemExcluir(TabPersonagens tabPersonagens)
    {
        personagensBusiness.Excluir(tabPersonagens.COD);

        string TIPOUSER = base.RecuperarValorCookie("TIPOUSER");
        if (TIPOUSER == "M")
            return RedirectToAction("PersonagemMestre", "Personagens");
        else
            return RedirectToAction("Index", "Jogadores");
    }
}
}