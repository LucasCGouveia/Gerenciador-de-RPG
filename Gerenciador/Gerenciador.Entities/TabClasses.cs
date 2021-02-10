using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class TabClasses
    {
        public int Codigo { get; set; }
        public string Classe { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        //public string TipoLogin { get; set; } = string.Empty;
        public TabClasses()
        { }
        public TabClasses(string classe, string descricao)
        {
            Classe = classe;
            Descricao = descricao;
        }
    }
}
