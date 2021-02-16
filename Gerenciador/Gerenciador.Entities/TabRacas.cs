using System.Data.Entity.ModelConfiguration;

namespace Gerenciador.Entities
{
    public class TabRacas : EntityTypeConfiguration<TabRacas>
    {
        public int COD { get; set; }
        public string RACA { get; set; } = string.Empty;
        public string DESCRICAO { get; set; } = string.Empty;
        public int ATIVO { get; set; }
        public TabRacas()
        { }
        public TabRacas(string raca, string descricao)
        {
            RACA = raca;
            DESCRICAO = descricao;
        }

    }
}
