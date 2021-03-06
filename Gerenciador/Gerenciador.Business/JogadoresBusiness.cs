﻿using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Business
{
    public class JogadoresBusiness : BusinessBase<TabJogadores>
    {
        Resultado resultado = new Resultado();
        JogadoresRepository jogadoresRepository = new JogadoresRepository();
        TabJogadores tb_Jogadores = new TabJogadores();
        public Resultado Gravar(string Nome, string Nascimento, string RG, string CPF, int QtdPersonagens, int CodigoUsuario)
        {
            tb_Jogadores.NOME = Nome;
            tb_Jogadores.NASCIMENTO = Nascimento;
            tb_Jogadores.RG = RG;
            tb_Jogadores.CPF = CPF;
            tb_Jogadores.QTDPERSONAGENS = QtdPersonagens;
            tb_Jogadores.DATAINCLUSAO = DateTime.Now;
            tb_Jogadores.COD_USUARIO = CodigoUsuario;
            resultado = jogadoresRepository.Gravar(tb_Jogadores);
            return resultado;
        }
        public Resultado Ativar(int codigo)
        {
            resultado = jogadoresRepository.Ativar(codigo);
            return resultado;
        }
        public Resultado Desativar(int codigo)
        {
            resultado = jogadoresRepository.Desativar(codigo);
            return resultado;
        }
        public Resultado AtualizaQtdPersonagens(int codigo)
        {
            resultado = jogadoresRepository.AtualizaQtdPersonagens(codigo);
            return resultado;
        }
        public Resultado AtualizaQtdPersonagensExclusao(int codigo)
        {
            resultado = jogadoresRepository.AtualizaQtdPersonagensExclusao(codigo);
            return resultado;
        }
        //public Resultado Editar(string Codigo, string Nome, string Nascimento, string RG, string CPF, int QtdPersonagens, int CodigoUsuario)
        //{
        //    tb_Jogadores.COD = Convert.ToInt32(Codigo);
        //    tb_Jogadores.NOME = Nome;
        //    tb_Jogadores.NASCIMENTO = Nascimento;
        //    tb_Jogadores.RG = RG;
        //    tb_Jogadores.CPF = CPF;
        //    tb_Jogadores.QTDPERSONAGENS = QtdPersonagens;
        //    tb_Jogadores.DATAINCLUSAO = DateTime.Now;
        //    tb_Jogadores.COD_USUARIO = CodigoUsuario;
        //    jogadoresRepository.Editar(tb_Jogadores);
        //    return resultado;
        //}
        //public Resultado Excluir(int codigo)
        //{
        //    resultado = jogadoresRepository.Excluir(codigo);
        //    return resultado;
        //}
        public List<int> GetCODJogador(string Usuario)
        {
            try
            {
                DataTable objDataTable = new DataTable();
                List<int> ListaDeDados = new List<int>();
                objDataTable = jogadoresRepository.GetCODJogador();

                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    int CODLista = Convert.ToInt32(dataRow["COD"]);
                    string LoginLista = dataRow["LOGIN"].ToString();

                    if (Usuario.ToUpper() == LoginLista)
                    {
                        ListaDeDados.Add(CODLista);
                        break;
                    }
                }

                return ListaDeDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //=================================================================================================================================================================================
        //=================================================================================================================================================================================
        //=================================================================================================================================================================================
        //=================================================================================================================================================================================
        //=================================================================================================================================================================================
        public TabJogadores ListarJogadorPorCodUsuario(int pId)
        {
            TabJogadores tabJogadores = jogadoresRepository.ListarJogadorPorCodUsuario(pId);
            return tabJogadores;
        }
        //=================================================================================================================================================================================
        //=================================================================================================================================================================================
        //=================================================================================================================================================================================
        //=================================================================================================================================================================================
        //=================================================================================================================================================================================
    }
}
