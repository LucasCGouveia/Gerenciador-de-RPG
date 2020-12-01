using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class Tb_Jogadores
    {
        public int COD { get; set; }
        public string NOME { get; set; } = string.Empty;
        public string NASCIMENTO { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string QTDPERSONAGENS { get; set; } = string.Empty;
        public DateTime DATAINCLUSAO { get; set; }
        public int COD_USUARIO { get; set; }
        public int ATIVO { get; set; }
        public Tb_Jogadores()
        { }
        public Tb_Jogadores(string nome, string qtdpersonagens)
        {
            NOME = nome;
            QTDPERSONAGENS = qtdpersonagens;
        }

    }
}
