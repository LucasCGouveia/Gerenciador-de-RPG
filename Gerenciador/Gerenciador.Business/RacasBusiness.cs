using Gerenciador.Entities;
using Gerenciador.Repository;
using Gerenciador.Repository.BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Business
{
    public class RacasBusiness
    {
        Resultado resultado = new Resultado();
        RacasRepository racasRepository = new RacasRepository();
        Tb_Racas tb_Racas = new Tb_Racas();
        public Resultado GravarClasse(string Raca, string Descricao)
        {
            tb_Racas.Raca = Raca;
            tb_Racas.Descricao = Descricao;
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
            tb_Racas.Codigo = Convert.ToInt32(Codigo);
            tb_Racas.Raca = Raca;
            tb_Racas.Descricao = Descricao;
            resultado = racasRepository.Editar(tb_Racas);
            return resultado;
        }



    }
}
