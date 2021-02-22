using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gerenciador.Business
{
    public class BusinessBase<T> : IDisposable where T : class
    {
        private readonly RepositoryBase<T> _repository;
        private readonly Resultado resultado;

        public BusinessBase()
        {
            this._repository = new RepositoryBase<T>();
            this.resultado = new Resultado();
        }
        public void Adicionar(T pObj)
        {
            this._repository.Adicionar(pObj);
        }
        public T Listar(int pId)
        {
            return
                this._repository.Listar(pId);
        }
        public T Listar(int pId, bool asNoTracking)
        {
            return
                this._repository.Listar(pId, asNoTracking);
        }
        public T Listar(int pId, int pIdUsuario, bool asNoTracking)
        {
            return
                this._repository.Listar(pId, pIdUsuario, asNoTracking);
        }
        public IEnumerable<T> Listar()
        {
            return
                this._repository.Listar();
        }

        public IEnumerable<T> Listar(bool asNoTracking)
        {
            return
                this._repository.Listar(asNoTracking);
        }
        public Resultado Editar(T pObj)
        {
            this._repository.Editar(pObj);
            resultado.sucesso = true;
            return resultado;
        }
        public Resultado Excluir(int pId)
        {
            this._repository.Excluir(pId);
            resultado.sucesso = true;
            return resultado;
        }
        public void Dispose()
        {
            this._repository.Dispose();
            GC.SuppressFinalize(this);
        }
        public IEnumerable<T> Paginar(IEnumerable<T> pCollection, ref int pPaginaSolicitada, ref int pQuantidadePaginas, int pQuantidadeRegistros)
        {
            try
            {
                return
                    this._repository.Paginar(pCollection, ref pPaginaSolicitada, ref pQuantidadePaginas, pQuantidadeRegistros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<T> GetAll()
        {
            return
                this._repository.GetAll();
        }
    }
}