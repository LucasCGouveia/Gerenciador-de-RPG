using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Data.Entity.ModelConfiguration;

namespace Gerenciador.Entities
{
    public class TabUsuarios : EntityTypeConfiguration<TabUsuarios>
    {
        public int COD { get; set; }
        [Required]
        public string LOGIN { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string SENHA { get; set; } = string.Empty;
        public string TIPOUSER { get; set; } = string.Empty;
        public int ATIVO { get; set; }
        public TabUsuarios()
        { }
        public TabUsuarios(string login, string senha, string tipologin)
        {
            LOGIN = login;
            SENHA = senha;
            TIPOUSER = tipologin;
        }
        
    }
}
