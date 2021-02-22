using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmSkills : Form
    {
        public FrmSkills()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        TabSkills tb_Skills = new TabSkills();

        SkillsBusiness skillsBusiness = new SkillsBusiness();
        PersonagensBusiness personagensBusiness = new PersonagensBusiness();

        SkillsRepository skillsRepository = new SkillsRepository();
        public void CarregaDataGrid()
        {
            dgv.DataSource = skillsRepository.ListarDataGrid(lblTipoItem.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("Skill");
            dgv.Columns[2].HeaderText = ("Tipo");
            dgv.Columns[2].HeaderText = ("Nivel");
            dgv.Columns[3].HeaderText = ("Dano");
            dgv.Columns[4].HeaderText = ("Bonus");
            dgv.Columns[5].HeaderText = ("Valor");
            dgv.Columns[3].HeaderText = ("Tempo");
            dgv.Columns[4].HeaderText = ("Alcance");
            dgv.Columns[5].HeaderText = ("Duração");
            dgv.Columns[6].HeaderText = ("Descrição");
            dgv.AutoResizeColumns(); 
            if (dgv.RowCount == 0) 
            {
                BtnEditar.Enabled = false;
                BtnExcluir.Enabled = false;
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; 
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
                tb_Skills.SKILL = txtSkill.Text;
                tb_Skills.TIPO = cBoxTipo.Text;
                tb_Skills.NIVEL = txtNivel.Text;
                tb_Skills.DANO = txtDano.Text;
                tb_Skills.BONUS = txtBonus.Text;
                tb_Skills.VALOR = txtValor.Text;
                tb_Skills.TEMPO = txtTempo.Text;
                tb_Skills.ALCANCE = txtAlcance.Text;
                tb_Skills.DURACAO = txtDuracao.Text;
                tb_Skills.DESCRICAO = txtDescricao.Text;
                resultado = skillsBusiness.Gravar(tb_Skills);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Gravado. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSkill.Text = "";
                    cBoxTipo.Text = "";
                    txtNivel.Text = "";
                    txtDano.Text = "";
                    txtBonus.Text = "";
                    txtValor.Text = "";
                    txtTempo.Text = "";
                    txtAlcance.Text = "";
                    txtDuracao.Text = "";
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

        private void FrmSkills_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            string ValorItem = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            int ValorItemConvertido = Convert.ToInt32(ValorItem.Replace(".", ""));
            int DinheiroPersonagem = Convert.ToInt32(txtJades.Text);
            if (DinheiroPersonagem > ValorItemConvertido)
            {
                int Resultado = DinheiroPersonagem - ValorItemConvertido;

                //MessageBox.Show("", "");

                resultado = personagensBusiness.VenderItem(Resultado, LblPersonagem.Text);
                if (resultado.sucesso)
                {
                    tb_Skills.SKILL = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                    tb_Skills.TIPO = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                    tb_Skills.NIVEL = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                    tb_Skills.DANO = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                    tb_Skills.BONUS = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                    tb_Skills.VALOR = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                    tb_Skills.TEMPO = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                    tb_Skills.ALCANCE = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
                    tb_Skills.DURACAO = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                    tb_Skills.DESCRICAO = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
                    tb_Skills.COD_PERSONAGEM = Convert.ToInt32(LblPersonagem.Text);
                    resultado = skillsBusiness.AdicionarPersonagem(tb_Skills);
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

        private void BtnSair2_Click(object sender, EventArgs e)
        {
            FrmAddAtributos frmAddAtributos = new FrmAddAtributos();
            frmAddAtributos.LblCampanha.Text = LblCampanha.Text;
            frmAddAtributos.LblUser.Text = LblUser.Text;
            frmAddAtributos.LblPersonagem.Text = LblPersonagem.Text;
            frmAddAtributos.Show();
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = skillsBusiness.Desativar(codigo);
            if (resultado.sucesso)
            {
                MessageBox.Show("Excluido com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSkill.Text = "";
                cBoxTipo.Text = "";
                txtNivel.Text = "";
                txtDano.Text = "";
                txtBonus.Text = "";
                txtValor.Text = "";
                txtTempo.Text = "";
                txtAlcance.Text = "";
                txtDuracao.Text = "";
                txtDescricao.Text = "";
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSkill.Text = "";
            cBoxTipo.Text = "";
            txtNivel.Text = "";
            txtDano.Text = "";
            txtBonus.Text = "";
            txtValor.Text = "";
            txtTempo.Text = "";
            txtAlcance.Text = "";
            txtDuracao.Text = "";
            txtDescricao.Text = "";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmSkills objFrm = new FrmSkills();
            if (BtnEditar.Text == "Alterar")
            {
                tb_Skills.COD = Convert.ToInt32(LblCodItem.Text);
                tb_Skills.SKILL = txtSkill.Text;
                tb_Skills.TIPO = cBoxTipo.Text;
                tb_Skills.NIVEL = txtNivel.Text;
                tb_Skills.DANO = txtDano.Text;
                tb_Skills.BONUS = txtBonus.Text;
                tb_Skills.VALOR = txtValor.Text;
                tb_Skills.TEMPO = txtTempo.Text;
                tb_Skills.ALCANCE = txtAlcance.Text;
                tb_Skills.DURACAO = txtDuracao.Text;
                tb_Skills.DESCRICAO = txtDescricao.Text;
                resultado = skillsBusiness.Editar(tb_Skills);
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
                objFrm.txtSkill.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                objFrm.cBoxTipo.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                objFrm.txtNivel.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                objFrm.txtDano.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                objFrm.txtBonus.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                objFrm.txtValor.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                objFrm.txtTempo.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                objFrm.txtAlcance.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
                objFrm.txtDuracao.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                objFrm.txtDescricao.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
                //tb_Skills.COD_PERSONAGEM = Convert.ToInt32(LblPersonagem.Text);
                objFrm.dgv.Visible = false;
                objFrm.Show();
                Close();
                objFrm.BtnEditar.Text = "Alterar";
            }
        }
    }
}
