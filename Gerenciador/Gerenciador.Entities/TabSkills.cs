using System.Data.Entity.ModelConfiguration;

namespace Gerenciador.Entities
{
    public class TabSkills : EntityTypeConfiguration<TabSkills>
    {
        public int COD { get; set; }
        public string SKILL { get; set; } = string.Empty;
        public string DESCRICAO { get; set; } = string.Empty;
        public int ATIVO { get; set; }
        public TabSkills()
        { }
        public TabSkills(string skill, string descricao)
        {
            SKILL = skill;
            DESCRICAO = descricao;
        }

    }
}
