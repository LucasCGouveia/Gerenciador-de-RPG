using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gerenciador.Business;
using Gerenciador.Entities;

namespace Gerenciador
{
    public partial class FrmCadJogador : Form
    {
        public FrmCadJogador()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        JogadoresBusiness jogadoresBusiness = new JogadoresBusiness();
        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        private void FrmCadJogador_Load(object sender, EventArgs e)
        {
            List<int> CodUsuario = usuarioBusiness.GetCodigoUsuario(txtUsuario.Text);
            txtCod.Text = Convert.ToString(CodUsuario[0]);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            resultado = jogadoresBusiness.Excluir(Convert.ToInt32(txtCod.Text));
            if (resultado.sucesso)
            {
                MessageBox.Show("Cancelado criação de usuario voltando a tela de login. ", "C A N C E L A D O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                Close();
            }
            else
            {
                //MessageBox.Show("Cancelado criação de usuario voltando a tela de login. ", "C A N C E L A D O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mtxtDataNasc.Text = "";
            mtxtCPF.Text = "";
            mtxtRG.Text = "";
            //gbSexo.Select = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && mtxtDataNasc.Text == "" && mtxtRG.Text == "" && mtxtCPF.Text == "")
            {
                MessageBox.Show("Algum campo ficou em branco revise seus dados. ", "C A M P O   V A Z I O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                resultado = jogadoresBusiness.Gravar(txtNome.Text, mtxtDataNasc.Text, mtxtRG.Text, mtxtCPF.Text, 0, Convert.ToInt32(txtCod.Text));
                if (resultado.sucesso)
                {
                    MessageBox.Show("Cadastro concluido com sucesso voltando a tela de login. ", "C O N C L U I D O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Show();
                    Close();
                }
                else
                {
                    //MessageBox.Show("Cancelado criação de usuario voltando a tela de login. ", "C A N C E L A D O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
