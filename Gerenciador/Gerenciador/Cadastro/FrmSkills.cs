using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmSkills : Form
    {
        Resultado resultado = new Resultado();
        SkillsBusiness skillsBusiness = new SkillsBusiness();
        SkillsRepository skillsRepository = new SkillsRepository();
        public FrmSkills()
        {
            InitializeComponent();
        }
        public void CarregaDataGrid()
        {
            //dgv.DataSource = ObjUsuario.ListarUsuariosCadUsuario(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgv.DataSource = skillsRepository.ListarDataGrid().Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
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
            if (txtSkill.Text == "" && txtDescricao.Text == "")
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSkill.Focus();
            }
            else
            {
                resultado = skillsBusiness.GravarClasse(txtSkill.Text, txtDescricao.Text);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Gravado. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSkill.Text = "";
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
            frmMenuPrincipal.Show();
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int codigoClasse = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = skillsBusiness.Desativar(codigoClasse);
            if (resultado.sucesso)
            {
                MessageBox.Show("Excluido com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSkill.Text = "";
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
            FrmSkills objFrm = new FrmSkills();
            if (BtnEditar.Text == "Alterar")
            {
                resultado = skillsBusiness.Editar(LblCodSkill.Text, txtSkill.Text, txtDescricao.Text);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Editado com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSkill.Text = "";
                    txtDescricao.Text = "";
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
                objFrm.LblCodSkill.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                objFrm.txtSkill.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                objFrm.txtDescricao.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                objFrm.dgv.Visible = false;
                objFrm.Show();
                Close();
                objFrm.BtnEditar.Text = "Alterar";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSkill.Text = "";
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
    }
}
