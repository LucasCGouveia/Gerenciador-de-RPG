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
    public partial class FrmCadItens : Form
    {
        public FrmCadItens()
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
            ItensRepository ObjContatos = new ItensRepository();//Criar Obj
            dgv.DataSource = ObjContatos.ListarContatos(LblCodigo.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("COD");
            dgv.Columns[1].HeaderText = ("Tipo");
            dgv.Columns[2].HeaderText = ("Contato");
            dgv.Columns[3].HeaderText = ("Observação");
            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                //btnRelatorio.Enabled = false; //Desativar os botões
                //btnConsultar.Enabled = false;
                BtnEditar.Enabled = false;
                BtnExcluir.Enabled = false;
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtContato.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
                txtContato.Focus();
            }
            else
            {
                //btnRelatorio.Enabled = true; //Ativar os botões
                //btnConsultar.Enabled = true;
                BtnEditar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmCadItens ObjCadEndereco = new FrmCadItens();
            ObjCadEndereco.Text = ">>> Alterar <<<";
            ObjCadEndereco.lblCodEndereco.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            ObjCadEndereco.LblCodigo.Text = LblCodigo.Text;
            ObjCadEndereco.lblNomeFuncionario.Text = lblNomeFuncionario.Text;
            ObjCadEndereco.cboxTipo.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.txtContato.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.txtObs.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value); //Envia para o campo código o valor do código marcado
            ObjCadEndereco.BtnEditar.Visible = false;
            ObjCadEndereco.BtnExcluir.Visible = false;
            ObjCadEndereco.btnGravar.Text = "&Alterar";
            ObjCadEndereco.txtContato.Focus();
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if ((txtContato.Text == ""))
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContato.Focus();
            }
            else
            {
                ItensRepository ObjClnEndereco = new ItensRepository();
                if (btnGravar.Text == "&Alterar")
                {
                    ObjClnEndereco.COD = Convert.ToInt32(lblCodEndereco.Text);
                }
                ObjClnEndereco.COD_FUNC = Convert.ToInt32(LblCodigo.Text);
                ObjClnEndereco.TIPO = cboxTipo.Text;
                ObjClnEndereco.CONTATO = txtContato.Text;
                ObjClnEndereco.OBS = txtObs.Text;

                if (ObjOperacao == ClnFuncoesGerais.Operacao.Inclusao)//Verifica se é inclusão faça
                {
                    ObjClnEndereco.Gravar();
                    MessageBox.Show("Contato de Tipo: " + cboxTipo.Text + ", cadastrado com sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboxTipo.Text = "";
                    txtContato.Text = "";
                    txtObs.Text = "";
                    CarregaDataGrid(); //Chama o Método Preencher a Grid
                }
                else if (ObjOperacao == ClnFuncoesGerais.Operacao.Alteracao)//Verifica se é alteração faça
                {
                    ObjClnEndereco.Alterar();
                    MessageBox.Show("Usuario " + txtContato.Text + ", Alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaDataGrid(); //Chama o Método Preencher a Grid
                    FrmCadSkills objCadContatos = new FrmCadSkills();
                    objCadContatos.LblCodigo.Text = LblCodigo.Text;
                    objCadContatos.lblNomeFuncionario.Text = lblNomeFuncionario.Text;
                    objCadContatos.Show();
                    this.Close();
                }
            }
        }

        private void FrmCadContatos_Load(object sender, EventArgs e)
        {
            try
            {
                //Carregar ComboBox de Cargos Cadastrados
                ItensRepository ObjClnContatosRepository = new ItensRepository();//Criar Obj
                DataTable dtResultado = ObjClnContatosRepository.ListarComboTiposContatos().Tables[0];
                cboxTipo.DataSource = null;
                cboxTipo.DataSource = dtResultado;
                cboxTipo.ValueMember = "COD";
                cboxTipo.DisplayMember = "TIPO";
                cboxTipo.SelectedItem = "Nenhum";
                cboxTipo.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
                DateTime now = DateTime.Now;
                //txtDataInclusao.Text = Convert.ToString(now);
                if (cboxTipo.SelectedItem == "")
                {
                    MessageBox.Show("Usuario esta desabilitado, informe seu supervisor.", "Problema ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {

                throw;
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

        private void lblCodEndereco_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void gbtxts_Enter(object sender, EventArgs e)
        {

        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void txtContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnderco_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

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
