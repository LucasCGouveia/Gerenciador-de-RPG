using Gerenciador.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
            List<string> ListaDeDados = new List<string>();
            FrmMenuPrincipal objFrmMenuPrinciapl = new FrmMenuPrincipal();
            FrmAreaJogador frmAreaJogador = new FrmAreaJogador();

            ListaDeDados = usuarioBusiness.GetUsuarios(txtUsuario.Text,txtSenha.Text);            

            if (ListaDeDados.Count() == 0)
            {
                MessageBox.Show("Nome de Usuario ou senhas Incorretas.", "Problema ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
            else
            {
                switch (ListaDeDados[0])
                {
                    case "Jogador":
                        //this.Visible = false;
                        //MessageBox.Show("Area de Jogador sendo desenvolvida.", "Problema ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAreaJogador.LblUser.Text = txtUsuario.Text;
                        frmAreaJogador.Show();
                        break;
                    case "Mestre":
                        this.Visible = false;
                        objFrmMenuPrinciapl.LblUser.Text = txtUsuario.Text;
                        objFrmMenuPrinciapl.Show();
                        break;
                    case "Bloqueado":
                        MessageBox.Show("Usuario Bloqueado.", "Problema ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSenha.Text = "";
                        txtUsuario.Focus(); break;
                    default:
                        MessageBox.Show("Nome de Usuario ou senhas Incorretas.", "Problema ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSenha.Text = "";
                        txtUsuario.Focus();
                        break;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (MessageBox.Show("Deseja Realmente Fechar o Sistema???", "Fechar...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                }
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
        }

        private void LlblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //try
            //{
                this.Visible = false;
                FrmCadUsuario ObjFrmCadUsuario_FrmLogin = new FrmCadUsuario();
                ObjFrmCadUsuario_FrmLogin.Show();
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
