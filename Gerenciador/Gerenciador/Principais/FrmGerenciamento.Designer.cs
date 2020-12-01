namespace Gerenciador
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
            this.button3 = new System.Windows.Forms.Button();
            this.BtnDesbloquearUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastroDeUsuario = new System.Windows.Forms.Button();
            this.btnCadRacas = new System.Windows.Forms.Button();
            this.BtnBuscaDeFuncionario = new System.Windows.Forms.Button();
            this.bntCadClasses = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btnAdicionarExcluirServico = new System.Windows.Forms.Button();
            this.btnCadastroDeFuncionario = new System.Windows.Forms.Button();
            this.LblMestre = new System.Windows.Forms.Label();
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
            this.gpGerencia.Controls.Add(this.button3);
            this.gpGerencia.Controls.Add(this.BtnDesbloquearUsuario);
            this.gpGerencia.Controls.Add(this.label1);
            this.gpGerencia.Controls.Add(this.btnCadastroDeUsuario);
            this.gpGerencia.Controls.Add(this.btnCadRacas);
            this.gpGerencia.Controls.Add(this.BtnBuscaDeFuncionario);
            this.gpGerencia.Controls.Add(this.bntCadClasses);
            this.gpGerencia.Controls.Add(this.BtnSair);
            this.gpGerencia.Controls.Add(this.btnAdicionarExcluirServico);
            this.gpGerencia.Controls.Add(this.btnCadastroDeFuncionario);
            this.gpGerencia.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpGerencia.Location = new System.Drawing.Point(31, 49);
            this.gpGerencia.Name = "gpGerencia";
            this.gpGerencia.Size = new System.Drawing.Size(379, 511);
            this.gpGerencia.TabIndex = 115;
            this.gpGerencia.TabStop = false;
            this.gpGerencia.Enter += new System.EventHandler(this.gpGerencia_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(203, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 57);
            this.button1.TabIndex = 33;
            this.button1.Text = "Verificar Personagens excluidos";
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
            this.button2.Text = "Verificar Jogadores excluidos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(18, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 57);
            this.button3.TabIndex = 31;
            this.button3.Text = "Verificar Jogadores";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnDesbloquearUsuario
            // 
            this.BtnDesbloquearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesbloquearUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDesbloquearUsuario.Location = new System.Drawing.Point(18, 274);
            this.BtnDesbloquearUsuario.Name = "BtnDesbloquearUsuario";
            this.BtnDesbloquearUsuario.Size = new System.Drawing.Size(163, 57);
            this.BtnDesbloquearUsuario.TabIndex = 31;
            this.BtnDesbloquearUsuario.Text = "Verificar Personagens";
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
            this.btnCadastroDeUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroDeUsuario.Location = new System.Drawing.Point(18, 198);
            this.btnCadastroDeUsuario.Name = "btnCadastroDeUsuario";
            this.btnCadastroDeUsuario.Size = new System.Drawing.Size(163, 57);
            this.btnCadastroDeUsuario.TabIndex = 29;
            this.btnCadastroDeUsuario.Text = "Verificar Usuario";
            this.btnCadastroDeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroDeUsuario.UseVisualStyleBackColor = false;
            this.btnCadastroDeUsuario.Click += new System.EventHandler(this.btnCadastroDeUsuario_Click);
            // 
            // btnCadRacas
            // 
            this.btnCadRacas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadRacas.BackColor = System.Drawing.Color.Transparent;
            this.btnCadRacas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadRacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadRacas.ForeColor = System.Drawing.Color.Black;
            this.btnCadRacas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadRacas.Location = new System.Drawing.Point(18, 50);
            this.btnCadRacas.Name = "btnCadRacas";
            this.btnCadRacas.Size = new System.Drawing.Size(163, 57);
            this.btnCadRacas.TabIndex = 10;
            this.btnCadRacas.Text = "Cadastrar Raças";
            this.btnCadRacas.UseVisualStyleBackColor = false;
            this.btnCadRacas.Click += new System.EventHandler(this.btnCadRacas_Click);
            // 
            // BtnBuscaDeFuncionario
            // 
            this.BtnBuscaDeFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscaDeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscaDeFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscaDeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscaDeFuncionario.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscaDeFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscaDeFuncionario.Location = new System.Drawing.Point(203, 198);
            this.BtnBuscaDeFuncionario.Name = "BtnBuscaDeFuncionario";
            this.BtnBuscaDeFuncionario.Size = new System.Drawing.Size(163, 57);
            this.BtnBuscaDeFuncionario.TabIndex = 28;
            this.BtnBuscaDeFuncionario.Text = "Verificar Usuario Excluidos";
            this.BtnBuscaDeFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscaDeFuncionario.UseVisualStyleBackColor = false;
            // 
            // bntCadClasses
            // 
            this.bntCadClasses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntCadClasses.BackColor = System.Drawing.Color.Transparent;
            this.bntCadClasses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntCadClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadClasses.ForeColor = System.Drawing.Color.Black;
            this.bntCadClasses.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntCadClasses.Location = new System.Drawing.Point(203, 50);
            this.bntCadClasses.Name = "bntCadClasses";
            this.bntCadClasses.Size = new System.Drawing.Size(163, 57);
            this.bntCadClasses.TabIndex = 9;
            this.bntCadClasses.Text = "Cadastrar Classes";
            this.bntCadClasses.UseVisualStyleBackColor = false;
            this.bntCadClasses.Click += new System.EventHandler(this.bntCadClasses_Click);
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
            // LblMestre
            // 
            this.LblMestre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblMestre.AutoSize = true;
            this.LblMestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblMestre.Location = new System.Drawing.Point(389, 9);
            this.LblMestre.Name = "LblMestre";
            this.LblMestre.Size = new System.Drawing.Size(65, 17);
            this.LblMestre.TabIndex = 34;
            this.LblMestre.Text = "MESTRE";
            this.LblMestre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 565);
            this.Controls.Add(this.LblMestre);
            this.Controls.Add(this.gpGerencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGerenciamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGerenciamento_Load);
            this.gpGerencia.ResumeLayout(false);
            this.gpGerencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox gpGerencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDesbloquearUsuario;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnCadastroDeUsuario;
        internal System.Windows.Forms.Button btnCadRacas;
        internal System.Windows.Forms.Button BtnBuscaDeFuncionario;
        internal System.Windows.Forms.Button bntCadClasses;
        internal System.Windows.Forms.Button BtnSair;
        internal System.Windows.Forms.Button btnAdicionarExcluirServico;
        internal System.Windows.Forms.Button btnCadastroDeFuncionario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label LblMestre;
    }
}