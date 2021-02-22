using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Repository
{
    public class PersonagensRepository : RepositoryBase<TabPersonagens>
    {
        Resultado resultado = new Resultado();
        TabPersonagens tb_Personagens = new TabPersonagens();
        public DataTable GetDadosPersonagem(TabPersonagens tb_Personagens)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = ("Select P.COD,NOME,RACA,CLASSE,ALINHAMENTO,CA,PVTOTAL,PVATUAL,PATAQUE,INICIATIVA,DINHEIRO,EXPERIENCIA,NIVEL,A.FORC,A.DEST,A.CONS,A.INTE,A.SABE,A.CARI,HISTORIA ");
            strQuery += (" From TabPersonagens as P");
            strQuery += (" INNER JOIN TabAtributos as A on A.COD_PERSONAGEM = P.COD");
            strQuery += (" WHERE P.ATIVO = 1 and COD_PERSONAGEM = " + tb_Personagens.COD + " ORDER BY INICIATIVA DESC");
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.GetTable(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataSet ListarDataGrid(int Codigo)
        {
            string strQuery;
            strQuery = "Select COD,NOME,RACA,CLASSE,ALINHAMENTO,CA,PVTOTAL,PVATUAL,PATAQUE,INICIATIVA,NIVEL From TabPersonagens WHERE ATIVO = 1 and COD_JOGADOR = " + Codigo;
            ConexaoDB ObjBancoDados = new ConexaoDB();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        public DataSet ListarDataGridFULL(int Codigo)
        {
            string strQuery;
            strQuery = "Select COD,NOME,RACA,CLASSE,ALINHAMENTO,CA,PVTOTAL,PVATUAL,PATAQUE,INICIATIVA,NIVEL,GENERO,CABELO,OLHOS,TAMANHO,ALTURA,PESO,HISTORIA From TabPersonagens WHERE ATIVO = 1 and COD_JOGADOR = " + Codigo;
            ConexaoDB ObjBancoDados = new ConexaoDB();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        public DataSet GetPersonagemCamapanha()
        {
            string strQuery;
            strQuery = ("Select P.COD,P.NOME,RACA,CLASSE,ALINHAMENTO,NIVEL,J.NOME as 'JOGADOR' From TabPersonagens as P ");
            strQuery += ("INNER JOIN TabJogadores as J ");
            strQuery += ("on J.COD = P.COD_JOGADOR "); 
            strQuery += ("WHERE P.ATIVO = 1 AND COD_CAMPANHA = 0");
            ConexaoDB ObjBancoDados = new ConexaoDB();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        public Resultado Desativar(int COD)
        {
            string strQuery;
            strQuery = (" UPDATE TabPersonagens ");
            strQuery += (" SET ");
            strQuery += (" Ativo = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + COD + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }
        //public Resultado Excluir(int COD)
        //{
        //    string strQuery;
        //    strQuery = ("DELETE FROM TabPersonagens ");
        //    strQuery += (" WHERE ");
        //    strQuery += (" COD = '" + COD + "' ;");
        //    ConexaoDB ObjCldBancoDados = new ConexaoDB();
        //    resultado = ObjCldBancoDados.Executar(strQuery);
        //    return resultado;

        //}
        public Resultado Gravar(TabPersonagens tb_Personagens)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TabPersonagens ";
            strQuery += ("(");
            strQuery += ("NOME");
            strQuery += (",RACA");
            strQuery += (",CLASSE");
            strQuery += (",ALINHAMENTO");
            strQuery += (",CA");
            strQuery += (",PVTOTAL");
            strQuery += (",PVATUAL");
            strQuery += (",PATAQUE");
            strQuery += (",INICIATIVA");
            strQuery += (",DINHEIRO");
            strQuery += (",EXPERIENCIA");
            strQuery += (",NIVEL");
            strQuery += (",GENERO");
            strQuery += (",CABELO");
            strQuery += (",OLHOS");
            strQuery += (",TAMANHO");
            strQuery += (",ALTURA");
            strQuery += (",PESO");
            strQuery += (",HISTORIA");
            strQuery += (",DATAINCLUSAO");
            strQuery += (",COD_JOGADOR");
            strQuery += (",COD_CAMPANHA");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Personagens.NOME + "'");
            strQuery += (",'" + tb_Personagens.RACA + "'");
            strQuery += (",'" + tb_Personagens.CLASSE + "'");
            strQuery += (",'" + tb_Personagens.ALINHAMENTO + "'");
            strQuery += (",'" + tb_Personagens.CA + "'");
            strQuery += (",'" + tb_Personagens.PVTOTAL + "'");
            strQuery += (",'" + tb_Personagens.PVATUAL + "'");
            strQuery += (",'" + tb_Personagens.PATAQUE + "'");
            strQuery += (",'" + tb_Personagens.INICIATIVA + "'");
            strQuery += (",'" + tb_Personagens.DINHEIRO + "'");
            strQuery += (",'" + tb_Personagens.EXPERIENCIA + "'");
            strQuery += (",'" + tb_Personagens.NIVEL + "'");
            strQuery += (",'" + tb_Personagens.GENERO + "'");
            strQuery += (",'" + tb_Personagens.CABELO + "'");
            strQuery += (",'" + tb_Personagens.OLHOS + "'");
            strQuery += (",'" + tb_Personagens.TAMANHO + "'");
            strQuery += (",'" + tb_Personagens.ALTURA + "'");
            strQuery += (",'" + tb_Personagens.PESO + "'");
            strQuery += (",'" + tb_Personagens.HISTORIA + "'");
            strQuery += (",'" + tb_Personagens.DATAINCLUSAO + "'");
            strQuery += (",'" + tb_Personagens.COD_JOGADOR + "'");
            strQuery += (",'" + tb_Personagens.COD_CAMPANHA + "'");
            strQuery += (",1");
            strQuery += (")");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
        //================================================================

        public Resultado JogadorEditando(TabPersonagens tb_Personagens)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TabPersonagens ");
            strQuery += (" SET ");
            strQuery += (" NOME = '" + tb_Personagens.NOME + "' ");
            strQuery += (" ,RACA = '" + tb_Personagens.RACA + "' ");
            strQuery += (" ,CLASSE = '" + tb_Personagens.CLASSE + "' ");
            strQuery += (" ,ALINHAMENTO = '" + tb_Personagens.ALINHAMENTO + "' ");
            strQuery += (" ,GENERO = '" + tb_Personagens.GENERO + "' ");
            strQuery += (" ,CABELO = '" + tb_Personagens.CABELO + "' ");
            strQuery += (" ,OLHOS = '" + tb_Personagens.OLHOS + "' ");
            strQuery += (" ,TAMANHO = '" + tb_Personagens.TAMANHO + "'");
            strQuery += (" ,ALTURA = '" + tb_Personagens.ALTURA + "'");
            strQuery += (" ,PESO = '" + tb_Personagens.PESO + "'");
            strQuery += (" ,HISTORIA = '" + tb_Personagens.HISTORIA + "'");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Personagens.COD + " ");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
        public Resultado MestreEditando(TabPersonagens tb_Personagens)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TabPersonagens ");
            strQuery += (" SET ");
            strQuery += (" CA = '" + tb_Personagens.CA + "' ");
            strQuery += (" ,PVTOTAL = '" + tb_Personagens.PVTOTAL + "' ");
            strQuery += (" ,PVATUAL = '" + tb_Personagens.PVATUAL + "' ");
            strQuery += (" ,PATAQUE = '" + tb_Personagens.PATAQUE + "' ");
            strQuery += (" ,INICIATIVA = '" + tb_Personagens.INICIATIVA + "' ");
            strQuery += (" ,NIVEL = '" + tb_Personagens.NIVEL + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Personagens.COD + " ");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }
        public Resultado AdicionarCampanha(TabPersonagens tb_Personagens)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TabPersonagens ");
            strQuery += (" SET ");
            strQuery += (" COD_CAMPANHA = " + tb_Personagens.COD_CAMPANHA + " ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Personagens.COD + " ");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }
        public Resultado VenderItem(TabPersonagens tb_Personagens)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TabPersonagens ");
            strQuery += (" SET ");
            strQuery += (" DINHEIRO = " + tb_Personagens.DINHEIRO + " ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Personagens.COD + " ");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        //============================================================================================================
        //============================================================================================================
        //============================================================================================================
        //============================================================================================================
        //============================================================================================================
        public List<TabPersonagens> ListarPersonagensCampanha(int pId)
        {
            try
            {
                // if (obj != null && !((int)obj.GetType().GetProperty("Ativo").GetValue(obj) == 0))
                List<TabPersonagens> ListaPersonagensCampanha = Db.TabPersonagens.Where(x => x.COD_CAMPANHA == pId)
                    .Where(x => x.ATIVO == 1).ToList();


                return ListaPersonagensCampanha;
                throw new Exception("Nenhum registro encontrado.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TabPersonagens> ListarPersonagensJogador(int pId)
        {
            try
            {
                // if (obj != null && !((int)obj.GetType().GetProperty("Ativo").GetValue(obj) == 0))
                List<TabPersonagens> ListaPersonagensCampanha = Db.TabPersonagens.Where(x => x.COD_JOGADOR == pId)
                    .Where(x => x.ATIVO == 1).ToList();


                return ListaPersonagensCampanha;
                throw new Exception("Nenhum registro encontrado.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TabPersonagens> BuscarPersonagensSemCampanha(string Nome)
        {
            try
            {
                List<TabPersonagens> ListaPersonagensCampanha = Db.TabPersonagens.Where(x => x.COD_CAMPANHA == 0)
                    .Where(x => x.NOME.ToUpper() == Nome.ToUpper())
                    .Where(x => x.RACA != "Monstro")
                    .Where(x => x.ATIVO == 1).ToList().ToList();

                return ListaPersonagensCampanha;
                throw new Exception("Nenhum registro encontrado.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //============================================================================================================
        //============================================================================================================
        //============================================================================================================
        //============================================================================================================
        //============================================================================================================
    }
}
