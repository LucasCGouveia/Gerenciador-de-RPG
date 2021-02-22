using System;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmGerenciamento : Form
    {
        FrmCadClasses frmCadClasses = new FrmCadClasses();
        public FrmGerenciamento()
        {
            InitializeComponent();
        }

        private void btnCadastroDeRACA_Click(object sender, EventArgs e)
        {
            //FrmCadCargos objFrmCargos = new FrmCadCargos();
            //objFrmCargos.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            //objFrmCargos.txtSenhaCookie.Text = txtSenhaCookie.Text;
            //objFrmCargos.Show();
            //this.Close();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal ObjFMP = new FrmMenuPrincipal();
            ObjFMP.LblUser.Text = LblMestre.Text;
            ObjFMP.Show();
            this.Close();

        }

        private void bntCadTipoContato_Click(object sender, EventArgs e)
        {
            //FrmCadTipoContato ObjCTC = new FrmCadTipoContato();
            //ObjCTC.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            //ObjCTC.txtSenhaCookie.Text = txtSenhaCookie.Text;
            //ObjCTC.Show();
            //this.Close();

        }

        private void btnAtribuirUsuarioaFunc_Click(object sender, EventArgs e)
        {
            //FrmJuntarUserAFunc ObjJUaF = new FrmJuntarUserAFunc();
            //ObjJUaF.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            //ObjJUaF.txtSenhaCookie.Text = txtSenhaCookie.Text;
            //ObjJUaF.Show();
            //this.Close();

        }

        private void BtnDesbloquearUsuario_Click(object sender, EventArgs e)
        {
            //FrmDesbloquearUsuarios ObjDU = new FrmDesbloquearUsuarios();
            //ObjDU.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            //ObjDU.txtSenhaCookie.Text = txtSenhaCookie.Text;
            //ObjDU.Show();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmAtribuirAdm ObjAD = new FrmAtribuirAdm();
            //ObjAD.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            //ObjAD.txtSenhaCookie.Text = txtSenhaCookie.Text;
            //ObjAD.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FrmFuncExcluidos ObjFE = new FrmFuncExcluidos();
            //ObjFE.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            //ObjFE.txtSenhaCookie.Text = txtSenhaCookie.Text;
            //ObjFE.Show();
            //this.Close();
        }

        private void bntCadClasses_Click(object sender, EventArgs e)
        {
            frmCadClasses.LblMestre.Text = LblMestre.Text;
            frmCadClasses.Show();
            Close();
        }

        private void gpGerencia_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadRacas_Click(object sender, EventArgs e)
        {
            FrmRacas frmRacas = new FrmRacas();
            frmRacas.LblMestre.Text = LblMestre.Text;
            frmRacas.Show();
            Close();
        }

        private void btnCadastroDeUsuario_Click(object sender, EventArgs e)
        {
            FrmBuscaUsuarios frmBuscaUsuarios = new FrmBuscaUsuarios();
            frmBuscaUsuarios.LblMestre.Text = LblMestre.Text;
            frmBuscaUsuarios.Show();
            Close();
        }

        private void FrmGerenciamento_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerificarJogadores_Click(object sender, EventArgs e)
        {
            FrmBuscaJogadores frmBuscaJogadores = new FrmBuscaJogadores();
            frmBuscaJogadores.LblMestre.Text = LblMestre.Text;
            frmBuscaJogadores.Show();
            Close();
        }
    }
}
