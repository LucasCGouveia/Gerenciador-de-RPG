namespace Gerenciador
{
    partial class FrmTrocaTelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrocaTelas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSim = new System.Windows.Forms.Button();
            this.BtnDeslogar = new System.Windows.Forms.Button();
            this.BtnNao = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblDeOndeVim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(378, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 23);
            this.label1.TabIndex = 118;
            this.label1.Text = "Você Realmente Deseja Sair do Sistema?";
            // 
            // BtnSim
            // 
            this.BtnSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSim.Location = new System.Drawing.Point(22, 139);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(103, 61);
            this.BtnSim.TabIndex = 115;
            this.BtnSim.Text = "Sim";
            this.BtnSim.UseVisualStyleBackColor = true;
            this.BtnSim.Click += new System.EventHandler(this.BtnSim_Click_1);
            // 
            // BtnDeslogar
            // 
            this.BtnDeslogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDeslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeslogar.Location = new System.Drawing.Point(269, 139);
            this.BtnDeslogar.Name = "BtnDeslogar";
            this.BtnDeslogar.Size = new System.Drawing.Size(103, 61);
            this.BtnDeslogar.TabIndex = 116;
            this.BtnDeslogar.Text = "Deslogar-se";
            this.BtnDeslogar.UseVisualStyleBackColor = true;
            this.BtnDeslogar.Click += new System.EventHandler(this.BtnDeslogar_Click_1);
            // 
            // BtnNao
            // 
            this.BtnNao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNao.Location = new System.Drawing.Point(143, 139);
            this.BtnNao.Name = "BtnNao";
            this.BtnNao.Size = new System.Drawing.Size(103, 61);
            this.BtnNao.TabIndex = 117;
            this.BtnNao.Text = "Não";
            this.BtnNao.UseVisualStyleBackColor = true;
            this.BtnNao.Click += new System.EventHandler(this.BtnNao_Click);
            // 
            // LblUser
            // 
            this.LblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.Transparent;
            this.LblUser.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblUser.Location = new System.Drawing.Point(520, 9);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(96, 23);
            this.LblUser.TabIndex = 120;
            this.LblUser.Text = "USUARIO";
            this.LblUser.Visible = false;
            // 
            // LblDeOndeVim
            // 
            this.LblDeOndeVim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDeOndeVim.AutoSize = true;
            this.LblDeOndeVim.BackColor = System.Drawing.Color.Transparent;
            this.LblDeOndeVim.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeOndeVim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblDeOndeVim.Location = new System.Drawing.Point(482, 39);
            this.LblDeOndeVim.Name = "LblDeOndeVim";
            this.LblDeOndeVim.Size = new System.Drawing.Size(134, 23);
            this.LblDeOndeVim.TabIndex = 121;
            this.LblDeOndeVim.Text = "DE ONDE VIM";
            this.LblDeOndeVim.Visible = false;
            // 
            // FrmTrocaTelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 257);
            this.Controls.Add(this.LblDeOndeVim);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSim);
            this.Controls.Add(this.BtnDeslogar);
            this.Controls.Add(this.BtnNao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTrocaTelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrocaTelas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTrocaTelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.Button BtnDeslogar;
        private System.Windows.Forms.Button BtnNao;
        public System.Windows.Forms.Label LblUser;
        public System.Windows.Forms.Label LblDeOndeVim;
    }
}