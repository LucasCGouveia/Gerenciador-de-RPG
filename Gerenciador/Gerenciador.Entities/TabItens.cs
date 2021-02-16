using System.Data.Entity.ModelConfiguration;

namespace Gerenciador.Entities
{
    public class TabItens : EntityTypeConfiguration<TabItens>
    {
        public int COD { get; set; }
        public string ITEM { get; set; } = string.Empty;
        public string DESCRICAO { get; set; } = string.Empty;
        public int ATIVO { get; set; }
        public TabItens()
        { }
        public TabItens(string item, string descricao)
        {
            ITEM = item;
            DESCRICAO = descricao;
        }

    }
}
