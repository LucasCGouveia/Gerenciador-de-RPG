using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;

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
        public Resultado Editar(string Codigo, string NomeCampanha, string Sistema, string Descricao)
        {
            tb_Campanhas.COD = Convert.ToInt32(Codigo);
            tb_Campanhas.NOMECAMPANHA = NomeCampanha;
            tb_Campanhas.SISTEMA = Sistema;
            tb_Campanhas.DESCRICAO = Descricao;
            resultado = campanhasRepository.Editar(tb_Campanhas);
            return resultado;
        }
        public List<TabCampanhas> ListarCampanhasMestre(int pId)
        {
            List<TabCampanhas> ListaCampanhas = campanhasRepository.ListarCampanhasMestre(pId);
            return ListaCampanhas;
        }



    }
}
