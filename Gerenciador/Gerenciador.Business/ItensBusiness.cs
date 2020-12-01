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
    public class ItensBusiness
    {
        Resultado resultado = new Resultado();
        ItensRepository itensRepository = new ItensRepository();
        Tb_Itens tb_Itens = new Tb_Itens();
        public Resultado Gravar(string Item, string Descricao)
        {
            tb_Itens.Item = Item;
            tb_Itens.Descricao = Descricao;
            resultado = itensRepository.Gravar(tb_Itens);
            return resultado;
        }
        public Resultado Desativar(int codigo)
        {
            resultado = itensRepository.Desativar(codigo);
            return resultado;
        }
        public Resultado Editar(string Codigo, string Item, string Descricao)
        {
            tb_Itens.Codigo = Convert.ToInt32(Codigo);
            tb_Itens.Item = Item;
            tb_Itens.Descricao = Descricao;
            resultado = itensRepository.Editar(tb_Itens);
            return resultado;
        }



    }
}
