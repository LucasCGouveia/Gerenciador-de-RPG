using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Business
{
    public class MissoesBusiness : BusinessBase<TabMissoes>
    {
        Resultado resultado = new Resultado();
        MissoesRepository missoesRepository = new MissoesRepository();
        TabMissoes tb_Missoes = new TabMissoes();
        public Resultado Gravar(TabMissoes tb_Missoes)
        {
            resultado = missoesRepository.Gravar(tb_Missoes);
            return resultado;
        }
        //public Resultado Desativar(int codigo)
        //{
        //    resultado = missoesRepository.Desativar(codigo);
        //    return resultado;
        //}
        //public Resultado Editar(TabMissoes tb_Missoes)
        //{
        //    resultado = missoesRepository.Editar(tb_Missoes);
        //    return resultado;
        //}
        //public Resultado Excluir(int codigo)
        //{
        //    resultado = missoesRepository.Excluir(codigo);
        //    return resultado;
        //}
        public Resultado AtribuirMissaoCampanha(TabMissoes tb_Missoes)
        {
            resultado = missoesRepository.AtribuirMissaoCampanha(tb_Missoes);
            return resultado;
        }
        public Resultado ConcluirMissao(TabMissoes tb_Missoes)
        {
            resultado = missoesRepository.ConcluirMissao(tb_Missoes);
            return resultado;
        }
        public List<int> GetCodigoMestre(string NomeMestre)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            try
            {
                DataTable objDataTable = new DataTable();
                List<int> ListaDeDados = new List<int>();
                objDataTable = usuarioRepository.GetCodigoMestre();
                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    int Codigo = Convert.ToInt32(dataRow["COD"]);
                    string LoginLista = dataRow["LOGIN"].ToString();

                    if (LoginLista == NomeMestre.ToUpper())
                    {
                        ListaDeDados.Add(Codigo);
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
    }
}
