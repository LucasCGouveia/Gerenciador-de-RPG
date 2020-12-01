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
    public class RacasRepository
    {
        Resultado resultado = new Resultado();
        public DataSet ListarDataGrid()//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = "Select COD,RACA,DESCRICAO From TB_RACAS WHERE ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        //==================================================================================================================
        public DataSet ListarCargosCadCargos(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "Select COD,CARGO,SALARIO From TB_RACAS WHERE CARGO = '" + strDescricao + "' and ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "Select COD,Cargo,Salario From TB_RACAS where ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)

            }
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataSet ListarRacasCombo()//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            strQuery = "Select COD,RACA From TB_RACAS";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            CldBancoDados ObjBancoDados = new CldBancoDados();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public Resultado Desativar(int codRacas)
        {
            string strQuery;
            strQuery = (" UPDATE TB_RACAS ");
            strQuery += (" SET ");
            strQuery += (" ATIVO = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + codRacas + "' ;");
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


        public Resultado Gravar(Tb_Racas tb_Racas)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TB_RACAS ";
            strQuery += ("(");
            strQuery += ("RACA");
            strQuery += (",DESCRICAO");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Racas.Raca + "'");
            strQuery += (",'" + tb_Racas.Descricao + "'");
            strQuery += (",1");
            strQuery += (")");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Editar(Tb_Racas tb_Racas)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_RACAS ");
            strQuery += (" SET ");
            strQuery += (" RACA = '" + tb_Racas.Raca + "' ");
            strQuery += (" ,DESCRICAO = '" + tb_Racas.Descricao + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Racas.Codigo + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }





















    }
}
