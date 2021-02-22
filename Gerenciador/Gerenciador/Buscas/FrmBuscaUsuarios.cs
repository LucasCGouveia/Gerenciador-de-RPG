using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmBuscaUsuarios : Form
    {
        public FrmBuscaUsuarios()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        UsuarioRepository usuarioRepository = new UsuarioRepository();
        CampanhasBusiness campanhasBusiness = new CampanhasBusiness();
        JogadoresBusiness jogadoresBusiness = new JogadoresBusiness();

        public void CarregaDataGrid()
        {
            //dgv.DataSource = ObjUsuario.ListarUsuariosCadUsuario(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            dgv.DataSource = usuarioRepository.ListarDataGrid(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("LOGIN");
            dgv.Columns[2].HeaderText = ("TIPO USER");
            dgv.Columns[3].HeaderText = ("ATIVO");
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
        private void FrmBuscaUsuarios_Load(object sender, EventArgs e)
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
        private void BtnDesabilitar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = usuarioBusiness.Desativar(codigo);
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            resultado.sucesso = true;
            int codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            string TipoUser = Convert.ToString(dgv.CurrentRow.Cells[2].Value);

            if (TipoUser == "M")
            {
                List<int> QtdCampanhasMestre = campanhasBusiness.VerificarCampanhas(codigo);

                if (QtdCampanhasMestre.Count >= 1)
                {
                    MessageBox.Show("Este Mestre Possui Campanhas,não é possivel exclui-lo", "");
                    resultado.sucesso = false;
                }
            }
            else if (TipoUser == "J")
            {
                List<int> VerificarCadastroJogador = jogadoresBusiness.GetCODJogador(Convert.ToString(dgv.CurrentRow.Cells[1].Value));

                if (VerificarCadastroJogador.Count >= 1 && VerificarCadastroJogador[0] != 0)
                {
                    MessageBox.Show("Este Jogador Possui Conta de Jogador,não é possivel exclui-lo", "");
                    resultado.sucesso = false;
                }
            }
                if (resultado.sucesso)
            {
                resultado = usuarioBusiness.Excluir(codigo);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Excluido com sucesso. ", "E X C L U I D O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaDataGrid();
                }
                else
                {
                    MessageBox.Show("Falha na Exclusão. Erro:" + resultado.exception, "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciamento frmGerenciamento = new FrmGerenciamento();
            frmGerenciamento.LblMestre.Text = LblMestre.Text;
            frmGerenciamento.Show();
            Close();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void BtnAtivar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = usuarioBusiness.Ativar(codigo);
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
