namespace Gerenciador
{
    partial class FrmBuscaPersonagem
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbResultadoDaPesquisa = new System.Windows.Forms.GroupBox();
            this.lblResultadoDaPesquisa = new System.Windows.Forms.Label();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblPsquisaRapida = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.BtnAtivar = new System.Windows.Forms.Button();
            this.lblDadosDoCadastro = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.LblCampanha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbResultadoDaPesquisa.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv.Location = new System.Drawing.Point(21, 33);
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
            this.dgv.Size = new System.Drawing.Size(679, 343);
            this.dgv.TabIndex = 3;
            // 
            // gbResultadoDaPesquisa
            // 
            this.gbResultadoDaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbResultadoDaPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbResultadoDaPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbResultadoDaPesquisa.Controls.Add(this.dgv);
            this.gbResultadoDaPesquisa.Controls.Add(this.lblResultadoDaPesquisa);
            this.gbResultadoDaPesquisa.Location = new System.Drawing.Point(33, 160);
            this.gbResultadoDaPesquisa.Name = "gbResultadoDaPesquisa";
            this.gbResultadoDaPesquisa.Size = new System.Drawing.Size(718, 394);
            this.gbResultadoDaPesquisa.TabIndex = 141;
            this.gbResultadoDaPesquisa.TabStop = false;
            // 
            // lblResultadoDaPesquisa
            // 
            this.lblResultadoDaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultadoDaPesquisa.AutoSize = true;
            this.lblResultadoDaPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoDaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDaPesquisa.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoDaPesquisa.Location = new System.Drawing.Point(309, 15);
            this.lblResultadoDaPesquisa.Name = "lblResultadoDaPesquisa";
            this.lblResultadoDaPesquisa.Size = new System.Drawing.Size(155, 15);
            this.lblResultadoDaPesquisa.TabIndex = 0;
            this.lblResultadoDaPesquisa.Text = "Resultado da Pesquisa";
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbPesquisa.Controls.Add(this.btnPesquisar);
            this.gbPesquisa.Controls.Add(this.lblPsquisaRapida);
            this.gbPesquisa.Controls.Add(this.txtPesquisa);
            this.gbPesquisa.Location = new System.Drawing.Point(33, 88);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(718, 66);
            this.gbPesquisa.TabIndex = 140;
            this.gbPesquisa.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(591, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 44);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // lblPsquisaRapida
            // 
            this.lblPsquisaRapida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPsquisaRapida.AutoSize = true;
            this.lblPsquisaRapida.BackColor = System.Drawing.Color.Transparent;
            this.lblPsquisaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsquisaRapida.ForeColor = System.Drawing.Color.Black;
            this.lblPsquisaRapida.Location = new System.Drawing.Point(143, 16);
            this.lblPsquisaRapida.Name = "lblPsquisaRapida";
            this.lblPsquisaRapida.Size = new System.Drawing.Size(71, 15);
            this.lblPsquisaRapida.TabIndex = 1;
            this.lblPsquisaRapida.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(146, 35);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(394, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // LblUser
            // 
            this.LblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.Transparent;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.Black;
            this.LblUser.Location = new System.Drawing.Point(702, 14);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(68, 15);
            this.LblUser.TabIndex = 139;
            this.LblUser.Text = "USUARIO";
            this.LblUser.Visible = false;
            // 
            // BtnAtivar
            // 
            this.BtnAtivar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAtivar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAtivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAtivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtivar.ForeColor = System.Drawing.Color.Black;
            this.BtnAtivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtivar.Location = new System.Drawing.Point(33, 570);
            this.BtnAtivar.Name = "BtnAtivar";
            this.BtnAtivar.Size = new System.Drawing.Size(171, 47);
            this.BtnAtivar.TabIndex = 146;
            this.BtnAtivar.Text = "&Adicionar";
            this.BtnAtivar.UseVisualStyleBackColor = false;
            this.BtnAtivar.Click += new System.EventHandler(this.BtnAtivar_Click);
            // 
            // lblDadosDoCadastro
            // 
            this.lblDadosDoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDadosDoCadastro.AutoSize = true;
            this.lblDadosDoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosDoCadastro.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDoCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDadosDoCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDadosDoCadastro.Location = new System.Drawing.Point(195, 25);
            this.lblDadosDoCadastro.Name = "lblDadosDoCadastro";
            this.lblDadosDoCadastro.Size = new System.Drawing.Size(373, 46);
            this.lblDadosDoCadastro.TabIndex = 143;
            this.lblDadosDoCadastro.Text = "Busca de Personganes";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(580, 570);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 47);
            this.btnSair.TabIndex = 142;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // LblCampanha
            // 
            this.LblCampanha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCampanha.AutoSize = true;
            this.LblCampanha.BackColor = System.Drawing.Color.Transparent;
            this.LblCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampanha.ForeColor = System.Drawing.Color.Black;
            this.LblCampanha.Location = new System.Drawing.Point(689, 39);
            this.LblCampanha.Name = "LblCampanha";
            this.LblCampanha.Size = new System.Drawing.Size(81, 15);
            this.LblCampanha.TabIndex = 147;
            this.LblCampanha.Text = "CAMPANHA";
            // 
            // FrmBuscaPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 630);
            this.Controls.Add(this.LblCampanha);
            this.Controls.Add(this.gbResultadoDaPesquisa);
            this.Controls.Add(this.gbPesquisa);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.BtnAtivar);
            this.Controls.Add(this.lblDadosDoCadastro);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscaPersonagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscaPersonagemCampanha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBuscaPersonagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbResultadoDaPesquisa.ResumeLayout(false);
            this.gbResultadoDaPesquisa.PerformLayout();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.GroupBox gbResultadoDaPesquisa;
        internal System.Windows.Forms.Label lblResultadoDaPesquisa;
        internal System.Windows.Forms.GroupBox gbPesquisa;
        internal System.Windows.Forms.Button btnPesquisar;
        internal System.Windows.Forms.Label lblPsquisaRapida;
        internal System.Windows.Forms.TextBox txtPesquisa;
        internal System.Windows.Forms.Label LblUser;
        internal System.Windows.Forms.Button BtnAtivar;
        internal System.Windows.Forms.Label lblDadosDoCadastro;
        internal System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Label LblCampanha;
    }
}