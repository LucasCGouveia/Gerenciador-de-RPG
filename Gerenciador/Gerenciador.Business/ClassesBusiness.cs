using Gerenciador.Entities;
using Gerenciador.Repository;
using Gerenciador.Repository.BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Business
{
    public class ClassesBusiness
    {
        Resultado resultado = new Resultado();
        ClassesRepository classesRepository = new ClassesRepository();
        Tb_Classes tb_Classes = new Tb_Classes();

        //ClnFuncoesGerais.Operacao ObjOperacao;   //Cria Obj da Operação
        //public ClnFuncoesGerais.Operacao EnumProperty //Método para receber o valor
        //{
        //    get { return ObjOperacao; }//Retorna o valor
        //    set { ObjOperacao = value; }//Recebe o valor
        //}
        public Resultado GravarClasse(string Classe, string Descricao)
        {
            tb_Classes.Classe = Classe;
            tb_Classes.Descricao = Descricao;
            resultado = classesRepository.Gravar(tb_Classes);
            return resultado;
        }
        public Resultado DesativarClasse(int codigoClasse)
        {
            resultado = classesRepository.DesativarClasse(codigoClasse);
            return resultado;
        }
        public Resultado EditarClasse(string Codigo,string Classe, string Descricao)
        {
            tb_Classes.Codigo = Convert.ToInt32(Codigo);
            tb_Classes.Classe = Classe;
            tb_Classes.Descricao = Descricao;
            resultado = classesRepository.EditarClasse(tb_Classes);
            return resultado;
        }



    }
}
