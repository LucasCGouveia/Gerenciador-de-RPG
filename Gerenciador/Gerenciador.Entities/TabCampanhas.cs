using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class TabCampanhas
    {
        public int Codigo { get; set; }
        public string NomeCampanha { get; set; } = string.Empty;
        public string Sistema { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int CodigoMestre { get; set; }
        public TabCampanhas()
        { }
        public TabCampanhas(string nomeCampanha, string descricao)
        {
            NomeCampanha = nomeCampanha;
            Descricao = descricao;
        }
    }
}
