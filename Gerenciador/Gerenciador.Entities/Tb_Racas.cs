using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class Tb_Racas
    {
        public int Codigo { get; set; }
        public string Raca { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        //public string TipoLogin { get; set; } = string.Empty;
        public Tb_Racas()
        { }
        public Tb_Racas(string raca, string descricao)
        {
            Raca = raca;
            Descricao = descricao;
        }

    }
}
