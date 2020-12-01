using Gerenciador.Repository.BancoDados;
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
    public class UsuarioRepository
    {
        Resultado resultado = new Resultado();
        public DataSet ListarDataGrid(string LOGIN) //Recebe o código p/ procura
        {
            string strQuery;
            if (LOGIN == "")
            {
                strQuery = ("SELECT COD,LOGIN,TIPOUSER,ATIVO from TB_USUARIOS WHERE LOGIN != 'ADM'");
            }
            else
            {
                strQuery = ("SELECT COD,LOGIN,TIPOUSER from TB_USUARIOS WHERE LOGIN LIKE '% " + LOGIN + "%' AND LOGIN =! ADM");
            }
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataTable GetUsuarioVinculado() //Recebe o código p/ procura
        {
            string strQuery;
            strQuery = ("SELECT U.COD,U.LOGIN from DBSK002..TB_USUARIOS as U ");
            strQuery += ("INNER JOIN DBSK002..TB_JOGADORES as J ");
            strQuery += ("on U.COD = J.COD_USUARIO where U.ATIVO = 1");
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataTable(strQuery);//Return a consulta tipo SqlDataReader
        }
        public DataTable GetCodigoMestre() //Recebe o código p/ procura
        {
            string strQuery = "select COD,LOGIN from TB_USUARIOS";
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataTable(strQuery);//Return a consulta tipo SqlDataReader
        }
        public DataTable GetCodigoUsuario() //Recebe o código p/ procura
        {
            string strQuery = "select COD,LOGIN from TB_USUARIOS";
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
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
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataTable GetUsuarios() //Recebe o código p/ procura
        {
            string strQuery = "select * from TB_USUARIOS";
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataTable(strQuery);//Return a consulta tipo SqlDataReader
        }
        public Resultado Ativar(int codigo)
        {
            string strQuery;
            strQuery = (" UPDATE TB_USUARIOS ");
            strQuery += (" SET ");
            strQuery += (" ATIVO = '" + 1 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + codigo + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Desativar(int codigo)
        {
            string strQuery;
            strQuery = (" UPDATE TB_USUARIOS ");
            strQuery += (" SET ");
            strQuery += (" ATIVO = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + codigo + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Excluir(int _COD)
        {
            string strQuery;
            strQuery = ("DELETE FROM TB_USUARIOS ");
            strQuery += (" WHERE ");
            strQuery += (" cod = '" + _COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Gravar(Tb_Usuarios tb_Usuarios)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TB_USUARIOS ";
            strQuery += ("(");
            strQuery += ("LOGIN");
            strQuery += (",SENHA");
            strQuery += (",TIPOUSER");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Usuarios.Login + "'");
            strQuery += (",'" + tb_Usuarios.Senha + "'");
            strQuery += (",'" + tb_Usuarios.TipoLogin + "'");
            strQuery += (",1");
            strQuery += (")");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Editar(Tb_Usuarios tb_Usuarios)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_USUARIOS ");
            strQuery += (" SET ");
            strQuery += (" LOGIN = '" + tb_Usuarios.Login + "' ");
            strQuery += (" ,SENHA = '" + tb_Usuarios.Senha + "' ");
            strQuery += (" ,TIPOUSER = '" + tb_Usuarios.Senha + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Usuarios.Codigo + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }


















    }
}
