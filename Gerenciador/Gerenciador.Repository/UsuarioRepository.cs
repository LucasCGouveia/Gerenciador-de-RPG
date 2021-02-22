using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data;//Importar ADO
using System.Data.SqlClient; //Importar SQLusing System.Data;
using System.Drawing;
using Gerenciador.Entities;

namespace Gerenciador.Repository
{
    public class UsuarioRepository : RepositoryBase<TabUsuarios>
    {
        Resultado resultado = new Resultado();
        public DataSet ListarDataGrid(string LOGIN) //Recebe o código p/ procura
        {
            string strQuery;
            if (LOGIN == "")
            {
                strQuery = ("SELECT COD,LOGIN,TIPOUSER,ATIVO from TabUsuarios WHERE LOGIN != 'ADM'");
            }
            else
            {
                strQuery = ("SELECT COD,LOGIN,TIPOUSER from TabUsuarios WHERE LOGIN LIKE '% " + LOGIN + "%' AND LOGIN =! ADM");
            }
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataTable GetUsuarioVinculado() //Recebe o código p/ procura
        {
            string strQuery;
            strQuery = ("SELECT U.COD,U.LOGIN from TabUsuarios as U ");
            strQuery += ("INNER JOIN TabJogadores as J ");
            strQuery += ("on U.COD = J.COD_USUARIO where U.ATIVO = 1");
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataTable(strQuery);//Return a consulta tipo SqlDataReader
        }
        public DataTable GetCodigoMestre() //Recebe o código p/ procura
        {
            string strQuery = "select COD,LOGIN from TabUsuarios";
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataTable(strQuery);//Return a consulta tipo SqlDataReader
        }
        public DataTable GetCodigoUsuario() //Recebe o código p/ procura
        {
            string strQuery = "select COD,LOGIN from TabUsuarios";
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataTable(strQuery);//Return a consulta tipo SqlDataReader
        }
        public DataSet ListarUserParaAtribuir(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "SELECT U.COD,U.LOGIN from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD != F.COD_USUARIO where U.LOGIN like '%" + strDescricao + "%' and U.ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "SELECT U.COD,U.LOGIN from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD != F.COD_USUARIO where U.ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataTable GetUsuarios() //Recebe o código p/ procura
        {
            string strQuery = "select * from TabUsuarios";
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataTable(strQuery);//Return a consulta tipo SqlDataReader
        }
        public Resultado Ativar(int codigo)
        {
            string strQuery;
            strQuery = (" UPDATE TabUsuarios ");
            strQuery += (" SET ");
            strQuery += (" ATIVO = '" + 1 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + codigo + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Desativar(int codigo)
        {
            string strQuery;
            strQuery = (" UPDATE TabUsuarios ");
            strQuery += (" SET ");
            strQuery += (" ATIVO = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + codigo + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        //public Resultado Excluir(int _COD)
        //{
        //    string strQuery;
        //    strQuery = ("DELETE FROM TabUsuarios ");
        //    strQuery += (" WHERE ");
        //    strQuery += (" cod = '" + _COD + "' ;");
        //    ConexaoDB ObjCldBancoDados = new ConexaoDB();
        //    resultado = ObjCldBancoDados.Executar(strQuery);

        //    return resultado;
        //}
        public Resultado Gravar(TabUsuarios tb_Usuarios)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TabUsuarios ";
            strQuery += ("(");
            strQuery += ("LOGIN");
            strQuery += (",SENHA");
            strQuery += (",TIPOUSER");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Usuarios.LOGIN + "'");
            strQuery += (",'" + tb_Usuarios.SENHA + "'");
            strQuery += (",'" + tb_Usuarios.TIPOUSER + "'");
            strQuery += (",1");
            strQuery += (")");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        //public Resultado Editar(TabUsuarios tb_Usuarios)
        //{
        //    string strQuery; //Criar a String para alterar
        //    strQuery = (" UPDATE TabUsuarios ");
        //    strQuery += (" SET ");
        //    strQuery += (" LOGIN = '" + tb_Usuarios.LOGIN + "' ");
        //    strQuery += (" ,SENHA = '" + tb_Usuarios.SENHA + "' ");
        //    strQuery += (" ,TIPOUSER = '" + tb_Usuarios.SENHA + "' ");
        //    strQuery += (" WHERE ");
        //    strQuery += (" COD = " + tb_Usuarios.COD + " ");
        //    ConexaoDB ObjCldBancoDados = new ConexaoDB();
        //    resultado = ObjCldBancoDados.Executar(strQuery);
        //    return resultado;
        //}

        //=============================================================================================================================================================================
        //=============================================================================================================================================================================
        //=============================================================================================================================================================================
        //=============================================================================================================================================================================
        //=============================================================================================================================================================================
        public TabUsuarios Login(TabUsuarios login)
        {
            TabUsuarios usuario = Db.TabUsuarios.Where(x => x.LOGIN == login.LOGIN)
                                        .Where(x => x.SENHA == login.SENHA)
                                        .FirstOrDefault();
            return usuario;
        }
        public TabUsuarios VerificarUsuario(TabUsuarios login)
        {
            TabUsuarios usuario = Db.TabUsuarios.Where(x => x.LOGIN == login.LOGIN)
                                        .FirstOrDefault();
            return usuario;
        }
        
        //=============================================================================================================================================================================
        //=============================================================================================================================================================================
        //=============================================================================================================================================================================
        //=============================================================================================================================================================================
        //=============================================================================================================================================================================














    }
}
