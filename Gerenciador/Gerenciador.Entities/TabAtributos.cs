using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class TabAtributos
    {
        public int Codigo { get; set; }
        public int FORC { get; set; } 
        public int DESC { get; set; }
        public int CONS { get; set; }
        public int INTE { get; set; } 
        public int SABE { get; set; } 
        public int CARI { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int CodigoPersonagem { get; set; }
        public TabAtributos()
        { }

    }
}
