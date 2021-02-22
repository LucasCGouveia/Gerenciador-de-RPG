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
        public Resultado Gravar(string Item, string Tipo, string Dano, string Bonus, string Valor, string Descricao)
        {
            tb_Itens.ITEM = Item;
            tb_Itens.TIPO = Tipo;
            tb_Itens.DANO = Dano;
            tb_Itens.BONUS = Bonus;
            tb_Itens.VALOR = Valor;
            tb_Itens.DESCRICAO = Descricao;
            resultado = itensRepository.Gravar(tb_Itens);
            return resultado;
        }
        public Resultado Desativar(int codigo)
        {
            resultado = itensRepository.Desativar(codigo);
            return resultado;
        }
        public Resultado Editar(string Codigo, string Item, string Tipó, string Dano, string Bonus, string Valor, string Descricao)
        {
            tb_Itens.COD = Convert.ToInt32(Codigo);
            tb_Itens.ITEM = Item;
            tb_Itens.TIPO = Tipó;
            tb_Itens.DANO = Dano;
            tb_Itens.BONUS = Bonus;
            tb_Itens.VALOR = Valor;
            tb_Itens.DESCRICAO = Descricao;
            resultado = itensRepository.Editar(tb_Itens);
            return resultado;
        }
        public Resultado Excluir(int codigo)
        {
            resultado = itensRepository.Excluir(codigo);
            return resultado;
        }
        public Resultado ExcluirItensPersonagem(int codigo)
        {
            resultado = itensRepository.ExcluirItensPersonagem(codigo);
            return resultado;
        }
        public Resultado AdicionarPersonagem(string Item, string Tipo, string Dano, string Bonus, string Valor, string Descricao, string CodigoPersonagem)
        {
            tb_Itens.ITEM = Item;
            tb_Itens.TIPO = Tipo;
            tb_Itens.DANO = Dano;
            tb_Itens.BONUS = Bonus;
            tb_Itens.VALOR = Valor;
            tb_Itens.COD_PERSONAGEM = Convert.ToInt32(CodigoPersonagem);
            tb_Itens.DESCRICAO = Descricao;
            resultado = itensRepository.AdicionarPersonagem(tb_Itens);
            return resultado;
        }



    }
}
