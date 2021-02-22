using System.Data.Entity.ModelConfiguration;

namespace Gerenciador.Entities
{
    public class TabSkills : EntityTypeConfiguration<TabSkills>
    {
        public int COD { get; set; }
        public string SKILL { get; set; } = string.Empty;
        public string TIPO { get; set; } = string.Empty;
        public string NIVEL { get; set; } = string.Empty;
        public string DANO { get; set; } = string.Empty;
        public string BONUS { get; set; } = string.Empty;
        public string VALOR { get; set; } = string.Empty;
        public string TEMPO { get; set; } = string.Empty;
        public string ALCANCE { get; set; } = string.Empty;
        public string DURACAO { get; set; } = string.Empty;
        public string DESCRICAO { get; set; } = string.Empty;
        public int COD_PERSONAGEM { get; set; }
        public TabSkills()
        { }
        public TabSkills(string skill, string descricao)
        {
            SKILL = skill;
            DESCRICAO = descricao;
        }

    }
}
