using Gerenciador;
using System;

using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmTrocaTelas : Form
    {
        public FrmTrocaTelas()
        {
            InitializeComponent();
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            if (LblDeOndeVim.Text == "Mestre")
            {
                FrmMenuPrincipal ObjMenu = new FrmMenuPrincipal();
                ObjMenu.LblUser.Text = LblUser.Text;
                ObjMenu.Show();
                Close();
            }
            else
            {
                FrmAreaJogador rrmAreaJogador = new FrmAreaJogador();
                rrmAreaJogador.LblUser.Text = LblUser.Text;
                rrmAreaJogador.Show();
                Close();
            }
        }

        private void BtnDeslogar_Click_1(object sender, EventArgs e)
        {
            FrmLogin ObjLogin = new FrmLogin();
            ObjLogin.Show();
            Close();
        }

        private void BtnSim_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmTrocaTelas_Load(object sender, EventArgs e)
        {

        }
    }
}
