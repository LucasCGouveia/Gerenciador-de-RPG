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
    public class SkillsRepository
    {
        Resultado resultado = new Resultado();
        public DataSet ListarDataGrid(string Tipo)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (Tipo == "SKILLS")
            {
                strQuery = "Select COD,SKILL,TIPO,NIVEL,DANO,BONUS,VALOR,TEMPO,ALCANCE,DURACAO,DESCRICAO From TabSkills WHERE COD_PERSONAGEM is NULL AND ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "Select COD,SKILL,TIPO,NIVEL,DANO,BONUS,VALOR,TEMPO,ALCANCE,DURACAO,DESCRICAO From TabSkills WHERE COD_PERSONAGEM is NULL AND TIPO = '" + Tipo + "' AND ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataSet ListarDataGridSkills(TabPersonagens tb_Personagens)
        {
            string strQuery;
            strQuery = "select SKILL,TIPO,NIVEL,DANO,BONUS,VALOR,TEMPO,ALCANCE,DURACAO,DESCRICAO,COD From TabSkills WHERE COD_PERSONAGEM = " + tb_Personagens.COD + " AND ATIVO = 1 ";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public DataSet ListarCargosCadCargos(string strDescricao)//Recebe a string do campo descrição, enviado por parâmetro, porém com retorno
        {
            string strQuery;
            if (strDescricao != "")
            {
                strQuery = "Select COD,CARGO,SALARIO From TabSkills WHERE CARGO = '" + strDescricao + "' and ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)
            }
            else
            {
                strQuery = "Select COD,Cargo,Salario From TabSkills where ATIVO = 1";//String de pesquisa no BD, onde: Seleciona código, nome e telefone pesquisando por qualquer parte do campo nome somente os ativados(não foram excluidos)

            }
            ConexaoDB ObjBancoDados = new ConexaoDB();//Instancia/cria objeto do BancoDeDados
            return ObjBancoDados.RetornaDataSet(strQuery);//Envia a consulta por parâmetro para objeto e aguarda o retorno
        }
        public Resultado Desativar(int codigo)
        {
            string strQuery;
            strQuery = (" UPDATE TabSkills ");
            strQuery += (" SET ");
            strQuery += (" ATIVO = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = '" + codigo + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Excluir(int _COD)
        {
            string strQuery;
            strQuery = ("DELETE FROM TabSkills ");
            strQuery += (" WHERE ");
            strQuery += (" cod = '" + _COD + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado ExcluirSkillsPersonagem(int _COD)
        {
            string strQuery;
            strQuery = ("DELETE FROM TabSkills ");
            strQuery += (" WHERE ");
            strQuery += (" COD_PERSONAGEM = '" + _COD + "' ;");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Gravar(TabSkills tb_Skills)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TabSkills ";
            strQuery += ("(");
            strQuery += ("SKILL");
            strQuery += (",TIPO");
            strQuery += (",NIVEL");
            strQuery += (",DANO");
            strQuery += (",BONUS");
            strQuery += (",VALOR");
            strQuery += (",TEMPO");
            strQuery += (",ALCANCE");
            strQuery += (",DURACAO");
            strQuery += (",Descricao");
            strQuery += (",COD_PERSONAGEM");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Skills.SKILL + "'");
            strQuery += (",'" + tb_Skills.TIPO + "'");
            strQuery += (",'" + tb_Skills.NIVEL + "'");
            strQuery += (",'" + tb_Skills.DANO + "'");
            strQuery += (",'" + tb_Skills.BONUS + "'");
            strQuery += (",'" + tb_Skills.VALOR + "'");
            strQuery += (",'" + tb_Skills.TEMPO + "'");
            strQuery += (",'" + tb_Skills.ALCANCE + "'");
            strQuery += (",'" + tb_Skills.DURACAO + "'");
            strQuery += (",'" + tb_Skills.DESCRICAO + "'");
            strQuery += (",Null");
            strQuery += (",1");
            strQuery += (")");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }
        public Resultado Editar(TabSkills tb_Skills)
        {
            string strQuery; //Criar a String para alterar
            strQuery = (" UPDATE TabSkills ");
            strQuery += (" SET ");
            strQuery += (" SKILL = '" + tb_Skills.SKILL + "' ");
            strQuery += (" ,TIPO = '" + tb_Skills.TIPO + "' ");
            strQuery += (" ,NIVEL = '" + tb_Skills.NIVEL + "' ");
            strQuery += (" ,DANO = '" + tb_Skills.DANO + "' ");
            strQuery += (" ,BONUS = '" + tb_Skills.BONUS + "' ");
            strQuery += (" ,VALOR = '" + tb_Skills.VALOR + "' ");
            strQuery += (" ,TEMPO = '" + tb_Skills.TEMPO + "' ");
            strQuery += (" ,ALCANCE = '" + tb_Skills.ALCANCE + "' ");
            strQuery += (" ,DURACAO = '" + tb_Skills.DURACAO + "' ");
            strQuery += (" ,DESCRICAO = '" + tb_Skills.DESCRICAO + "' ");
            strQuery += (" WHERE ");
            strQuery += (" COD = " + tb_Skills.COD + " ");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);
            return resultado;
        }
        public Resultado AdicionarPersonagem(TabSkills tb_Skills)
        {
            string strQuery; //Criar a String para inserir
            strQuery = " INSERT INTO TabSkills ";
            strQuery += ("(");
            strQuery += ("SKILL");
            strQuery += (",TIPO");
            strQuery += (",NIVEL");
            strQuery += (",DANO");
            strQuery += (",BONUS");
            strQuery += (",VALOR");
            strQuery += (",TEMPO");
            strQuery += (",ALCANCE");
            strQuery += (",DURACAO");
            strQuery += (",DESCRICAO");
            strQuery += (",COD_PERSONAGEM");
            strQuery += (",ATIVO");
            strQuery += (")");
            strQuery += (" VALUES (");
            strQuery += ("'" + tb_Skills.SKILL + "'");
            strQuery += (",'" + tb_Skills.TIPO + "'");
            strQuery += (",'" + tb_Skills.NIVEL + "'");
            strQuery += (",'" + tb_Skills.DANO + "'");
            strQuery += (",'" + tb_Skills.BONUS + "'");
            strQuery += (",'" + tb_Skills.VALOR + "'");
            strQuery += (",'" + tb_Skills.TEMPO + "'");
            strQuery += (",'" + tb_Skills.ALCANCE + "'");
            strQuery += (",'" + tb_Skills.DURACAO + "'");
            strQuery += (",'" + tb_Skills.DESCRICAO + "'");
            strQuery += (",'" + tb_Skills.COD_PERSONAGEM + "'");
            strQuery += (",1");
            strQuery += (")");
            ConexaoDB ObjCldBancoDados = new ConexaoDB();
            resultado = ObjCldBancoDados.Executar(strQuery);

            return resultado;
        }





















    }
}
