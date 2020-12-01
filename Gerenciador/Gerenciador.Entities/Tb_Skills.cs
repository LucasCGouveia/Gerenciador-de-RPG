using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class Tb_Skills
    {
        public int Codigo { get; set; }
        public string Skill { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        //public string TipoLogin { get; set; } = string.Empty;
        public Tb_Skills()
        { }
        public Tb_Skills(string skill, string descricao)
        {
            Skill = skill;
            Descricao = descricao;
        }

    }
}
