using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmGerenciarMesa : Form
    {
        public FrmGerenciarMesa()
        {
            InitializeComponent();
        }
        TabPersonagens tb_Personagens = new TabPersonagens();
        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        CampanhasRepository campanhasRepository = new CampanhasRepository();
        PersonagensBusiness personagensBusiness = new PersonagensBusiness();
        public void CarregaDataGrid()
        {
            dgv.DataSource = campanhasRepository.ListarDataGridPersonagensMesa(Convert.ToInt32(LblCampanha.Text)).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("Nome");
            dgv.Columns[2].HeaderText = ("Raça");
            dgv.Columns[3].HeaderText = ("Classe");
            dgv.Columns[4].HeaderText = ("Alinhamento");
            dgv.Columns[5].HeaderText = ("CA");
            dgv.Columns[6].HeaderText = ("PV Total");
            dgv.Columns[7].HeaderText = ("PV Atuais");
            dgv.Columns[8].HeaderText = ("Pontos ATK");
            dgv.Columns[9].HeaderText = ("Iniciativa");
            dgv.Columns[10].HeaderText = ("Nivel");
            dgv.Columns[11].HeaderText = ("FOR");
            dgv.Columns[12].HeaderText = ("DES");
            dgv.Columns[13].HeaderText = ("CON");
            dgv.Columns[14].HeaderText = ("INT");
            dgv.Columns[15].HeaderText = ("SAB");
            dgv.Columns[16].HeaderText = ("CAR");
            dgv.Columns[17].HeaderText = ("Historia");
            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                btnEditar.Enabled = false;
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
            }
            else
            {
                btnEditar.Enabled = true;
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.LblUser.Text = LblMestre.Text; 
            frmMenuPrincipal.Show();
            Close();
        }

        private void btn_AgendarHorario_Click(object sender, EventArgs e)
        {

        }

        private void FrmGerenciarMesa_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void BtnAdicionarJogador_Click(object sender, EventArgs e)
        {
            FrmBuscaPersonagem frmBuscaPersonagem = new FrmBuscaPersonagem();
            frmBuscaPersonagem.LblUser.Text = LblMestre.Text;
            frmBuscaPersonagem.LblCampanha.Text = LblCampanha.Text;
            frmBuscaPersonagem.Show();
            Close();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            tb_Personagens.COD_CAMPANHA = 0;
            tb_Personagens.COD = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            personagensBusiness.AdicionarCampanha(tb_Personagens);
            CarregaDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmAddAtributos frmAddAtributos = new FrmAddAtributos();
            frmAddAtributos.LblCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            frmAddAtributos.LblUser.Text = LblMestre.Text;
            frmAddAtributos.LblCampanha.Text = LblCampanha.Text;
            frmAddAtributos.lblPersonagem.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            frmAddAtributos.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            frmAddAtributos.cBoxRaca.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            frmAddAtributos.cBoxClasse.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            frmAddAtributos.cBoxAlinhamento.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            frmAddAtributos.txtClasseArmadura.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            frmAddAtributos.txtPontosVida.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            frmAddAtributos.txtPontosVidaAtuais.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            frmAddAtributos.txtPontosAtaque.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            frmAddAtributos.txtIniciativa.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            frmAddAtributos.txtNivel.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            frmAddAtributos.txtFOR.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            frmAddAtributos.txtDES.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            frmAddAtributos.txtCON.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            frmAddAtributos.txtINT.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            frmAddAtributos.txtSAB.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
            frmAddAtributos.txtCAR.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            frmAddAtributos.txtDescricao.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
            frmAddAtributos.Show();
            Close();


        }
    }
}
