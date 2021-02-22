using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmAreaJogador : Form
    {
        public FrmAreaJogador()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        JogadoresBusiness jogadoresBusiness = new JogadoresBusiness();
        PersonagensBusiness personagensBusiness = new PersonagensBusiness();
        AtributosBusiness atributosBusiness = new AtributosBusiness();
        ItensBusiness itensBusiness = new ItensBusiness();
        SkillsBusiness skillsBusiness = new SkillsBusiness();

        PersonagensRepository personagensRepository = new PersonagensRepository();
        public void CarregaDataGrid()
        {
            List<int> Codigo = jogadoresBusiness.GetCODJogador(LblUser.Text);
            dgv.DataSource = personagensRepository.ListarDataGridFULL(Codigo[0]).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
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
            dgv.Columns[11].HeaderText = ("Genero");
            dgv.Columns[12].HeaderText = ("Cabelo");
            dgv.Columns[13].HeaderText = ("Olhos");
            dgv.Columns[14].HeaderText = ("Tamanho");
            dgv.Columns[15].HeaderText = ("Altura");
            dgv.Columns[16].HeaderText = ("Peso");
            dgv.Columns[17].HeaderText = ("Historia");
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
        private void btnNovaCampanha_Click(object sender, EventArgs e)
        {
            FrmCadPersongem frmCadPersongem = new FrmCadPersongem();
            frmCadPersongem.LblUser.Text = LblUser.Text;
            frmCadPersongem.Show();
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmTrocaTelas frmTrocaTelas = new FrmTrocaTelas();
            frmTrocaTelas.LblUser.Text = LblUser.Text;
            frmTrocaTelas.LblDeOndeVim.Text = gboxMenuPrincipal.Text;
            frmTrocaTelas.Show();
            Close();
        }

        private void FrmAreaJogador_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmCadPersongem frmCadPersongem = new FrmCadPersongem();
            frmCadPersongem.LblUser.Text = LblUser.Text;
            frmCadPersongem.LblCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            frmCadPersongem.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            frmCadPersongem.CarregaComboRaca();
            frmCadPersongem.cBoxRaca.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            frmCadPersongem.CarregaComboClasse();
            frmCadPersongem.cBoxClasse.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            frmCadPersongem.cBoxAlinhamento.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            //frmCadPersongem.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            //frmCadPersongem.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            //frmCadPersongem.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            //frmCadPersongem.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            //frmCadPersongem.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            //frmCadPersongem.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            frmCadPersongem.cBoxGenero.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            frmCadPersongem.txtCabelo.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            frmCadPersongem.txtOlhos.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            frmCadPersongem.cBoxTamanho.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            frmCadPersongem.txtAltura.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
            frmCadPersongem.txtPeso.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            frmCadPersongem.txtDescricao.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
            frmCadPersongem.btnGravar.Text = "&Alterar";
            frmCadPersongem.Show();
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                resultado = atributosBusiness.Excluir(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value));
                resultado = itensBusiness.ExcluirItensPersonagem(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value));
                resultado = skillsBusiness.ExcluirSkillsPersonagem(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value));
                resultado = personagensBusiness.Excluir(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value));
                List<int> Codigo = jogadoresBusiness.GetCODJogador(LblUser.Text);

                if (resultado.sucesso)
                {
                    MessageBox.Show("Personagem Excluido com sucesso", "S U C E S S O");
                    jogadoresBusiness.AtualizaQtdPersonagensExclusao(Codigo[0]);
                    CarregaDataGrid();
                }
                else
                {
                    MessageBox.Show("Falha na Exclusão do Personagem Exceção:" + resultado.exception, "F A L H A");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na Exclusão do Personagem Exceção:" + ex, "F A L H A");
            }
            

        }
    }
}
