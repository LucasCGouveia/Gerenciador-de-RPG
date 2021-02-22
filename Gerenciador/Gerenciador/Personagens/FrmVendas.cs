using Gerenciador.Business;
using Gerenciador.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        ItensBusiness itensBusiness = new ItensBusiness();
        SkillsBusiness skillsBusiness = new SkillsBusiness();

        PersonagensBusiness personagensBusiness = new PersonagensBusiness();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string ValorItem = txtValor.Text;
            int ValorItemConvertido = Convert.ToInt32(ValorItem.Replace(".", ""));
            int DinheiroPersonagem = Convert.ToInt32(txtJades.Text);
            int Resultado = DinheiroPersonagem + ValorItemConvertido;

            resultado = personagensBusiness.VenderItem(Resultado, LblPersonagem.Text);
            if (resultado.sucesso)
            {
                switch (LblVenda.Text)
                {
                    case "S":
                        resultado = skillsBusiness.Excluir(Convert.ToInt32(LblItem.Text));
                        break;
                    case "P":
                        resultado = itensBusiness.Excluir(Convert.ToInt32(LblItem.Text));
                        break;
                    case "I":
                        resultado = itensBusiness.Excluir(Convert.ToInt32(LblItem.Text));
                        break;
                    default:
                        resultado = itensBusiness.Excluir(Convert.ToInt32(LblItem.Text));

                        break;
                }
                resultado = itensBusiness.Excluir(Convert.ToInt32(LblItem.Text));
                if (resultado.sucesso)
                {
                    MessageBox.Show("Venda realizada com sucesso", "S U C E S S O");
                }
            }
            else
            {
                MessageBox.Show("Valha na negociação Exceção:" + resultado.exception, "F A L H A   N A   V E N D A");
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
