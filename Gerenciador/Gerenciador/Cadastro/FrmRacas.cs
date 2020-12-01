using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;

using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmRacas : Form
    {
        Resultado resultado = new Resultado();
        RacasBusiness racasBusiness = new RacasBusiness();
        RacasRepository racasRepository = new RacasRepository();
        public FrmRacas()
        {
            InitializeComponent();
        }
        public void CarregaDataGrid()
        {
            //dgv.DataSource = ObjUsuario.ListarUsuariosCadUsuario(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgv.DataSource = racasRepository.ListarDataGrid().Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("Classe");
            dgv.Columns[2].HeaderText = ("Descrição");
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
        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            //Verifica se os campos obrigatórios estão preenchidos
            if (txtRaca.Text == "" && txtDescricao.Text == "")
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRaca.Focus();
            }
            else
            {
                resultado = racasBusiness.GravarClasse(txtRaca.Text, txtDescricao.Text);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Gravado. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRaca.Text = "";
                    txtDescricao.Text = "";
                    CarregaDataGrid();
                }
                else
                {
                    MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtRaca.Text = "";
            txtDescricao.Text = "";
        }

        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            int codigoClasse = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = racasBusiness.Desativar(codigoClasse);
            if (resultado.sucesso)
            {
                MessageBox.Show("Excluido com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRaca.Text = "";
                txtDescricao.Text = "";
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            FrmRacas frmRacas = new FrmRacas();
            if (BtnEditar.Text == "Alterar")
            {
                resultado = racasBusiness.Editar(LblCodRacas.Text, txtRaca.Text, txtDescricao.Text);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Editado com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRaca.Text = "";
                    txtDescricao.Text = "";
                    frmRacas.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmRacas.Show();
                    Close();
                }
            }
            else
            {
                frmRacas.btnGravar.Visible = false;
                frmRacas.BtnExcluir.Visible = false;
                frmRacas.btnLimpar.Visible = false;
                frmRacas.dgv.Visible = false;
                frmRacas.LblCodRacas.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                frmRacas.txtRaca.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                frmRacas.txtDescricao.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                frmRacas.dgv.Visible = false;
                frmRacas.Show();
                Close();
                frmRacas.BtnEditar.Text = "Alterar";
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            FrmGerenciamento frmGerenciamento = new FrmGerenciamento();
            frmGerenciamento.LblMestre.Text = LblMestre.Text;
            frmGerenciamento.Show();
            Close();
        }

        private void FrmRacas_Load(object sender, EventArgs e)
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
    }
}
