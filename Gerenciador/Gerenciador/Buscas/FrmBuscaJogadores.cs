using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmBuscaJogadores : Form
    {
        public FrmBuscaJogadores()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        JogadoresBusiness jogadoresBusiness = new JogadoresBusiness();
        JogadoresRepository jogadoresRepository = new JogadoresRepository();
        public void CarregaDataGrid()
        {
            //dgv.DataSource = ObjUsuario.ListarUsuariosCadUsuario(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgv.DataSource = jogadoresRepository.ListarDataGrid(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("NOME");
            dgv.Columns[2].HeaderText = ("Nascimento");
            dgv.Columns[3].HeaderText = ("RG");
            dgv.Columns[4].HeaderText = ("CPF");
            dgv.Columns[5].HeaderText = ("QtdPersonagens");
            dgv.Columns[6].HeaderText = ("DataInclusao");
            dgv.Columns[7].HeaderText = ("COD_USUARIO");
            dgv.Columns[8].HeaderText = ("ATIVO");

            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                BtnAtivar.Enabled = false;
                BtnDesabilitar.Enabled = false;
                //MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
                //txtPesquisa.Text = "";
                //txtPesquisa.Focus();
            }
            else
            {
                BtnAtivar.Enabled = true;
                BtnDesabilitar.Enabled = true;
            }
        }
        private void FrmBuscarJogadores_Load(object sender, EventArgs e)
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int QtdPersonagens = Convert.ToInt32(dgv.CurrentRow.Cells[5].Value);
            if (QtdPersonagens == 0)
            {
                resultado = jogadoresBusiness.Excluir(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value));
                if (resultado.sucesso)
                {
                    MessageBox.Show("Jogador Excluido com sucesso", "E X C L U I D O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha na Exclusão do Jogador", "E R R O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Jogador tem personagens criados, não é possivel exclui-lo", "");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciamento frmGerenciamento = new FrmGerenciamento();
            frmGerenciamento.LblMestre.Text = LblMestre.Text;
            frmGerenciamento.Show();
            Close();
        }

        private void BtnAtivar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = jogadoresBusiness.Ativar(codigo);
            if (resultado.sucesso)
            {
                MessageBox.Show("Usuario Desativado com sucesso. ", "D E S A T I V A D O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDesabilitar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = jogadoresBusiness.Desativar(codigo);
            if (resultado.sucesso)
            {
                MessageBox.Show("Usuario Desativado com sucesso. ", "D E S A T I V A D O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
