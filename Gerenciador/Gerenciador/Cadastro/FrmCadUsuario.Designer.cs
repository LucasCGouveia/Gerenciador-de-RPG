namespace Gerenciador
{
    partial class FrmCadUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.cBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.gbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 46);
            this.label1.TabIndex = 95;
            this.label1.Text = "Cadastro de Usuario";
            // 
            // gbCadastro
            // 
            this.gbCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCadastro.BackColor = System.Drawing.Color.Transparent;
            this.gbCadastro.Controls.Add(this.cBoxTipoUsuario);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.txtSenha);
            this.gbCadastro.Controls.Add(this.txtLogin);
            this.gbCadastro.Controls.Add(this.lblNome);
            this.gbCadastro.Controls.Add(this.lblSenha);
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCadastro.Location = new System.Drawing.Point(30, 87);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbCadastro.Size = new System.Drawing.Size(438, 165);
            this.gbCadastro.TabIndex = 0;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro de Usuario";
            // 
            // cBoxTipoUsuario
            // 
            this.cBoxTipoUsuario.FormattingEnabled = true;
            this.cBoxTipoUsuario.Items.AddRange(new object[] {
            "Jogador",
            "Mestre"});
            this.cBoxTipoUsuario.Location = new System.Drawing.Point(170, 101);
            this.cBoxTipoUsuario.Name = "cBoxTipoUsuario";
            this.cBoxTipoUsuario.Size = new System.Drawing.Size(178, 23);
            this.cBoxTipoUsuario.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(71, 104);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 47;
            this.label2.Tag = "&Password:";
            this.label2.Text = "Tipo de Usuario:";
            // 
            // txtSenha
            // 
            this.txtSenha.AcceptsReturn = true;
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSenha.Location = new System.Drawing.Point(141, 74);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSenha.Size = new System.Drawing.Size(207, 21);
            this.txtSenha.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.AcceptsReturn = true;
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogin.Location = new System.Drawing.Point(141, 47);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLogin.Size = new System.Drawing.Size(207, 21);
            this.txtLogin.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(71, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(64, 21);
            this.lblNome.TabIndex = 46;
            this.lblNome.Tag = "&User Name:";
            this.lblNome.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenha.Location = new System.Drawing.Point(71, 77);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSenha.Size = new System.Drawing.Size(64, 21);
            this.lblSenha.TabIndex = 45;
            this.lblSenha.Tag = "&Password:";
            this.lblSenha.Text = "Senha:";
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGravar.BackColor = System.Drawing.Color.Transparent;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.Location = new System.Drawing.Point(252, 271);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGravar.Size = new System.Drawing.Size(105, 42);
            this.btnGravar.TabIndex = 100;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(141, 271);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExcluir.Size = new System.Drawing.Size(105, 42);
            this.btnExcluir.TabIndex = 98;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(30, 271);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditar.Size = new System.Drawing.Size(105, 42);
            this.btnEditar.TabIndex = 96;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.Black;
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(363, 271);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSair.Size = new System.Drawing.Size(105, 42);
            this.BtnSair.TabIndex = 101;
            this.BtnSair.Text = "&Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 325);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadUsuario_Load);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbCadastro;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtLogin;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label lblSenha;
        internal System.Windows.Forms.Button btnGravar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cBoxTipoUsuario;
        public System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button BtnSair;
    }
}