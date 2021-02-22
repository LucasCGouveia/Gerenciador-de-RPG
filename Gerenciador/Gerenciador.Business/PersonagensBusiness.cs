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
    public class PersonagensBusiness : BusinessBase<TabPersonagens>
    {
        Resultado resultado = new Resultado();
        TabPersonagens tb_Personagens = new TabPersonagens();

        PersonagensRepository personagensRepository = new PersonagensRepository();
        public TabPersonagens GetDadosPersonagem(TabPersonagens tb_Personagens, TabAtributos tb_Atributos)
        {
            DataTable dt = new DataTable();
            dt = personagensRepository.GetDadosPersonagem(tb_Personagens);
            tb_Personagens.NOME = dt.Rows[0]["NOME"].ToString();
            tb_Personagens.RACA = dt.Rows[0]["RACA"].ToString();
            tb_Personagens.CLASSE = dt.Rows[0]["CLASSE"].ToString();
            tb_Personagens.ALINHAMENTO = dt.Rows[0]["ALINHAMENTO"].ToString();
            tb_Personagens.CA = Convert.ToInt32(dt.Rows[0]["CA"].ToString());
            tb_Personagens.PVTOTAL = Convert.ToInt32(dt.Rows[0]["PVTOTAL"].ToString());
            tb_Personagens.PVATUAL = Convert.ToInt32(dt.Rows[0]["PVATUAL"].ToString());
            tb_Personagens.PATAQUE = Convert.ToInt32(dt.Rows[0]["PATAQUE"].ToString());
            tb_Personagens.INICIATIVA = Convert.ToInt32(dt.Rows[0]["INICIATIVA"].ToString());
            tb_Personagens.DINHEIRO = Convert.ToInt32(dt.Rows[0]["DINHEIRO"].ToString());
            tb_Personagens.EXPERIENCIA = Convert.ToInt32(dt.Rows[0]["EXPERIENCIA"].ToString());
            tb_Personagens.NIVEL = Convert.ToInt32(dt.Rows[0]["NIVEL"].ToString());
            tb_Personagens.HISTORIA = dt.Rows[0]["HISTORIA"].ToString();


            tb_Atributos.FORC = Convert.ToInt32(dt.Rows[0]["FORC"].ToString());
            tb_Atributos.DEST = Convert.ToInt32(dt.Rows[0]["DEST"].ToString());
            tb_Atributos.CONS = Convert.ToInt32(dt.Rows[0]["CONS"].ToString());
            tb_Atributos.INTE = Convert.ToInt32(dt.Rows[0]["INTE"].ToString());
            tb_Atributos.SABE = Convert.ToInt32(dt.Rows[0]["SABE"].ToString());
            tb_Atributos.CARI = Convert.ToInt32(dt.Rows[0]["CARI"].ToString());

            return tb_Personagens;
        }
        public Resultado Gravar(TabPersonagens tb_Personagens)
        {
            resultado = personagensRepository.Gravar(tb_Personagens);
            return resultado;
        }
        public Resultado Desativar(int codigo)
        {
            resultado = personagensRepository.Desativar(codigo);
            return resultado;
        }
        public Resultado JogadorEditando(TabPersonagens tb_Personagens)
        {
            resultado = personagensRepository.JogadorEditando(tb_Personagens);
            return resultado;
        }
        public Resultado MestreEditando(TabPersonagens tb_Personagens)
        {
            resultado = personagensRepository.MestreEditando(tb_Personagens);
            return resultado;
        }
        public Resultado AdicionarCampanha(TabPersonagens tb_Personagens)
        {
            resultado = personagensRepository.AdicionarCampanha(tb_Personagens);
            return resultado;
        }
        //public Resultado Excluir(int codigo)
        //{
        //    resultado = personagensRepository.Excluir(codigo);
        //    return resultado;
        //}
        public Resultado VenderItem(int DinheiroAtual, string CodigoPersonagem)
        {
            tb_Personagens.COD = Convert.ToInt32(CodigoPersonagem);
            tb_Personagens.DINHEIRO = DinheiroAtual;
            resultado = personagensRepository.VenderItem(tb_Personagens);
            return resultado;
        }
        //==================================================================================================
        //==================================================================================================
        //==================================================================================================
        //==================================================================================================
        //==================================================================================================
        public List<TabPersonagens> ListarPersonagensCampanha(int pId)
        {
            List<TabPersonagens> listaPersonagensCampanha = personagensRepository.ListarPersonagensCampanha(pId);
            return listaPersonagensCampanha;
        }
        public List<TabPersonagens> ListarPersonagensJogador(int pId)
        {
            List<TabPersonagens> listaPersonagensCampanha = personagensRepository.ListarPersonagensJogador(pId);
            return listaPersonagensCampanha;
        }
        public List<TabPersonagens> BuscarPersonagensSemCampanha(string Nome)
        {
            List<TabPersonagens> listaPersonagensSemCampanha = personagensRepository.BuscarPersonagensSemCampanha(Nome);
            return listaPersonagensSemCampanha;
        }

        //==================================================================================================
        //==================================================================================================
        //==================================================================================================
        //==================================================================================================
        //==================================================================================================
    }
}
