namespace Gerenciador
{
    partial class FrmCadPersongem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblUser = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDadosDoCadastro = new System.Windows.Forms.Label();
            this.gbtxts = new System.Windows.Forms.GroupBox();
            this.cBoxRaca = new System.Windows.Forms.ComboBox();
            this.cBoxAlinhamento = new System.Windows.Forms.ComboBox();
            this.cBoxTamanho = new System.Windows.Forms.ComboBox();
            this.cBoxGenero = new System.Windows.Forms.ComboBox();
            this.cBoxClasse = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOlhos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCabelo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnderco = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbResultadoDaPesquisa = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.LblVoltar = new System.Windows.Forms.Label();
            this.gbtxts.SuspendLayout();
            this.gbResultadoDaPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(904, 11);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(56, 13);
            this.LblUser.TabIndex = 161;
            this.LblUser.Text = "USUARIO";
            this.LblUser.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(462, 96);
            this.txtDescricao.MaxLength = 20;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(435, 123);
            this.txtDescricao.TabIndex = 10;
            // 
            // lblDadosDoCadastro
            // 
            this.lblDadosDoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDadosDoCadastro.AutoSize = true;
            this.lblDadosDoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosDoCadastro.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDoCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDadosDoCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDadosDoCadastro.Location = new System.Drawing.Point(412, 9);
            this.lblDadosDoCadastro.Name = "lblDadosDoCadastro";
            this.lblDadosDoCadastro.Size = new System.Drawing.Size(220, 46);
            this.lblDadosDoCadastro.TabIndex = 156;
            this.lblDadosDoCadastro.Text = "Personagens";
            // 
            // gbtxts
            // 
            this.gbtxts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbtxts.BackColor = System.Drawing.Color.Transparent;
            this.gbtxts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbtxts.Controls.Add(this.cBoxRaca);
            this.gbtxts.Controls.Add(this.cBoxAlinhamento);
            this.gbtxts.Controls.Add(this.cBoxTamanho);
            this.gbtxts.Controls.Add(this.cBoxGenero);
            this.gbtxts.Controls.Add(this.cBoxClasse);
            this.gbtxts.Controls.Add(this.txtDescricao);
            this.gbtxts.Controls.Add(this.lblCidade);
            this.gbtxts.Controls.Add(this.txtNome);
            this.gbtxts.Controls.Add(this.label3);
            this.gbtxts.Controls.Add(this.label5);
            this.gbtxts.Controls.Add(this.label9);
            this.gbtxts.Controls.Add(this.txtAltura);
            this.gbtxts.Controls.Add(this.txtPeso);
            this.gbtxts.Controls.Add(this.label7);
            this.gbtxts.Controls.Add(this.txtOlhos);
            this.gbtxts.Controls.Add(this.label4);
            this.gbtxts.Controls.Add(this.txtCabelo);
            this.gbtxts.Controls.Add(this.label8);
            this.gbtxts.Controls.Add(this.label2);
            this.gbtxts.Controls.Add(this.label6);
            this.gbtxts.Controls.Add(this.label1);
            this.gbtxts.Controls.Add(this.txtEnderco);
            this.gbtxts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtxts.ForeColor = System.Drawing.Color.Black;
            this.gbtxts.Location = new System.Drawing.Point(66, 319);
            this.gbtxts.Name = "gbtxts";
            this.gbtxts.Size = new System.Drawing.Size(926, 243);
            this.gbtxts.TabIndex = 159;
            this.gbtxts.TabStop = false;
            this.gbtxts.Text = "Cadastro de Personagens";
            // 
            // cBoxRaca
            // 
            this.cBoxRaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cBoxRaca.FormattingEnabled = true;
            this.cBoxRaca.Location = new System.Drawing.Point(241, 47);
            this.cBoxRaca.Name = "cBoxRaca";
            this.cBoxRaca.Size = new System.Drawing.Size(215, 26);
            this.cBoxRaca.TabIndex = 1;
            // 
            // cBoxAlinhamento
            // 
            this.cBoxAlinhamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxAlinhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cBoxAlinhamento.FormattingEnabled = true;
            this.cBoxAlinhamento.Items.AddRange(new object[] {
            "BOM - LEAL",
            "BOM - CAOTICO",
            "BOM - NEUTRO",
            "MAL - LEAL",
            "MAL - CAOTICO",
            "MAL - NEUTRO",
            "NEUTRO - LEAL",
            "NEUTRO - CAOTICO",
            "NEUTRO"});
            this.cBoxAlinhamento.Location = new System.Drawing.Point(683, 47);
            this.cBoxAlinhamento.Name = "cBoxAlinhamento";
            this.cBoxAlinhamento.Size = new System.Drawing.Size(215, 26);
            this.cBoxAlinhamento.TabIndex = 3;
            // 
            // cBoxTamanho
            // 
            this.cBoxTamanho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cBoxTamanho.FormattingEnabled = true;
            this.cBoxTamanho.Items.AddRange(new object[] {
            "Anão",
            "Pequeno",
            "Medio",
            "Grande",
            "Gigante"});
            this.cBoxTamanho.Location = new System.Drawing.Point(241, 146);
            this.cBoxTamanho.Name = "cBoxTamanho";
            this.cBoxTamanho.Size = new System.Drawing.Size(215, 26);
            this.cBoxTamanho.TabIndex = 7;
            // 
            // cBoxGenero
            // 
            this.cBoxGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cBoxGenero.FormattingEnabled = true;
            this.cBoxGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Neutro",
            "Luis"});
            this.cBoxGenero.Location = new System.Drawing.Point(20, 96);
            this.cBoxGenero.Name = "cBoxGenero";
            this.cBoxGenero.Size = new System.Drawing.Size(215, 26);
            this.cBoxGenero.TabIndex = 4;
            // 
            // cBoxClasse
            // 
            this.cBoxClasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cBoxClasse.FormattingEnabled = true;
            this.cBoxClasse.Location = new System.Drawing.Point(462, 47);
            this.cBoxClasse.Name = "cBoxClasse";
            this.cBoxClasse.Size = new System.Drawing.Size(215, 26);
            this.cBoxClasse.TabIndex = 2;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(459, 77);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(73, 16);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNome.Location = new System.Drawing.Point(20, 47);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 24);
            this.txtNome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(459, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Classe:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(680, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alinhamento:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAltura.Location = new System.Drawing.Point(20, 195);
            this.txtAltura.MaxLength = 50;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(215, 24);
            this.txtAltura.TabIndex = 8;
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPeso.Location = new System.Drawing.Point(241, 195);
            this.txtPeso.MaxLength = 50;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(215, 24);
            this.txtPeso.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Olhos:";
            // 
            // txtOlhos
            // 
            this.txtOlhos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOlhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtOlhos.Location = new System.Drawing.Point(20, 146);
            this.txtOlhos.MaxLength = 50;
            this.txtOlhos.Name = "txtOlhos";
            this.txtOlhos.Size = new System.Drawing.Size(215, 24);
            this.txtOlhos.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Genero:";
            // 
            // txtCabelo
            // 
            this.txtCabelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCabelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCabelo.Location = new System.Drawing.Point(241, 96);
            this.txtCabelo.MaxLength = 50;
            this.txtCabelo.Name = "txtCabelo";
            this.txtCabelo.Size = new System.Drawing.Size(215, 24);
            this.txtCabelo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(238, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Peso:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(238, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Raça:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(238, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tamanho:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtEnderco
            // 
            this.txtEnderco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnderco.AutoSize = true;
            this.txtEnderco.BackColor = System.Drawing.Color.Transparent;
            this.txtEnderco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEnderco.ForeColor = System.Drawing.Color.Black;
            this.txtEnderco.Location = new System.Drawing.Point(238, 77);
            this.txtEnderco.Name = "txtEnderco";
            this.txtEnderco.Size = new System.Drawing.Size(55, 16);
            this.txtEnderco.TabIndex = 0;
            this.txtEnderco.Text = "Cabelo:";
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(966, 11);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(40, 13);
            this.LblCodigo.TabIndex = 160;
            this.LblCodigo.Text = "Codigo";
            this.LblCodigo.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(821, 568);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 47);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGravar.BackColor = System.Drawing.Color.Transparent;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(66, 568);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(171, 47);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(243, 568);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(171, 47);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "   &Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // gbResultadoDaPesquisa
            // 
            this.gbResultadoDaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbResultadoDaPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbResultadoDaPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbResultadoDaPesquisa.Controls.Add(this.dgv);
            this.gbResultadoDaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultadoDaPesquisa.Location = new System.Drawing.Point(66, 58);
            this.gbResultadoDaPesquisa.Name = "gbResultadoDaPesquisa";
            this.gbResultadoDaPesquisa.Size = new System.Drawing.Size(926, 255);
            this.gbResultadoDaPesquisa.TabIndex = 153;
            this.gbResultadoDaPesquisa.TabStop = false;
            this.gbResultadoDaPesquisa.Text = "Meus Personagens";
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(20, 43);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(877, 185);
            this.dgv.TabIndex = 3;
            // 
            // LblVoltar
            // 
            this.LblVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblVoltar.AutoSize = true;
            this.LblVoltar.Location = new System.Drawing.Point(848, 11);
            this.LblVoltar.Name = "LblVoltar";
            this.LblVoltar.Size = new System.Drawing.Size(50, 13);
            this.LblVoltar.TabIndex = 162;
            this.LblVoltar.Text = "VOLTAR";
            this.LblVoltar.Visible = false;
            // 
            // FrmCadPersongem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 643);
            this.Controls.Add(this.LblVoltar);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.lblDadosDoCadastro);
            this.Controls.Add(this.gbtxts);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbResultadoDaPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadPersongem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadPersongem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadPersongem_Load);
            this.gbtxts.ResumeLayout(false);
            this.gbtxts.PerformLayout();
            this.gbResultadoDaPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblUser;
        public System.Windows.Forms.TextBox txtDescricao;
        internal System.Windows.Forms.Label lblDadosDoCadastro;
        public System.Windows.Forms.GroupBox gbtxts;
        public System.Windows.Forms.Label lblCidade;
        public System.Windows.Forms.TextBox txtCabelo;
        public System.Windows.Forms.Label txtEnderco;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnGravar;
        internal System.Windows.Forms.Button btnLimpar;
        internal System.Windows.Forms.GroupBox gbResultadoDaPesquisa;
        internal System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtAltura;
        public System.Windows.Forms.TextBox txtPeso;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtOlhos;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label LblCodigo;
        public System.Windows.Forms.ComboBox cBoxClasse;
        public System.Windows.Forms.ComboBox cBoxRaca;
        public System.Windows.Forms.ComboBox cBoxAlinhamento;
        public System.Windows.Forms.ComboBox cBoxTamanho;
        public System.Windows.Forms.ComboBox cBoxGenero;
        public System.Windows.Forms.Label LblVoltar;
    }
}