using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Data;

namespace Gerenciador.Business
{
    public class CampanhasBusiness : BusinessBase<TabCampanhas>
    {
        Resultado resultado = new Resultado();
        CampanhasRepository campanhasRepository = new CampanhasRepository();
        TabCampanhas tb_Campanhas = new TabCampanhas();
        public Resultado Gravar(string NomeCampanha, string Sistema, string Descricao, int CodigoMestre)
        {
            tb_Campanhas.NOMECAMPANHA = NomeCampanha;
            tb_Campanhas.SISTEMA = Sistema;
            tb_Campanhas.DESCRICAO = Descricao;
            tb_Campanhas.COD_MESTRE = CodigoMestre;
            resultado = campanhasRepository.Gravar(tb_Campanhas);
            return resultado;
        }
        public Resultado Desativar(int codigoRaca)
        {
            resultado = campanhasRepository.Desativar(codigoRaca);
            return resultado;
        }
        //public TabCampanhas Editar(string Codigo, string NomeCampanha, string Sistema, string Descricao)
        //{
        //    tb_Campanhas.COD = Convert.ToInt32(Codigo);
        //    tb_Campanhas.NOMECAMPANHA = NomeCampanha;
        //    tb_Campanhas.SISTEMA = Sistema;
        //    tb_Campanhas.DESCRICAO = Descricao;
        //    TabCampanhas  = campanhasRepository.Editar(tb_Campanhas);
        //    return resultado;
        //}
        public List<TabCampanhas> ListarCampanhasMestre(int pId)
        {
            List<TabCampanhas> ListaCampanhas = campanhasRepository.ListarCampanhasMestre(pId);
            return ListaCampanhas;
        }
        public List<int> VerificarCampanhas(int codigoMestre)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            try
            {
                DataTable objDataTable = new DataTable();
                List<int> ListaDeDados = new List<int>();
                objDataTable = campanhasRepository.VerificarCampanhas();
                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    int Codigo = Convert.ToInt32(dataRow["COD_MESTRE"]);

                    if (Codigo == codigoMestre)
                    {
                        ListaDeDados.Add(Codigo);
                        break;
                    }
                }
                return ListaDeDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Fechar Conexão 
            }
        }


    }
}
