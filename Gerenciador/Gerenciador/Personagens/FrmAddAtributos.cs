using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmAddAtributos : Form
    {
        public FrmAddAtributos()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        TabAtributos tb_Atributos = new TabAtributos();
        TabPersonagens tb_Personagens = new TabPersonagens();

        PersonagensBusiness personagensBusiness = new PersonagensBusiness();
        AtributosBusiness atributosBusiness = new AtributosBusiness();

        ItensRepository itensRepository = new ItensRepository();
        SkillsRepository skillsRepository = new SkillsRepository();
        public void GetDadosPersonagem()
        {
            tb_Personagens.COD = Convert.ToInt32(LblPersonagem.Text);
            tb_Personagens = personagensBusiness.GetDadosPersonagem(tb_Personagens, tb_Atributos);
            txtNome.Text = tb_Personagens.NOME;
            cBoxRaca.Text = tb_Personagens.RACA;
            cBoxClasse.Text = tb_Personagens.CLASSE;
            cBoxAlinhamento.Text = tb_Personagens.ALINHAMENTO;
            txtClasseArmadura.Text = Convert.ToString(tb_Personagens.CA);
            txtPontosVida.Text = Convert.ToString(tb_Personagens.PVTOTAL);
            txtPontosVidaAtuais.Text = Convert.ToString(tb_Personagens.PVATUAL);
            txtPontosAtaque.Text = Convert.ToString(tb_Personagens.PATAQUE);
            txtIniciativa.Text = Convert.ToString(tb_Personagens.INICIATIVA);
            txtJades.Text = Convert.ToString(tb_Personagens.DINHEIRO);
            txtExperiencia.Text = Convert.ToString(tb_Personagens.EXPERIENCIA);
            txtNivel.Text = Convert.ToString(tb_Personagens.NIVEL);
            txtFOR.Text = Convert.ToString(tb_Atributos.FORC);
            txtDES.Text = Convert.ToString(tb_Atributos.DEST);
            txtCON.Text = Convert.ToString(tb_Atributos.CONS);
            txtINT.Text = Convert.ToString(tb_Atributos.INTE);
            txtSAB.Text = Convert.ToString(tb_Atributos.SABE);
            txtCAR.Text = Convert.ToString(tb_Atributos.CARI);
            txtDescricao.Text = tb_Personagens.HISTORIA;
        }
        public void CarregaDataGridArmas()
        {
            //dgv.DataSource = ObjUsuario.ListarUsuariosCadUsuario(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgvArmas.DataSource = itensRepository.ListarDataGridArmas(tb_Personagens).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgvArmas.Columns[0].HeaderText = ("Item");
            dgvArmas.Columns[1].HeaderText = ("Tipo");
            dgvArmas.Columns[2].HeaderText = ("Dano");
            dgvArmas.Columns[3].HeaderText = ("Bonus");
            dgvArmas.Columns[4].HeaderText = ("Valor");
            dgvArmas.Columns[5].HeaderText = ("Descrição");
            dgvArmas.Columns[6].HeaderText = ("Codigo");
            dgvArmas.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgvArmas.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                //MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvArmas.DataSource = null; //Limpa o cabeçalho
                //txtPesquisa.Text = "";
                //txtPesquisa.Focus();
            }
            else
            {

            }
        }
        public void CarregaDataGridInventario()
        {
            //dgv.DataSource = ObjUsuario.ListarUsuariosCadUsuario(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgvInventario.DataSource = itensRepository.ListarDataGridInventario(tb_Personagens).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgvInventario.Columns[0].HeaderText = ("Item");
            dgvInventario.Columns[1].HeaderText = ("Tipo");
            dgvInventario.Columns[2].HeaderText = ("Dano");
            dgvInventario.Columns[3].HeaderText = ("Bonus");
            dgvInventario.Columns[4].HeaderText = ("Valor");
            dgvInventario.Columns[5].HeaderText = ("Descrição");
            dgvInventario.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgvInventario.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                //MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvInventario.DataSource = null; //Limpa o cabeçalho
                //txtPesquisa.Text = "";
                //txtPesquisa.Focus();
            }
            else
            {

            }
        }
        public void CarregaDataGridSkills()
        {
            dgvSkills.DataSource = skillsRepository.ListarDataGridSkills(tb_Personagens).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgvSkills.Columns[0].HeaderText = ("Codigo");
            dgvSkills.Columns[1].HeaderText = ("Skill");
            dgvSkills.Columns[2].HeaderText = ("Tipo");
            dgvSkills.Columns[3].HeaderText = ("Nivel");
            dgvSkills.Columns[4].HeaderText = ("Dano");
            dgvSkills.Columns[5].HeaderText = ("Bonus");
            dgvSkills.Columns[6].HeaderText = ("Valor");
            dgvSkills.Columns[7].HeaderText = ("Tempo");
            dgvSkills.Columns[8].HeaderText = ("Alcance");
            dgvSkills.Columns[9].HeaderText = ("Duração");
            dgvSkills.Columns[10].HeaderText = ("Descrição");
            dgvSkills.AutoResizeColumns();
            if (dgvSkills.RowCount == 0)
            {
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSkills.DataSource = null;
            }
            else
            {
            }
        }
        private void FrmAddAtributos_Load(object sender, EventArgs e)
        {
            List<int> CodAtributo = atributosBusiness.GetCodAtributos(Convert.ToInt32(LblPersonagem.Text));
            LblAtributo.Text = Convert.ToString(CodAtributo[0]);

            GetDadosPersonagem();
            CarregaDataGridArmas();
            CarregaDataGridSkills();
            CarregaDataGridInventario();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciarMesa frmGerenciarMesa = new FrmGerenciarMesa();
            frmGerenciarMesa.LblMestre.Text = LblUser.Text;
            frmGerenciarMesa.LblCampanha.Text = LblCampanha.Text;
            frmGerenciarMesa.Show();
            Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            tb_Personagens.COD = Convert.ToInt32(LblPersonagem.Text);
            tb_Personagens.CA = Convert.ToInt32(txtClasseArmadura.Text);
            tb_Personagens.PVTOTAL = Convert.ToInt32(txtPontosVida.Text);
            tb_Personagens.PVATUAL = Convert.ToInt32(txtPontosVidaAtuais.Text);
            tb_Personagens.PATAQUE = Convert.ToInt32(txtPontosAtaque.Text);
            tb_Personagens.INICIATIVA = Convert.ToInt32(txtIniciativa.Text);
            tb_Personagens.DINHEIRO = Convert.ToInt32(txtJades.Text);
            tb_Personagens.EXPERIENCIA = Convert.ToInt32(txtExperiencia.Text);
            tb_Personagens.NIVEL = Convert.ToInt32(txtNivel.Text);
            tb_Personagens.HISTORIA = txtDescricao.Text;
            resultado = personagensBusiness.MestreEditando(tb_Personagens);
            if (resultado.sucesso)
            {
                tb_Atributos.FORC = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.DEST = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.CONS = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.INTE = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.SABE = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.CARI = Convert.ToInt32(txtFOR.Text);
                tb_Atributos.COD = Convert.ToInt32(LblAtributo.Text);
                resultado = atributosBusiness.Editar(tb_Atributos);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Atualido com sucesso", "A T U A L I Z A D O");
                }
                else
                {
                    MessageBox.Show("Falha na Atualização dos Atributos", "D E U   R U I M");
                }
            }
            else
            {
                MessageBox.Show("Falha na Atualização", "D E U   R U I M");
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGerenciarMesa frmGerenciarMesa = new FrmGerenciarMesa();
            frmGerenciarMesa.LblMestre.Text = LblUser.Text;
            frmGerenciarMesa.LblCampanha.Text = LblCampanha.Text;
            frmGerenciarMesa.Show();
            Close();
        }

        private void armasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItens frmItens = new FrmItens();
            frmItens.LblCampanha.Text = LblCampanha.Text;
            frmItens.LblUser.Text = LblUser.Text;
            frmItens.LblPersonagem.Text = LblPersonagem.Text;
            frmItens.lblTipoItem.Text = "ARMA";
            frmItens.gbCadastro.Visible = false;
            frmItens.BtnComprar.Visible = true;
            frmItens.BtnSair2.Visible = true;
            frmItens.lblSeuDinheiro.Visible = true;
            frmItens.txtJades.Visible = true;
            frmItens.txtJades.Text = txtJades.Text;
            frmItens.Show();
            Close();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {   
            FrmVendas frmVendas = new FrmVendas();
            frmVendas.txtItem.Text = Convert.ToString(dgvArmas.CurrentRow.Cells[0].Value);
            frmVendas.txtJades.Text = txtJades.Text;
            frmVendas.txtValor.Text = Convert.ToString(dgvArmas.CurrentRow.Cells[4].Value);
            frmVendas.LblItem.Text = Convert.ToString(dgvArmas.CurrentRow.Cells[6].Value);
            frmVendas.LblPersonagem.Text = LblPersonagem.Text;
            frmVendas.ShowDialog();
            GetDadosPersonagem();
            CarregaDataGridArmas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmItens objFrm = new FrmItens();
            objFrm.LblPersonagem.Text = LblPersonagem.Text;
            objFrm.LblUser.Text = LblUser.Text;
            objFrm.LblCampanha.Text = LblCampanha.Text;
            objFrm.btnGravar.Visible = false;
            objFrm.BtnExcluir.Visible = false;
            objFrm.btnLimpar.Visible = false;
            objFrm.dgv.Visible = false;
            objFrm.btnSair.Visible = false;
            objFrm.BtnPesquisar.Visible = false;
            objFrm.LblPesquisar.Visible = false;
            objFrm.txtPesquisa.Visible = false;
            objFrm.BtnSair2.Visible = true;
            objFrm.LblCodItem.Text = Convert.ToString(dgvArmas.CurrentRow.Cells[6].Value);
            objFrm.txtItem.Text = Convert.ToString(dgvArmas.CurrentRow.Cells[0].Value);
            objFrm.cBoxTipo.Text = Convert.ToString(dgvArmas.CurrentRow.Cells[1].Value);
            objFrm.cBoxTipo.Enabled = false;
            objFrm.txtDano.Text = Convert.ToString(dgvArmas.CurrentRow.Cells[2].Value);
            objFrm.txtBonus.Text = Convert.ToString(dgvArmas.CurrentRow.Cells[3].Value);
            objFrm.txtValor.Text = Convert.ToString(dgvArmas.CurrentRow.Cells[4].Value);
            objFrm.txtDescricao.Text = Convert.ToString(dgvArmas.CurrentRow.Cells[5].Value);
            objFrm.dgv.Visible = false;
            objFrm.Show();
            Close();
            objFrm.BtnEditar.Text = "Alterar";
        }

        private void hABILIDADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSkills frmSkills = new FrmSkills();
            frmSkills.LblCampanha.Text = LblCampanha.Text;
            frmSkills.LblUser.Text = LblUser.Text;
            frmSkills.LblPersonagem.Text = LblPersonagem.Text;
            frmSkills.lblTipoItem.Text = "HABILIDADE";
            frmSkills.gbCadastro.Visible = false;
            frmSkills.BtnComprar.Visible = true;
            frmSkills.BtnSair2.Visible = true;
            frmSkills.lblSeuDinheiro.Visible = true;
            frmSkills.txtJades.Visible = true;
            frmSkills.txtJades.Text = txtJades.Text;
            frmSkills.Show();
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void BtnAprimorarSkills_Click(object sender, EventArgs e)
        {
            FrmSkills objFrm = new FrmSkills();
            objFrm.LblPersonagem.Text = LblPersonagem.Text;
            objFrm.LblUser.Text = LblUser.Text;
            objFrm.LblCampanha.Text = LblCampanha.Text;
            objFrm.btnGravar.Visible = false;
            objFrm.BtnExcluir.Visible = false;
            objFrm.btnLimpar.Visible = false;
            objFrm.dgv.Visible = false;
            objFrm.btnSair.Visible = false;
            objFrm.BtnPesquisar.Visible = false;
            objFrm.LblPesquisar.Visible = false;
            objFrm.txtPesquisa.Visible = false;
            objFrm.BtnSair2.Visible = true;
            objFrm.LblCodItem.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[10].Value);
            objFrm.txtSkill.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[0].Value);
            objFrm.cBoxTipo.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[1].Value);
            objFrm.cBoxTipo.Enabled = false;
            objFrm.txtNivel.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[2].Value);
            objFrm.txtDano.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[3].Value);
            objFrm.txtBonus.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[4].Value);
            objFrm.txtValor.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[5].Value);
            objFrm.txtTempo.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[6].Value);
            objFrm.txtAlcance.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[7].Value);
            objFrm.txtDuracao.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[8].Value);
            objFrm.txtDescricao.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[9].Value);
            objFrm.dgv.Visible = false;
            objFrm.Show();
            Close();
            objFrm.BtnEditar.Text = "Alterar";
        }

        private void BtnVenderSkills_Click(object sender, EventArgs e)
        {
            FrmVendas frmVendas = new FrmVendas();
            frmVendas.LblVenda.Text = "S";
            frmVendas.txtItem.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[0].Value);
            frmVendas.txtJades.Text = txtJades.Text;
            frmVendas.txtValor.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[5].Value);
            frmVendas.LblItem.Text = Convert.ToString(dgvSkills.CurrentRow.Cells[10].Value);
            frmVendas.LblPersonagem.Text = LblPersonagem.Text;
            frmVendas.ShowDialog();
            GetDadosPersonagem();
            CarregaDataGridSkills();
        }

        private void armadurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItens frmItens = new FrmItens();
            frmItens.LblCampanha.Text = LblCampanha.Text;
            frmItens.LblUser.Text = LblUser.Text;
            frmItens.LblPersonagem.Text = LblPersonagem.Text;
            frmItens.lblTipoItem.Text = "ARMADURA";
            frmItens.gbCadastro.Visible = false;
            frmItens.BtnComprar.Visible = true;
            frmItens.BtnSair2.Visible = true;
            frmItens.lblSeuDinheiro.Visible = true;
            frmItens.txtJades.Visible = true;
            frmItens.txtJades.Text = txtJades.Text;
            frmItens.Show();
            Close();
        }

        private void cONSUMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItens frmItens = new FrmItens();
            frmItens.LblCampanha.Text = LblCampanha.Text;
            frmItens.LblUser.Text = LblUser.Text;
            frmItens.LblPersonagem.Text = LblPersonagem.Text;
            frmItens.lblTipoItem.Text = "CONSUMO";
            frmItens.gbCadastro.Visible = false;
            frmItens.BtnComprar.Visible = true;
            frmItens.BtnSair2.Visible = true;
            frmItens.lblSeuDinheiro.Visible = true;
            frmItens.txtJades.Visible = true;
            frmItens.txtJades.Text = txtJades.Text;
            frmItens.Show();
            Close();
        }

        private void escudosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItens frmItens = new FrmItens();
            frmItens.LblCampanha.Text = LblCampanha.Text;
            frmItens.LblUser.Text = LblUser.Text;
            frmItens.LblPersonagem.Text = LblPersonagem.Text;
            frmItens.lblTipoItem.Text = "ESCUDO";
            frmItens.gbCadastro.Visible = false;
            frmItens.BtnComprar.Visible = true;
            frmItens.BtnSair2.Visible = true;
            frmItens.lblSeuDinheiro.Visible = true;
            frmItens.txtJades.Visible = true;
            frmItens.txtJades.Text = txtJades.Text;
            frmItens.Show();
            Close();
        }

        private void iTEMMAGICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItens frmItens = new FrmItens();
            frmItens.LblCampanha.Text = LblCampanha.Text;
            frmItens.LblUser.Text = LblUser.Text;
            frmItens.LblPersonagem.Text = LblPersonagem.Text;
            frmItens.lblTipoItem.Text = "ITEM MAGICO";
            frmItens.gbCadastro.Visible = false;
            frmItens.BtnComprar.Visible = true;
            frmItens.BtnSair2.Visible = true;
            frmItens.lblSeuDinheiro.Visible = true;
            frmItens.txtJades.Visible = true;
            frmItens.txtJades.Text = txtJades.Text;
            frmItens.Show();
            Close();
        }

        private void pETSMontariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItens frmItens = new FrmItens();
            frmItens.LblCampanha.Text = LblCampanha.Text;
            frmItens.LblUser.Text = LblUser.Text;
            frmItens.LblPersonagem.Text = LblPersonagem.Text;
            frmItens.lblTipoItem.Text = "PETS/MONTARIAS";
            frmItens.gbCadastro.Visible = false;
            frmItens.BtnComprar.Visible = true;
            frmItens.BtnSair2.Visible = true;
            frmItens.lblSeuDinheiro.Visible = true;
            frmItens.txtJades.Visible = true;
            frmItens.txtJades.Text = txtJades.Text;
            frmItens.Show();
            Close();
        }

        private void pOÇÕESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItens frmItens = new FrmItens();
            frmItens.LblCampanha.Text = LblCampanha.Text;
            frmItens.LblUser.Text = LblUser.Text;
            frmItens.LblPersonagem.Text = LblPersonagem.Text;
            frmItens.lblTipoItem.Text = "POÇÃO";
            frmItens.gbCadastro.Visible = false;
            frmItens.BtnComprar.Visible = true;
            frmItens.BtnSair2.Visible = true;
            frmItens.lblSeuDinheiro.Visible = true;
            frmItens.txtJades.Visible = true;
            frmItens.txtJades.Text = txtJades.Text;
            frmItens.Show();
            Close();
        }

        private void cLASSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSkills frmSkills = new FrmSkills();
            frmSkills.LblCampanha.Text = LblCampanha.Text;
            frmSkills.LblUser.Text = LblUser.Text;
            frmSkills.LblPersonagem.Text = LblPersonagem.Text;
            frmSkills.lblTipoItem.Text = "CLASSE";
            frmSkills.gbCadastro.Visible = false;
            frmSkills.BtnComprar.Visible = true;
            frmSkills.BtnSair2.Visible = true;
            frmSkills.lblSeuDinheiro.Visible = true;
            frmSkills.txtJades.Visible = true;
            frmSkills.txtJades.Text = txtJades.Text;
            frmSkills.Show();
            Close();
        }

        private void mAGIASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSkills frmSkills = new FrmSkills();
            frmSkills.LblCampanha.Text = LblCampanha.Text;
            frmSkills.LblUser.Text = LblUser.Text;
            frmSkills.LblPersonagem.Text = LblPersonagem.Text;
            frmSkills.lblTipoItem.Text = "MAGIA";
            frmSkills.gbCadastro.Visible = false;
            frmSkills.BtnComprar.Visible = true;
            frmSkills.BtnSair2.Visible = true;
            frmSkills.lblSeuDinheiro.Visible = true;
            frmSkills.txtJades.Visible = true;
            frmSkills.txtJades.Text = txtJades.Text;
            frmSkills.Show();
            Close();
        }
    }
}
