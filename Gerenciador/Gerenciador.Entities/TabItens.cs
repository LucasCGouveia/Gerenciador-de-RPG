using System.Data.Entity.ModelConfiguration;

namespace Gerenciador.Entities
{
    public class TabItens : EntityTypeConfiguration<TabItens>
    {
        public int COD { get; set; }
        public string ITEM { get; set; } = string.Empty;
        public string TIPO { get; set; } = string.Empty;
        public string DANO { get; set; } = string.Empty;
        public string BONUS { get; set; } = string.Empty;
        public string VALOR { get; set; } = string.Empty;
        public string DESCRICAO { get; set; } = string.Empty;
        public int COD_PERSONAGEM { get; set; }
        public TabItens()
        { }
        public TabItens(string item, string descricao)
        {
            ITEM = item;
            DESCRICAO = descricao;
        }

    }
}
