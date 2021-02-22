namespace Gerenciador
{
    partial class FrmItens
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtRacas = new System.Windows.Forms.Label();
            this.gbResultadoDaPesquisa = new System.Windows.Forms.GroupBox();
            this.BtnSair2 = new System.Windows.Forms.Button();
            this.BtnComprar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.LblPesquisar = new System.Windows.Forms.Label();
            this.txtJades = new System.Windows.Forms.TextBox();
            this.lblSeuDinheiro = new System.Windows.Forms.Label();
            this.LblCodItem = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxTipo = new System.Windows.Forms.ComboBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtDano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblCampanha = new System.Windows.Forms.Label();
            this.LblPersonagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbResultadoDaPesquisa.SuspendLayout();
            this.gbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(470, 66);
            this.txtDescricao.MaxLength = 999;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(381, 121);
            this.txtDescricao.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(727, 209);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 47);
            this.btnSair.TabIndex = 7;
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
            this.btnGravar.Location = new System.Drawing.Point(550, 209);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(171, 47);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "     &Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(467, 47);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(73, 16);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Descrição:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(373, 209);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(171, 47);
            this.btnLimpar.TabIndex = 163;
            this.btnLimpar.Text = "   &Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtItem
            // 
            this.txtItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtItem.Location = new System.Drawing.Point(44, 70);
            this.txtItem.MaxLength = 50;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(204, 22);
            this.txtItem.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(27, 43);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgv.Size = new System.Drawing.Size(867, 185);
            this.dgv.TabIndex = 3;
            // 
            // txtRacas
            // 
            this.txtRacas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRacas.AutoSize = true;
            this.txtRacas.BackColor = System.Drawing.Color.Transparent;
            this.txtRacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtRacas.ForeColor = System.Drawing.Color.Black;
            this.txtRacas.Location = new System.Drawing.Point(41, 47);
            this.txtRacas.Name = "txtRacas";
            this.txtRacas.Size = new System.Drawing.Size(36, 16);
            this.txtRacas.TabIndex = 0;
            this.txtRacas.Text = "Item:";
            // 
            // gbResultadoDaPesquisa
            // 
            this.gbResultadoDaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbResultadoDaPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbResultadoDaPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbResultadoDaPesquisa.Controls.Add(this.BtnSair2);
            this.gbResultadoDaPesquisa.Controls.Add(this.BtnComprar);
            this.gbResultadoDaPesquisa.Controls.Add(this.BtnPesquisar);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtPesquisa);
            this.gbResultadoDaPesquisa.Controls.Add(this.LblPesquisar);
            this.gbResultadoDaPesquisa.Controls.Add(this.dgv);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtJades);
            this.gbResultadoDaPesquisa.Controls.Add(this.lblSeuDinheiro);
            this.gbResultadoDaPesquisa.Location = new System.Drawing.Point(97, 54);
            this.gbResultadoDaPesquisa.Name = "gbResultadoDaPesquisa";
            this.gbResultadoDaPesquisa.Size = new System.Drawing.Size(905, 294);
            this.gbResultadoDaPesquisa.TabIndex = 161;
            this.gbResultadoDaPesquisa.TabStop = false;
            // 
            // BtnSair2
            // 
            this.BtnSair2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair2.Location = new System.Drawing.Point(685, 241);
            this.BtnSair2.Name = "BtnSair2";
            this.BtnSair2.Size = new System.Drawing.Size(171, 47);
            this.BtnSair2.TabIndex = 169;
            this.BtnSair2.Text = "&Sair";
            this.BtnSair2.UseVisualStyleBackColor = true;
            this.BtnSair2.Visible = false;
            this.BtnSair2.Click += new System.EventHandler(this.BtnSair2_Click);
            // 
            // BtnComprar
            // 
            this.BtnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar.Location = new System.Drawing.Point(491, 241);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(171, 47);
            this.BtnComprar.TabIndex = 169;
            this.BtnComprar.Text = "&Comprar";
            this.BtnComprar.UseVisualStyleBackColor = true;
            this.BtnComprar.Visible = false;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.Location = new System.Drawing.Point(642, 12);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(133, 23);
            this.BtnPesquisar.TabIndex = 169;
            this.BtnPesquisar.Text = "PESQUISAR";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPesquisa.Location = new System.Drawing.Point(280, 13);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(348, 22);
            this.txtPesquisa.TabIndex = 0;
            // 
            // LblPesquisar
            // 
            this.LblPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPesquisar.AutoSize = true;
            this.LblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.LblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LblPesquisar.ForeColor = System.Drawing.Color.Black;
            this.LblPesquisar.Location = new System.Drawing.Point(202, 16);
            this.LblPesquisar.Name = "LblPesquisar";
            this.LblPesquisar.Size = new System.Drawing.Size(72, 16);
            this.LblPesquisar.TabIndex = 167;
            this.LblPesquisar.Text = "Pesquisar:";
            // 
            // txtJades
            // 
            this.txtJades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJades.Enabled = false;
            this.txtJades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtJades.Location = new System.Drawing.Point(42, 254);
            this.txtJades.MaxLength = 50;
            this.txtJades.Name = "txtJades";
            this.txtJades.Size = new System.Drawing.Size(204, 29);
            this.txtJades.TabIndex = 2;
            this.txtJades.Visible = false;
            // 
            // lblSeuDinheiro
            // 
            this.lblSeuDinheiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeuDinheiro.AutoSize = true;
            this.lblSeuDinheiro.BackColor = System.Drawing.Color.Transparent;
            this.lblSeuDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSeuDinheiro.ForeColor = System.Drawing.Color.Black;
            this.lblSeuDinheiro.Location = new System.Drawing.Point(39, 231);
            this.lblSeuDinheiro.Name = "lblSeuDinheiro";
            this.lblSeuDinheiro.Size = new System.Drawing.Size(88, 16);
            this.lblSeuDinheiro.TabIndex = 0;
            this.lblSeuDinheiro.Text = "Seu Dinheiro:";
            this.lblSeuDinheiro.Visible = false;
            // 
            // LblCodItem
            // 
            this.LblCodItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCodItem.AutoSize = true;
            this.LblCodItem.Location = new System.Drawing.Point(878, 9);
            this.LblCodItem.Name = "LblCodItem";
            this.LblCodItem.Size = new System.Drawing.Size(33, 13);
            this.LblCodItem.TabIndex = 168;
            this.LblCodItem.Text = "ITEM";
            this.LblCodItem.Visible = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.Black;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(21, 209);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(171, 47);
            this.BtnEditar.TabIndex = 166;
            this.BtnEditar.Text = "E&ditar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.Black;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(197, 209);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(171, 47);
            this.BtnExcluir.TabIndex = 165;
            this.BtnExcluir.Text = "   &Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoItem.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTipoItem.Location = new System.Drawing.Point(471, 9);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(134, 46);
            this.lblTipoItem.TabIndex = 164;
            this.lblTipoItem.Text = "ITENS";
            // 
            // gbCadastro
            // 
            this.gbCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCadastro.BackColor = System.Drawing.Color.Transparent;
            this.gbCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbCadastro.Controls.Add(this.txtValor);
            this.gbCadastro.Controls.Add(this.label5);
            this.gbCadastro.Controls.Add(this.btnSair);
            this.gbCadastro.Controls.Add(this.btnGravar);
            this.gbCadastro.Controls.Add(this.cBoxTipo);
            this.gbCadastro.Controls.Add(this.txtDescricao);
            this.gbCadastro.Controls.Add(this.btnLimpar);
            this.gbCadastro.Controls.Add(this.lblCidade);
            this.gbCadastro.Controls.Add(this.txtBonus);
            this.gbCadastro.Controls.Add(this.txtDano);
            this.gbCadastro.Controls.Add(this.txtItem);
            this.gbCadastro.Controls.Add(this.BtnEditar);
            this.gbCadastro.Controls.Add(this.label3);
            this.gbCadastro.Controls.Add(this.BtnExcluir);
            this.gbCadastro.Controls.Add(this.label1);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.txtRacas);
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.ForeColor = System.Drawing.Color.Black;
            this.gbCadastro.Location = new System.Drawing.Point(93, 354);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(909, 262);
            this.gbCadastro.TabIndex = 167;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastrar novo Item";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtValor.Location = new System.Drawing.Point(44, 165);
            this.txtValor.MaxLength = 50;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(204, 22);
            this.txtValor.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor:";
            // 
            // cBoxTipo
            // 
            this.cBoxTipo.FormattingEnabled = true;
            this.cBoxTipo.Items.AddRange(new object[] {
            "ARMA",
            "ARMADURA",
            "CONSUMO",
            "ESCUDO",
            "ITEM MAGICO",
            "POÇÃO"});
            this.cBoxTipo.Location = new System.Drawing.Point(254, 70);
            this.cBoxTipo.Name = "cBoxTipo";
            this.cBoxTipo.Size = new System.Drawing.Size(204, 24);
            this.cBoxTipo.TabIndex = 1;
            // 
            // txtBonus
            // 
            this.txtBonus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBonus.Location = new System.Drawing.Point(254, 118);
            this.txtBonus.MaxLength = 50;
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(204, 22);
            this.txtBonus.TabIndex = 3;
            // 
            // txtDano
            // 
            this.txtDano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDano.Location = new System.Drawing.Point(44, 118);
            this.txtDano.MaxLength = 50;
            this.txtDano.Name = "txtDano";
            this.txtDano.Size = new System.Drawing.Size(204, 22);
            this.txtDano.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(251, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bonus:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dano:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(251, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo:";
            // 
            // LblUser
            // 
            this.LblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(997, 9);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(56, 13);
            this.LblUser.TabIndex = 169;
            this.LblUser.Text = "USUARIO";
            this.LblUser.Visible = false;
            // 
            // LblCampanha
            // 
            this.LblCampanha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCampanha.AutoSize = true;
            this.LblCampanha.Location = new System.Drawing.Point(924, 9);
            this.LblCampanha.Name = "LblCampanha";
            this.LblCampanha.Size = new System.Drawing.Size(67, 13);
            this.LblCampanha.TabIndex = 170;
            this.LblCampanha.Text = "CAMPANHA";
            this.LblCampanha.Visible = false;
            // 
            // LblPersonagem
            // 
            this.LblPersonagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPersonagem.AutoSize = true;
            this.LblPersonagem.Location = new System.Drawing.Point(789, 9);
            this.LblPersonagem.Name = "LblPersonagem";
            this.LblPersonagem.Size = new System.Drawing.Size(83, 13);
            this.LblPersonagem.TabIndex = 171;
            this.LblPersonagem.Text = "PERSONAGEM";
            this.LblPersonagem.Visible = false;
            // 
            // FrmItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 646);
            this.Controls.Add(this.LblPersonagem);
            this.Controls.Add(this.LblCampanha);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.gbResultadoDaPesquisa);
            this.Controls.Add(this.LblCodItem);
            this.Controls.Add(this.lblTipoItem);
            this.Controls.Add(this.gbCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmItens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbResultadoDaPesquisa.ResumeLayout(false);
            this.gbResultadoDaPesquisa.PerformLayout();
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtDescricao;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Label lblCidade;
        internal System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.TextBox txtItem;
        internal System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.Label txtRacas;
        internal System.Windows.Forms.GroupBox gbResultadoDaPesquisa;
        internal System.Windows.Forms.Button BtnEditar;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Label lblTipoItem;
        public System.Windows.Forms.GroupBox gbCadastro;
        public System.Windows.Forms.TextBox txtBonus;
        public System.Windows.Forms.TextBox txtDano;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtJades;
        public System.Windows.Forms.Label lblSeuDinheiro;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.Label LblPesquisar;
        public System.Windows.Forms.Label LblCodItem;
        public System.Windows.Forms.Label LblUser;
        public System.Windows.Forms.Label LblCampanha;
        public System.Windows.Forms.Label LblPersonagem;
        public System.Windows.Forms.Button BtnSair2;
        public System.Windows.Forms.Button BtnComprar;
        public System.Windows.Forms.ComboBox cBoxTipo;
        public System.Windows.Forms.Button BtnPesquisar;
    }
}