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
    public class SkillsRepository
    {

        private int _COD;
        private int _COD_FUNC;
        private string _DESCRICAO;
        private string _CEP;
        private string _ENDERECO;
        private string _NUMERO;
        private string _COMPLEMENTO;
        private string _BAIRRO;
        private string _CIDADE;
        private string _ESTADO;
        //private int _ATIVO;
        private int _linhas;
        private int _excluir;//1 ativo, 0 desativado
        //================================================================
        public int COD
        {
            get { return _COD; }
            set { _COD = value; }//Letras maiusculas

        }
        public int COD_FUNC
        {
            get { return _COD_FUNC; }
            set { _COD_FUNC = value; }//Letras maiusculas

        }
        public string DESCRICAO
        {
            get { return _DESCRICAO; }
            set { _DESCRICAO = value; }//Letras maiusculas
        }
        //================================================================
        public string CEP
        {
            get { return _CEP; }
            set { _CEP = value; }//Letras maiusculas

        }
        //================================================================
        public string ENDERECO
        {
            get { return _ENDERECO; }
            set { _ENDERECO = value; }//Letras maiusculas

        }
        //================================================================
        public string NUMERO
        {
            get { return _NUMERO; }
            set { _NUMERO = value; }//Letras maiusculas

        }
        //================================================================
        public string COMPLEMENTO
        {
            get { return _COMPLEMENTO; }
            set { _COMPLEMENTO = value; }//Letras maiusculas

        }
        //================================================================
        public string BAIRRO
        {
            get { return _BAIRRO; }
            set { _BAIRRO = value.ToUpper(); }//Letras maiusculas

        }
        //================================================================
        public string CIDADE
        {
            get { return _CIDADE; }
            set { _CIDADE = value; }//Letras maiusculas
        }
        //================================================================
        public string ESTADO
        {
            get { return _ESTADO; }
            set { _ESTADO = value.ToUpper(); }//Letras maiusculas

        }
        //public int ATIVO
        //{
        //    get { return _ATIVO; }
        //    set { _ATIVO = value; }//Letras maiusculas
        //}
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
        //public IDataReader Listar()//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        //{
        //    string strQuery;
        //    strQuery = "Select COD,LOGIN From TB_USUARIO";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
        //    CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
        //    return ObjBancoDados.RetornaDataReader(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        //}
        ////==================================================================================================================
        public DataSet ListarEnderecos(string COD_FUNC)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = "select E.COD,E.DESCRICAO,E.CEP,E.ENDERECO,E.NUMERO,E.COMPLEMENTO,E.BAIRRO,E.CIDADE,E.ESTADO from tb_Enderecos as E Inner JOIN tb_UserDefinitivo as F on E.cod_FUNC = F.Cod where E.COD_FUNC = " + COD_FUNC;//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
        public IDataReader ListarUsuario(string NOME_LOGIN, string SENHA_LOGIN) //Recebe o código p/ procura
        {
            string strQuery = "select * from tb_Usuario where LOGIN = '" + NOME_LOGIN + "' and SENHA ='" + SENHA_LOGIN + "'";
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataReader(strQuery);//Return a consulta tipo SqlDataReader
        }
        //===============================================================================================================

        //Alterar o código informado para que o Ativo=0, não apresenta o dado

        //public void ExcluirLogicamente()
        //{
        //    string strQuery;
        //    strQuery = (" UPDATE JOGADOR ");
        //    strQuery += (" SET ");
        //    strQuery += ("'COD_JOG =' " + _COD);
        //    strQuery += (" Ativo = '" + 0 + "' ");
        //    strQuery += (" WHERE ");
        //    strQuery += (" cod = '" + _COD + "' ;");
        //    CldBancoDados ObjCldBancoDados = new CldBancoDados();
        //    ObjCldBancoDados.ExecutaComando(strQuery);
        //}

        //================================================================

        //Alterar o código informado para que o Ativo=0, não apresenta o dado

        public void Excluir(int _COD)
        {
            string strQuery;
            strQuery = ("DELETE FROM Tb_Enderecos ");
            strQuery += (" WHERE ");
            strQuery += (" cod = '" + _COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        //================================================================


        public void Gravar()
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TB_ENDERECOS ";
            strQuery += ("(");
            strQuery += ("COD_FUNC");
            strQuery += (",DESCRICAO");
            strQuery += (",CEP");
            strQuery += (",ENDERECO");
            strQuery += (",NUMERO");
            strQuery += (",COMPLEMENTO");
            strQuery += (",BAIRRO");
            strQuery += (",CIDADE");
            strQuery += (",ESTADO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += (" " + _COD_FUNC + " ");
            strQuery += (",'" + _DESCRICAO + "'");
            strQuery += (",'" + _CEP + "'");
            strQuery += (",'" + _ENDERECO + "'");
            strQuery += (",'" + _NUMERO + "'");
            strQuery += (",'" + _COMPLEMENTO + "'");
            strQuery += (",'" + _BAIRRO + "'");
            strQuery += (",'" + _CIDADE + "'");
            strQuery += (",'" + _ESTADO + "'");
            strQuery += (")");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }
        //================================================================

        public void Alterar()
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE tb_enderecos ");
            strQuery += (" SET ");
            strQuery += (" DESCRICAO = '" + _DESCRICAO + "' ");
            strQuery += (" ,CEP = '" + _CEP + "' ");
            strQuery += (" ,ENDERECO = '" + _ENDERECO + "' ");
            strQuery += (" ,NUMERO = '" + _NUMERO + "' ");
            strQuery += (" ,COMPLEMENTO = '" + _COMPLEMENTO + "' ");
            strQuery += (" ,BAIRRO = '" + _BAIRRO + "' ");
            strQuery += (" ,CIDADE = '" + _CIDADE + "' ");
            strQuery += (" ,ESTADO = '" + _ESTADO + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + _COD + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }





















    }
}
