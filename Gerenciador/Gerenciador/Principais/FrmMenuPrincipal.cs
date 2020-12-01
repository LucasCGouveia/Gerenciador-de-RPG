﻿using Gerenciador.Business;
using Gerenciador.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        CampanhasRepository campanhasRepository = new CampanhasRepository();
        public void CarregaDataGrid()
        {
            try
            {
                List<int> CodigoMestre = usuarioBusiness.GetCodigoMestre(LblUser.Text);
                dgv.DataSource = campanhasRepository.ListarDataGrid(CodigoMestre[0]).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
                dgv.Columns[0].HeaderText = ("Codigo");
                dgv.Columns[1].HeaderText = ("Campanha");
                dgv.Columns[2].HeaderText = ("Sistema");
                dgv.Columns[3].HeaderText = ("Descrição");
                dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
                if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
                {
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: ", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv.DataSource = null; //Limpa o cabeçalho
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao listar campanhas\n Exceção: " + ex, "FALHA AO CARREGAR CAMPANHAS");
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            //try
            FrmTrocaTelas ObjTrocaTelas = new FrmTrocaTelas();
            ObjTrocaTelas.LblUser.Text = LblUser.Text;
            ObjTrocaTelas.LblDeOndeVim.Text = gboxTipoUser.Text;
            ObjTrocaTelas.Show();
            Close();
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
        }

        private void btnCadastroDeCliente_Click(object sender, EventArgs e)
        {
            FrmCadJogador ObjfrmCadFuncionarios = new FrmCadJogador();
            ObjfrmCadFuncionarios.Show();
            this.Close();
        }

        private void btnBuscaDeCliente_Click(object sender, EventArgs e)
        {
            FrmBuscaJogador ObjBF = new FrmBuscaJogador();
            ObjBF.Show();
            this.Close();
        }

        private void BtnGerencia_Click_1(object sender, EventArgs e)
        {
            FrmGerenciamento ObjFrmGerenciamento = new FrmGerenciamento();
            ObjFrmGerenciamento.LblMestre.Text = LblUser.Text;
            ObjFrmGerenciamento.Show();
            Close();
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }
        private void btnSkills_Click(object sender, EventArgs e)
        {
            FrmSkills frmSkills = new FrmSkills();
            frmSkills.Show();
            Close();
        }
        private void btnItens_Click(object sender, EventArgs e)
        {
            FrmItens frmItens = new FrmItens();
            frmItens.Show();
            Close();
        }
        private void btnNovaCampanha_Click(object sender, EventArgs e)
        {
            FrmCampanhas frmCampanhas = new FrmCampanhas();
            frmCampanhas.LblMestre.Text = LblUser.Text;
            frmCampanhas.Show();
            Close();
        }

        private void BtnGerenciarMesa_Click(object sender, EventArgs e)
        {
            FrmGerenciarMesa frmGerenciarMesa = new FrmGerenciarMesa();
            frmGerenciarMesa.LblCampanha.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            frmGerenciarMesa.LblMestre.Text = LblUser.Text;
            frmGerenciarMesa.Show();
            Close();
        }
    }
}
