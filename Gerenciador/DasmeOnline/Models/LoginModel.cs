using Gerenciador.Entities;
using Gerenciador.Repository.BancoDados;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Web.Mvc;
namespace DasmeOnline.Models
{
    public class LoginModel
    {
        private SqlConnection connection;
        public LoginModel()
        {
            connection = ConexaoDB.AbreBanco();
        }
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [HiddenInput]
        public string ReturnUrl { get; set; }

        public List<TabUsuarios> Read()
        {
            List<TabUsuarios> lista = new List<TabUsuarios>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"SELECT * FROM TabUsuario";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TabUsuarios tb_Usuario = new TabUsuarios();
                tb_Usuario.Codigo = Convert.ToInt32(reader["Codigo"]);
                tb_Usuario.Login = (string)reader["Login"];
                tb_Usuario.Senha = (string)reader["Senha"];
                tb_Usuario.TipoLogin = Convert.ToString(reader["TipoLogin"]);
                lista.Add(tb_Usuario);
            }

            return lista;
        }
    }
}