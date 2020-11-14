using Gerenciador.Buscas;
using Gerenciador.Cadastro;
using Gerenciador.Principais;
using Gerenciador.Secundarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //try
            //{
                FrmTrocaTelas ObjTrocaTelas = new FrmTrocaTelas();
                ObjTrocaTelas.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
                ObjTrocaTelas.txtSenhaCookie.Text = txtUsuarioCookie.Text;
                ObjTrocaTelas.Show();
                this.Close();
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
        }

        private void btnCadastroDeCliente_Click(object sender, EventArgs e)
        {
            FrmCadUserDefinitivo ObjfrmCadFuncionarios = new FrmCadUserDefinitivo();
            ObjfrmCadFuncionarios.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjfrmCadFuncionarios.txtSenhaCookie.Text = txtSenhaCookie.Text;
            ObjfrmCadFuncionarios.Show();
            this.Close();
        }

        private void BtnGerencia_Click(object sender, EventArgs e)
        {
            FrmGerenciamento ObjFrmGerenciamento = new FrmGerenciamento();
            ObjFrmGerenciamento.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjFrmGerenciamento.txtSenhaCookie.Text = txtSenhaCookie.Text;
            ObjFrmGerenciamento.Show();
            Close();
        }

        private void btnBuscaDeCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarUserDefinitivo ObjBF = new FrmBuscarUserDefinitivo();
            ObjBF.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjBF.txtSenhaCookie.Text = txtSenhaCookie.Text;
            ObjBF.Show();

            this.Close();
        }

        private void btnBuscaDeHorario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAlterarSenha_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalAgendado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void grbCadastros_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastroDeProduto_Click(object sender, EventArgs e)
        {

        }

        private void grbBuscas_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscaDePets_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgendarHorario_Click(object sender, EventArgs e)
        {

        }

        private void gboxMenuPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void txtSenhaCookie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioCookie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
