using DasmeOnline;
using Gerenciador.Business;
using Gerenciador.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace DasmeOnline.Controllers
{
    [AllowAnonymous]
    public class LoginController : Cookie
    {
        private readonly UsuarioBusiness usuarioBusiness;
        private readonly JogadoresBusiness jogadoresBusiness;
        public LoginController()
        {
            usuarioBusiness = new UsuarioBusiness();
            jogadoresBusiness = new JogadoresBusiness();

        }
        public ActionResult Index(string returnUrl)
        {
            var login = new UsuarioBusiness
            {
                ReturnUrl = returnUrl
            };
            return View(login);
        }
        [HttpPost]
        public ActionResult Index(string usuario, string password)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabUsuarios login = new TabUsuarios()
                    {
                        LOGIN = usuario.ToUpper(),
                        SENHA = password.Encrypt(),
                    };
                    TabUsuarios tabUsuarios = usuarioBusiness.Login(login);
                    if (tabUsuarios != null)
                    {
                        base.SalvarCookie("IdUsuario", tabUsuarios.COD.ToString());
                        base.SalvarCookie("Login", tabUsuarios.LOGIN.ToString());
                        return Redirect(GetRedirectUrl(usuarioBusiness.ReturnUrl,tabUsuarios));
                    }
                    ViewBag.Message = "Usuario ou senha inválidos.";
                }
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Dasme");
        }
        private string GetRedirectUrl(string returnUrl,TabUsuarios tabUsuarios)
        {
            if ((string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl)) && tabUsuarios.TIPOUSER == "M")
            {
                return Url.Action("Index", "Mestres");
            }
            else if ((string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl)) && tabUsuarios.TIPOUSER == "J")
            {
                return Url.Action("Index", "Jogadores");
            }
            return returnUrl;
        }
        [HttpGet]
        public ActionResult UsuarioNovo()
        {

            return View();
        }
        [HttpPost]
        public ActionResult UsuarioNovo(TabUsuarios tabUsuarios)
        {
            //VERIFICAR SE JA NÃO EXISTE ESTE LOGIN
            TabUsuarios Validacao = usuarioBusiness.VerificarUsuario(tabUsuarios);
            if(Validacao != null)
            {
                ViewBag.Message = "Usuario já cadastrado.";
                return View();
            }

            tabUsuarios.SENHA = tabUsuarios.SENHA.Encrypt();
            if (tabUsuarios.TIPOUSER == "JOGADOR")
            {
                tabUsuarios.TIPOUSER = "J";
                usuarioBusiness.Adicionar(tabUsuarios);
                base.SalvarCookie("Login", tabUsuarios.LOGIN.ToString());
                return RedirectToAction("JogadorNovo");
            }

            tabUsuarios.TIPOUSER = "M";
            usuarioBusiness.Adicionar(tabUsuarios);
            return RedirectToAction("Index");
        }
        public ActionResult JogadorNovo()
        {
            string LOGIN = Convert.ToString(base.RecuperarStringCookie("Login"));
            TabUsuarios tabUsuarios = new TabUsuarios();
            tabUsuarios.LOGIN = LOGIN;
            tabUsuarios = usuarioBusiness.VerificarUsuario(tabUsuarios);

            ViewBag.TabUsuarios = tabUsuarios;
            return View();
        }
        [HttpPost]
        public ActionResult JogadorNovo(TabJogadores tabJogadores)
        {
            tabJogadores.QTDPERSONAGENS = 0;
            tabJogadores.DATAINCLUSAO = DateTime.Now;

            jogadoresBusiness.Adicionar(tabJogadores);

            return RedirectToAction("LogOut");
        }
    }
}