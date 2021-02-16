using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class TabCampanhas : EntityTypeConfiguration<TabCampanhas>
    {
        public int COD { get; set; }
        public string NOMECAMPANHA { get; set; } = string.Empty;
        public string SISTEMA { get; set; } = string.Empty;
        public string DESCRICAO { get; set; } = string.Empty;
        public int COD_MESTRE { get; set; }
        public int ATIVO { get; set; }
        public TabCampanhas()
        { }
        public TabCampanhas(string nomeCampanha, string descricao)
        {
            NOMECAMPANHA = nomeCampanha;
            DESCRICAO = descricao;
        }
    }
}
