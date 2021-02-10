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
    public partial class FrmCadPersongem : Form
    {
        public FrmCadPersongem()
        {
            InitializeComponent();
        }
        Resultado resultado = new Resultado();
        TabPersonagens tb_Personagens = new TabPersonagens();
        JogadoresBusiness jogadoresBusiness = new JogadoresBusiness();
        PersonagensBusiness personagensBusiness = new PersonagensBusiness();
        AtributosBusiness atributosBusiness = new AtributosBusiness();
        PersonagensRepository personagensRepository = new PersonagensRepository();
        public void CarregaDataGrid()
        {
            List<int> Codigo = jogadoresBusiness.GetCODJogador(LblUser.Text);
            dgv.DataSource = personagensRepository.ListarDataGrid(Codigo[0]).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
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
            dgv.Columns[9].HeaderText = ("INICIATIVA");
            dgv.Columns[10].HeaderText = ("NIVEL");
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
        public void CarregaComboRaca()
        {
            //Carregar ComboBox de Cargos Cadastrados
            RacasRepository racasRepository = new RacasRepository();//Criar Obj
            DataTable dtResultado = racasRepository.ListarRacasCombo().Tables[0];
            cBoxRaca.DataSource = null;
            cBoxRaca.DataSource = dtResultado;
            cBoxRaca.ValueMember = "COD";
            cBoxRaca.DisplayMember = "RACA";
            cBoxRaca.Text = "";
            cBoxRaca.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
            DateTime now = DateTime.Now;
        }
        public void CarregaComboClasse()
        {
            //Carregar ComboBox de Cargos Cadastrados
            ClassesRepository ObjClnCargosRepository = new ClassesRepository();//Criar Obj
            DataTable dtResultado = ObjClnCargosRepository.ListarClassesCombo().Tables[0];
            cBoxClasse.DataSource = null;
            cBoxClasse.DataSource = dtResultado;
            cBoxClasse.ValueMember = "COD";
            cBoxClasse.DisplayMember = "CLASSE";
            cBoxClasse.Text = "";
            cBoxClasse.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
            DateTime now = DateTime.Now;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmAreaJogador frmAreaJogador = new FrmAreaJogador();
            frmAreaJogador.LblUser.Text = LblUser.Text;
            frmAreaJogador.Show();
            Close();
        }

        private void FrmCadPersongem_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
            if (btnGravar.Text == "&Gravar")
            {
                CarregaComboClasse();
                CarregaComboRaca();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGravar.Text == "&Gravar")
                {
                    if (txtNome.Text == "" && cBoxRaca.Text == "" && cBoxClasse.Text == "" && cBoxAlinhamento.Text == "")
                    {
                        MessageBox.Show("Algum campo ficou em branco revise seus dados. ", "C A M P O   V A Z I O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        List<int> Codigo = jogadoresBusiness.GetCODJogador(LblUser.Text);

                        tb_Personagens.NOME = txtNome.Text;
                        tb_Personagens.RACA = cBoxRaca.Text;
                        tb_Personagens.CLASSE = cBoxClasse.Text;
                        tb_Personagens.ALINHAMENTO = cBoxAlinhamento.Text;
                        tb_Personagens.CA = 0;
                        tb_Personagens.PVTOTAL = 0;
                        tb_Personagens.PVATUAL = 0;
                        tb_Personagens.PATAQUE = 0;
                        tb_Personagens.INICIATIVA = 0;
                        tb_Personagens.DINHEIRO = 0;
                        tb_Personagens.EXPERIENCIA = 0;
                        tb_Personagens.NIVEL = 0;
                        tb_Personagens.GENERO = cBoxGenero.Text;
                        tb_Personagens.CABELO = txtCabelo.Text;
                        tb_Personagens.OLHOS = txtOlhos.Text;
                        tb_Personagens.TAMANHO = cBoxTamanho.Text;
                        tb_Personagens.ALTURA = txtAltura.Text;
                        tb_Personagens.PESO = txtPeso.Text;
                        tb_Personagens.HISTORIA = txtDescricao.Text;
                        tb_Personagens.DATAINCLUSAO = DateTime.Now;
                        tb_Personagens.COD_JOGADOR = (Codigo[0]);
                        tb_Personagens.COD_CAMPANHA = 0;
                        resultado = personagensBusiness.Gravar(tb_Personagens);
                        if (resultado.sucesso)
                        {
                            CarregaDataGrid();
                            LblCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                            resultado = atributosBusiness.Gravar(Convert.ToInt32(LblCodigo.Text));
                            if (!resultado.sucesso)
                            {
                                personagensBusiness.Excluir(Convert.ToInt32(LblCodigo.Text));
                                MessageBox.Show("Erro no Cadastro.Exceção: " + resultado.exception, "F A L H A   N O   C A D A S T R O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            MessageBox.Show("Cadastro concluido com sucesso. ", "C O N C L U I D O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro no Cadastro.Exceção: " + resultado.exception, "F A L H A   N O   C A D A S T R O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    tb_Personagens.COD = Convert.ToInt32(LblCodigo.Text);
                    tb_Personagens.NOME = txtNome.Text;
                    tb_Personagens.RACA = cBoxRaca.Text;
                    tb_Personagens.CLASSE = cBoxClasse.Text;
                    tb_Personagens.ALINHAMENTO = cBoxAlinhamento.Text;
                    tb_Personagens.GENERO = cBoxGenero.Text;
                    tb_Personagens.CABELO = txtCabelo.Text;
                    tb_Personagens.OLHOS = txtOlhos.Text;
                    tb_Personagens.TAMANHO = cBoxTamanho.Text;
                    tb_Personagens.ALTURA = txtAltura.Text;
                    tb_Personagens.PESO = txtPeso.Text;
                    tb_Personagens.HISTORIA = txtDescricao.Text;
                    resultado = personagensBusiness.JogadorEditando(tb_Personagens);
                    if (resultado.sucesso)
                    {
                        MessageBox.Show("Alteração feita com sucesso", "A L T E R A D O");
                        CarregaDataGrid();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Cadastro.Exceção: " + ex, "F A L H A   N O   C A D A S T R O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
