using Gerenciador.Repository.BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;//Importar ADO
using System.Data.SqlClient; //Importar SQLusing System.Data;
using System.Drawing;
using Gerenciador.Entities;

namespace Gerenciador.Repository
{
    public class CampanhasRepository
    {
        Resultado resultado = new Resultado();
        public DataSet ListarDataGrid(int CodigoMestre)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = "Select COD,NOMECAMPANHA,SISTEMA,DESCRICAO From TB_CAMPANHAS WHERE ATIVO = 1 and COD_MESTRE = " + CodigoMestre;//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataSet ListarDataGridPersonagensMesa(int Codigo)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = ("Select P.COD,NOME,RACA,CLASSE,ALINHAMENTO,CA,PVTOTAL,PVATUAL,PATAQUE,INICIATIVA,NIVEL,A.FORC,A.DEST,A.CONS,A.INTE,A.SABE,A.CARI,HISTORIA ");
            strQuery += (" From TB_PERSONAGENS as P");
            strQuery += (" INNER JOIN TB_ATRIBUTOS as A on A.COD_PERSONAGEM = P.COD");
            strQuery += (" WHERE P.ATIVO = 1 and COD_CAMPANHA = " + Codigo + "ORDER BY INICIATIVA DESC");
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }



























        public DataSet ListarCargosCadCargos(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "Select COD,CARGO,SALARIO From TB_CAMPANHAS WHERE CARGO = '" + strDescricao + "' and ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "Select COD,Cargo,Salario From TB_CAMPANHAS where ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)

            }
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public Resultado Desativar(int codigo)
        {
            string strQuery;
            strQuery = (" UPDATE TB_CAMPANHAS ");
            strQuery += (" SET ");
            strQuery += (" ATIVO = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + codigo + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
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


        public Resultado Gravar(Tb_Campanhas tb_Campanhas)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TB_CAMPANHAS ";
            strQuery += ("(");
            strQuery += ("NOMECAMPANHA");
            strQuery += (",SISTEMA");
            strQuery += (",DESCRICAO");
            strQuery += (",COD_MESTRE");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Campanhas.NomeCampanha + "'");
            strQuery += (",'" + tb_Campanhas.Sistema + "'");
            strQuery += (",'" + tb_Campanhas.Descricao + "'");
            strQuery += ("," + tb_Campanhas.CodigoMestre);
            strQuery += (",1");
            strQuery += (")");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Editar(Tb_Campanhas tb_Campanhas)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_CAMPANHAS ");
            strQuery += (" SET ");
            strQuery += (" NOMECAMPANHA = '" + tb_Campanhas.NomeCampanha + "' ");
            strQuery += (" SISTEMA = '" + tb_Campanhas.Sistema + "' ");
            strQuery += (" ,DESCRICAO = '" + tb_Campanhas.Descricao + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Campanhas.Codigo + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }





















    }
}
