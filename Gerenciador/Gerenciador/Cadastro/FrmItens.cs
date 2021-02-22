using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;

using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmItens : Form
    {
        public FrmItens()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        ItensBusiness itensBusiness = new ItensBusiness();
        ItensRepository itensRepository = new ItensRepository();
        PersonagensBusiness personagensBusiness = new PersonagensBusiness();
        public void CarregaDataGrid()
        {
            //dgv.DataSource = ObjUsuario.ListarUsuariosCadUsuario(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgv.DataSource = itensRepository.ListarDataGrid(lblTipoItem.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("Item");
            dgv.Columns[2].HeaderText = ("Tipo");
            dgv.Columns[3].HeaderText = ("Dano");
            dgv.Columns[4].HeaderText = ("Bonus");
            dgv.Columns[5].HeaderText = ("Valor");
            dgv.Columns[6].HeaderText = ("Descrição");
            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                BtnEditar.Enabled = false;
                BtnExcluir.Enabled = false;
                //MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
                //txtPesquisa.Text = "";
                //txtPesquisa.Focus();
            }
            else
            {
                BtnEditar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Verifica se os campos obrigatórios estão preenchidos
            if (txtItem.Text == "" && txtDescricao.Text == "")
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItem.Focus();
            }
            else
            {
                resultado = itensBusiness.Gravar(txtItem.Text, cBoxTipo.Text, txtDano.Text, txtBonus.Text, txtValor.Text, txtDescricao.Text);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Gravado. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItem.Text = "";
                    cBoxTipo.Text = "";
                    txtDano.Text = "";
                    txtBonus.Text = "";
                    txtValor.Text = "";
                    txtDescricao.Text = "";
                    CarregaDataGrid();
                }
                else
                {
                    MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.LblUser.Text = LblUser.Text;
            frmMenuPrincipal.Show();
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int codigoClasse = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = itensBusiness.Desativar(codigoClasse);
            if (resultado.sucesso)
            {
                MessageBox.Show("Excluido com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItem.Text = "";
                txtDescricao.Text = "";
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmItens objFrm = new FrmItens();
            if (BtnEditar.Text == "Alterar")
            {
                resultado = itensBusiness.Editar(LblCodItem.Text, txtItem.Text, cBoxTipo.Text, txtDano.Text, txtBonus.Text, txtValor.Text, txtDescricao.Text);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Editado com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objFrm.LblUser.Text = LblUser.Text;
                    objFrm.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objFrm.Show();
                    Close();
                }
            }
            else
            {
                objFrm.btnGravar.Visible = false;
                objFrm.BtnExcluir.Visible = false;
                objFrm.btnLimpar.Visible = false;
                objFrm.dgv.Visible = false;
                objFrm.LblUser.Text = LblUser.Text;
                objFrm.LblCodItem.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                objFrm.txtItem.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                objFrm.cBoxTipo.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                objFrm.txtDano.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                objFrm.txtBonus.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                objFrm.txtValor.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                objFrm.txtDescricao.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                objFrm.dgv.Visible = false;
                objFrm.Show();
                Close();
                objFrm.BtnEditar.Text = "Alterar";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtItem.Text = "";
            txtDescricao.Text = "";
        }
        private void FrmSkills_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opa!!! falha ao carregar usuarios cadastrados.\nExceção: " + ex, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            string ValorItem = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            int ValorItemConvertido = Convert.ToInt32(ValorItem.Replace(".", ""));
            int DinheiroPersonagem = Convert.ToInt32(txtJades.Text);
            if (DinheiroPersonagem > ValorItemConvertido)
            {
                int Resultado = DinheiroPersonagem - ValorItemConvertido;

                txtJades.Text = Convert.ToString(Resultado);
                resultado = personagensBusiness.VenderItem(Resultado, LblPersonagem.Text);
                if (resultado.sucesso)
                {
                    string Item = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                    string Tipo = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                    string Dano = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                    string Bonus = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                    string Valor = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                    string Descricao = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                    resultado = itensBusiness.AdicionarPersonagem(Item, Tipo, Dano, Bonus, Valor, Descricao, LblPersonagem.Text);
                    if (resultado.sucesso)
                    {
                        MessageBox.Show("Compra feita com sucesso", "S U C E S S O");
                    }
                }
                else
                {
                    MessageBox.Show("Valha na negociação Exceção:" + resultado.exception, "F A L H A   N A   V E N D A");
                }
            }
            else
            {
                MessageBox.Show("Você não tem dinheiro para isso. Faça mais missões", "S E M   D I N H E I R O");
            }

        }

        private void FrmItens_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void BtnSair2_Click(object sender, EventArgs e)
        {
            FrmAddAtributos frmAddAtributos = new FrmAddAtributos();
            frmAddAtributos.LblCampanha.Text = LblCampanha.Text;
            frmAddAtributos.LblUser.Text = LblUser.Text;
            frmAddAtributos.LblPersonagem.Text = LblPersonagem.Text;
            frmAddAtributos.Show();
            Close();
        }
    }
}
