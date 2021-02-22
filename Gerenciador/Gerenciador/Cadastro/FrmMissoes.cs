using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmMissoes : Form
    {
        public FrmMissoes()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        MissoesBusiness missoesBusiness = new MissoesBusiness();
        MissoesRepository missoesRepository = new MissoesRepository();
        public void CarregaDataGrid()
        {
            List<int> CodigoMestre = new List<int>();
            CodigoMestre = missoesBusiness.GetCodigoMestre(LblMestre.Text);

            //dgv.DataSource = ObjUsuario.ListarUsuariosCadUsuario(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgv.DataSource = missoesRepository.ListarDataGrid(CodigoMestre[0]).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("Missão");
            dgv.Columns[2].HeaderText = ("Solicitante");
            dgv.Columns[3].HeaderText = ("XP");
            dgv.Columns[4].HeaderText = ("Jades");
            dgv.Columns[5].HeaderText = ("Item");
            dgv.Columns[6].HeaderText = ("Concluida");
            dgv.Columns[7].HeaderText = ("Detalhes");
            dgv.Columns[8].HeaderText = ("Mestre");
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
        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.LblUser.Text = LblMestre.Text;
            frmMenuPrincipal.Show();
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            List<int> CodigoMestre = new List<int>();

            if (txtMissao.Text != "" && txtSolicitante.Text != "")
            {
                resultado.sucesso = false;

                TabMissoes tb_Missoes = new TabMissoes();
                tb_Missoes.MISSAO = txtMissao.Text;
                tb_Missoes.SOLICITANTE = txtSolicitante.Text;
                tb_Missoes.XP = Convert.ToInt32(txtXP.Text);
                tb_Missoes.JADES = Convert.ToInt32(txtJades.Text);
                tb_Missoes.ITEM = txtItem.Text;
                tb_Missoes.DETALHES = txtDetalhes.Text;

                CodigoMestre = missoesBusiness.GetCodigoMestre(LblMestre.Text);
                if (CodigoMestre.Count > 0)
                {
                    tb_Missoes.COD_MESTRE = CodigoMestre[0];
                    resultado = missoesBusiness.Gravar(tb_Missoes);
                }
                else
                    MessageBox.Show("Falha ao obter codigo do mestre, favor logar novamente", "F A L H A   C A D A S T R O");
                if (resultado.sucesso)
                {
                    MessageBox.Show("Missão Gravado com sucesso", "S U C E S S O");
                    txtMissao.Text = "";
                    txtSolicitante.Text = "";
                    txtXP.Text = "";
                    txtJades.Text = "";
                    txtItem.Text = "";
                    txtDetalhes.Text = "";
                    CarregaDataGrid();
                }
                else
                    MessageBox.Show("Falho no cadastro da missão", "F A L H A");
            }
            else
            {
                MessageBox.Show("Campos Missão e Solicitante são obrigatorios, favor preenche-los", "C A M P O   V A Z I O");
            }
            
        }

        private void FrmMissoes_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMissao.Text = "";
            txtSolicitante.Text = "";
            txtXP.Text = "";
            txtJades.Text = "";
            txtItem.Text = "";
            txtDetalhes.Text = "";
            CarregaDataGrid();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmMissoes objFrm = new FrmMissoes();
            if (BtnEditar.Text == "Alterar")
            {
                TabMissoes tb_Missoes = new TabMissoes();
                tb_Missoes.COD = Convert.ToInt32(LblCodigo.Text);
                tb_Missoes.MISSAO = txtMissao.Text;
                tb_Missoes.SOLICITANTE = txtSolicitante.Text;
                tb_Missoes.XP = Convert.ToInt32(txtXP.Text);
                tb_Missoes.JADES = Convert.ToInt32(txtJades.Text);
                tb_Missoes.ITEM = txtItem.Text;
                tb_Missoes.DETALHES = txtDetalhes.Text;

                resultado = missoesBusiness.Editar(tb_Missoes);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Editado com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objFrm.LblMestre.Text = LblMestre.Text;
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
                objFrm.LblMestre.Text = LblMestre.Text;

                objFrm.LblCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                objFrm.txtMissao.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                objFrm.txtSolicitante.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                objFrm.txtXP.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                objFrm.txtJades.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                objFrm.txtItem.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                objFrm.txtDetalhes.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                objFrm.dgv.Visible = false;
                objFrm.Show();
                Close();
                objFrm.BtnEditar.Text = "Alterar";
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int codigoClasse = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = missoesBusiness.Excluir(codigoClasse);
            if (resultado.sucesso)
            {
                MessageBox.Show("Excluido com sucesso. ", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Falha na Excluisão. Erro:" + resultado.exception, "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
