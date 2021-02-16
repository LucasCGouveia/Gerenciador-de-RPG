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
    public class JogadoresRepository : RepositoryBase<TabJogadores>
    {
        Resultado resultado = new Resultado();
        public DataTable GetCODJogador()
        {
            string strQuery;
            strQuery = ("SELECT J.COD,U.LOGIN from TabUsuarios as U ");
            strQuery += ("INNER JOIN TabJOgadores as J ");
            strQuery += ("on U.COD = J.COD_USUARIO where U.ATIVO = 1");
            ConexaoDB ObjBancoDados = new ConexaoDB();
            return ObjBancoDados.RetornaDataTable(strQuery);
        }
        public Resultado Desativar(int COD)
        {
            string strQuery;
            strQuery = (" UPDATE TabJOgadores ");
            strQuery += (" SET ");
            strQuery += (" Ativo = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + COD + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }
        public Resultado Excluir(int COD)
        {
            string strQuery;
            strQuery = ("DELETE FROM TabJOgadores ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + COD + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }
        public Resultado Gravar(TabJogadores tb_Jogadores)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TabJOgadores ";
            strQuery += ("(");
            strQuery += ("NOME");
            strQuery += (",NASCIMENTO");
            strQuery += (",RG");
            strQuery += (",CPF");
            strQuery += (",QTDPERSONAGENS");
            strQuery += (",DATAINCLUSAO");
            strQuery += (",COD_USUARIO");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Jogadores.NOME + "'");
            strQuery += (",'" + tb_Jogadores.NASCIMENTO + "'");
            strQuery += (",'" + tb_Jogadores.RG + "'");
            strQuery += (",'" + tb_Jogadores.CPF + "'");
            strQuery += (",'" + tb_Jogadores.QTDPERSONAGENS + "'");
            strQuery += (",'" + tb_Jogadores.DATAINCLUSAO + "'");
            strQuery += ("," + tb_Jogadores.COD_USUARIO );
            strQuery += (",1");
            strQuery += (")");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
        //================================================================

        public Resultado Editar(TabJogadores tb_Jogadores)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TabJOgadores ");
            strQuery += (" SET ");
            strQuery += (" NOME = '" + tb_Jogadores.NOME + "' ");
            strQuery += (" ,NASCIMENTO = '" + tb_Jogadores.NASCIMENTO + "' ");
            strQuery += (" ,RG = '" + tb_Jogadores.RG + "' ");
            strQuery += (" ,CPF = '" + tb_Jogadores.CPF + "' ");
            strQuery += (" ,QTDPERSONAGENS = '" + tb_Jogadores.QTDPERSONAGENS + "' ");
            //strQuery += (" ,DATAINCLUSAO = '" + tb_Jogadores.DATAINCLUSAO + "' ");
            //strQuery += (" ,COD_USUARIO = '" + tb_Jogadores.COD_USUARIO + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Jogadores.COD + " ");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }




        //========================================================================================================================================================================
        //========================================================================================================================================================================
        //========================================================================================================================================================================
        //========================================================================================================================================================================
        //========================================================================================================================================================================

        public TabJogadores ListarJogadorPorCodUsuario(int pId)
        {
            try
            {
                // if (obj != null && !((int)obj.GetType().GetProperty("Ativo").GetValue(obj) == 0))
                TabJogadores tabJogadores = Db.TabJogadores.Where(x => x.COD_USUARIO == pId)
                    .Where(x => x.ATIVO == 1).FirstOrDefault();


                return tabJogadores;
                throw new Exception("Nenhum registro encontrado.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //========================================================================================================================================================================
        //========================================================================================================================================================================
        //========================================================================================================================================================================
        //========================================================================================================================================================================
        //========================================================================================================================================================================














    }
}
