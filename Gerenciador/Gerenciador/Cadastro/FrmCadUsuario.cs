using Gerenciador.Repository;
using Gerenciador.Repository.BancoDados;
using Gerenciador.Secundarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Cadastro
{
    public partial class FrmCadUsuario : Form
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }
        ClnFuncoesGerais.Operacao ObjOperacao;   //Cria Obj da Operação
        public ClnFuncoesGerais.Operacao EnumProperty //Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }
        //==============================================

        public void CarregaDataGrid()
        {
            UsuarioRepository ObjUsuario = new UsuarioRepository();//Criar Obj
            dgv.DataSource = ObjUsuario.ListarUsuariosCadUsuario(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("COD");
            dgv.Columns[1].HeaderText = ("USUARIO");
            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                //btnRelatorio.Enabled = false; //Desativar os botões
                //btnConsultar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
                txtPesquisa.Text = "";
                txtPesquisa.Focus();
            }
            else
            {
                //btnRelatorio.Enabled = true; //Ativar os botões
                //btnConsultar.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin ObjFL = new FrmLogin();
            ObjFL.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Opa!!! esqueceu de preencher o campo Pesquisar. vou trazer tudo beleza!!! ", "Falta de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaDataGrid();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Verifica se os campos nome e telefone estão preenchidos, porque são obrigatórios
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPesquisa.Focus();
            }
            else
            {
                UsuarioRepository Usuario = new UsuarioRepository();
                Usuario.LOGIN = txtUsuario.Text;
                Usuario.SENHA = txtSenha.Text;
                Usuario.TIPOUSER = "C";
                if (btnGravar.Text == "&Alterar")
                {
                    Usuario.COD = Convert.ToInt32(TxtCod.Text);
                }
                if (ObjOperacao == ClnFuncoesGerais.Operacao.Inclusao)//Verifica se é inclusão faça
                {
                    Usuario.Gravar();
                    MessageBox.Show("Usuario: " + txtUsuario.Text + ", cadastrado com sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtPesquisa.Text = "";
                    CarregaDataGrid(); //Chama o Método Preencher a Grid
                }
                else if (ObjOperacao == ClnFuncoesGerais.Operacao.Alteracao)//Verifica se é alteração faça
                {
                    Usuario.Alterar();
                    MessageBox.Show("Usuario " + txtUsuario.Text + ", Alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaDataGrid(); //Chama o Método Preencher a Grid
                    FrmCadUsuario objCadUsuario = new FrmCadUsuario();
                    objCadUsuario.Show();
                    this.Close();
                }
            }
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                //Chama o Método Preencher a Grid 
                CarregaDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opa!!! falha ao carregar usuarios cadastrados. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Excluir Um Usuario é necessario autenticar usuario!!! ", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmGenerico ObjFrmGenerico = new FrmGenerico();
            ObjFrmGenerico.lblUm.Visible = true;
            ObjFrmGenerico.lblDois.Visible = true;
            ObjFrmGenerico.txtUm.Visible = true;
            ObjFrmGenerico.txtDois.Visible = true;
            ObjFrmGenerico.Btn2.Visible = true;
            ObjFrmGenerico.lblFuncao.Text = "Excluir Usuario";
            ObjFrmGenerico.lblDois.Text = "Login";
            ObjFrmGenerico.lblUm.Text = "Senha";
            ObjFrmGenerico.Btn2.Text = "Excluir";
            ObjFrmGenerico.lblCinco.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            ObjFrmGenerico.txtCinco.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            ObjFrmGenerico.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Editar Um Usuario é necessario autenticar usuario !!! ", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmGenerico ObjFrmGenerico = new FrmGenerico();
            ObjFrmGenerico.lblUm.Visible = true;
            ObjFrmGenerico.lblDois.Visible = true;
            ObjFrmGenerico.txtUm.Visible = true;
            ObjFrmGenerico.txtDois.Visible = true;
            ObjFrmGenerico.Btn2.Visible = true;
            ObjFrmGenerico.lblFuncao.Text = "Editar Usuario";
            ObjFrmGenerico.lblDois.Text = "Login";
            ObjFrmGenerico.lblUm.Text = "Senha";
            ObjFrmGenerico.Btn2.Text = "Editar";
            ObjFrmGenerico.lblCinco.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            ObjFrmGenerico.txtCinco.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            ObjFrmGenerico.Show();
            this.Close();
        }
    }
}
