using Gerenciador.Repository.BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data;//Importar ADO
using System.Data.SqlClient; //Importar SQLusing System.Data;
using System.Drawing;

namespace Gerenciador.Repository
{
    public class UsuarioRepository
    {

        private int _COD;
        private string _LOGIN;
        private string _SENHA;
        private string _TIPOUSER;
        private int _ATIVO;
        private int _linhas;
        private int _excluir;//1 ativo, 0 desativado
        //================================================================
        public int COD
        {
            get { return _COD; }
            set { _COD = value; }//Letras maiusculas

        }
        public string LOGIN
        {
            get { return _LOGIN; }
            set { _LOGIN = value.ToUpper(); }//Letras maiusculas
        }
        //================================================================
        public string SENHA
        {
            get { return _SENHA; }
            set { _SENHA = value.ToUpper(); }//Letras maiusculas

        }
        //================================================================
        public string TIPOUSER
        {
            get { return _TIPOUSER; }
            set { _TIPOUSER = value.ToUpper(); }//Letras maiusculas

        }
        public int ATIVO
        {
            get { return _ATIVO; }
            set { _ATIVO = value; }//Letras maiusculas
        }
        //===============================================================
        public int linhas
        {
            get { return _linhas; }//Controle nr das linhas
            set { _linhas = value; }
        }
        //================================================================
        public int excluir
        {
            get { return _excluir; }//Controle nr das linhas
            set { _excluir = value; }
        }
        //================================================================
        public IDataReader Listar()//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = "Select COD,LOGIN From TB_USUARIOS";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataReader(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
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
        //==================================================================================================================
        //==================================================================================================================

        //==================================================================================================================
        public DataSet ListarUsuariosDesativados(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "SELECT U.COD,U.LOGIN from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD != F.COD_USUARIO where U.LOGIN like '%" + strDescricao + "%' and LOGIN != 'null' and U.ATIVO = 0";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "SELECT U.COD,U.LOGIN from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD != F.COD_USUARIO where LOGIN != 'null' and U.ATIVO = 0";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
        //==================================================================================================================
        //==================================================================================================================
        public DataSet ListarUsuariosNaoADM(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "SELECT U.COD,U.LOGIN from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD = F.COD_USUARIO where U.LOGIN like '%" + strDescricao + "%' and U.TipoUser != 'A' and Login != 'null' and U.ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "SELECT U.COD,U.LOGIN from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD = F.COD_USUARIO where U.TipoUser != 'A' and Login != 'null' and U.ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
        //==================================================================================================================
        public DataSet ListarUserAtribuidos(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "SELECT U.COD,U.LOGIN,F.COD,F.NOME from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD = F.COD_USUARIO where U.LOGIN like '%" + strDescricao + "%' and U.ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "SELECT U.COD,U.LOGIN,F.COD,F.NOME from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD = F.COD_USUARIO where U.ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
        //==================================================================================================================
        //==================================================================================================================
        public DataSet ListarUsuariosCadUsuario(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "SELECT U.COD,U.LOGIN from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD != F.COD_USUARIO where U.LOGIN like '%" + strDescricao + "%' and U.TIPOUSER != 'A' U.ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "SELECT U.COD,U.LOGIN from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD != F.COD_USUARIO where U.TIPOUSER != 'A' and U.ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
        public IDataReader ListarUsuarioBloqueado(string NOME_LOGIN, string SENHA_LOGIN) //Recebe o código p/ procura
        {
            string strQuery = "select * from TB_USUARIOS where LOGIN = '" + NOME_LOGIN + "' and SENHA ='" + SENHA_LOGIN + "' and ATIVO = 0";
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataReader(strQuery);//Return a consulta tipo SqlDataReader
        }
        //===============================================================================================================
        public IDataReader ListarUsuario(string NOME_LOGIN, string SENHA_LOGIN) //Recebe o código p/ procura
        {
            string strQuery = "select * from TB_USUARIOS where LOGIN = '" + NOME_LOGIN + "' and SENHA ='" + SENHA_LOGIN + "' and ATIVO = 1";
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataReader(strQuery);//Return a consulta tipo SqlDataReader
        }
        //===============================================================================================================
        public IDataReader ListarUserAdmin(string NOME_LOGIN, string SENHA_LOGIN, string TIPO_LOGIN) //Recebe o código p/ procura
        {
            string strQuery = "select * from TB_USUARIOS where LOGIN = '" + NOME_LOGIN + "' and SENHA ='" + SENHA_LOGIN + "' and TIPOUSER = '" + TIPO_LOGIN + "' and ATIVO = 1";
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataReader(strQuery);//Return a consulta tipo SqlDataReader
        }
        //Alterar o código informado para que o Ativo=0, não apresenta o dado

        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" UPDATE JOGADOR ");
            strQuery += (" SET ");
            strQuery += ("'COD_JOG =' " + _COD);
            strQuery += (" Ativo = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" cod = '" + _COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        //================================================================

        public void AtivarUsuario(int _COD)
        {
            string strQuery;
            strQuery = (" UPDATE TB_USUARIOS ");
            strQuery += (" SET ");
            strQuery += (" Ativo = '" + 1 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + _COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        //================================================================

        public void AtivarUsuarioADM(int _COD)
        {
            string strQuery;
            strQuery = (" UPDATE TB_USUARIOS ");
            strQuery += (" SET ");
            strQuery += (" TipoUser = 'A' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + _COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        //================================================================

        //Alterar o código informado para que o Ativo=0, não apresenta o dado

        public void Excluir(int _COD)
        {
            string strQuery;
            strQuery = ("UPDATE tb_funcionarios ");
            strQuery += (" SET ");
            strQuery += (" Ativo = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" cod = '" + _COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        //================================================================


        public void Gravar()
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
            strQuery += ("'" + _LOGIN + "'");
            strQuery += (",'" + _SENHA + "'");
            strQuery += (",'" + _TIPOUSER + "'");
            strQuery += (",1");
            strQuery += (")");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }
        //================================================================

        public void Alterar()
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_USUARIOS ");
            strQuery += (" SET ");
            strQuery += (" LOGIN = '" + _LOGIN + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + _COD + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }





















    }
}
