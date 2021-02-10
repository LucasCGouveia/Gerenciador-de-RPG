using DasmeOnline.Models;
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
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            List<TabUsuarios> lista = model.Read();

            foreach (TabUsuarios item in lista)
            {
                if (item.Login == model.Login && item.Senha == model.Senha)
                {
                    var identity = new ClaimsIdentity(new[]
                    {
                    new Claim(ClaimTypes.Name,item.Login),
                    },
                    "ApplicationCookie");

                    var ctx = Request.GetOwinContext();
                    var authManager = ctx.Authentication;

                    authManager.SignIn(identity);

                    return Redirect(GetRedirectUrl(model.ReturnUrl));
                }
                //TODO: lcaetano ADICIONADO APENAS PARA TESTE ---RETIRAR ASSIM QUE POSSIVEL
                else
                {
                    if (model.Login == "ADM" && model.Senha == "ADM")
                    {
                        var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name,"Administrador"),
                },
                    "ApplicationCookie");

                        var ctx = Request.GetOwinContext();
                        var authManager = ctx.Authentication;

                        authManager.SignIn(identity);

                        return Redirect(GetRedirectUrl(model.ReturnUrl));
                    }

                }
            }
            return View();
        }
        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Dasme");
        }
        private string GetRedirectUrl(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("Index", "Dasme");
            }
            return returnUrl;
        }

    }
}