using Gerenciador.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Repository
{
    public class MissoesRepository : RepositoryBase<TabMissoes>
    {
        Resultado resultado = new Resultado();
        public DataSet ListarDataGrid(int codigo)
        {
            string strQuery = "Select COD,MISSAO,SOLICITANTE,XP,JADES,ITEM,CONCLUIDA,DETALHES,COD_MESTRE From TabMissoes WHERE COD_MESTRE = " + codigo;
            ConexaoDB ObjBancoDados = new ConexaoDB();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        public DataSet ListarDataGridMissoesAtivas(int codigo)
        {
            string strQuery = "Select COD,MISSAO,SOLICITANTE,XP,JADES,ITEM,CONCLUIDA,DETALHES,COD_MESTRE From TabMissoes WHERE COD_CAMPANHA = " + codigo + " AND CONCLUIDA = 'N' ";
            ConexaoDB ObjBancoDados = new ConexaoDB();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        //==================================================================================================================
        public DataSet ListarDataGridQuadroMissoes(string strDescricao, int codigoMestre)
        {
            string strQuery;
            if (strDescricao != "")
                strQuery = "Select COD,MISSAO,SOLICITANTE,XP,JADES,ITEM,DETALHES From TabMissoes WHERE MISSAO = like '" + strDescricao + "' and COD_MESTRE = " + codigoMestre + " AND COD_CAMPANHA is null ";
            else
                strQuery = "Select COD,MISSAO,SOLICITANTE,XP,JADES,ITEM,DETALHES From TabMissoes WHERE COD_MESTRE = " + codigoMestre + " AND COD_CAMPANHA is null";
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //public DataSet ListarDataGridQuadroMissoes(string strDescricao, int codigoMestre, int codigoCampanha)
        //{
        //    string strQuery;
        //    if (strDescricao != "")
        //    {
        //        strQuery = "Select MISSAO,SOLICITANTE,XP,JADES,DETALHES From Tb_Missoes WHERE MISSAO = like '" + strDescricao + "' and COD_MESTRE = " + codigoMestre + " COD_CAMPANHA = " + codigoCampanha;
        //    }
        //    else
        //    {
        //        strQuery = "Select COD,Cargo,Salario From Tb_Cargos where ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)

        //    }
        //    CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
        //    return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        //}
        //public Resultado Desativar(int codigo)
        //{
        //    string strQuery;
        //    strQuery = (" UPDATE TB_MISSOES ");
        //    strQuery += (" SET ");
        //    strQuery += (" ATIVO = '" + 0 + "' ");
        //    strQuery += (" WHERE ");
        //    strQuery += (" COD = '" + codigo + "' ;");
        //    CldBancoDados ObjCldBancoDados = new CldBancoDados();
        //    resultado = ObjCldBancoDados.Executar(strQuery);

        //    return resultado;
        //}
        //public Resultado Excluir(int codigo)
        //{
        //    string strQuery;
        //    strQuery = (" DELETE FROM TabMissoes ");
        //    strQuery += (" WHERE ");
        //    strQuery += (" COD = '" + codigo + "' ;");
        //    ConexaoDB ObjCldBancoDados = new ConexaoDB();
        //    resultado = ObjCldBancoDados.Executar(strQuery);

        //    return resultado;
        //}
        public Resultado Gravar(TabMissoes tb_Missoes)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TabMissoes ";
            strQuery += ("(");
            strQuery += ("MISSAO");
            strQuery += (",SOLICITANTE");
            strQuery += (",XP");
            strQuery += (",JADES");
            strQuery += (",ITEM");
            strQuery += (",CONCLUIDA");
            strQuery += (",DETALHES");
            strQuery += (",COD_CAMPANHA");
            strQuery += (",COD_MESTRE");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Missoes.MISSAO + "'");
            strQuery += (",'" + tb_Missoes.SOLICITANTE + "'");
            strQuery += ("," + tb_Missoes.XP + "");
            strQuery += ("," + tb_Missoes.JADES + "");
            strQuery += (",'" + tb_Missoes.ITEM + "'");
            strQuery += (",'N'");
            strQuery += (",'" + tb_Missoes.DETALHES + "'");
            strQuery += (",null");
            strQuery += ("," + tb_Missoes.COD_MESTRE + "");
            strQuery += (")");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        //public Resultado Editar(TabMissoes tb_Missoes)
        //{
        //    string strQuery; //Criar a String para alterar
        //    strQuery = (" UPDATE TabMissoes ");
        //    strQuery += (" SET ");
        //    strQuery += (" MISSAO = '" + tb_Missoes.MISSAO + "' ");
        //    strQuery += (" ,SOLICITANTE = '" + tb_Missoes.SOLICITANTE + "' ");
        //    strQuery += (" ,XP = '" + tb_Missoes.XP + "' ");
        //    strQuery += (" ,JADES = '" + tb_Missoes.JADES + "' ");
        //    strQuery += (" ,ITEM = '" + tb_Missoes.ITEM + "' ");
        //    strQuery += (" ,DETALHES = '" + tb_Missoes.DETALHES + "' ");
        //    strQuery += (" WHERE ");
        //    strQuery += (" COD = " + tb_Missoes.COD + " ");
        //    ConexaoDB ObjCldBancoDados = new ConexaoDB();
        //    resultado = ObjCldBancoDados.Executar(strQuery);
        //    return resultado;
        //}
        public Resultado AtribuirMissaoCampanha(TabMissoes tb_Missoes)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TabMissoes ");
            strQuery += (" SET ");
            strQuery += (" COD_CAMPANHA = " + tb_Missoes.COD_CAMPANHA + " ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Missoes.COD + " ");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
        public Resultado ConcluirMissao(TabMissoes tb_Missoes)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TabMissoes ");
            strQuery += (" SET ");
            strQuery += (" CONCLUIDA = '" + tb_Missoes.CONCLUIDA + "'");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Missoes.COD + " ");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
    }
}
