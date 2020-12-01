using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class Tb_Classes
    {
        public int Codigo { get; set; }
        public string Classe { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        //public string TipoLogin { get; set; } = string.Empty;
        public Tb_Classes()
        { }
        public Tb_Classes(string classe, string descricao)
        {
            Classe = classe;
            Descricao = descricao;
        }
    }
}
