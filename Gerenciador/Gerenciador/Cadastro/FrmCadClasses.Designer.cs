﻿namespace Gerenciador
{
    partial class FrmCadClasses
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
            this.Label24 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtEnderco = new System.Windows.Forms.Label();
            this.gbResultadoDaPesquisa = new System.Windows.Forms.GroupBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.lblDadosDoCadastro = new System.Windows.Forms.Label();
            this.gbtxts = new System.Windows.Forms.GroupBox();
            this.LblCodClasse = new System.Windows.Forms.Label();
            this.LblMestre = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbResultadoDaPesquisa.SuspendLayout();
            this.gbtxts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(459, 81);
            this.txtDescricao.MaxLength = 20;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(381, 77);
            this.txtDescricao.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(743, 519);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 47);
            this.btnSair.TabIndex = 142;
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
            this.btnGravar.Location = new System.Drawing.Point(566, 519);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(171, 47);
            this.btnGravar.TabIndex = 140;
            this.btnGravar.Text = "     &Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // Label24
            // 
            this.Label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.Transparent;
            this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Label24.ForeColor = System.Drawing.Color.Black;
            this.Label24.Location = new System.Drawing.Point(344, 19);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(184, 20);
            this.Label24.TabIndex = 0;
            this.Label24.Text = "Cadastros de Classes";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(456, 62);
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
            this.btnLimpar.Location = new System.Drawing.Point(389, 519);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(171, 47);
            this.btnLimpar.TabIndex = 143;
            this.btnLimpar.Text = "   &Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtClasse
            // 
            this.txtClasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtClasse.Location = new System.Drawing.Point(33, 136);
            this.txtClasse.MaxLength = 50;
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(366, 22);
            this.txtClasse.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 29);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // txtEnderco
            // 
            this.txtEnderco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnderco.AutoSize = true;
            this.txtEnderco.BackColor = System.Drawing.Color.Transparent;
            this.txtEnderco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEnderco.ForeColor = System.Drawing.Color.Black;
            this.txtEnderco.Location = new System.Drawing.Point(30, 113);
            this.txtEnderco.Name = "txtEnderco";
            this.txtEnderco.Size = new System.Drawing.Size(53, 16);
            this.txtEnderco.TabIndex = 0;
            this.txtEnderco.Text = "Classe:";
            // 
            // gbResultadoDaPesquisa
            // 
            this.gbResultadoDaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbResultadoDaPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbResultadoDaPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbResultadoDaPesquisa.Controls.Add(this.dgv);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtQuantidade);
            this.gbResultadoDaPesquisa.Controls.Add(this.label1);
            this.gbResultadoDaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultadoDaPesquisa.Location = new System.Drawing.Point(35, 56);
            this.gbResultadoDaPesquisa.Name = "gbResultadoDaPesquisa";
            this.gbResultadoDaPesquisa.Size = new System.Drawing.Size(879, 255);
            this.gbResultadoDaPesquisa.TabIndex = 141;
            this.gbResultadoDaPesquisa.TabStop = false;
            this.gbResultadoDaPesquisa.Text = "Classes Cadastradas";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.Black;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(37, 519);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(171, 47);
            this.BtnEditar.TabIndex = 146;
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
            this.BtnExcluir.Location = new System.Drawing.Point(213, 519);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(171, 47);
            this.BtnExcluir.TabIndex = 145;
            this.BtnExcluir.Text = "   &Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // lblDadosDoCadastro
            // 
            this.lblDadosDoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDadosDoCadastro.AutoSize = true;
            this.lblDadosDoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosDoCadastro.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDoCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDadosDoCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDadosDoCadastro.Location = new System.Drawing.Point(404, 7);
            this.lblDadosDoCadastro.Name = "lblDadosDoCadastro";
            this.lblDadosDoCadastro.Size = new System.Drawing.Size(131, 46);
            this.lblDadosDoCadastro.TabIndex = 144;
            this.lblDadosDoCadastro.Text = "Classes";
            // 
            // gbtxts
            // 
            this.gbtxts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbtxts.BackColor = System.Drawing.Color.Transparent;
            this.gbtxts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbtxts.Controls.Add(this.Label24);
            this.gbtxts.Controls.Add(this.txtDescricao);
            this.gbtxts.Controls.Add(this.lblCidade);
            this.gbtxts.Controls.Add(this.txtClasse);
            this.gbtxts.Controls.Add(this.txtEnderco);
            this.gbtxts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtxts.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbtxts.Location = new System.Drawing.Point(35, 317);
            this.gbtxts.Name = "gbtxts";
            this.gbtxts.Size = new System.Drawing.Size(879, 184);
            this.gbtxts.TabIndex = 149;
            this.gbtxts.TabStop = false;
            // 
            // LblCodClasse
            // 
            this.LblCodClasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCodClasse.AutoSize = true;
            this.LblCodClasse.Location = new System.Drawing.Point(65, 32);
            this.LblCodClasse.Name = "LblCodClasse";
            this.LblCodClasse.Size = new System.Drawing.Size(71, 13);
            this.LblCodClasse.TabIndex = 150;
            this.LblCodClasse.Text = "CodigoClasse";
            this.LblCodClasse.Visible = false;
            // 
            // LblMestre
            // 
            this.LblMestre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMestre.AutoSize = true;
            this.LblMestre.Location = new System.Drawing.Point(873, 9);
            this.LblMestre.Name = "LblMestre";
            this.LblMestre.Size = new System.Drawing.Size(52, 13);
            this.LblMestre.TabIndex = 151;
            this.LblMestre.Text = "MESTRE";
            this.LblMestre.Visible = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtQuantidade.Location = new System.Drawing.Point(93, 227);
            this.txtQuantidade.MaxLength = 50;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(80, 26);
            this.txtQuantidade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade:";
            // 
            // FrmCadClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 594);
            this.Controls.Add(this.LblMestre);
            this.Controls.Add(this.LblCodClasse);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbResultadoDaPesquisa);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.lblDadosDoCadastro);
            this.Controls.Add(this.gbtxts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadClasses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbResultadoDaPesquisa.ResumeLayout(false);
            this.gbResultadoDaPesquisa.PerformLayout();
            this.gbtxts.ResumeLayout(false);
            this.gbtxts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtDescricao;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Label Label24;
        public System.Windows.Forms.Label lblCidade;
        internal System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.TextBox txtClasse;
        internal System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.Label txtEnderco;
        internal System.Windows.Forms.GroupBox gbResultadoDaPesquisa;
        internal System.Windows.Forms.Button BtnEditar;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Label lblDadosDoCadastro;
        public System.Windows.Forms.GroupBox gbtxts;
        private System.Windows.Forms.Label LblCodClasse;
        public System.Windows.Forms.Label LblMestre;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.Label label1;
    }
}