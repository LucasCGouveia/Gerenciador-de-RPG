namespace Gerenciador
{
    partial class FrmVendas
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtJades = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.LblItem = new System.Windows.Forms.Label();
            this.LblPersonagem = new System.Windows.Forms.Label();
            this.LblVenda = new System.Windows.Forms.Label();
            this.gbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGravar.BackColor = System.Drawing.Color.Transparent;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.Location = new System.Drawing.Point(23, 160);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGravar.Size = new System.Drawing.Size(105, 42);
            this.btnGravar.TabIndex = 106;
            this.btnGravar.Text = "&Vender";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 46);
            this.label1.TabIndex = 103;
            this.label1.Text = "Vendas";
            // 
            // gbCadastro
            // 
            this.gbCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCadastro.BackColor = System.Drawing.Color.Transparent;
            this.gbCadastro.Controls.Add(this.btnGravar);
            this.gbCadastro.Controls.Add(this.txtValor);
            this.gbCadastro.Controls.Add(this.txtJades);
            this.gbCadastro.Controls.Add(this.txtItem);
            this.gbCadastro.Controls.Add(this.lblNome);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.BtnSair);
            this.gbCadastro.Controls.Add(this.lblSenha);
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCadastro.Location = new System.Drawing.Point(19, 64);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbCadastro.Size = new System.Drawing.Size(460, 208);
            this.gbCadastro.TabIndex = 102;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Negociação";
            // 
            // txtValor
            // 
            this.txtValor.AcceptsReturn = true;
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtValor.Location = new System.Drawing.Point(23, 113);
            this.txtValor.MaxLength = 20;
            this.txtValor.Name = "txtValor";
            this.txtValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValor.Size = new System.Drawing.Size(191, 21);
            this.txtValor.TabIndex = 3;
            // 
            // txtJades
            // 
            this.txtJades.AcceptsReturn = true;
            this.txtJades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJades.BackColor = System.Drawing.SystemColors.Window;
            this.txtJades.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJades.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJades.Enabled = false;
            this.txtJades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtJades.Location = new System.Drawing.Point(250, 62);
            this.txtJades.MaxLength = 8;
            this.txtJades.Name = "txtJades";
            this.txtJades.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtJades.Size = new System.Drawing.Size(191, 21);
            this.txtJades.TabIndex = 3;
            // 
            // txtItem
            // 
            this.txtItem.AcceptsReturn = true;
            this.txtItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItem.BackColor = System.Drawing.SystemColors.Window;
            this.txtItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItem.Location = new System.Drawing.Point(23, 62);
            this.txtItem.MaxLength = 50;
            this.txtItem.Name = "txtItem";
            this.txtItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtItem.Size = new System.Drawing.Size(191, 21);
            this.txtItem.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(20, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(64, 21);
            this.lblNome.TabIndex = 46;
            this.lblNome.Tag = "&User Name:";
            this.lblNome.Text = "Item:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 45;
            this.label2.Tag = "&Password:";
            this.label2.Text = "Valor:";
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.Black;
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(336, 160);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSair.Size = new System.Drawing.Size(105, 42);
            this.BtnSair.TabIndex = 107;
            this.BtnSair.Text = "&Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenha.Location = new System.Drawing.Point(247, 38);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSenha.Size = new System.Drawing.Size(85, 21);
            this.lblSenha.TabIndex = 45;
            this.lblSenha.Tag = "&Password:";
            this.lblSenha.Text = "Suas Jades:";
            // 
            // LblItem
            // 
            this.LblItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblItem.BackColor = System.Drawing.Color.Transparent;
            this.LblItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblItem.Location = new System.Drawing.Point(446, 9);
            this.LblItem.Name = "LblItem";
            this.LblItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblItem.Size = new System.Drawing.Size(41, 21);
            this.LblItem.TabIndex = 108;
            this.LblItem.Tag = "&Password:";
            this.LblItem.Text = "ITEM";
            this.LblItem.Visible = false;
            // 
            // LblPersonagem
            // 
            this.LblPersonagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.LblPersonagem.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPersonagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPersonagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPersonagem.Location = new System.Drawing.Point(341, 9);
            this.LblPersonagem.Name = "LblPersonagem";
            this.LblPersonagem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblPersonagem.Size = new System.Drawing.Size(99, 21);
            this.LblPersonagem.TabIndex = 109;
            this.LblPersonagem.Tag = "&Password:";
            this.LblPersonagem.Text = "PERSONAGEM";
            this.LblPersonagem.Visible = false;
            // 
            // LblVenda
            // 
            this.LblVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblVenda.BackColor = System.Drawing.Color.Transparent;
            this.LblVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblVenda.Location = new System.Drawing.Point(446, 30);
            this.LblVenda.Name = "LblVenda";
            this.LblVenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblVenda.Size = new System.Drawing.Size(48, 21);
            this.LblVenda.TabIndex = 110;
            this.LblVenda.Tag = "&Password:";
            this.LblVenda.Text = "VENDA";
            this.LblVenda.Visible = false;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 304);
            this.Controls.Add(this.LblVenda);
            this.Controls.Add(this.LblPersonagem);
            this.Controls.Add(this.LblItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVendas";
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbCadastro;
        public System.Windows.Forms.TextBox txtJades;
        public System.Windows.Forms.TextBox txtItem;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label lblSenha;
        internal System.Windows.Forms.Button BtnSair;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LblItem;
        public System.Windows.Forms.Label LblPersonagem;
        public System.Windows.Forms.Label LblVenda;
    }
}