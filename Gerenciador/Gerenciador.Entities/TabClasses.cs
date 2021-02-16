using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class TabClasses : EntityTypeConfiguration<TabClasses>
    {
        public int COD { get; set; }
        public string CLASSE { get; set; } = string.Empty;
        public string DESCRICAO { get; set; } = string.Empty;
        public int ATIVO { get; set; }
        public TabClasses()
        { }
        public TabClasses(string classe, string descricao)
        {
            CLASSE = classe;
            DESCRICAO = descricao;
        }
    }
}
