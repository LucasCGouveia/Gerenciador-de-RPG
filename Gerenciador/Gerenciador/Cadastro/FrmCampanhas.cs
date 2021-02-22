using Gerenciador.Business;
using Gerenciador.Entities;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmCampanhas : Form
    {
        public FrmCampanhas()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        CampanhasBusiness campanhasBusiness = new CampanhasBusiness();
        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        CampanhasRepository campanhasRepository = new CampanhasRepository();
        public void CarregaDataGrid()
        {
            List<int> CodigoMestre = usuarioBusiness.GetCodigoMestre(LblMestre.Text);
            dgv.DataSource = campanhasRepository.ListarDataGrid(CodigoMestre[0]).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("Campanha");
            dgv.Columns[2].HeaderText = ("Sistema");
            dgv.Columns[3].HeaderText = ("Descrição");
            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                BtnEditar.Enabled = false;
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
            }
            else
            {
                BtnEditar.Enabled = true;
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Verifica se os campos obrigatórios estão preenchidos
            if (txtNomeCampanha.Text == "" && txtDescricao.Text == "")
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCampanha.Focus();
            }
            else
            {
                List<int> CodigoMestre = usuarioBusiness.GetCodigoMestre(LblMestre.Text);
                resultado = campanhasBusiness.Gravar(txtNomeCampanha.Text, cBoxSistemaCampanha.Text, txtDescricao.Text, CodigoMestre[0]);
                if (resultado.sucesso)
                {
                    MessageBox.Show("Gravado. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeCampanha.Text = "";
                    cBoxSistemaCampanha.Text = "";
                    txtDescricao.Text = "";
                    CarregaDataGrid();
                }
                else
                {
                    MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            resultado = campanhasBusiness.Desativar(codigo);
            if (resultado.sucesso)
            {
                MessageBox.Show("Excluido com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCampanha.Text = "";
                txtDescricao.Text = "";
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmCampanhas objFrm = new FrmCampanhas();
            if (BtnEditar.Text == "Alterar")
            {
                if (LblCodigo.Text != "Codigo")
                {
                    TabCampanhas tabCampanhas = new TabCampanhas();
                    tabCampanhas.COD = Convert.ToInt32(LblCodigo.Text);
                    tabCampanhas.NOMECAMPANHA = txtNomeCampanha.Text;
                    tabCampanhas.SISTEMA = cBoxSistemaCampanha.Text;
                    tabCampanhas.DESCRICAO = txtDescricao.Text;
                    campanhasBusiness.Editar(tabCampanhas);
                    if (resultado.sucesso)
                    {
                        MessageBox.Show("Editado com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                        frmMenuPrincipal.LblUser.Text = LblMestre.Text;
                        frmMenuPrincipal.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        objFrm.Show();
                        Close();
                    }
                }
                else
                {
                    TabCampanhas tabCampanhas = new TabCampanhas();
                    tabCampanhas.COD = Convert.ToInt32(LblCodigo.Text);
                    tabCampanhas.NOMECAMPANHA = txtNomeCampanha.Text;
                    tabCampanhas.SISTEMA = cBoxSistemaCampanha.Text;
                    tabCampanhas.DESCRICAO = txtDescricao.Text;
                    resultado = campanhasBusiness.Editar(tabCampanhas);
                    
                    if (resultado.sucesso)
                    {
                        MessageBox.Show("Editado com sucesso. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        objFrm.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha na Gravação. Erro:" + resultado.exception, "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        objFrm.Show();
                        Close();
                    }
                }
            }
            else
            {
                objFrm.btnGravar.Visible = false;
                objFrm.BtnEditar.Visible = true;
                objFrm.btnLimpar.Visible = false;
                objFrm.dgv.Visible = false;
                objFrm.LblCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                objFrm.txtNomeCampanha.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                objFrm.cBoxSistemaCampanha.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                objFrm.txtDescricao.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                objFrm.dgv.Visible = false;
                objFrm.Show();
                Close();
                objFrm.BtnEditar.Text = "Alterar";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.LblUser.Text = LblMestre.Text;
            frmMenuPrincipal.Show();
            Close();
        }

        private void FrmCampanhas_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }
    }
}
