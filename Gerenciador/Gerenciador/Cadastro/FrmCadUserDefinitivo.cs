using Gerenciador.Repository;
using Gerenciador.Repository.BancoDados;
using Gerenciador.Buscas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Cadastro
{
    public partial class FrmCadUserDefinitivo : Form
    {
        public FrmCadUserDefinitivo()
        {
            InitializeComponent();
        }
        ClnFuncoesGerais.Operacao ObjOperacao;   //Cria Obj da Operação
        public ClnFuncoesGerais.Operacao EnumProperty //Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }
        //==============================================
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnGravar.Text == "&Alterar")
            {
                FrmBuscarUserDefinitivo ObjBuscarFunc = new FrmBuscarUserDefinitivo();
                ObjBuscarFunc.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
                ObjBuscarFunc.txtSenhaCookie.Text = txtSenhaCookie.Text;
                ObjBuscarFunc.Show();
                this.Close();
            }
            else
            {
                UsuarioRepository ObjUser = new UsuarioRepository();
                //Aqui listo se usuario é Administrador
                string TipoUser = "A";
                IDataReader drDadosListarUserAdmin;
                drDadosListarUserAdmin = ObjUser.ListarUserAdmin(txtUsuarioCookie.Text, txtSenhaCookie.Text, TipoUser);
                if (drDadosListarUserAdmin.Read())
                {
                    FrmMenuPrincipal ObjMenu = new FrmMenuPrincipal();
                    ObjMenu.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
                    ObjMenu.txtSenhaCookie.Text = txtSenhaCookie.Text;
                    ObjMenu.Show();
                    this.Close();
                }
                else
                {
                    FrmMenuPrincipal ObjMenu = new FrmMenuPrincipal();
                    ObjMenu.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
                    ObjMenu.txtSenhaCookie.Text = txtSenhaCookie.Text;
                    ObjMenu.Show();
                    ObjMenu.BtnGerencia.Visible = false;
                    ObjMenu.Show();
                    this.Close();


                }
            }
        }

        private void FrmCadFuncionarios_Load(object sender, EventArgs e)
        {
            try
            {
                //Carregar ComboBox de Cargos Cadastrados
                RacasRepository ObjClnCargosRepository = new RacasRepository();//Criar Obj
                DataTable dtResultado = ObjClnCargosRepository.ListarCargosCombo().Tables[0];
                cboxCargoFunc.DataSource = null;
                cboxCargoFunc.DataSource = dtResultado;
                cboxCargoFunc.ValueMember = "COD";
                cboxCargoFunc.DisplayMember = "CARGO";
                cboxCargoFunc.SelectedItem = "Nenhum";
                cboxCargoFunc.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
                DateTime now = DateTime.Now;
                //txtDataInclusao.Text = Convert.ToString(now);
                if (cboxCargoFunc.SelectedItem == "")
                {
                    MessageBox.Show("Usuario esta desabilitado, informe seu supervisor.", "Problema ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Verifica se os campos nome e telefone estão preenchidos, porque são obrigatórios
            if ((txtNome.Text == ""))
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else if (cboxCargoFunc.Text == "Nenhum")
            {
                if (MessageBox.Show("Deseja Realmente Cadastrar o funcionario sem Cargo?", "SEM CARGO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    cboxCargoFunc.Focus();
                }
                else
                {
                    UserDefinitivoRepository ObjFunc = new UserDefinitivoRepository();
                    if (btnGravar.Text == "&Alterar")
                    {
                        ObjFunc.COD = Convert.ToInt32(txtCod.Text);
                    }
                    ObjFunc.NOME = txtNome.Text;
                    ObjFunc.NASCIMENTO = mtxtDataNasc.Text;
                    ObjFunc.RG = mtxtRG.Text;
                    ObjFunc.CPF = mtxtCPF.Text;
                    ObjFunc.DATAADMISSAO = mtxtDataAdmissao.Text;
                    ObjFunc.COD_CARGO = Convert.ToInt32(cboxCargoFunc.SelectedValue);
                    ObjFunc.SALARIO = txtRS.Text + txtSalario.Text;
                    //if (btnGravar.Text == "&Alterar")
                    //{
                    //    ObjFunc.COD = Convert.ToInt32(TxtCod.Text);
                    //}
                    if (ObjOperacao == ClnFuncoesGerais.Operacao.Inclusao)//Verifica se é inclusão faça
                    {
                        ObjFunc.Gravar();
                        MessageBox.Show("Usuario: " + txtNome.Text + ", cadastrado com sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Text = "";
                        mtxtDataNasc.Text = "";
                        mtxtRG.Text = "";
                        mtxtCPF.Text = "";
                        mtxtDataAdmissao.Text = "";
                        txtSalario.Text = "";
                        //CarregaDataGrid(); //Chama o Método Preencher a Grid
                    }
                    else if (ObjOperacao == ClnFuncoesGerais.Operacao.Alteracao)//Verifica se é alteração faça
                    {
                        ObjFunc.Alterar();
                        MessageBox.Show("Usuario " + txtNome.Text + ", Alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //CarregaDataGrid(); //Chama o Método Preencher a Grid
                        FrmBuscarUserDefinitivo ObjBuscarFunc = new FrmBuscarUserDefinitivo();
                        ObjBuscarFunc.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
                        ObjBuscarFunc.txtSenhaCookie.Text = txtSenhaCookie.Text;
                        ObjBuscarFunc.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                UserDefinitivoRepository ObjFunc = new UserDefinitivoRepository();
                if (btnGravar.Text == "&Alterar")
                {
                    ObjFunc.COD = Convert.ToInt32(txtCod.Text);
                }
                ObjFunc.NOME = txtNome.Text;
                ObjFunc.NASCIMENTO = mtxtDataNasc.Text;
                ObjFunc.RG = mtxtRG.Text;
                ObjFunc.CPF = mtxtCPF.Text;
                ObjFunc.DATAADMISSAO = mtxtDataAdmissao.Text;
                ObjFunc.COD_CARGO = Convert.ToInt32(cboxCargoFunc.SelectedValue);
                ObjFunc.SALARIO = txtRS.Text + txtSalario.Text;
                //if (btnGravar.Text == "&Alterar")
                //{
                //    ObjFunc.COD = Convert.ToInt32(TxtCod.Text);
                //}
                if (ObjOperacao == ClnFuncoesGerais.Operacao.Inclusao)//Verifica se é inclusão faça
                {
                    ObjFunc.Gravar();
                    MessageBox.Show("Usuario: " + txtNome.Text + ", cadastrado com sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Text = "";
                    mtxtDataNasc.Text = "";
                    mtxtRG.Text = "";
                    mtxtCPF.Text = "";
                    mtxtDataAdmissao.Text = "";
                    txtSalario.Text = "";
                    //CarregaDataGrid(); //Chama o Método Preencher a Grid
                }
                else if (ObjOperacao == ClnFuncoesGerais.Operacao.Alteracao)//Verifica se é alteração faça
                {
                    ObjFunc.Alterar();
                    MessageBox.Show("Usuario " + txtNome.Text + ", Alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //CarregaDataGrid(); //Chama o Método Preencher a Grid
                    FrmBuscarUserDefinitivo objBuscarFunc = new FrmBuscarUserDefinitivo();
                    objBuscarFunc.Show();
                    this.Close();
                }
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mtxtDataNasc.Text = "";
            mtxtRG.Text = "";
            mtxtCPF.Text = "";
            mtxtDataAdmissao.Text = "";
            txtSalario.Text = "";
        }

        private void gbDadosFuncionario_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void mtxtDataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gbSexo_Enter(object sender, EventArgs e)
        {

        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDadosPessoais_Click(object sender, EventArgs e)
        {

        }

        private void lblNomefunc_Click(object sender, EventArgs e)
        {

        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void lblRG_Click(object sender, EventArgs e)
        {

        }

        private void lblNasc_Click(object sender, EventArgs e)
        {

        }

        private void mtxtRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDadosDoCadastro_Click(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodFunc_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblSalario_Click(object sender, EventArgs e)
        {

        }

        private void txtRS_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtDataAdmissao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblDadosFunc_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboxCargoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCargoFunc_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbDadosPessoais_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
