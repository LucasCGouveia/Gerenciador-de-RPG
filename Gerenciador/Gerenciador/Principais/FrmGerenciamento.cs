using Gerenciador.Cadastro;
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

namespace Gerenciador.Principais
{
    public partial class FrmGerenciamento : Form
    {
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
            ObjFMP.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjFMP.txtSenhaCookie.Text = txtSenhaCookie.Text;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastroDeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscaDeFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void gpGerencia_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdicionarExcluirServico_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastroDeFuncionario_Click(object sender, EventArgs e)
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
