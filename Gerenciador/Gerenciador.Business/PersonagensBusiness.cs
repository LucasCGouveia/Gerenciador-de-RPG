using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Business
{
    public class PersonagensBusiness
    {
        Resultado resultado = new Resultado();
        PersonagensRepository personagensRepository = new PersonagensRepository();
        public Resultado Gravar(Tb_Personagens tb_Personagens)
        {
            resultado = personagensRepository.Gravar(tb_Personagens);
            return resultado;
        }
        public Resultado Desativar(int codigo)
        {
            resultado = personagensRepository.Desativar(codigo);
            return resultado;
        }
        public Resultado JogadorEditando(Tb_Personagens tb_Personagens)
        {
            resultado = personagensRepository.JogadorEditando(tb_Personagens);
            return resultado;
        }
        public Resultado MestreEditando(Tb_Personagens tb_Personagens)
        {
            resultado = personagensRepository.MestreEditando(tb_Personagens);
            return resultado;
        }
        public Resultado AdicionarCampanha(Tb_Personagens tb_Personagens)
        {
            resultado = personagensRepository.AdicionarCampanha(tb_Personagens);
            return resultado;
        }
        public Resultado Excluir(int codigo)
        {
            resultado = personagensRepository.Excluir(codigo);
            return resultado;
        }

    }
}
