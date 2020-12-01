namespace Gerenciador
{
    partial class FrmCadJogador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDadosDoCadastro = new System.Windows.Forms.Label();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mtxtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.txtDadosPessoais = new System.Windows.Forms.Label();
            this.lblNomefunc = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.mtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblDadosDoCadastro);
            this.groupBox1.Controls.Add(this.lblCodFunc);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(39, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 161);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            // 
            // lblDadosDoCadastro
            // 
            this.lblDadosDoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDadosDoCadastro.AutoSize = true;
            this.lblDadosDoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosDoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDadosDoCadastro.ForeColor = System.Drawing.Color.Black;
            this.lblDadosDoCadastro.Location = new System.Drawing.Point(194, 16);
            this.lblDadosDoCadastro.Name = "lblDadosDoCadastro";
            this.lblDadosDoCadastro.Size = new System.Drawing.Size(153, 20);
            this.lblDadosDoCadastro.TabIndex = 109;
            this.lblDadosDoCadastro.Text = "Dados do Usuario";
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.BackColor = System.Drawing.Color.Transparent;
            this.lblCodFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCodFunc.ForeColor = System.Drawing.Color.Black;
            this.lblCodFunc.Location = new System.Drawing.Point(202, 47);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(121, 16);
            this.lblCodFunc.TabIndex = 111;
            this.lblCodFunc.Text = "Codigo do Usuario";
            // 
            // txtCod
            // 
            this.txtCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCod.Location = new System.Drawing.Point(198, 66);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(134, 22);
            this.txtCod.TabIndex = 0;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(111, 117);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(302, 22);
            this.txtUsuario.TabIndex = 114;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(233, 98);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 16);
            this.Label1.TabIndex = 115;
            this.Label1.Text = "Usuario:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(178, 427);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 52);
            this.btnLimpar.TabIndex = 112;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGravar.BackColor = System.Drawing.Color.Transparent;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(39, 427);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(133, 52);
            this.btnGravar.TabIndex = 111;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSair.Location = new System.Drawing.Point(436, 427);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 52);
            this.btnSair.TabIndex = 113;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.gbDadosPessoais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDadosPessoais.Controls.Add(this.mtxtDataNasc);
            this.gbDadosPessoais.Controls.Add(this.gbSexo);
            this.gbDadosPessoais.Controls.Add(this.txtDadosPessoais);
            this.gbDadosPessoais.Controls.Add(this.lblNomefunc);
            this.gbDadosPessoais.Controls.Add(this.lblCPF);
            this.gbDadosPessoais.Controls.Add(this.lblRG);
            this.gbDadosPessoais.Controls.Add(this.lblNasc);
            this.gbDadosPessoais.Controls.Add(this.mtxtRG);
            this.gbDadosPessoais.Controls.Add(this.mtxtCPF);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbDadosPessoais.Location = new System.Drawing.Point(39, 248);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(530, 159);
            this.gbDadosPessoais.TabIndex = 114;
            this.gbDadosPessoais.TabStop = false;
            // 
            // mtxtDataNasc
            // 
            this.mtxtDataNasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mtxtDataNasc.Location = new System.Drawing.Point(42, 119);
            this.mtxtDataNasc.Mask = "00/00/0000";
            this.mtxtDataNasc.Name = "mtxtDataNasc";
            this.mtxtDataNasc.Size = new System.Drawing.Size(108, 22);
            this.mtxtDataNasc.TabIndex = 1;
            this.mtxtDataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // gbSexo
            // 
            this.gbSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.ForeColor = System.Drawing.Color.Black;
            this.gbSexo.Location = new System.Drawing.Point(409, 101);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(96, 42);
            this.gbSexo.TabIndex = 0;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbMasculino.ForeColor = System.Drawing.Color.Black;
            this.rbMasculino.Location = new System.Drawing.Point(17, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(35, 17);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "M";
            this.rbMasculino.UseVisualStyleBackColor = false;
            // 
            // rbFeminino
            // 
            this.rbFeminino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.BackColor = System.Drawing.Color.Transparent;
            this.rbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbFeminino.ForeColor = System.Drawing.Color.Black;
            this.rbFeminino.Location = new System.Drawing.Point(64, 19);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(32, 17);
            this.rbFeminino.TabIndex = 0;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "F";
            this.rbFeminino.UseVisualStyleBackColor = false;
            // 
            // txtDadosPessoais
            // 
            this.txtDadosPessoais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDadosPessoais.AutoSize = true;
            this.txtDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.txtDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDadosPessoais.ForeColor = System.Drawing.Color.Black;
            this.txtDadosPessoais.Location = new System.Drawing.Point(196, 16);
            this.txtDadosPessoais.Name = "txtDadosPessoais";
            this.txtDadosPessoais.Size = new System.Drawing.Size(138, 20);
            this.txtDadosPessoais.TabIndex = 0;
            this.txtDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblNomefunc
            // 
            this.lblNomefunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomefunc.AutoSize = true;
            this.lblNomefunc.BackColor = System.Drawing.Color.Transparent;
            this.lblNomefunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNomefunc.ForeColor = System.Drawing.Color.Black;
            this.lblNomefunc.Location = new System.Drawing.Point(40, 43);
            this.lblNomefunc.Name = "lblNomefunc";
            this.lblNomefunc.Size = new System.Drawing.Size(48, 16);
            this.lblNomefunc.TabIndex = 0;
            this.lblNomefunc.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(274, 95);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 16);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF:";
            // 
            // lblRG
            // 
            this.lblRG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRG.AutoSize = true;
            this.lblRG.BackColor = System.Drawing.Color.Transparent;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblRG.ForeColor = System.Drawing.Color.Black;
            this.lblRG.Location = new System.Drawing.Point(161, 95);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(31, 16);
            this.lblRG.TabIndex = 0;
            this.lblRG.Text = "RG:";
            // 
            // lblNasc
            // 
            this.lblNasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNasc.AutoSize = true;
            this.lblNasc.BackColor = System.Drawing.Color.Transparent;
            this.lblNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNasc.ForeColor = System.Drawing.Color.Black;
            this.lblNasc.Location = new System.Drawing.Point(40, 95);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(83, 16);
            this.lblNasc.TabIndex = 0;
            this.lblNasc.Text = "Nascimento:";
            // 
            // mtxtRG
            // 
            this.mtxtRG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mtxtRG.Location = new System.Drawing.Point(156, 119);
            this.mtxtRG.Mask = "00.000.000-C";
            this.mtxtRG.Name = "mtxtRG";
            this.mtxtRG.Size = new System.Drawing.Size(112, 22);
            this.mtxtRG.TabIndex = 2;
            this.mtxtRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mtxtCPF.Location = new System.Drawing.Point(274, 117);
            this.mtxtCPF.Mask = "000.000.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(129, 22);
            this.mtxtCPF.TabIndex = 3;
            this.mtxtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(42, 66);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(462, 22);
            this.txtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 46);
            this.label2.TabIndex = 118;
            this.label2.Text = "Cadastro de Jogador";
            // 
            // FrmCadJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadJogador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadJogador1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadJogador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblDadosDoCadastro;
        public System.Windows.Forms.Label lblCodFunc;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.GroupBox gbDadosPessoais;
        public System.Windows.Forms.MaskedTextBox mtxtDataNasc;
        public System.Windows.Forms.GroupBox gbSexo;
        public System.Windows.Forms.RadioButton rbMasculino;
        public System.Windows.Forms.RadioButton rbFeminino;
        public System.Windows.Forms.Label txtDadosPessoais;
        public System.Windows.Forms.Label lblNomefunc;
        public System.Windows.Forms.Label lblCPF;
        public System.Windows.Forms.Label lblRG;
        public System.Windows.Forms.Label lblNasc;
        public System.Windows.Forms.MaskedTextBox mtxtRG;
        public System.Windows.Forms.MaskedTextBox mtxtCPF;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label2;
    }
}