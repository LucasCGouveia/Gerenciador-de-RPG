using Gerenciador.Repository;
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
    public class ItensRepository
    {
        Resultado resultado = new Resultado();
        public DataSet ListarDataGrid(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao == "ITENS")
            {
                strQuery = "Select COD,ITEM,TIPO,DANO,BONUS,VALOR,DESCRICAO From TB_ITENS WHERE COD_PERSONAGEM is NULL AND ATIVO = 1 ";
            }
            else
            {
                strQuery = "Select COD,ITEM,TIPO,DANO,BONUS,VALOR,DESCRICAO From TB_ITENS WHERE COD_PERSONAGEM is NULL AND TIPO = '" + strDescricao + "' AND ATIVO = 1 ";
            }
            ConexaoDB ObjBancoDados = new ConexaoDB();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        public DataSet ListarDataGridArmas(TabPersonagens tb_Personagens)
        {
            string strQuery;
            strQuery = "Select ITEM,TIPO,DANO,BONUS,VALOR,DESCRICAO,COD From TabItens WHERE COD_PERSONAGEM = " + tb_Personagens.COD + " AND ATIVO = 1 AND TIPO in ('ARMA')";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataSet ListarDataGridInventario(TabPersonagens tb_Personagens)
        {
            string strQuery;
            strQuery = "Select ITEM,TIPO,DANO,BONUS,VALOR,DESCRICAO,COD From TabItens WHERE COD_PERSONAGEM = " + tb_Personagens.COD + " AND ATIVO = 1 AND TIPO NOT IN ('ARMA')";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataSet ListarCargosCadCargos(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "Select COD,CARGO,SALARIO From Tb_Cargos WHERE CARGO = '" + strDescricao + "' and ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "Select COD,Cargo,Salario From Tb_Cargos where ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)

            }
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public Resultado Desativar(int codigo)
        {
            string strQuery;
            strQuery = (" UPDATE TabItens ");
            strQuery += (" SET ");
            strQuery += (" ATIVO = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + codigo + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Excluir(int codigo)
        {
            string strQuery;
            strQuery = (" DELETE FROM TabItens ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + codigo + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado ExcluirItensPersonagem(int codigo)
        {
            string strQuery;
            strQuery = (" DELETE FROM TabItens ");
            strQuery += (" WHERE ");
            strQuery += (" COD_PERSONAGEM = '" + codigo + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Gravar(TabItens tb_Itens)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TabItens ";
            strQuery += ("(");
            strQuery += ("ITEM");
            strQuery += (",TIPO");
            strQuery += (",DANO");
            strQuery += (",BONUS");
            strQuery += (",VALOR");
            strQuery += (",DESCRICAO");
            strQuery += (",COD_PERSONAGEM");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Itens.ITEM + "'");
            strQuery += (",'" + tb_Itens.TIPO + "'");
            strQuery += (",'" + tb_Itens.DANO + "'");
            strQuery += (",'" + tb_Itens.BONUS + "'");
            strQuery += (",'" + tb_Itens.VALOR + "'");
            strQuery += (",'" + tb_Itens.DESCRICAO + "'");
            strQuery += (",null");
            strQuery += (",1");
            strQuery += (")");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Editar(TabItens tb_Itens)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TabItens ");
            strQuery += (" SET ");
            strQuery += (" ITEM = '" + tb_Itens.ITEM + "' ");
            strQuery += (" ,TIPO = '" + tb_Itens.TIPO + "' ");
            strQuery += (" ,DANO = '" + tb_Itens.DANO + "' ");
            strQuery += (" ,BONUS = '" + tb_Itens.BONUS + "' ");
            strQuery += (" ,VALOR = '" + tb_Itens.VALOR + "' ");
            strQuery += (" ,DESCRICAO = '" + tb_Itens.DESCRICAO + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Itens.COD + " ");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
        public Resultado AdicionarPersonagem(TabItens tb_Itens)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TabItens ";
            strQuery += ("(");
            strQuery += ("ITEM");
            strQuery += (",TIPO");
            strQuery += (",DANO");
            strQuery += (",BONUS");
            strQuery += (",VALOR");
            strQuery += (",DESCRICAO");
            strQuery += (",COD_PERSONAGEM");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Itens.ITEM + "'");
            strQuery += (",'" + tb_Itens.TIPO + "'");
            strQuery += (",'" + tb_Itens.DANO + "'");
            strQuery += (",'" + tb_Itens.BONUS + "'");
            strQuery += (",'" + tb_Itens.VALOR + "'");
            strQuery += (",'" + tb_Itens.DESCRICAO + "'");
            strQuery += (",'" + tb_Itens.COD_PERSONAGEM + "'");
            strQuery += (",1");
            strQuery += (")");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }





















    }
}
