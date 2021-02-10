using Gerenciador.Entities;
using Gerenciador.Repository;
using Gerenciador.Repository.BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Business
{
    public class CampanhasBusiness
    {
        Resultado resultado = new Resultado();
        CampanhasRepository campanhasRepository = new CampanhasRepository();
        TabCampanhas tb_Campanhas = new TabCampanhas();
        public Resultado Gravar(string NomeCampanha, string Sistema, string Descricao, int CodigoMestre)
        {
            tb_Campanhas.NomeCampanha = NomeCampanha;
            tb_Campanhas.Sistema = Sistema;
            tb_Campanhas.Descricao = Descricao;
            tb_Campanhas.CodigoMestre = CodigoMestre;
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
            tb_Campanhas.Codigo = Convert.ToInt32(Codigo);
            tb_Campanhas.NomeCampanha = NomeCampanha;
            tb_Campanhas.Sistema = Sistema;
            tb_Campanhas.Descricao = Descricao;
            resultado = campanhasRepository.Editar(tb_Campanhas);
            return resultado;
        }
        



    }
}
