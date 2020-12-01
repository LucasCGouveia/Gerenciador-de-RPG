using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class Tb_Itens
    {
        public int Codigo { get; set; }
        public string Item { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public Tb_Itens()
        { }
        public Tb_Itens(string item, string descricao)
        {
            Item = item;
            Descricao = descricao;
        }

    }
}
