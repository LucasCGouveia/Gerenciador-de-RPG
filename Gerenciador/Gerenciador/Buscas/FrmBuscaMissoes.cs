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
    public partial class FrmBuscaMissoes : Form
    {
        public FrmBuscaMissoes()
        {
            InitializeComponent();
        }
        MissoesRepository missoesRepository = new MissoesRepository();
        MissoesBusiness missoesBusiness = new MissoesBusiness();
        TabMissoes tb_Missoes = new TabMissoes();
        public void CarregaDataGrid()
        {
            List<int> CodigoMestre = missoesBusiness.GetCodigoMestre(LblUser.Text);
            dgv.DataSource = missoesRepository.ListarDataGridQuadroMissoes(txtPesquisa.Text, CodigoMestre[0]).Tables[0];
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("Missao");
            dgv.Columns[2].HeaderText = ("Solicitante");
            dgv.Columns[3].HeaderText = ("XP");
            dgv.Columns[4].HeaderText = ("Jades");
            dgv.Columns[5].HeaderText = ("Item");
            dgv.Columns[6].HeaderText = ("Detalhes");

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
        private void FrmQuadroMissoes_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void BtnAtivar_Click(object sender, EventArgs e)
        {
            tb_Missoes.COD_CAMPANHA = Convert.ToInt32(LblCampanha.Text);
            tb_Missoes.COD = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            missoesBusiness.AtribuirMissaoCampanha(tb_Missoes);
            CarregaDataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciarMesa frmGerenciarMesa = new FrmGerenciarMesa();
            frmGerenciarMesa.LblCampanha.Text = LblCampanha.Text;
            frmGerenciarMesa.LblMestre.Text = LblUser.Text;
            frmGerenciarMesa.Show();
            Close();
        }
    }
}
