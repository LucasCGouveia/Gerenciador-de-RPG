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
    public class RacasRepository
    {

        private int _COD;
        private string _CARGO;
        private string _SALARIO;
        private int _ATIVO;
        private int _linhas;
        private int _excluir;//1 ativo, 0 desativado
        //================================================================
        public int COD
        {
            get { return _COD; }
            set { _COD = value; }//Letras maiusculas

        }
        public string CARGO
        {
            get { return _CARGO; }
            set { _CARGO = value.ToUpper(); }//Letras maiusculas
        }
        //================================================================
        public string SALARIO
        {
            get { return _SALARIO; }
            set { _SALARIO = value.ToUpper(); }//Letras maiusculas

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
            strQuery = "Select COD,LOGIN From TB_USUARIO";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataReader(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
        public DataSet ListarCargosCadCargos(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "Select COD,CARGO,SALARIO From Tb_Cargos WHERE CARGO = '" + strDescricao + "' and ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "Select COD,Cargo,Salario From Tb_Cargos where ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)

            }
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
        public DataSet ListarCargosCombo()//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = "Select COD,Cargo From Tb_Cargos";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
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
            strQuery = ("UPDATE Tb_Cargos ");
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
            strQuery = " INSERT INTO TB_CARGOS ";
            strQuery += ("(");
            strQuery += ("CARGO");
            strQuery += (",SALARIO");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + _CARGO + "'");
            strQuery += (",'" + _SALARIO + "'");
            strQuery += (",1");
            strQuery += (")");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }
        //================================================================

        public void Alterar()
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_CARGOS ");
            strQuery += (" SET ");
            strQuery += (" Cargo = '" + _CARGO + "' ");
            strQuery += (" ,Salario = '" + _SALARIO + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + _COD + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }





















    }
}
