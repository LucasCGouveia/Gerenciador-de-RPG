namespace Gerenciador
{
    partial class FrmGerenciarMesa
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btn_AgendarHorario = new System.Windows.Forms.Button();
            this.gboxMenuPrincipal = new System.Windows.Forms.GroupBox();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnAdicionarJogador = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.LblMestre = new System.Windows.Forms.Label();
            this.LblCampanha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gboxMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(610, 59);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 24);
            this.lblUsuario.TabIndex = 33;
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(21, 65);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgv.Size = new System.Drawing.Size(765, 249);
            this.dgv.TabIndex = 31;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(292, 31);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditar.Size = new System.Drawing.Size(103, 28);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(633, 320);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(153, 91);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btn_AgendarHorario
            // 
            this.btn_AgendarHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AgendarHorario.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgendarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgendarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgendarHorario.ForeColor = System.Drawing.Color.Black;
            this.btn_AgendarHorario.Location = new System.Drawing.Point(24, 320);
            this.btn_AgendarHorario.Name = "btn_AgendarHorario";
            this.btn_AgendarHorario.Size = new System.Drawing.Size(153, 91);
            this.btn_AgendarHorario.TabIndex = 1;
            this.btn_AgendarHorario.Text = "&Adicionar Adversario";
            this.btn_AgendarHorario.UseVisualStyleBackColor = false;
            this.btn_AgendarHorario.Click += new System.EventHandler(this.btn_AgendarHorario_Click);
            // 
            // gboxMenuPrincipal
            // 
            this.gboxMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboxMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.gboxMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gboxMenuPrincipal.Controls.Add(this.BtnRemover);
            this.gboxMenuPrincipal.Controls.Add(this.BtnAdicionarJogador);
            this.gboxMenuPrincipal.Controls.Add(this.lblUsuario);
            this.gboxMenuPrincipal.Controls.Add(this.dgv);
            this.gboxMenuPrincipal.Controls.Add(this.Label1);
            this.gboxMenuPrincipal.Controls.Add(this.btnEditar);
            this.gboxMenuPrincipal.Controls.Add(this.btnSair);
            this.gboxMenuPrincipal.Controls.Add(this.btn_AgendarHorario);
            this.gboxMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxMenuPrincipal.ForeColor = System.Drawing.Color.Black;
            this.gboxMenuPrincipal.Location = new System.Drawing.Point(71, 24);
            this.gboxMenuPrincipal.Name = "gboxMenuPrincipal";
            this.gboxMenuPrincipal.Size = new System.Drawing.Size(804, 600);
            this.gboxMenuPrincipal.TabIndex = 8;
            this.gboxMenuPrincipal.TabStop = false;
            this.gboxMenuPrincipal.Text = "Gerenciador de Mesa de RPG";
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(683, 31);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(103, 28);
            this.BtnRemover.TabIndex = 43;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnAdicionarJogador
            // 
            this.BtnAdicionarJogador.Location = new System.Drawing.Point(183, 31);
            this.BtnAdicionarJogador.Name = "BtnAdicionarJogador";
            this.BtnAdicionarJogador.Size = new System.Drawing.Size(103, 28);
            this.BtnAdicionarJogador.TabIndex = 42;
            this.BtnAdicionarJogador.Text = "Adicionar";
            this.BtnAdicionarJogador.UseVisualStyleBackColor = true;
            this.BtnAdicionarJogador.Click += new System.EventHandler(this.BtnAdicionarJogador_Click);
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(27, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(150, 25);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Personagens";
            // 
            // LblMestre
            // 
            this.LblMestre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMestre.BackColor = System.Drawing.Color.Transparent;
            this.LblMestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblMestre.Location = new System.Drawing.Point(868, 9);
            this.LblMestre.Name = "LblMestre";
            this.LblMestre.Size = new System.Drawing.Size(66, 18);
            this.LblMestre.TabIndex = 43;
            this.LblMestre.Text = "MESTRE";
            // 
            // LblCampanha
            // 
            this.LblCampanha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCampanha.BackColor = System.Drawing.Color.Transparent;
            this.LblCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampanha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCampanha.Location = new System.Drawing.Point(789, 9);
            this.LblCampanha.Name = "LblCampanha";
            this.LblCampanha.Size = new System.Drawing.Size(73, 18);
            this.LblCampanha.TabIndex = 44;
            this.LblCampanha.Text = "Campanha";
            // 
            // FrmGerenciarMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 649);
            this.Controls.Add(this.LblCampanha);
            this.Controls.Add(this.LblMestre);
            this.Controls.Add(this.gboxMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmGerenciarMesa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGerenciarMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gboxMenuPrincipal.ResumeLayout(false);
            this.gboxMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label lblUsuario;
        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btn_AgendarHorario;
        internal System.Windows.Forms.GroupBox gboxMenuPrincipal;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button BtnAdicionarJogador;
        internal System.Windows.Forms.Label LblMestre;
        internal System.Windows.Forms.Label LblCampanha;
        private System.Windows.Forms.Button BtnRemover;
    }
}