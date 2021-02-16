using Gerenciador.Entities;
using Gerenciador.Repository;
using System;

namespace Gerenciador.Business
{
    public class ItensBusiness
    {
        Resultado resultado = new Resultado();
        ItensRepository itensRepository = new ItensRepository();
        TabItens tb_Itens = new TabItens();
        public Resultado Gravar(string Item, string Descricao)
        {
            tb_Itens.ITEM = Item;
            tb_Itens.DESCRICAO = Descricao;
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
            tb_Itens.COD = Convert.ToInt32(Codigo);
            tb_Itens.ITEM = Item;
            tb_Itens.DESCRICAO = Descricao;
            resultado = itensRepository.Editar(tb_Itens);
            return resultado;
        }



    }
}
