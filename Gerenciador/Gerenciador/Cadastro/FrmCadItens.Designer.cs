namespace Gerenciador.Cadastro
{
    partial class FrmCadItens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblValidacao = new System.Windows.Forms.Label();
            this.txtSenhaCookie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.lblDadosDoCadastro = new System.Windows.Forms.Label();
            this.lblResultadoDaPesquisa = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.gbResultadoDaPesquisa = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEnderco = new System.Windows.Forms.Label();
            this.txtUsuarioCookie = new System.Windows.Forms.TextBox();
            this.lblCodEndereco = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gbtxts = new System.Windows.Forms.GroupBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.gbResultadoDaPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbtxts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValidacao
            // 
            this.lblValidacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidacao.AutoSize = true;
            this.lblValidacao.BackColor = System.Drawing.Color.Transparent;
            this.lblValidacao.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValidacao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblValidacao.Location = new System.Drawing.Point(638, 30);
            this.lblValidacao.Name = "lblValidacao";
            this.lblValidacao.Size = new System.Drawing.Size(290, 46);
            this.lblValidacao.TabIndex = 139;
            this.lblValidacao.Text = "VALIDACAO!!!";
            this.lblValidacao.Visible = false;
            // 
            // txtSenhaCookie
            // 
            this.txtSenhaCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenhaCookie.Location = new System.Drawing.Point(426, 41);
            this.txtSenhaCookie.MaxLength = 20;
            this.txtSenhaCookie.Name = "txtSenhaCookie";
            this.txtSenhaCookie.PasswordChar = '*';
            this.txtSenhaCookie.Size = new System.Drawing.Size(199, 20);
            this.txtSenhaCookie.TabIndex = 138;
            this.txtSenhaCookie.Text = "txtSenhaCookie";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo de Contato:";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.Black;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(57, 593);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(171, 47);
            this.BtnEditar.TabIndex = 132;
            this.BtnEditar.Text = "E&ditar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.Black;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(233, 593);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(171, 47);
            this.BtnExcluir.TabIndex = 131;
            this.BtnExcluir.Text = "   &Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // lblDadosDoCadastro
            // 
            this.lblDadosDoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDadosDoCadastro.AutoSize = true;
            this.lblDadosDoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosDoCadastro.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDoCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDadosDoCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDadosDoCadastro.Location = new System.Drawing.Point(200, 78);
            this.lblDadosDoCadastro.Name = "lblDadosDoCadastro";
            this.lblDadosDoCadastro.Size = new System.Drawing.Size(235, 46);
            this.lblDadosDoCadastro.TabIndex = 130;
            this.lblDadosDoCadastro.Text = "Contatos de: ";
            // 
            // lblResultadoDaPesquisa
            // 
            this.lblResultadoDaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultadoDaPesquisa.AutoSize = true;
            this.lblResultadoDaPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoDaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDaPesquisa.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoDaPesquisa.Location = new System.Drawing.Point(389, 14);
            this.lblResultadoDaPesquisa.Name = "lblResultadoDaPesquisa";
            this.lblResultadoDaPesquisa.Size = new System.Drawing.Size(155, 15);
            this.lblResultadoDaPesquisa.TabIndex = 0;
            this.lblResultadoDaPesquisa.Text = "Resultado da Pesquisa";
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
            this.Label24.Size = new System.Drawing.Size(166, 20);
            this.Label24.TabIndex = 0;
            this.Label24.Text = "Cadastrar Contatos";
            // 
            // gbResultadoDaPesquisa
            // 
            this.gbResultadoDaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbResultadoDaPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbResultadoDaPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbResultadoDaPesquisa.Controls.Add(this.dgv);
            this.gbResultadoDaPesquisa.Controls.Add(this.lblResultadoDaPesquisa);
            this.gbResultadoDaPesquisa.Location = new System.Drawing.Point(55, 130);
            this.gbResultadoDaPesquisa.Name = "gbResultadoDaPesquisa";
            this.gbResultadoDaPesquisa.Size = new System.Drawing.Size(879, 255);
            this.gbResultadoDaPesquisa.TabIndex = 127;
            this.gbResultadoDaPesquisa.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 43);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(867, 185);
            this.dgv.TabIndex = 3;
            // 
            // cboxTipo
            // 
            this.cboxTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxTipo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Location = new System.Drawing.Point(33, 81);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(139, 24);
            this.cboxTipo.Sorted = true;
            this.cboxTipo.TabIndex = 7;
            this.cboxTipo.UseWaitCursor = true;
            // 
            // txtObs
            // 
            this.txtObs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtObs.Location = new System.Drawing.Point(459, 81);
            this.txtObs.MaxLength = 20;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(381, 77);
            this.txtObs.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(409, 593);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(171, 47);
            this.btnLimpar.TabIndex = 129;
            this.btnLimpar.Text = "   &Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
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
            this.lblCidade.Size = new System.Drawing.Size(86, 16);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Observação:";
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
            this.txtEnderco.Size = new System.Drawing.Size(57, 16);
            this.txtEnderco.TabIndex = 0;
            this.txtEnderco.Text = "Contato:";
            // 
            // txtUsuarioCookie
            // 
            this.txtUsuarioCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuarioCookie.Location = new System.Drawing.Point(211, 41);
            this.txtUsuarioCookie.MaxLength = 20;
            this.txtUsuarioCookie.Name = "txtUsuarioCookie";
            this.txtUsuarioCookie.Size = new System.Drawing.Size(199, 20);
            this.txtUsuarioCookie.TabIndex = 137;
            this.txtUsuarioCookie.Text = "txtUsuarioCookie";
            // 
            // lblCodEndereco
            // 
            this.lblCodEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodEndereco.AutoSize = true;
            this.lblCodEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblCodEndereco.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEndereco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodEndereco.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCodEndereco.Location = new System.Drawing.Point(793, 76);
            this.lblCodEndereco.Name = "lblCodEndereco";
            this.lblCodEndereco.Size = new System.Drawing.Size(141, 46);
            this.lblCodEndereco.TabIndex = 136;
            this.lblCodEndereco.Text = "COD!!!";
            this.lblCodEndereco.Visible = false;
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.LblCodigo.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCodigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblCodigo.Location = new System.Drawing.Point(60, 78);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(141, 46);
            this.LblCodigo.TabIndex = 134;
            this.LblCodigo.Text = "COD!!!";
            this.LblCodigo.Visible = false;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(445, 78);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(253, 46);
            this.lblNomeFuncionario.TabIndex = 133;
            this.lblNomeFuncionario.Text = "Funcionario!!!";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(763, 593);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 47);
            this.btnSair.TabIndex = 128;
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
            this.btnGravar.Location = new System.Drawing.Point(586, 593);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(171, 47);
            this.btnGravar.TabIndex = 126;
            this.btnGravar.Text = "     &Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // gbtxts
            // 
            this.gbtxts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbtxts.BackColor = System.Drawing.Color.Transparent;
            this.gbtxts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbtxts.Controls.Add(this.label1);
            this.gbtxts.Controls.Add(this.Label24);
            this.gbtxts.Controls.Add(this.cboxTipo);
            this.gbtxts.Controls.Add(this.txtObs);
            this.gbtxts.Controls.Add(this.lblCidade);
            this.gbtxts.Controls.Add(this.txtContato);
            this.gbtxts.Controls.Add(this.txtEnderco);
            this.gbtxts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtxts.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbtxts.Location = new System.Drawing.Point(55, 391);
            this.gbtxts.Name = "gbtxts";
            this.gbtxts.Size = new System.Drawing.Size(879, 184);
            this.gbtxts.TabIndex = 135;
            this.gbtxts.TabStop = false;
            // 
            // txtContato
            // 
            this.txtContato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtContato.Location = new System.Drawing.Point(33, 136);
            this.txtContato.MaxLength = 50;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(366, 22);
            this.txtContato.TabIndex = 2;
            // 
            // FrmCadItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 670);
            this.Controls.Add(this.lblValidacao);
            this.Controls.Add(this.txtSenhaCookie);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.lblDadosDoCadastro);
            this.Controls.Add(this.gbResultadoDaPesquisa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtUsuarioCookie);
            this.Controls.Add(this.lblCodEndereco);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gbtxts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadItens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbResultadoDaPesquisa.ResumeLayout(false);
            this.gbResultadoDaPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbtxts.ResumeLayout(false);
            this.gbtxts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblValidacao;
        internal System.Windows.Forms.TextBox txtSenhaCookie;
        public System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnEditar;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Label lblDadosDoCadastro;
        internal System.Windows.Forms.Label lblResultadoDaPesquisa;
        public System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.GroupBox gbResultadoDaPesquisa;
        internal System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.ComboBox cboxTipo;
        public System.Windows.Forms.TextBox txtObs;
        internal System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Label lblCidade;
        public System.Windows.Forms.Label txtEnderco;
        public System.Windows.Forms.TextBox txtUsuarioCookie;
        internal System.Windows.Forms.Label lblCodEndereco;
        internal System.Windows.Forms.Label LblCodigo;
        internal System.Windows.Forms.Label lblNomeFuncionario;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.GroupBox gbtxts;
        public System.Windows.Forms.TextBox txtContato;
    }
}