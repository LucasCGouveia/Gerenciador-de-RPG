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
using Gerenciador.Principais;

namespace Gerenciador.Secundarios
{
    public partial class FrmBuscaUserExcluido : Form
    {
        public FrmBuscaUserExcluido()
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
            dgv.DataSource = ObjFunc.ListarFuncionariosExcluidos(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
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
        private void FrmFuncExcluidos_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciamento ObjGer = new FrmGerenciamento();
            ObjGer.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjGer.txtSenhaCookie.Text = txtSenhaCookie.Text;
            ObjGer.Show();
            Close();
        }

        private void btnGerContato_Click(object sender, EventArgs e)
        {
            FrmCadSkills ObjCadContatos = new FrmCadSkills();
            ObjCadContatos.LblCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value); //Envia para o campo código o valor do código marcado
            ObjCadContatos.lblNomeFuncionario.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value); //Envia para o campo código o valor do código marcado
            ObjCadContatos.lblValidacao.Text = "Excluidos";
            ObjCadContatos.btnGravar.Visible = false;
            ObjCadContatos.btnLimpar.Visible = false;
            ObjCadContatos.BtnEditar.Visible = false;
            ObjCadContatos.BtnExcluir.Visible = false;
            ObjCadContatos.gbtxts.Visible = false;
            ObjCadContatos.Show();
            this.Close();
        }

        private void btnGerEndereco_Click(object sender, EventArgs e)
        {
            FrmCadItens ObjCadEndereco = new FrmCadItens();
            ObjCadEndereco.LblCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.lblNomeFuncionario.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.lblValidacao.Text = "Excluidos";
            ObjCadEndereco.btnGravar.Visible = false;
            ObjCadEndereco.btnLimpar.Visible = false;
            ObjCadEndereco.BtnEditar.Visible = false;
            ObjCadEndereco.BtnExcluir.Visible = false;
            ObjCadEndereco.gbtxts.Visible = false;
            ObjCadEndereco.Show();
            this.Close();
        }

        private void BtnAtivar_Click(object sender, EventArgs e)
        {
            int msg; //Pergunta e aguarda resposta
            msg = Convert.ToInt32(MessageBox.Show("Deseja Ativar o Funcionario? " + Convert.ToString(dgv.CurrentRow.Cells[1].Value), "Ativar funcionario excluido", MessageBoxButtons.YesNo, MessageBoxIcon.Information));//msg aguardando resposta

            //Exclusão física, será apagado do BD
            if (msg == 6) //6 representa Yes e 7 No
            {
                UserDefinitivoRepository objFunc = new UserDefinitivoRepository(); //Apagar da Agenda
                objFunc.AtivarFunc(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)); //Por Código
                MessageBox.Show("Usuario ativado com sucesso", "Ativar Funcionario excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "Ativar Funcionario excluido CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregaDataGrid();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //int msg; //Pergunta e aguarda resposta
            //msg = Convert.ToInt32(MessageBox.Show("Deseja Ativar o Usuario? " + Convert.ToString(dgv.CurrentRow.Cells[1].Value), "Ativar usuario Desabilitado", MessageBoxButtons.YesNo, MessageBoxIcon.Information));//msg aguardando resposta

            ////Exclusão física, será apagado do BD
            //if (msg == 6) //6 representa Yes e 7 No
            //{
            //    ClnFuncRepository objFunc = new ClnFuncRepository(); //Apagar da Agenda
            //    objFunc.AtivarFunc(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)); //Por Código
            //    MessageBox.Show("Usuario atribuido com sucesso", "A T R I B U I Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("OPERAÇÃO CANCELADA", "A T R I B U I Ç Ã O CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //CarregaDataGrid();
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

        private void txtSenhaCookie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioCookie_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDadosDoCadastro_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmFuncExcluidos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
