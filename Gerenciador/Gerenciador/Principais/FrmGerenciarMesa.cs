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
        TabMissoes tb_Missoes = new TabMissoes();
        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        CampanhasRepository campanhasRepository = new CampanhasRepository();
        PersonagensBusiness personagensBusiness = new PersonagensBusiness();
        MissoesRepository missoesRepository = new MissoesRepository();
        MissoesBusiness missoesBusiness = new MissoesBusiness();
        public void CarregaDataGrid()
        {
            dgv.DataSource = campanhasRepository.ListarDataGridPersonagensMesa(Convert.ToInt32(LblCampanha.Text)).Tables[0];
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
            dgv.Columns[10].HeaderText = ("Jades");
            dgv.Columns[11].HeaderText = ("EXP");
            dgv.Columns[12].HeaderText = ("Nivel");
            dgv.Columns[13].HeaderText = ("FOR");
            dgv.Columns[14].HeaderText = ("DES");
            dgv.Columns[15].HeaderText = ("CON");
            dgv.Columns[16].HeaderText = ("INT");
            dgv.Columns[17].HeaderText = ("SAB");
            dgv.Columns[18].HeaderText = ("CAR");
            dgv.Columns[19].HeaderText = ("Historia");
            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                btnEditar.Enabled = false;
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
            }
        }
        public void CarregaDataGridMissoes()
        {

            dgvMissoes.DataSource = missoesRepository.ListarDataGridMissoesAtivas(Convert.ToInt32(LblCampanha.Text)).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgvMissoes.Columns[0].HeaderText = ("Codigo");
            dgvMissoes.Columns[1].HeaderText = ("Missão");
            dgvMissoes.Columns[2].HeaderText = ("Solicitante");
            dgvMissoes.Columns[3].HeaderText = ("XP");
            dgvMissoes.Columns[4].HeaderText = ("Jades");
            dgvMissoes.Columns[5].HeaderText = ("Item");
            dgvMissoes.Columns[6].HeaderText = ("Concluida");
            dgvMissoes.Columns[7].HeaderText = ("Detalhes");
            dgvMissoes.Columns[8].HeaderText = ("Mestre");
            dgvMissoes.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgvMissoes.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                //MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMissoes.DataSource = null; //Limpa o cabeçalho
                //txtPesquisa.Text = "";
                //txtPesquisa.Focus();
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
            FrmBuscaPersonagem frmBuscaPersonagem = new FrmBuscaPersonagem();
            frmBuscaPersonagem.lblTituloFormulario.Text = "Buscar de NPC's";
            frmBuscaPersonagem.LblUser.Text = LblMestre.Text;
            frmBuscaPersonagem.LblCampanha.Text = LblCampanha.Text;
            frmBuscaPersonagem.Show();
            Close();
        }

        private void FrmGerenciarMesa_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
            CarregaDataGridMissoes();
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
            frmAddAtributos.LblPersonagem.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            frmAddAtributos.LblUser.Text = LblMestre.Text;
            frmAddAtributos.LblCampanha.Text = LblCampanha.Text;
            frmAddAtributos.LblNomePersonagem.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            frmAddAtributos.Show();
            Close();
        }
        private void BtnAddMissao_Click(object sender, EventArgs e)
        {
            FrmBuscaMissoes frmBuscaMissoes = new FrmBuscaMissoes();
            frmBuscaMissoes.LblCampanha.Text = LblCampanha.Text;
            frmBuscaMissoes.LblUser.Text = LblMestre.Text;
            frmBuscaMissoes.Show();
            Close();
        }
        private void BtnConcluirMissao_Click(object sender, EventArgs e)
        {
            tb_Missoes.CONCLUIDA = "S";
            tb_Missoes.COD = Convert.ToInt32(dgvMissoes.CurrentRow.Cells[0].Value);
            missoesBusiness.ConcluirMissao(tb_Missoes);
            CarregaDataGrid();
        }

        private void BtnD4_Click(object sender, EventArgs e)
        {
            int Dado = 4;
            Rolagem(Dado);
        }

        private int Rolagem(int Dado)
        {
            int rolagem = 1;
            Random random = new Random();
            try
            {
                if (cBoxPersonagem.Text != "")
                {
                    txtUltimoResultado.Text = txtResultadoRolagem.Text;
                    for (int i = 1; i <= 4; i++)
                        txtResultadoRolagem.Text = Convert.ToString(random.Next(Dado) + 1) + " - D" + Dado + " - " + cBoxPersonagem.Text;
                }
                else
                {
                    MessageBox.Show("Selecione o Personagem", "SEM PERSONAGEM");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na Rolagem" + ex, "SEM PERSONAGEM");
            }
            return rolagem;
        }

        private void BtnD6_Click(object sender, EventArgs e)
        {
            int Dado = 6;
            Rolagem(Dado);
        }

        private void BtnD8_Click(object sender, EventArgs e)
        {
            int Dado = 8;
            Rolagem(Dado);
        }

        private void BtnD10_Click(object sender, EventArgs e)
        {
            int Dado = 10;
            Rolagem(Dado);
        }

        private void BtnD12_Click(object sender, EventArgs e)
        {
            int Dado = 12;
            Rolagem(Dado);
        }

        private void BtnD20_Click(object sender, EventArgs e)
        {
            int Dado = 20;
            Rolagem(Dado);
        }

        private void BtnD24_Click(object sender, EventArgs e)
        {
            int Dado = 24;
            Rolagem(Dado);
        }

        private void BtnD30_Click(object sender, EventArgs e)
        {
            int Dado = 30;
            Rolagem(Dado);
        }

        private void BtnD60_Click(object sender, EventArgs e)
        {
            int Dado = 60;
            Rolagem(Dado);
        }

        private void BtnD100_Click(object sender, EventArgs e)
        {
            int Dado = 100;
            Rolagem(Dado);
        }
    }
}
