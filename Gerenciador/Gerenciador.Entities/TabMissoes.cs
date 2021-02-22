using System.Data.Entity.ModelConfiguration;

namespace Gerenciador.Entities
{
    public class TabMissoes : EntityTypeConfiguration<TabMissoes>
    {
        public int COD { get; set; }
        public string MISSAO { get; set; } = string.Empty;
        public string SOLICITANTE { get; set; } = string.Empty;
        public int XP { get; set; }
        public int JADES { get; set; }
        public string ITEM { get; set; } = string.Empty;
        public string CONCLUIDA { get; set; } = string.Empty;
        public string DETALHES { get; set; } = string.Empty;
        public int COD_CAMPANHA { get; set; }
        public int COD_MESTRE { get; set; }
        public TabMissoes()
        { }
    }
}
