namespace Gerenciador.Principais
{
    partial class FrmGerenciamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciamento));
            this.gpGerencia = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAtribuirUsuarioaFunc = new System.Windows.Forms.Button();
            this.BtnDesbloquearUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastroDeUsuario = new System.Windows.Forms.Button();
            this.btnCadastroDeRACA = new System.Windows.Forms.Button();
            this.BtnBuscaDeFuncionario = new System.Windows.Forms.Button();
            this.bntCadTipoContato = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btnAdicionarExcluirServico = new System.Windows.Forms.Button();
            this.btnCadastroDeFuncionario = new System.Windows.Forms.Button();
            this.txtSenhaCookie = new System.Windows.Forms.TextBox();
            this.txtUsuarioCookie = new System.Windows.Forms.TextBox();
            this.gpGerencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpGerencia
            // 
            this.gpGerencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpGerencia.BackColor = System.Drawing.Color.Transparent;
            this.gpGerencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpGerencia.Controls.Add(this.button1);
            this.gpGerencia.Controls.Add(this.button2);
            this.gpGerencia.Controls.Add(this.btnAtribuirUsuarioaFunc);
            this.gpGerencia.Controls.Add(this.BtnDesbloquearUsuario);
            this.gpGerencia.Controls.Add(this.label1);
            this.gpGerencia.Controls.Add(this.btnCadastroDeUsuario);
            this.gpGerencia.Controls.Add(this.btnCadastroDeRACA);
            this.gpGerencia.Controls.Add(this.BtnBuscaDeFuncionario);
            this.gpGerencia.Controls.Add(this.bntCadTipoContato);
            this.gpGerencia.Controls.Add(this.BtnSair);
            this.gpGerencia.Controls.Add(this.btnAdicionarExcluirServico);
            this.gpGerencia.Controls.Add(this.btnCadastroDeFuncionario);
            this.gpGerencia.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpGerencia.Location = new System.Drawing.Point(31, 49);
            this.gpGerencia.Name = "gpGerencia";
            this.gpGerencia.Size = new System.Drawing.Size(379, 511);
            this.gpGerencia.TabIndex = 115;
            this.gpGerencia.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(201, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 57);
            this.button1.TabIndex = 32;
            this.button1.Text = "Tornar Usuario Administrador";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(203, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 57);
            this.button2.TabIndex = 33;
            this.button2.Text = "Verificar Funcionarios excluidos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAtribuirUsuarioaFunc
            // 
            this.btnAtribuirUsuarioaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtribuirUsuarioaFunc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtribuirUsuarioaFunc.Location = new System.Drawing.Point(18, 271);
            this.btnAtribuirUsuarioaFunc.Name = "btnAtribuirUsuarioaFunc";
            this.btnAtribuirUsuarioaFunc.Size = new System.Drawing.Size(163, 57);
            this.btnAtribuirUsuarioaFunc.TabIndex = 31;
            this.btnAtribuirUsuarioaFunc.Text = "Atribuir Usuario a Funcionario";
            this.btnAtribuirUsuarioaFunc.UseVisualStyleBackColor = true;
            // 
            // BtnDesbloquearUsuario
            // 
            this.BtnDesbloquearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesbloquearUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDesbloquearUsuario.Location = new System.Drawing.Point(18, 345);
            this.BtnDesbloquearUsuario.Name = "BtnDesbloquearUsuario";
            this.BtnDesbloquearUsuario.Size = new System.Drawing.Size(163, 57);
            this.BtnDesbloquearUsuario.TabIndex = 31;
            this.BtnDesbloquearUsuario.Text = "Desbloquear Usuarios";
            this.BtnDesbloquearUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(94, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gerenciamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCadastroDeUsuario
            // 
            this.btnCadastroDeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastroDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroDeUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastroDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroDeUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroDeUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroDeUsuario.Image")));
            this.btnCadastroDeUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroDeUsuario.Location = new System.Drawing.Point(203, 198);
            this.btnCadastroDeUsuario.Name = "btnCadastroDeUsuario";
            this.btnCadastroDeUsuario.Size = new System.Drawing.Size(163, 57);
            this.btnCadastroDeUsuario.TabIndex = 29;
            this.btnCadastroDeUsuario.Text = "N/A";
            this.btnCadastroDeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroDeUsuario.UseVisualStyleBackColor = false;
            // 
            // btnCadastroDeRACA
            // 
            this.btnCadastroDeRACA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastroDeRACA.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroDeRACA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastroDeRACA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroDeRACA.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroDeRACA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastroDeRACA.Location = new System.Drawing.Point(18, 50);
            this.btnCadastroDeRACA.Name = "btnCadastroDeRACA";
            this.btnCadastroDeRACA.Size = new System.Drawing.Size(163, 57);
            this.btnCadastroDeRACA.TabIndex = 10;
            this.btnCadastroDeRACA.Text = "Cadastrar Cargos";
            this.btnCadastroDeRACA.UseVisualStyleBackColor = false;
            // 
            // BtnBuscaDeFuncionario
            // 
            this.BtnBuscaDeFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscaDeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscaDeFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscaDeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscaDeFuncionario.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscaDeFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscaDeFuncionario.Image")));
            this.BtnBuscaDeFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscaDeFuncionario.Location = new System.Drawing.Point(18, 198);
            this.BtnBuscaDeFuncionario.Name = "BtnBuscaDeFuncionario";
            this.BtnBuscaDeFuncionario.Size = new System.Drawing.Size(163, 57);
            this.BtnBuscaDeFuncionario.TabIndex = 28;
            this.BtnBuscaDeFuncionario.Text = "N/A";
            this.BtnBuscaDeFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscaDeFuncionario.UseVisualStyleBackColor = false;
            // 
            // bntCadTipoContato
            // 
            this.bntCadTipoContato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntCadTipoContato.BackColor = System.Drawing.Color.Transparent;
            this.bntCadTipoContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntCadTipoContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadTipoContato.ForeColor = System.Drawing.Color.Black;
            this.bntCadTipoContato.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntCadTipoContato.Location = new System.Drawing.Point(203, 50);
            this.bntCadTipoContato.Name = "bntCadTipoContato";
            this.bntCadTipoContato.Size = new System.Drawing.Size(163, 57);
            this.bntCadTipoContato.TabIndex = 9;
            this.bntCadTipoContato.Text = "Cadastrar Tipo Contato";
            this.bntCadTipoContato.UseVisualStyleBackColor = false;
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSair.BackColor = System.Drawing.Color.DimGray;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.Black;
            this.BtnSair.Location = new System.Drawing.Point(100, 421);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(171, 48);
            this.BtnSair.TabIndex = 27;
            this.BtnSair.Text = "&Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnAdicionarExcluirServico
            // 
            this.btnAdicionarExcluirServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionarExcluirServico.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarExcluirServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionarExcluirServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarExcluirServico.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarExcluirServico.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarExcluirServico.Image")));
            this.btnAdicionarExcluirServico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarExcluirServico.Location = new System.Drawing.Point(203, 123);
            this.btnAdicionarExcluirServico.Name = "btnAdicionarExcluirServico";
            this.btnAdicionarExcluirServico.Size = new System.Drawing.Size(163, 57);
            this.btnAdicionarExcluirServico.TabIndex = 7;
            this.btnAdicionarExcluirServico.Text = "N/A";
            this.btnAdicionarExcluirServico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarExcluirServico.UseVisualStyleBackColor = false;
            // 
            // btnCadastroDeFuncionario
            // 
            this.btnCadastroDeFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastroDeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroDeFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastroDeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroDeFuncionario.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroDeFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroDeFuncionario.Image")));
            this.btnCadastroDeFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroDeFuncionario.Location = new System.Drawing.Point(18, 123);
            this.btnCadastroDeFuncionario.Name = "btnCadastroDeFuncionario";
            this.btnCadastroDeFuncionario.Size = new System.Drawing.Size(163, 57);
            this.btnCadastroDeFuncionario.TabIndex = 6;
            this.btnCadastroDeFuncionario.Text = "N/A";
            this.btnCadastroDeFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroDeFuncionario.UseVisualStyleBackColor = false;
            // 
            // txtSenhaCookie
            // 
            this.txtSenhaCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenhaCookie.Location = new System.Drawing.Point(246, 23);
            this.txtSenhaCookie.MaxLength = 20;
            this.txtSenhaCookie.Name = "txtSenhaCookie";
            this.txtSenhaCookie.PasswordChar = '*';
            this.txtSenhaCookie.Size = new System.Drawing.Size(199, 20);
            this.txtSenhaCookie.TabIndex = 117;
            this.txtSenhaCookie.Text = "txtSenhaCookie";
            this.txtSenhaCookie.Visible = false;
            // 
            // txtUsuarioCookie
            // 
            this.txtUsuarioCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuarioCookie.Location = new System.Drawing.Point(39, 23);
            this.txtUsuarioCookie.MaxLength = 20;
            this.txtUsuarioCookie.Name = "txtUsuarioCookie";
            this.txtUsuarioCookie.Size = new System.Drawing.Size(199, 20);
            this.txtUsuarioCookie.TabIndex = 116;
            this.txtUsuarioCookie.Text = "txtUsuarioCookie";
            this.txtUsuarioCookie.Visible = false;
            // 
            // FrmGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 565);
            this.Controls.Add(this.gpGerencia);
            this.Controls.Add(this.txtSenhaCookie);
            this.Controls.Add(this.txtUsuarioCookie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGerenciamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpGerencia.ResumeLayout(false);
            this.gpGerencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox gpGerencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAtribuirUsuarioaFunc;
        private System.Windows.Forms.Button BtnDesbloquearUsuario;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnCadastroDeUsuario;
        internal System.Windows.Forms.Button btnCadastroDeRACA;
        internal System.Windows.Forms.Button BtnBuscaDeFuncionario;
        internal System.Windows.Forms.Button bntCadTipoContato;
        internal System.Windows.Forms.Button BtnSair;
        internal System.Windows.Forms.Button btnAdicionarExcluirServico;
        internal System.Windows.Forms.Button btnCadastroDeFuncionario;
        internal System.Windows.Forms.TextBox txtSenhaCookie;
        public System.Windows.Forms.TextBox txtUsuarioCookie;
    }
}