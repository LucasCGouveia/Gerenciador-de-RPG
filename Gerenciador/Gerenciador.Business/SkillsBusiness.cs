using Gerenciador.Entities;
using Gerenciador.Repository;
using System;

namespace Gerenciador.Business
{
    public class SkillsBusiness : BusinessBase<TabSkills>
    {
        Resultado resultado = new Resultado();
        SkillsRepository skillsRepository = new SkillsRepository();
        TabSkills tb_Skills = new TabSkills();
        public Resultado Gravar(TabSkills tb_Skills)
        {
            resultado = skillsRepository.Gravar(tb_Skills);
            return resultado;
        }
        public Resultado Desativar(int codigoRaca)
        {
            resultado = skillsRepository.Desativar(codigoRaca);
            return resultado;
        }
        //public Resultado Excluir(int codigo)
        //{
        //    resultado = skillsRepository.Excluir(codigo);
        //    return resultado;
        //}
        public Resultado ExcluirSkillsPersonagem(int codigo)
        {
            resultado = skillsRepository.ExcluirSkillsPersonagem(codigo);
            return resultado;
        }
        //public Resultado Editar(TabSkills tb_Skills)
        //{
        //    resultado = skillsRepository.Editar(tb_Skills);
        //    return resultado;
        //}
        public Resultado AdicionarPersonagem(TabSkills tb_Skills)
        {
            resultado = skillsRepository.AdicionarPersonagem(tb_Skills);
            return resultado;
        }



    }
}
