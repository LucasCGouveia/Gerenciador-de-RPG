using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Gerenciador.Business
{
    public class UsuarioBusiness
    {
        Resultado resultado = new Resultado();
        UsuarioRepository ObjRepository = new UsuarioRepository();
        TabUsuarios tb_Usuarios = new TabUsuarios();

        public Resultado Gravar(string Login, string Senha, string TipoUser)
        {
            tb_Usuarios.Login = Login.ToUpper();
            tb_Usuarios.Senha = Senha;
            tb_Usuarios.TipoLogin = TipoUser;
            resultado = ObjRepository.Gravar(tb_Usuarios);
            return resultado;
        }
        public Resultado Ativar(int codigo)
        {
            resultado = ObjRepository.Ativar(codigo);
            return resultado;
        }
        public Resultado Desativar(int codigo)
        {
            resultado = ObjRepository.Desativar(codigo);
            return resultado;
        }
        public Resultado Excluir(int codigo)
        {
            resultado = ObjRepository.Excluir(codigo);
            return resultado;
        }
        public Resultado Editar(string Codigo, string Login, string Senha, string TipoUser)
        {
            tb_Usuarios.Codigo = Convert.ToInt32(Codigo);
            tb_Usuarios.Login = Login;
            tb_Usuarios.Senha = Senha;
            tb_Usuarios.TipoLogin = TipoUser;
            resultado = ObjRepository.Editar(tb_Usuarios);
            return resultado;
        }
        public List<string> GetUsuarios(string TxtLogin,string TxtSenha)
        {
            try
            {
                //Intermediario recebe a respota do comandos sql enviado  
                //dataAdapter = new SqlDataAdapter(command);

                //Estrutura da tabela 
                DataTable objDataTable = new DataTable();

                //Preencher com a estrutura do select enviado com as tuplas
                //dataAdapter.Fill(objDataTable);

                //Cria lista
                List<string> ListaDeDados = new List<string>();
                objDataTable = ObjRepository.GetUsuarios();

                //Percorrer as linhas do datatable para adicionar na lista 
                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    //Adiciona na lista Especificando a clouna 
                    string LoginLista = dataRow["LOGIN"].ToString();
                    string SenhaLista = dataRow["SENHA"].ToString();
                    string TipoUserLista = dataRow["TIPOUSER"].ToString();
                    int ATIVO = Convert.ToInt32(dataRow["ATIVO"]);

                    if (TxtLogin.ToUpper() == LoginLista && TxtSenha == SenhaLista && TipoUserLista == "J" && ATIVO == 1)
                    {
                        ListaDeDados.Add("Jogador");
                        break;
                    }
                    if (TxtLogin.ToUpper() == LoginLista && TxtSenha == SenhaLista && TipoUserLista == "M" && ATIVO == 1)
                    {
                        ListaDeDados.Add("Mestre");
                        break;
                    }
                    else
                    {
                        if (TxtLogin.ToUpper() == LoginLista && TxtSenha == SenhaLista && ATIVO == 0)
                        {
                            ListaDeDados.Add("Bloqueado");
                            break;
                        }
                    }
                    //ListaDeDados.Add(LoginLista);
                    //ListaDeDados.Add(SenhaLista);
                    //ListaDeDados.Add(TipoUserLista);
                }

                return ListaDeDados;
            }
            catch (Exception ex)
            {
                //Trata exceção
                throw ex;
            }
            finally
            {
                //Fechar Conexão 
            }
        }
        public List<int> GetCodigoMestre(string NomeMestre)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            try
            {
                DataTable objDataTable = new DataTable();
                List<int> ListaDeDados = new List<int>();
                objDataTable = usuarioRepository.GetCodigoMestre();
                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    int Codigo = Convert.ToInt32(dataRow["COD"]);
                    string LoginLista = dataRow["LOGIN"].ToString();

                    if (LoginLista == NomeMestre.ToUpper())
                    {
                        ListaDeDados.Add(Codigo);
                        break;
                    }
                }
                return ListaDeDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Fechar Conexão 
            }
        }
        public List<int> GetCodigoUsuario(string Login)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            try
            {
                DataTable objDataTable = new DataTable();
                List<int> ListaDeDados = new List<int>();
                objDataTable = usuarioRepository.GetCodigoUsuario();
                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    int Codigo = Convert.ToInt32(dataRow["COD"]);
                    string LoginLista = dataRow["LOGIN"].ToString();

                    if (LoginLista == Login.ToUpper())
                    {
                        ListaDeDados.Add(Codigo);
                        break;
                    }
                }
                return ListaDeDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Fechar Conexão 
            }
        }














    }
}
