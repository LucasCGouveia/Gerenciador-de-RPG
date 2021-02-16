using Gerenciador.Entities;
using Gerenciador.Repository;
using System;

namespace Gerenciador.Business
{
    public class RacasBusiness : BusinessBase<TabRacas>
    {
        Resultado resultado = new Resultado();
        RacasRepository racasRepository = new RacasRepository();
        TabRacas tb_Racas = new TabRacas();
        public Resultado GravarClasse(string Raca, string Descricao)
        {
            tb_Racas.RACA = Raca;
            tb_Racas.DESCRICAO = Descricao;
            resultado = racasRepository.Gravar(tb_Racas);
            return resultado;
        }
        public Resultado Desativar(int codigoRaca)
        {
            resultado = racasRepository.Desativar(codigoRaca);
            return resultado;
        }
        public Resultado Editar(string Codigo, string Raca, string Descricao)
        {
            tb_Racas.COD = Convert.ToInt32(Codigo);
            tb_Racas.RACA = Raca;
            tb_Racas.DESCRICAO = Descricao;
            resultado = racasRepository.Editar(tb_Racas);
            return resultado;
        }



    }
}
