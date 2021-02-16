using Gerenciador.Entities;
using Gerenciador.Repository;
using System;

namespace Gerenciador.Business
{
    public class ClassesBusiness : BusinessBase<TabClasses>
    {
        Resultado resultado = new Resultado();
        ClassesRepository classesRepository = new ClassesRepository();
        TabClasses tb_Classes = new TabClasses();

        //ClnFuncoesGerais.Operacao ObjOperacao;   //Cria Obj da Operação
        //public ClnFuncoesGerais.Operacao EnumProperty //Método para receber o valor
        //{
        //    get { return ObjOperacao; }//Retorna o valor
        //    set { ObjOperacao = value; }//Recebe o valor
        //}
        public Resultado GravarClasse(string Classe, string Descricao)
        {
            tb_Classes.CLASSE = Classe;
            tb_Classes.DESCRICAO = Descricao;
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
            tb_Classes.COD = Convert.ToInt32(Codigo);
            tb_Classes.CLASSE = Classe;
            tb_Classes.DESCRICAO = Descricao;
            resultado = classesRepository.EditarClasse(tb_Classes);
            return resultado;
        }



    }
}
