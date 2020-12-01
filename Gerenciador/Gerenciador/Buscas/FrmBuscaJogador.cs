using System;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmBuscaJogador : Form
    {
        public FrmBuscaJogador()
        {
            InitializeComponent();
        }

        public void CarregaDataGrid()
        {
            //JogadoresRepository ObjFunc = new JogadoresRepository();//Criar Obj
            //dgv.DataSource = ObjFunc.ListarJogadores(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            ////Cria os Cabeçalhos de cada coluna
            //dgv.Columns[0].HeaderText = ("CODIGO");
            //dgv.Columns[1].HeaderText = ("Nome");
            //dgv.Columns[2].HeaderText = ("Nascimento");
            //dgv.Columns[3].HeaderText = ("RG");
            //dgv.Columns[4].HeaderText = ("CPF");
            //dgv.Columns[5].HeaderText = ("Cargo");
            //dgv.Columns[6].HeaderText = ("Salario");
            //dgv.Columns[7].HeaderText = ("Data Admissão");
            //dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            //if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            //{
            //    //btnRelatorio.Enabled = false; //Desativar os botões
            //    //btnConsultar.Enabled = false;
            //    btnGerContato.Enabled = false;
            //    btnGerEndereco.Enabled = false;
            //    MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dgv.DataSource = null; //Limpa o cabeçalho
            //    txtPesquisa.Text = "";
            //    txtPesquisa.Focus();
            //}
            //else
            //{
            //    //btnRelatorio.Enabled = true; //Ativar os botões
            //    //btnConsultar.Enabled = true;
            //    btnGerContato.Enabled = true;
            //    btnGerEndereco.Enabled = true;
            //}
        }

        private void FrmBuscaJogador_Load(object sender, EventArgs e)
        {

        }
    }
}
