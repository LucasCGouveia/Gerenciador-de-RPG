using Gerenciador.Entities;
using Gerenciador.Repository.BancoDados;
using System.Data;

namespace Gerenciador.Repository
{
    public class AtributosRepository
    {
        Resultado resultado = new Resultado();
        public DataTable GetCodAtributos()
        {
            string strQuery;
            strQuery = ("SELECT COD,COD_PERSONAGEM from TB_ATRIBUTOS ");
            CldBancoDados ObjBancoDados = new CldBancoDados();
            return ObjBancoDados.RetornaDataTable(strQuery);
        }
        public Resultado Gravar(Tb_Atributos tb_Atributos)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TB_ATRIBUTOS ";
            strQuery += ("(");
            strQuery += ("FORC");
            strQuery += (",DEST");
            strQuery += (",CONS");
            strQuery += (",INTE");
            strQuery += (",SABE");
            strQuery += (",CARI");
            strQuery += (",DATAATUALIZACAO");
            strQuery += (",COD_PERSONAGEM");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("" + tb_Atributos.FORC);
            strQuery += ("," + tb_Atributos.DESC);
            strQuery += ("," + tb_Atributos.CONS);
            strQuery += ("," + tb_Atributos.INTE);
            strQuery += ("," + tb_Atributos.SABE);
            strQuery += ("," + tb_Atributos.CARI);
            strQuery += (",'" + tb_Atributos.DataAtualizacao + "'");
            strQuery += ("," + tb_Atributos.CodigoPersonagem);
            strQuery += (",1");
            strQuery += (")");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Editar(Tb_Atributos tb_Atributos)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_ATRIBUTOS ");
            strQuery += (" SET ");
            strQuery += (" FORC = " + tb_Atributos.FORC );
            strQuery += (" ,DEST = " + tb_Atributos.DESC);
            strQuery += (" ,CONS = " + tb_Atributos.CONS);
            strQuery += (" ,INTE = " + tb_Atributos.INTE);
            strQuery += (" ,SABE = " + tb_Atributos.SABE);
            strQuery += (" ,CARI = " + tb_Atributos.CARI);
            strQuery += (" ,DataAtualizacao = '" + tb_Atributos.DataAtualizacao + "' ");
            //strQuery += (" CodigoPersonagem = '" + tb_Atributos.CodigoPersonagem + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Atributos.Codigo + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
    }
}
