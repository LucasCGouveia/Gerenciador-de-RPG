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
    public class JogadoresRepository
    {
        Resultado resultado = new Resultado();
        public DataTable GetCODJogador()
        {
            string strQuery;
            strQuery = ("SELECT J.COD,U.LOGIN from DBSK002..TB_USUARIOS as U ");
            strQuery += ("INNER JOIN DBSK002..TB_JOGADORES as J ");
            strQuery += ("on U.COD = J.COD_USUARIO where U.ATIVO = 1");
            CldBancoDados ObjBancoDados = new CldBancoDados();
            return ObjBancoDados.RetornaDataTable(strQuery);
        }
        public Resultado Desativar(int COD)
        {
            string strQuery;
            strQuery = (" UPDATE TB_JOGADORES ");
            strQuery += (" SET ");
            strQuery += (" Ativo = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }
        public Resultado Excluir(int COD)
        {
            string strQuery;
            strQuery = ("DELETE FROM TB_JOGADORES ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }
        public Resultado Gravar(Tb_Jogadores tb_Jogadores)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TB_JOGADORES ";
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
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
        //================================================================

        public Resultado Editar(Tb_Jogadores tb_Jogadores)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_JOGADORES ");
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
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }





















    }
}
