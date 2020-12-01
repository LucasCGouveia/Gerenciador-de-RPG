using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient; //Importar SQL
using Gerenciador.Entities;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
//using System.Threading.Tasks;


namespace Gerenciador.Repository.BancoDados
{
    public class CldBancoDados
    {
        Resultado resultado = new Resultado();
        public static ClnFuncoesGerais.Operacao ObjOperacao;//Variável Enum Cep
        public ClnFuncoesGerais.Operacao EnumProperty//Propriedade p guardar Cep
        {
            get { return ObjOperacao; }
            set { ObjOperacao = value; }
        }
        //================================================================
        public static SqlConnection AbreBanco()
        {
            string StringConexao = @"Data Source=NOTNEWMIGHT\SQNPRD001;Initial Catalog=DBSK002;Persist Security Info=True;User ID=sa;Password=010921";
            try
            {
                SqlConnection conn = new SqlConnection(StringConexao);
                conn.ConnectionString = StringConexao;
                conn.Open();
                return conn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //================================================================
        public void FechaBanco(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //================================================================
        public DataSet RetornaDataSet(string strQuery)
        {
            SqlConnection conn;
            conn = AbreBanco();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmdComando = new SqlCommand(strQuery, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmdComando);
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw e;//or MessageBox(e.Message);
            }
            finally
            {
                FechaBanco(conn);
            }
        }
        //================================================================
        public IDataReader RetornaDataReader(string strQuery)
        {
            try
            {
                IDataReader dr;
                SqlCommand OracleComando = new SqlCommand(strQuery, AbreBanco());
                dr = OracleComando.ExecuteReader();
                return dr;
            }
            catch (Exception e)
            {
                throw e;//or MessageBox(e.Message);
            }
            //finally
            //{
            // //FechaBanco(conn);
            //}
        }
        //================================================================
        //================================================================
        public DataTable RetornaDataTable(string strQuery)
        {
            try
            {
                SqlCommand command;
                SqlDataAdapter dataAdapter;

                //Aqui você abre a conexão com o banco

                //Consulta
                command = new SqlCommand(strQuery, AbreBanco());

                //Intermediario recebe a respota do comandos sql enviado  
                dataAdapter = new SqlDataAdapter(command);

                //Estrutura da tabela 
                DataTable objDataTable = new DataTable();

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(objDataTable);

                return objDataTable;
            }
            catch (Exception e)
            {
                throw e;//or MessageBox(e.Message);
            }
        }

        //public IEnumerable<T> RetornaLista(string strQuery)
        //{
        //    try
        //    {
        //        SqlCommand command;
        //        SqlDataAdapter dataAdapter;

        //        //Aqui você abre a conexão com o banco

        //        //Consulta
        //        command = new SqlCommand(strQuery, AbreBanco());

        //        //Intermediario recebe a respota do comandos sql enviado  
        //        dataAdapter = new SqlDataAdapter(command);

        //        //Estrutura da tabela 
        //        List<Tb_Usuarios> objDataTable = new List<Tb_Usuarios>();

                
        //        return objDataTable;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;//or MessageBox(e.Message);
        //    }
        //    //finally
        //    //{
        //    // //FechaBanco(conn);
        //    //}
        //}
        public void ExecutaComando(string strQuery)
        {
            SqlConnection conn;
            conn = AbreBanco();
            try
            {
                SqlCommand sqlComm = new SqlCommand(strQuery, conn);
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally //Em caso de erro ou não, o finally é executado para fechar a conexao com bd
            {
                FechaBanco(conn);
            }
        }

        public Resultado Executar(string strQuery)
        {
            SqlConnection conn;
            conn = AbreBanco();
            try
            {
                SqlCommand sqlComm = new SqlCommand(strQuery, conn);
                sqlComm.ExecuteNonQuery();
                resultado.sucesso = true;
            }
            catch (Exception ex)
            {
                resultado.sucesso = false;
                resultado.exception = ex;
            }
            finally //Em caso de erro ou não, o finally é executado para fechar a conexao com bd
            {
                FechaBanco(conn);
            }
            return resultado;
        }







    }
}
