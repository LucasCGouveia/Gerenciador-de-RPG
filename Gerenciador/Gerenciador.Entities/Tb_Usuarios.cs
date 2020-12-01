using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Entities
{
    public class Tb_Usuarios
    {
        public int Codigo { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string TipoLogin { get; set; } = string.Empty;
        public Tb_Usuarios()
        { }
        public Tb_Usuarios(string login, string senha, string tipologin)
        {
            Login = login;
            Senha = senha;
            TipoLogin = tipologin;
        }
    }
}
