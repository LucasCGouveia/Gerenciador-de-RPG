using Gerenciador.Business;
using Gerenciador.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmAddAtributos : Form
    {
        public FrmAddAtributos()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        Tb_Atributos tb_Atributos = new Tb_Atributos();
        Tb_Personagens tb_Personagens = new Tb_Personagens();
        PersonagensBusiness personagensBusiness = new PersonagensBusiness();
        AtributosBusiness atributosBusiness = new AtributosBusiness();

        private void FrmAddAtributos_Load(object sender, EventArgs e)
        {
            List<int> CodAtributo = atributosBusiness.GetCodAtributos(Convert.ToInt32(LblCodigo.Text));
            LblAtributo.Text = Convert.ToString(CodAtributo[0]);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciarMesa frmGerenciarMesa = new FrmGerenciarMesa();
            frmGerenciarMesa.lblUsuario.Text = LblUser.Text;
            frmGerenciarMesa.LblCampanha.Text = LblCampanha.Text;
            frmGerenciarMesa.Show();
            Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            tb_Personagens.COD = Convert.ToInt32(LblCodigo.Text);
            tb_Personagens.CA = Convert.ToInt32(txtClasseArmadura.Text);
            tb_Personagens.PVTOTAL = Convert.ToInt32(txtPontosVida.Text);
            tb_Personagens.PVATUAL = Convert.ToInt32(txtPontosVidaAtuais.Text);
            tb_Personagens.PATAQUE = Convert.ToInt32(txtPontosAtaque.Text);
            tb_Personagens.INICIATIVA = Convert.ToInt32(txtIniciativa.Text);
            tb_Personagens.NIVEL = Convert.ToInt32(txtNivel.Text);
            resultado = personagensBusiness.MestreEditando(tb_Personagens);
            if (resultado.sucesso)
            {
                tb_Atributos.FORC = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.DESC = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.CONS = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.INTE = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.SABE = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.CARI = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.Codigo = Convert.ToInt32(LblAtributo.Text);
                resultado = atributosBusiness.Editar(tb_Atributos);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Atualido com sucesso", "A T U A L I Z A D O");
                }
                else
                {
                    MessageBox.Show("Falha na Atualização dos Atributos", "D E U   R U I M");
                }
            }
            else
            {
                MessageBox.Show("Falha na Atualização", "D E U   R U I M");
            }
        }
    }
}
