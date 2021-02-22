using System;
using System.Collections.Generic;
using System.Data;//Importar ADO
using System.Linq;
using Gerenciador.Entities;

namespace Gerenciador.Repository
{
    public class CampanhasRepository : RepositoryBase<TabCampanhas>
    {
        Resultado resultado = new Resultado();
        public DataSet ListarDataGrid(int CodigoMestre)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = "Select COD,NOMECAMPANHA,SISTEMA,DESCRICAO From TabCampanhas WHERE ATIVO = 1 and COD_MESTRE = " + CodigoMestre;//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataSet ListarDataGridPersonagensMesa(int Codigo)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = ("Select P.COD,NOME,RACA,CLASSE,ALINHAMENTO,CA,PVTOTAL,PVATUAL,PATAQUE,INICIATIVA,DINHEIRO,EXPERIENCIA,NIVEL,A.FORC,A.DEST,A.CONS,A.INTE,A.SABE,A.CARI,HISTORIA ");
            strQuery += (" From TabPersonagens as P");
            strQuery += (" INNER JOIN TabAtributos as A on A.COD_PERSONAGEM = P.COD");
            strQuery += (" WHERE P.ATIVO = 1 and COD_CAMPANHA = " + Codigo + "ORDER BY INICIATIVA DESC");
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public List<TabCampanhas> ListarCampanhasMestre(int pId)
        {
            try
            {
                // if (obj != null && !((int)obj.GetType().GetProperty("Ativo").GetValue(obj) == 0))
                List<TabCampanhas> ListaCampanhas = Db.TabCampanhas.Where(x => x.COD_MESTRE == pId)
                    .Where(x => x.ATIVO == 1).ToList();


                return ListaCampanhas;
                throw new Exception("Nenhum registro encontrado.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable VerificarCampanhas() //Recebe o código p/ procura
        {
            string strQuery = "select COD_MESTRE from TB_CAMPANHAS";
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia BancoDeDados, criar Obj
            return ObjBancoDados.RetornaDataTable(strQuery);//Return a consulta tipo SqlDataReader
        }


























        public DataSet ListarCargosCadCargos(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "Select COD,CARGO,SALARIO From TabCampanhas WHERE CARGO = '" + strDescricao + "' and ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "Select COD,Cargo,Salario From TabCampanhas where ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)

            }
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public Resultado Desativar(int codigo)
        {
            string strQuery;
            strQuery = (" UPDATE TabCampanhas ");
            strQuery += (" SET ");
            strQuery += (" ATIVO = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + codigo + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        //Alterar o código informado para que o Ativo=0, não apresenta o dado

        //public void Excluir(int _COD)
        //{
        //    string strQuery;
        //    strQuery = ("UPDATE Tb_Cargos ");
        //    strQuery += (" SET ");
        //    strQuery += (" Ativo = '" + 0 + "' ");
        //    strQuery += (" WHERE ");
        //    strQuery += (" cod = '" + _COD + "' ;");
        //    CldBancoDados ObjCldBancoDados = new CldBancoDados();
        //    ObjCldBancoDados.ExecutaComando(strQuery);
        //}

        //================================================================


        public Resultado Gravar(TabCampanhas tb_Campanhas)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TabCampanhas ";
            strQuery += ("(");
            strQuery += ("NOMECAMPANHA");
            strQuery += (",SISTEMA");
            strQuery += (",DESCRICAO");
            strQuery += (",COD_MESTRE");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Campanhas.NOMECAMPANHA + "'");
            strQuery += (",'" + tb_Campanhas.SISTEMA + "'");
            strQuery += (",'" + tb_Campanhas.DESCRICAO + "'");
            strQuery += ("," + tb_Campanhas.COD_MESTRE);
            strQuery += (",1");
            strQuery += (")");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        //public Resultado Editar(TabCampanhas tb_Campanhas)
        //{
        //    string strQuery; //Criar a String para alterar
        //    strQuery = (" UPDATE TabCampanhas ");
        //    strQuery += (" SET ");
        //    strQuery += (" NOMECAMPANHA = '" + tb_Campanhas.NOMECAMPANHA + "' ");
        //    strQuery += (" SISTEMA = '" + tb_Campanhas.SISTEMA + "' ");
        //    strQuery += (" ,DESCRICAO = '" + tb_Campanhas.DESCRICAO + "' ");
        //    strQuery += (" WHERE ");
        //    strQuery += (" COD = " + tb_Campanhas.COD + " ");
        //    ConexaoDB ObjCldBancoDados = new ConexaoDB();
        //    resultado = ObjCldBancoDados.Executar(strQuery);
        //    return resultado;
        //}





















    }
}
