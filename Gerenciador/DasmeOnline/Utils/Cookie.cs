﻿using Gerenciador.Business;
using Gerenciador.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace DasmeOnline
{
    public class Cookie : Controller
    {
        private readonly UsuarioBusiness _usuarioApp;

        public Cookie()
        {
            this._usuarioApp = new UsuarioBusiness();
        }

        /// <summary>
        /// Método responsável por Salvar um cookie contendo o Id do Usuário no navegador.
        /// </summary>
        /// <param name="pNomeCookie">Nome do Cookie que será salvo no navegador.</param>
        /// <param name="pValorCookie">Valor do Cookie que será salvo no navegador.</param>
        /// <param name="DataExpiriacao">Data em que o cookie expirará. Após isto, é necessário efetuar o login novamente. (OPCIONAL).</param>
        protected virtual void SalvarCookie(string pNomeCookie,string nome, DateTime? DataExpiracao = null)
        {
            try
            {
                var identity = new ClaimsIdentity(new[]
                    {
                    //new Claim(ClaimTypes.Name,item.NomLogin),
                    new Claim(ClaimTypes.Name,Convert.ToString(nome)),
                    },
                    "ApplicationCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                pNomeCookie = pNomeCookie.Encrypt().Substring(0, 10);
                nome = nome.Encrypt();
                DataExpiracao = !DataExpiracao.HasValue ? DateTime.Now.AddMonths(30) : DataExpiracao.Value;
                var _httpCookie = new HttpCookie(pNomeCookie, Convert.ToString(nome));
                _httpCookie.Expires = DataExpiracao.Value;
                _httpCookie.Domain = Convert.ToString(ConfigurationManager.AppSettings["DOMAIN"]);
                Response.Cookies.Add(_httpCookie);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //protected virtual void SalvarCookie(string pNomeCookie, string pValorCookie, DateTime? DataExpiracao = null)
        //{
        //    try
        //    {
        //        pNomeCookie = pNomeCookie.Encrypt().Substring(0, 10);
        //        pValorCookie = pValorCookie.Encrypt();
        //        DataExpiracao = !DataExpiracao.HasValue ? DateTime.Now.AddMonths(30) : DataExpiracao.Value;
        //        var _httpCookie = new HttpCookie(pNomeCookie, pValorCookie);
        //        _httpCookie.Expires = DataExpiracao.Value;
        //        _httpCookie.Domain = Convert.ToString(ConfigurationManager.AppSettings["DOMAIN"]);
        //        Response.Cookies.Add(_httpCookie);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        /// <summary>
        /// Método responsável por finalizar uma sessão. Após isto, é necessário efetuar o login novamente.
        /// </summary>
        protected virtual void FinalizarSessao()
        {
            try
            {
                var _httpCookie = this.RecuperarCookie("IdUsuario");
                if (_httpCookie != null)
                {
                    _httpCookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(_httpCookie);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Método responsável por excluir um cookie.
        /// </summary>
        /// <param name="pNomeCookie">Nome do cookie que será excluído.</param>
        protected virtual void ExcluirCookie(string pNomeCookie)
        {
            try
            {
                var _httpCookie = this.RecuperarCookie(pNomeCookie);

                _httpCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(_httpCookie);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Método responsável por recuperar o objeto do usuário que está logado.
        /// Primeiramente a consulta do Id do usuário é baseada em cookies.
        /// Caso o cookie esteja nulo, a busca é baseada em Session.
        /// </summary>
        /// <returns>Retorna um objeto do tipo TabUsuarios.</returns>
        protected virtual TabUsuarios RecuperarUsuarioLogado()
        {
            try
            {
                var _httpCookie = this.RecuperarValorCookie("COD");
                
                    if (this._usuarioApp != null)
                    {
                        return this._usuarioApp.Listar(int.Parse(_httpCookie.ToString()));
                    }
                
                throw new Exception("Nenhum usuário logado. Efetue o login novamente.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Método responsável por recuperar um cookie.
        /// </summary>
        /// <param name="pNomeCookie">Nome do cookie a ser recuperado.</param>
        /// <returns>Objeto do tipo HttpCookie.</returns>
        //protected int RecuperarValorCookie(string pNomeCookie)
        //{
        //    try
        //    {
        //        pNomeCookie = pNomeCookie.Encrypt().Substring(0, 10);
        //        if (Request != null)
        //        {
        //            var cookie = Request.Cookies[pNomeCookie];
        //            if (cookie != null)
        //            {
        //                string Value = cookie.Value.Decrypt();
        //                int Valor = Convert.ToInt32(Value);
        //                return Valor;
        //            }
        //        }
        //        return 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        protected string RecuperarValorCookie(string pNomeCookie)
        {
            try
            {
                pNomeCookie = pNomeCookie.Encrypt().Substring(0, 10);
                if (Request != null)
                {
                    var cookie = Request.Cookies[pNomeCookie];
                    if (cookie != null)
                    {
                        string Value = cookie.Value.Decrypt();
                        return Value;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Recupera o cookie de acordo com o nome passado por parâmetro.
        /// </summary>
        /// <param name="pNomeCookie">Nome do Cookie.</param>
        /// <returns>Cookie recuperado.</returns>
        protected HttpCookie RecuperarCookie(string pNomeCookie)
        {
            try
            {
                pNomeCookie = pNomeCookie.Encrypt().Substring(0, 10);
                var cookie =
                    Request.Cookies[pNomeCookie];
                return cookie;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Método responsável por validar se o usuário está logado.
        /// Caso o usuário esteja logado, retorna true. Caso o usuário não esteja logado, retorna false.
        /// </summary>
        /// <returns>Caso o usuário esteja logado, retorna true. Caso o usuário não esteja logado, retorna false.</returns>
        protected virtual bool IsLogged()
        {
            try
            {
                var _httpCookie = this.RecuperarValorCookie("COD");
                if (_httpCookie == null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Método responsável por redirecionar para o usuário para a página /Login/Index.
        /// </summary>
        /// <returns>Objeto do tipo ActionResult.</returns>
        protected virtual ActionResult RedirecionarLogin()
        {
            try
            {
                return
                    RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Verifica se o usuário está logado e retorna a página solicitada.
        /// </summary>
        /// <returns>Página solicitada.</returns>
        protected internal ViewResult View(bool ValidarPermissoes = true, bool pOnlyLogged = true)
        {
            try
            {
                this.SetMasterPageViewBags();
                if (pOnlyLogged)
                {
                    if (this.IsLogged())
                    {
                        return base.View();
                    }
                    else
                    {
                        return base.View("~/Views/Login/Index.cshtml");
                    }
                }
                else
                {
                    return base.View();
                }

            }
            catch (Exception)
            {
                this.FinalizarSessao();
                return base.View("~/Views/Login/Index.cshtml");
            }
        }
        /// <summary>
        /// Verifica se o usuário está logado e retorna a página solicitada.
        /// </summary>
        /// <param name="viewName"></param>
        /// <returns>Página solicitada.</returns>
        protected internal ViewResult View(string viewName, bool pValidarPermissoes = true, bool pOnlyLogged = true)
        {
            try
            {
                if (pOnlyLogged)
                {
                    if (viewName == "HomeController")
                    {
                        this.SetMasterPageViewBags();
                    }

                    if (this.IsLogged())
                    {
                        return base.View();
                    }
                    else
                    {
                        return base.View("~/Views/Login/Index.cshtml");
                    }
                }
                else
                {
                    return base.View(viewName);
                }
            }
            catch (Exception)
            {
                return
                    base.View("~/Views/Login/Index.cshtml");
            }
        }
        /// <summary>
        /// Seta todas as viewbags utilizadas na Master Page.
        /// </summary>
        private void SetMasterPageViewBags()
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}