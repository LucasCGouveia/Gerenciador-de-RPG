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
    public class SkillsBusiness
    {
        Resultado resultado = new Resultado();
        SkillsRepository racasRepository = new SkillsRepository();
        TabSkills tb_Skills = new TabSkills();
        public Resultado GravarClasse(string Raca, string Descricao)
        {
            tb_Skills.Skill = Raca;
            tb_Skills.Descricao = Descricao;
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
            tb_Skills.Codigo = Convert.ToInt32(Codigo);
            tb_Skills.Skill = Raca;
            tb_Skills.Descricao = Descricao;
            resultado = racasRepository.Editar(tb_Skills);
            return resultado;
        }



    }
}
