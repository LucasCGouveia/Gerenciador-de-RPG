using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Business
{
    public class AtributosBusiness
    {
        Resultado resultado = new Resultado();
        AtributosRepository atributosRepository = new AtributosRepository();
        TabAtributos tb_Atributos = new TabAtributos();
        public Resultado Gravar(int Codigo)
        {
            tb_Atributos.COD_PERSONAGEM = Codigo;
            tb_Atributos.FORC = 0;
            tb_Atributos.DEST = 0;
            tb_Atributos.CONS = 0;
            tb_Atributos.INTE = 0;
            tb_Atributos.SABE = 0;
            tb_Atributos.CARI = 0;
            tb_Atributos.DataAtualizacao = DateTime.Now;
            resultado = atributosRepository.Gravar(tb_Atributos);
            return resultado;
        }
        //public Resultado Desativar(int codigoRaca)
        //{
        //    resultado = atributosRepository.Desativar(codigoRaca);
        //    return resultado;
        //}
        public Resultado Editar(TabAtributos tb_Atributos)
        {
            tb_Atributos.DataAtualizacao = DateTime.Now;
            resultado = atributosRepository.Editar(tb_Atributos);
            return resultado;
        }
        public Resultado Excluir(int codigo)
        {
            tb_Atributos.COD_PERSONAGEM = codigo;
            resultado = atributosRepository.Excluir(tb_Atributos);
            return resultado;
        }
        public List<int> GetCodAtributos(int Codigo)
        {
            try
            {
                DataTable objDataTable = new DataTable();
                List<int> ListaDeDados = new List<int>();
                objDataTable = atributosRepository.GetCodAtributos();

                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    int CODLista = Convert.ToInt32(dataRow["COD"]);
                    int CODPERSONAGEMLista = Convert.ToInt32(dataRow["COD_PERSONAGEM"]);

                    if (Codigo == CODPERSONAGEMLista)
                    {
                        ListaDeDados.Add(CODLista);
                        break;
                    }
                }

                return ListaDeDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
