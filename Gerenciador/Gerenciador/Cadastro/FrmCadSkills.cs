using Gerenciador.Repository;
using Gerenciador.Repository.BancoDados;
using Gerenciador.Buscas;
using Gerenciador.Secundarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Cadastro
{
    public partial class FrmCadSkills : Form
    {
        public FrmCadSkills()
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
            SkillsRepository ObjUsuario = new SkillsRepository();//Criar Obj
            dgv.DataSource = ObjUsuario.ListarEnderecos(LblCodigo.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("COD");
            dgv.Columns[1].HeaderText = ("Descrição");
            dgv.Columns[2].HeaderText = ("CEP");
            dgv.Columns[3].HeaderText = ("Endereço");
            dgv.Columns[4].HeaderText = ("Numero");
            dgv.Columns[5].HeaderText = ("Complemento");
            dgv.Columns[6].HeaderText = ("Bairro");
            dgv.Columns[7].HeaderText = ("Cidade");
            dgv.Columns[8].HeaderText = ("Estado");
            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                //btnRelatorio.Enabled = false; //Desativar os botões
                //btnConsultar.Enabled = false;
                BtnEditar.Enabled = false;
                BtnExcluir.Enabled = false;
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtEnd.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
                txtDescricao.Focus();
            }
            else
            {
                //btnRelatorio.Enabled = true; //Ativar os botões
                //btnConsultar.Enabled = true;
                BtnEditar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (lblValidacao.Text == "Excluidos")
            {
                FrmBuscaUserExcluido ObjBuscarFuncExcluidos = new FrmBuscaUserExcluido();
                ObjBuscarFuncExcluidos.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
                ObjBuscarFuncExcluidos.txtSenhaCookie.Text = txtSenhaCookie.Text;
                ObjBuscarFuncExcluidos.Show();
                this.Close();
            }
            else
            {
                FrmBuscarUserDefinitivo ObjBuscarFunc = new FrmBuscarUserDefinitivo();
                ObjBuscarFunc.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
                ObjBuscarFunc.txtSenhaCookie.Text = txtSenhaCookie.Text;
                ObjBuscarFunc.Show();
                this.Close();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if ((txtDescricao.Text == ""))
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Focus();
            }
            else
            {
                SkillsRepository ObjClnEndereco = new SkillsRepository();
                if (btnGravar.Text == "&Alterar")
                {
                    ObjClnEndereco.COD = Convert.ToInt32(lblCodEndereco.Text);
                }
                ObjClnEndereco.COD_FUNC = Convert.ToInt32(LblCodigo.Text);
                ObjClnEndereco.DESCRICAO = txtDescricao.Text;
                ObjClnEndereco.CEP = mtxtCEP.Text;
                ObjClnEndereco.ENDERECO = txtEnd.Text;
                ObjClnEndereco.NUMERO = mtxtNumero.Text;
                ObjClnEndereco.COMPLEMENTO = txtComplemento2.Text;
                ObjClnEndereco.BAIRRO = txtBairro.Text;
                ObjClnEndereco.CIDADE = txtCidade.Text;
                ObjClnEndereco.ESTADO = cboxEstado.Text;

                if (ObjOperacao == ClnFuncoesGerais.Operacao.Inclusao)//Verifica se é inclusão faça
                {
                    ObjClnEndereco.Gravar();
                    MessageBox.Show("Usuario: " + txtEnd.Text + ", cadastrado com sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescricao.Text = "";
                    mtxtCEP.Text = "";
                    txtEnd.Text = "";
                    mtxtNumero.Text = "";
                    txtComplemento2.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    cboxEstado.Text = "";
                    CarregaDataGrid(); //Chama o Método Preencher a Grid
                }
                else if (ObjOperacao == ClnFuncoesGerais.Operacao.Alteracao)//Verifica se é alteração faça
                {
                    ObjClnEndereco.Alterar();
                    MessageBox.Show("Usuario " + txtEnd.Text + ", Alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaDataGrid(); //Chama o Método Preencher a Grid
                    FrmCadItens objCadEnderecos = new FrmCadItens();
                    objCadEnderecos.LblCodigo.Text = LblCodigo.Text;
                    objCadEnderecos.lblNomeFuncionario.Text = lblNomeFuncionario.Text;
                    objCadEnderecos.Show();
                    this.Close();
                }
            }
        }

        private void FrmCadEndereco_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            mtxtCEP.Text = "";
            txtEnd.Text = "";
            mtxtNumero.Text = "";
            txtComplemento2.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cboxEstado.Text = "";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmCadSkills ObjCadEndereco = new FrmCadSkills();
            ObjCadEndereco.Text = ">>> Alterar <<<";
            //ObjCadEndereco.lblSenha.Text = "Necessario Logar para alterar a senha";
            //ObjCadEndereco.LblPesquisar.Text = "Atenção voce esta alterando o Usuario:";
            ObjCadEndereco.lblCodEndereco.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            ObjCadEndereco.LblCodigo.Text = LblCodigo.Text;
            ObjCadEndereco.lblNomeFuncionario.Text = lblNomeFuncionario.Text;
            ObjCadEndereco.txtDescricao.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.mtxtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.txtEnd.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.mtxtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.txtComplemento2.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.cboxEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.BtnEditar.Visible = false;
            ObjCadEndereco.BtnExcluir.Visible = false;
            ObjCadEndereco.btnGravar.Text = "&Alterar";
            ObjCadEndereco.txtEnd.Focus();
            ObjCadEndereco.EnumProperty = ClnFuncoesGerais.Operacao.Alteracao; //Informa que é Alteração
            ObjCadEndereco.ShowDialog();
            CarregaDataGrid();
            this.Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int msg; //Pergunta e aguarda resposta
            msg = Convert.ToInt32(MessageBox.Show("Deseja excluir o registro? " + Convert.ToString(dgv.CurrentRow.Cells[0].Value), "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));//msg aguardando resposta

            //Exclusão física, será apagado do BD
            if (msg == 6) //6 representa Yes e 7 No
            {
                ItensRepository objUsuario = new ItensRepository(); //Apagar da Agenda
                objUsuario.Excluir(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)); //Por Código
                MessageBox.Show("Registro excluído com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELAMENTO E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregaDataGrid();
        }

        private void gbResultadoDaPesquisa_Enter(object sender, EventArgs e)
        {

        }

        private void lblResultadoDaPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void lblDadosDoCadastro_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNomeFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void LblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void gbtxts_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void cboxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblCidade2_Click(object sender, EventArgs e)
        {

        }

        private void mtxtNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void mtxtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtComplemento2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBairro_Click(object sender, EventArgs e)
        {

        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComplemento_Click(object sender, EventArgs e)
        {

        }

        private void txtEnderco_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void lblCodEndereco_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaCookie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioCookie_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblValidacao_Click(object sender, EventArgs e)
        {

        }
    }
}
