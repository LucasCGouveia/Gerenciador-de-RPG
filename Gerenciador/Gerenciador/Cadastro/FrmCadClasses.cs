using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmCadClasses : Form
    {
        Resultado resultado = new Resultado();
        ClassesBusiness classesBusiness = new ClassesBusiness();
        ClassesRepository classesRepository = new ClassesRepository();
        public FrmCadClasses()
        {
            InitializeComponent();
        }
        public void CarregaDataGrid()
        {
            //dgv.DataSource = ObjUsuario.ListarUsuariosCadUsuario(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgv.DataSource = classesRepository.ListarDataGrid().Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
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
        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Verifica se os campos obrigatórios estão preenchidos
            if (txtClasse.Text == "" && txtDescricao.Text == "")
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClasse.Focus();
            }
            else
            {
                resultado = classesBusiness.GravarClasse(txtClasse.Text, txtDescricao.Text);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Gravado. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtClasse.Text = "";
                    txtDescricao.Text = "";
                    CarregaDataGrid();
                }
                else
                {
                    MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmCadClasses_Load(object sender, EventArgs e)
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciamento frmGerenciamento = new FrmGerenciamento();
            frmGerenciamento.LblMestre.Text = LblMestre.Text;
            frmGerenciamento.Show();
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int codigoClasse = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = classesBusiness.DesativarClasse(codigoClasse);
            if (resultado.sucesso)
            {
                MessageBox.Show("Excluido com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClasse.Text = "";
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
            FrmCadClasses frmCadClasses = new FrmCadClasses();
            if (BtnEditar.Text == "Alterar")
            {
                resultado = classesBusiness.EditarClasse(LblCodClasse.Text, txtClasse.Text, txtDescricao.Text);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Editado com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtClasse.Text = "";
                    txtDescricao.Text = "";
                    frmCadClasses.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCadClasses.Show();
                    Close();
                }
            }
            else
            {
                frmCadClasses.btnGravar.Visible = false;
                frmCadClasses.BtnExcluir.Visible = false;
                frmCadClasses.btnLimpar.Visible = false;
                frmCadClasses.dgv.Visible = false;
                frmCadClasses.LblCodClasse.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                frmCadClasses.txtClasse.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                frmCadClasses.txtDescricao.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                frmCadClasses.dgv.Visible = false; 
                frmCadClasses.Show();
                Close();
                frmCadClasses.BtnEditar.Text = "Alterar";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtClasse.Text = "";
            txtDescricao.Text = "";
        }
    }
}
