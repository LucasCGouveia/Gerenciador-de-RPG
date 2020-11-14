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
    public class UserDefinitivoRepository
    {

        private int _COD;
        private int _COD_USUARIO;
        private string _DataInclusao;
        private string _NOME;
        private string _NASCIMENTO;
        private string _RG;
        private string _CPF;
        private string _DATAADMISSAO;
        private int _COD_CARGO;
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
        public int COD_USUARIO
        {
            get { return _COD_USUARIO; }
            set { _COD_USUARIO = value; }//Letras maiusculas

        }
        public string DataInclusao
        {
            get { return _DataInclusao; }
            set { _DataInclusao = value; }//Letras maiusculas
        }
        //================================================================
        public string NOME
        {
            get { return _NOME; }
            set { _NOME = value.ToUpper(); }//Letras maiusculas

        }
        //================================================================
        public string NASCIMENTO
        {
            get { return _NASCIMENTO; }
            set { _NASCIMENTO = value.ToUpper(); }//Letras maiusculas

        }
        //================================================================
        public string RG
        {
            get { return _RG; }
            set { _RG = value.ToUpper(); }//Letras maiusculas

        }
        //================================================================
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value.ToUpper(); }//Letras maiusculas

        }
        //================================================================
        public string DATAADMISSAO
        {
            get { return _DATAADMISSAO; }
            set { _DATAADMISSAO = value.ToUpper(); }//Letras maiusculas

        }
        //================================================================
        public int COD_CARGO
        {
            get { return _COD_CARGO; }
            set { _COD_CARGO = value; }//Letras maiusculas
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
        public DataSet ListarFuncionarios(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "select F.COD,F.NOME,F.NASCIMENTO,F.RG,F.CPF,C.Cargo,F.Salario,F.DATAADMISSAO from tb_FuncionarioS as F Inner JOIN Tb_Cargos as C on F.cod_cargo = C.Cod  WHERE NOME like '%" + strDescricao + "%' and F.ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "select F.COD,F.NOME,F.NASCIMENTO,F.RG,F.CPF,C.Cargo,F.Salario,F.DATAADMISSAO from tb_FuncionarioS as F Inner JOIN Tb_Cargos as C on F.cod_cargo = C.Cod where F.ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)

            }
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
        //==================================================================================================================
        public DataSet ListarFuncionariosExcluidos(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "select F.COD,F.NOME,F.NASCIMENTO,F.RG,F.CPF,C.Cargo,F.Salario,F.DATAADMISSAO from tb_FuncionarioS as F Inner JOIN Tb_Cargos as C on F.cod_cargo = C.Cod  WHERE NOME like '%" + strDescricao + "%' and F.ATIVO = 0";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "select F.COD,F.NOME,F.NASCIMENTO,F.RG,F.CPF,C.Cargo,F.Salario,F.DATAADMISSAO from tb_FuncionarioS as F Inner JOIN Tb_Cargos as C on F.cod_cargo = C.Cod where F.ATIVO = 0";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)

            }
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
        public DataSet ListarFuncSemUser() //Recebe o código p/ procura
        {
            string strQuery = "select * from tb_UserDefinitivo where COD_USUARIO = 1 and ATIVO = 1";
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataSet(strQuery);//Return a consulta tipo SqlDataReader
        }
        //===============================================================================================================
        //===============================================================================================================
        public DataSet ListarFuncComUser() //Recebe o código p/ procura
        {
            string strQuery = "select * from tb_UserDefinitivo where COD_USUARIO != 1 and ATIVO = 1";
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataSet(strQuery);//Return a consulta tipo SqlDataReader
        }
        //===============================================================================================================

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
        public void AtivarFunc(int _COD)
        {
            string strQuery;
            strQuery = (" UPDATE tb_UserDefinitivo ");
            strQuery += (" SET ");
            strQuery += (" Ativo = '" + 1 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" cod = '" + _COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        //================================================================

        public void AtribuirUserFunc(int _COD_USUARIO, int _COD)
        {
            string strQuery;
            strQuery = (" UPDATE Tb_Funcionarios ");
            strQuery += (" SET ");
            strQuery += ("COD_USUARIO = " + _COD_USUARIO);
            strQuery += (" WHERE ");
            strQuery += (" cod = " + _COD + " ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        //================================================================
        //================================================================

        public void DesatribuirUserFunc(int _COD)
        {
            string strQuery;
            strQuery = (" UPDATE Tb_Funcionarios ");
            strQuery += (" SET ");
            strQuery += ("COD_USUARIO = 1 ");
            strQuery += (" WHERE ");
            strQuery += (" cod = " + _COD + " ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        //================================================================

        //Alterar o código informado para que o Ativo=0, não apresenta o dado

        public void Excluir(int _COD)
        {
            string strQuery;
            strQuery = ("UPDATE Tb_Usuario ");
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
            strQuery = " INSERT INTO TB_FUNCIONARIOS ";
            strQuery += ("(");
            strQuery += ("COD_USUARIO");
            strQuery += (",DATAINCLUSAO");
            strQuery += (",NOME");
            strQuery += (",NASCIMENTO");
            strQuery += (",RG");
            strQuery += (",CPF");
            strQuery += (",DATAADMISSAO");
            strQuery += (",COD_CARGO");
            strQuery += (",SALARIO");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("1");
            strQuery += (",GETDATE()");
            strQuery += (",'" + _NOME + "'");
            strQuery += (",'" + _NASCIMENTO + "'");
            strQuery += (",'" + _RG + "'");
            strQuery += (",'" + _CPF + "'");
            strQuery += (",'" + _DATAADMISSAO + "'");
            strQuery += (",'" + _COD_CARGO + "'");
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
            strQuery = (" UPDATE Tb_funcionarios ");
            strQuery += (" SET ");
            strQuery += (" NOME = '" + _NOME + "' ");
            strQuery += (" ,NASCIMENTO = '" + _NASCIMENTO + "' ");
            strQuery += (" ,RG = '" + _RG + "' ");
            strQuery += (" ,CPF = '" + _CPF + "' ");
            strQuery += (" ,DATAADMISSAO = '" + _DATAADMISSAO + "' ");
            strQuery += (" ,COD_CARGO = '" + _COD_CARGO + "' ");
            strQuery += (" ,SALARIO = '" + _SALARIO + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + _COD + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }





















    }
}
