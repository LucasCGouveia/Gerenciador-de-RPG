using Gerenciador.Business;
using Gerenciador.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasmeOnline.Controllers
{
    public class JogadoresController : Cookie
    {
        private readonly UsuarioBusiness usuarioBusiness;
        private readonly JogadoresBusiness jogadoresBusiness;
        private readonly PersonagensBusiness personagensBusiness;
        private readonly RacasBusiness racasBusiness;
        private readonly ClassesBusiness classesBusiness;


        public JogadoresController()
        {
            usuarioBusiness = new UsuarioBusiness();
            jogadoresBusiness = new JogadoresBusiness();
            personagensBusiness = new PersonagensBusiness();
            racasBusiness = new RacasBusiness();
            classesBusiness = new ClassesBusiness();
        }
        public ActionResult Index()
        {
            string Cod = base.RecuperarValorCookie("IdUsuario");

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
        public ActionResult JogadoresNovo()
        {
            string Cod = base.RecuperarValorCookie("IdUsuario");

            TabUsuarios tabUsuarios = usuarioBusiness.Listar(Convert.ToInt32(Cod));
            ViewBag.TabUsuarios = tabUsuarios;

            List<TabPersonagens> listaTabPersonagens = personagensBusiness.ListarPersonagensJogador(Convert.ToInt32(Cod));
            ViewBag.TabPersonagens = listaTabPersonagens;

            return View();
        }
        [HttpGet]
        public ActionResult JogadorEditar()
        {
            string Cod = base.RecuperarValorCookie("IdUsuario");

            TabUsuarios tabUsuarios = usuarioBusiness.Listar(Convert.ToInt32(Cod));
            ViewBag.TabUsuarios = tabUsuarios;

            TabJogadores tabJogadores = jogadoresBusiness.ListarJogadorPorCodUsuario(Convert.ToInt32(Cod));
            ViewBag.TabJogadores = tabJogadores;

            if (tabJogadores == null)
            {
                TabJogadores tabJogadoresvazio = new TabJogadores();
                ViewBag.TabJogadores = tabJogadoresvazio;
                ViewBag.Message = "Voce ainda não concluiu seu cadastro favor preencher os campos a baixo";
            }

            return View();
        }
        [HttpPost]
        public ActionResult JogadorEditar(TabJogadores tabJogadores)
        {
            if (tabJogadores.COD == 0)
            {
                tabJogadores.DATAINCLUSAO = DateTime.Now;
                jogadoresBusiness.Adicionar(tabJogadores);
            }
            else
            {
                jogadoresBusiness.Editar(tabJogadores);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult JogadorExcluir()
        {
            string Cod = base.RecuperarValorCookie("COD");

            TabUsuarios tabUsuarios = usuarioBusiness.Listar(Convert.ToInt32(Cod));
            ViewBag.TabUsuarios = tabUsuarios;

            TabJogadores tabJogadores = jogadoresBusiness.ListarJogadorPorCodUsuario(Convert.ToInt32(Cod));
            ViewBag.TabJogadores = tabJogadores;

            if (tabJogadores == null)
            {
                TabJogadores tabJogadoresVAZIO = new TabJogadores();
                ViewBag.TabJogadores = tabJogadoresVAZIO;

                List<TabPersonagens> listaTabPersonagensVAZIO = new List<TabPersonagens>();
                ViewBag.listaTabPersonagens = listaTabPersonagensVAZIO;
            }
            else
            {
                List<TabPersonagens> listaTabPersonagens = personagensBusiness.ListarPersonagensJogador(tabJogadores.COD);
                ViewBag.listaTabPersonagens = listaTabPersonagens;
            }

            return View();
        }
        [HttpPost]
        public ActionResult JogadorExcluir(TabJogadores tabJogadores)
        {
            string Cod = base.RecuperarValorCookie("IdUsuario");

            jogadoresBusiness.Excluir(tabJogadores.COD);
            usuarioBusiness.Excluir(Convert.ToInt32(Cod));

            return RedirectToAction("LogOut", "Login");
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
            //int COD_USUARIO = base.RecuperarValorCookie("IdUsuario");

            //TabUsuarios tabUsuarios = usuarioBusiness.Listar(COD_USUARIO);
            //ViewBag.TabUsuarios = tabUsuarios;

            personagensBusiness.Adicionar(tabPersonagens);
            

            return RedirectToAction("Index");
        }
    }
}