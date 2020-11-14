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
    public class ItensRepository
    {

        private int _COD;
        private int _COD_FUNC;
        private string _TIPO;
        private string _CONTATO;
        private string _OBS;
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
        public string TIPO
        {
            get { return _TIPO; }
            set { _TIPO = value; }//Letras maiusculas
        }
        //================================================================
        public string CONTATO
        {
            get { return _CONTATO; }
            set { _CONTATO = value; }//Letras maiusculas

        }
        //================================================================
        public string OBS
        {
            get { return _OBS; }
            set { _OBS = value; }//Letras maiusculas

        }
        //================================================================
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
        public DataSet ListarContatos(string COD_FUNC)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = "select C.COD,C.TIPO,C.CONTATO,C.OBSERVACAO from tb_CONTATOS as C Inner JOIN tb_UserDefinitivo as F on C.cod_FUNC = F.Cod where C.COD_FUNC = " + COD_FUNC;//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }

        //==================================================================================================================
        public DataSet ListarComboTiposContatos()//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = "Select COD,TIPO From Tb_TipoContatos";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
        public DataSet ListarTiposContatos(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "Select COD,TIPO From TB_TIPOCONTATOS WHERE TIPO = '" + strDescricao + "' and ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "Select COD,TIPO From TB_TIPOCONTATOS where ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)

            }
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
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
            strQuery = ("DELETE FROM tb_CONTATOS ");
            strQuery += (" WHERE ");
            strQuery += (" cod = '" + _COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        //================================================================
        public void ExcluirTipoContato(int _COD)
        {
            string strQuery;
            strQuery = ("DELETE FROM Tb_TipoContatos ");
            strQuery += (" WHERE ");
            strQuery += (" cod = '" + _COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }
        //================================================================
        public void Gravar()
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TB_CONTATOS ";
            strQuery += ("(");
            strQuery += ("COD_FUNC");
            strQuery += (",TIPO");
            strQuery += (",CONTATO");
            strQuery += (",OBSERVACAO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += (" " + _COD_FUNC + " ");
            strQuery += (",'" + _TIPO + "'");
            strQuery += (",'" + _CONTATO + "'");
            strQuery += (",'" + _OBS + "'");
            strQuery += (")");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }
        //================================================================
        public void GravarTipoContato()
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO Tb_TipoContatos ";
            strQuery += ("(");
            strQuery += ("TIPO");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + _TIPO + "'");
            strQuery += (",1");
            strQuery += (")");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }
        //================================================================AlterarTipoContato
        public void Alterar()
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_CONTATOS ");
            strQuery += (" SET ");
            strQuery += (" TIPO = '" + _TIPO + "' ");
            strQuery += (" ,CONTATO = '" + _CONTATO + "' ");
            strQuery += (" ,OBSERVACAO = '" + _OBS + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + _COD + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        public void AlterarTipoContato()
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE Tb_TipoContatos ");
            strQuery += (" SET ");
            strQuery += (" TIPO = '" + _TIPO + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + _COD + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }





















    }
}
