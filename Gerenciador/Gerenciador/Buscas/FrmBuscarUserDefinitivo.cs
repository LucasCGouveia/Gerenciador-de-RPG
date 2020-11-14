using Gerenciador.Repository;
using Gerenciador.Repository.BancoDados;
using Gerenciador.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Buscas
{
    public partial class FrmBuscarUserDefinitivo : Form
    {
        public FrmBuscarUserDefinitivo()
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

        public void CarregaDataGrid()
        {
            UserDefinitivoRepository ObjFunc = new UserDefinitivoRepository();//Criar Obj
            dgv.DataSource = ObjFunc.ListarFuncionarios(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("CODIGO");
            dgv.Columns[1].HeaderText = ("Nome");
            dgv.Columns[2].HeaderText = ("Nascimento");
            dgv.Columns[3].HeaderText = ("RG");
            dgv.Columns[4].HeaderText = ("CPF");
            dgv.Columns[5].HeaderText = ("Cargo");
            dgv.Columns[6].HeaderText = ("Salario");
            dgv.Columns[7].HeaderText = ("Data Admissão");
            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                //btnRelatorio.Enabled = false; //Desativar os botões
                //btnConsultar.Enabled = false;
                btnGerContato.Enabled = false;
                btnGerEndereco.Enabled = false;
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
                txtPesquisa.Text = "";
                txtPesquisa.Focus();
            }
            else
            {
                //btnRelatorio.Enabled = true; //Ativar os botões
                //btnConsultar.Enabled = true;
                btnGerContato.Enabled = true;
                btnGerEndereco.Enabled = true;
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
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
                ObjMenu.BtnGerencia.Visible = false;
                ObjMenu.Show();
                this.Close();

            }
        }

        private void FrmBuscarFunc_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnGerEndereco_Click(object sender, EventArgs e)
        {
            FrmCadSkills ObjCadEndereco = new FrmCadSkills();
            ObjCadEndereco.LblCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.lblNomeFuncionario.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.Show();
            this.Close();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmCadUserDefinitivo ObjCadFuncionarios = new FrmCadUserDefinitivo();
            ObjCadFuncionarios.Text = ">>> Alterar <<<";
            //ObjCadCargos.LblPesquisar.Text = "Atenção voce esta alterando o Usuario:";
            ObjCadFuncionarios.btnLimpar.Visible = false;
            ObjCadFuncionarios.btnGravar.Text = "&Alterar";
            ObjCadFuncionarios.txtCod.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value); //Envia para o campo código o valor do código marcado
            ObjCadFuncionarios.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value); //Envia para o campo código o valor do código marcado
            ObjCadFuncionarios.mtxtDataNasc.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value); //Envia para o campo código o valor do código marcado
            ObjCadFuncionarios.mtxtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value); //Envia para o campo código o valor do código marcado
            ObjCadFuncionarios.mtxtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value); //Envia para o campo código o valor do código marcado
            ObjCadFuncionarios.cboxCargoFunc.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value); //Envia para o campo código o valor do código marcado
            ObjCadFuncionarios.txtSalario.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value); //Envia para o campo código o valor do código marcado
            ObjCadFuncionarios.mtxtDataAdmissao.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value); //Envia para o campo código o valor do código marcado
            ObjCadFuncionarios.txtNome.Focus();
            ObjCadFuncionarios.EnumProperty = ClnFuncoesGerais.Operacao.Alteracao; //Informa que é Alteração
            ObjCadFuncionarios.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjCadFuncionarios.txtSenhaCookie.Text = txtSenhaCookie.Text;
            ObjCadFuncionarios.ShowDialog();
            this.Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int msg; //Pergunta e aguarda resposta
            msg = Convert.ToInt32(MessageBox.Show("Deseja excluir o registro? " + Convert.ToString(dgv.CurrentRow.Cells[1].Value), "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));//msg aguardando resposta

            //Exclusão física, será apagado do BD
            if (msg == 6) //6 representa Yes e 7 No
            {
                UsuarioRepository objUsuario = new UsuarioRepository(); //Apagar da Agenda
                objUsuario.Excluir(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)); //Por Código
                MessageBox.Show("Registro excluído com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELAMENTO E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregaDataGrid();
        }

        private void btnGerContato_Click(object sender, EventArgs e)
        {
            FrmCadItens ObjCadContatos = new FrmCadItens();
            ObjCadContatos.LblCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value); //Envia para o campo código o valor do código marcado
            ObjCadContatos.lblNomeFuncionario.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value); //Envia para o campo código o valor do código marcado
            ObjCadContatos.Show();
            this.Close();
        }

        private void txtUsuarioCookie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaCookie_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbResultadoDaPesquisa_Enter(object sender, EventArgs e)
        {

        }

        private void lblResultadoDaPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void gbPesquisa_Enter(object sender, EventArgs e)
        {

        }

        private void lblPsquisaRapida_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDadosDoCadastro_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBuscarUserDefinitivo_Load(object sender, EventArgs e)
        {

        }
    }
}
