using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmBuscaPersonagem : Form
    {
        public FrmBuscaPersonagem()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        TabPersonagens tb_Personagens = new TabPersonagens();
        JogadoresBusiness jogadoresBusiness = new JogadoresBusiness();
        PersonagensBusiness personagensBusiness = new PersonagensBusiness();
        PersonagensRepository personagensRepository = new PersonagensRepository();
        public void CarregaDataGrid()
        {
            int codigo = 0;
            if (lblTituloFormulario.Text.Contains("NPC"))
                dgv.DataSource = personagensRepository.ListarDataGrid(codigo).Tables[0];
            else
                dgv.DataSource = personagensRepository.GetPersonagemCamapanha().Tables[0];
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("Personagem");
            dgv.Columns[2].HeaderText = ("Raça");
            dgv.Columns[3].HeaderText = ("Classe");
            dgv.Columns[4].HeaderText = ("Alinhamento");
            dgv.Columns[5].HeaderText = ("Nivel");
            dgv.Columns[6].HeaderText = ("Jogador");
            //dgv.Columns[7].HeaderText = ("CAMAPANHA");
            //if(dgv.Columns[7].HeaderText == "0")
            //{ 
            //dgv.Columns[7].HeaderText = ("Sem CAMAPANHA");
            //}
            //else
            //    dgv.Columns[7].HeaderText = ("CAMAPANHA");

            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
            }
            else
            {
            }
        }
        private void FrmBuscaPersonagem_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciarMesa frmGerenciarMesa = new FrmGerenciarMesa();
            frmGerenciarMesa.LblMestre.Text = LblUser.Text;
            frmGerenciarMesa.LblCampanha.Text = LblCampanha.Text;
            frmGerenciarMesa.Show();
            Close();
        }

        private void BtnAtivar_Click(object sender, EventArgs e)
        {
            tb_Personagens.COD_CAMPANHA = Convert.ToInt32(LblCampanha.Text);
            tb_Personagens.COD = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            personagensBusiness.AdicionarCampanha(tb_Personagens);
            CarregaDataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }
    }
}
