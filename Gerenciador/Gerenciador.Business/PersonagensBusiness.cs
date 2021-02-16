using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Business
{
    public class PersonagensBusiness : BusinessBase<TabPersonagens>
    {
        Resultado resultado = new Resultado();
        PersonagensRepository personagensRepository = new PersonagensRepository();
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
        public Resultado Excluir(int codigo)
        {
            resultado = personagensRepository.Excluir(codigo);
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
