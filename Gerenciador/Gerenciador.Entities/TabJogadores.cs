using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class TabJogadores : EntityTypeConfiguration<TabJogadores>
    {
        public int COD { get; set; }
        public string NOME { get; set; } = string.Empty;
        public string NASCIMENTO { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public int QTDPERSONAGENS { get; set; }
        public DateTime DATAINCLUSAO { get; set; }
        public int COD_USUARIO { get; set; }
        public int ATIVO { get; set; }
        public TabJogadores()
        { }
        public TabJogadores(string nome, int qtdpersonagens)
        {
            NOME = nome;
            QTDPERSONAGENS = qtdpersonagens;
        }

    }
}
