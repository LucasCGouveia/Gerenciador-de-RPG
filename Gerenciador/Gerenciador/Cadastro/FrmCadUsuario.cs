using Gerenciador.Business;
using Gerenciador.Entities;
using System;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmCadUsuario : Form
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Verifica se os campos obrigatórios estão preenchidos
            if (txtLogin.Text == "" && txtSenha.Text == "" && cBoxTipoUsuario.Text == "")
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
            }
            else
            {
                string TipoUser;
                if (cBoxTipoUsuario.Text == "Jogador")
                    TipoUser = "J";
                else
                    TipoUser = "M";
                resultado = usuarioBusiness.Gravar(txtLogin.Text, txtSenha.Text, TipoUser);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Gravado. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (TipoUser == "J")
                    {
                        FrmCadJogador frmCadJogador = new FrmCadJogador();
                        frmCadJogador.txtUsuario.Text = txtLogin.Text;
                        frmCadJogador.Show();
                        Close();
                    }
                    else
                    {
                        FrmLogin frmLogin = new FrmLogin();
                        frmLogin.Show();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
