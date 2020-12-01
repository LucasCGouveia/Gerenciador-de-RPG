﻿using Gerenciador.Entities;
using Gerenciador.Repository.BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Repository
{
    public class PersonagensRepository
    {
        Resultado resultado = new Resultado();
        Tb_Personagens tb_Personagens = new Tb_Personagens();
        public DataSet ListarDataGrid(int Codigo)
        {
            string strQuery;
            strQuery = "Select COD,NOME,RACA,CLASSE,ALINHAMENTO,CA,PVTOTAL,PVATUAL,PATAQUE,INICIATIVA,NIVEL From TB_PERSONAGENS WHERE ATIVO = 1 and COD_JOGADOR = " + Codigo;
            CldBancoDados ObjBancoDados = new CldBancoDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        public DataSet ListarDataGridFULL(int Codigo)
        {
            string strQuery;
            strQuery = "Select COD,NOME,RACA,CLASSE,ALINHAMENTO,CA,PVTOTAL,PVATUAL,PATAQUE,INICIATIVA,NIVEL,GENERO,CABELO,OLHOS,TAMANHO,ALTURA,PESO,HISTORIA From TB_PERSONAGENS WHERE ATIVO = 1 and COD_JOGADOR = " + Codigo;
            CldBancoDados ObjBancoDados = new CldBancoDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        public DataSet GetPersonagemCamapanha()
        {
            string strQuery;
            strQuery = ("Select P.COD,P.NOME,RACA,CLASSE,ALINHAMENTO,NIVEL,J.NOME as 'JOGADOR' From TB_PERSONAGENS as P ");
            strQuery += ("INNER JOIN tb_Jogadores as J ");
            strQuery += ("on J.COD = P.COD_JOGADOR "); 
            strQuery += ("WHERE P.ATIVO = 1 AND COD_CAMPANHA = 0");
            CldBancoDados ObjBancoDados = new CldBancoDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        public Resultado Desativar(int COD)
        {
            string strQuery;
            strQuery = (" UPDATE TB_PERSONAGENS ");
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
            strQuery = ("DELETE FROM TB_PERSONAGENS ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + COD + "' ;");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }
        public Resultado Gravar(Tb_Personagens tb_Personagens)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TB_PERSONAGENS ";
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
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
        //================================================================

        public Resultado JogadorEditando(Tb_Personagens tb_Personagens)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_PERSONAGENS ");
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
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
        public Resultado MestreEditando(Tb_Personagens tb_Personagens)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_PERSONAGENS ");
            strQuery += (" SET ");
            strQuery += (" CA = '" + tb_Personagens.CA + "' ");
            strQuery += (" ,PVTOTAL = '" + tb_Personagens.PVTOTAL + "' ");
            strQuery += (" ,PVATUAL = '" + tb_Personagens.PVATUAL + "' ");
            strQuery += (" ,PATAQUE = '" + tb_Personagens.PATAQUE + "' ");
            strQuery += (" ,INICIATIVA = '" + tb_Personagens.INICIATIVA + "' ");
            strQuery += (" ,NIVEL = '" + tb_Personagens.NIVEL + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Personagens.COD + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }
        public Resultado AdicionarCampanha(Tb_Personagens tb_Personagens)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TB_PERSONAGENS ");
            strQuery += (" SET ");
            strQuery += (" COD_CAMPANHA = " + tb_Personagens.COD_CAMPANHA + " ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Personagens.COD + " ");
            CldBancoDados ObjCldBancoDados = new CldBancoDados();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;

        }
    }
}
