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
            strQuery = ("SELECT COD,COD_PERSONAGEM from TabAtributos ");
            ConexaoDB ObjBancoDados = new ConexaoDB();
            return ObjBancoDados.RetornaDataTable(strQuery);
        }
        public Resultado Gravar(TabAtributos tb_Atributos)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TabAtributos ";
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
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Editar(TabAtributos tb_Atributos)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TabAtributos ");
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
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
    }
}
