using System;
using System.Data.Entity.ModelConfiguration;

namespace Gerenciador.Entities
{
    public class TabAtributos : EntityTypeConfiguration<TabAtributos>
    {
        public int COD { get; set; }
        public int FORC { get; set; } 
        public int DEST { get; set; }
        public int CONS { get; set; }
        public int INTE { get; set; } 
        public int SABE { get; set; } 
        public int CARI { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int COD_PERSONAGEM { get; set; }
        public TabAtributos()
        { }

    }
}
