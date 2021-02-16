using Gerenciador.Entities;
using Gerenciador.Repository;
using System;

namespace Gerenciador.Business
{
    public class SkillsBusiness
    {
        Resultado resultado = new Resultado();
        SkillsRepository racasRepository = new SkillsRepository();
        TabSkills tb_Skills = new TabSkills();
        public Resultado GravarClasse(string Raca, string Descricao)
        {
            tb_Skills.SKILL = Raca;
            tb_Skills.DESCRICAO = Descricao;
            resultado = racasRepository.Gravar(tb_Skills);
            return resultado;
        }
        public Resultado Desativar(int codigoRaca)
        {
            resultado = racasRepository.Desativar(codigoRaca);
            return resultado;
        }
        public Resultado Editar(string Codigo, string Raca, string Descricao)
        {
            tb_Skills.COD = Convert.ToInt32(Codigo);
            tb_Skills.SKILL = Raca;
            tb_Skills.DESCRICAO = Descricao;
            resultado = racasRepository.Editar(tb_Skills);
            return resultado;
        }



    }
}
