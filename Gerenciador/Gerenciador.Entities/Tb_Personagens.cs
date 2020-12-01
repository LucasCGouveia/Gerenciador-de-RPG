using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class Tb_Personagens
    {
        public int COD { get; set; }
        public string NOME { get; set; } = string.Empty;
        public string RACA { get; set; } = string.Empty;
        public string CLASSE { get; set; } = string.Empty;
        public string ALINHAMENTO { get; set; } = string.Empty;
        public int CA { get; set; }
        public int PVTOTAL { get; set; } 
        public int PVATUAL { get; set; } 
        public int PATAQUE { get; set; } 
        public int INICIATIVA { get; set; }
        public int DINHEIRO { get; set; }
        public int EXPERIENCIA { get; set; }
        public int NIVEL { get; set; }
        public string GENERO { get; set; } = string.Empty;
        public string CABELO { get; set; } = string.Empty;
        public string OLHOS { get; set; } = string.Empty;
        public string TAMANHO { get; set; } = string.Empty;
        public string ALTURA { get; set; } = string.Empty;
        public string PESO { get; set; } = string.Empty;
        public string HISTORIA { get; set; } = string.Empty;
        public DateTime DATAINCLUSAO { get; set; }
        public int COD_JOGADOR { get; set; }
        public int COD_CAMPANHA { get; set; }
        public int ATIVO { get; set; }
        public Tb_Personagens()
        { }
    }
}
