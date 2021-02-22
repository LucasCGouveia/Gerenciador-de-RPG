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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConcluirMissao = new System.Windows.Forms.Button();
            this.BtnAddMissao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMissoes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEditarMissao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUltimoResultado = new System.Windows.Forms.TextBox();
            this.txtResultadoRolagem = new System.Windows.Forms.TextBox();
            this.BtnD100 = new System.Windows.Forms.Button();
            this.BtnD20 = new System.Windows.Forms.Button();
            this.BtnD24 = new System.Windows.Forms.Button();
            this.BtnD30 = new System.Windows.Forms.Button();
            this.BtnD60 = new System.Windows.Forms.Button();
            this.BtnD12 = new System.Windows.Forms.Button();
            this.BtnD6 = new System.Windows.Forms.Button();
            this.BtnD8 = new System.Windows.Forms.Button();
            this.BtnD10 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnD4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxPersonagem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gboxMenuPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissoes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(728, 45);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 24);
            this.lblUsuario.TabIndex = 33;
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 51);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowHeadersWidth = 70;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowTemplate.Height = 32;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1037, 231);
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
            this.btnEditar.Location = new System.Drawing.Point(271, 17);
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
            this.btnSair.Location = new System.Drawing.Point(784, 647);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(153, 47);
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
            this.btn_AgendarHorario.Location = new System.Drawing.Point(380, 17);
            this.btn_AgendarHorario.Name = "btn_AgendarHorario";
            this.btn_AgendarHorario.Size = new System.Drawing.Size(182, 28);
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
            this.gboxMenuPrincipal.Controls.Add(this.btn_AgendarHorario);
            this.gboxMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxMenuPrincipal.ForeColor = System.Drawing.Color.Black;
            this.gboxMenuPrincipal.Location = new System.Drawing.Point(12, 35);
            this.gboxMenuPrincipal.Name = "gboxMenuPrincipal";
            this.gboxMenuPrincipal.Size = new System.Drawing.Size(1049, 300);
            this.gboxMenuPrincipal.TabIndex = 8;
            this.gboxMenuPrincipal.TabStop = false;
            // 
            // BtnRemover
            // 
            this.BtnRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRemover.Location = new System.Drawing.Point(940, 17);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(103, 28);
            this.BtnRemover.TabIndex = 43;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnAdicionarJogador
            // 
            this.BtnAdicionarJogador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAdicionarJogador.Location = new System.Drawing.Point(162, 17);
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
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(6, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(133, 24);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Personagens";
            // 
            // LblMestre
            // 
            this.LblMestre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMestre.BackColor = System.Drawing.Color.Transparent;
            this.LblMestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblMestre.Location = new System.Drawing.Point(874, 20);
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
            this.LblCampanha.Location = new System.Drawing.Point(795, 20);
            this.LblCampanha.Name = "LblCampanha";
            this.LblCampanha.Size = new System.Drawing.Size(73, 18);
            this.LblCampanha.TabIndex = 44;
            this.LblCampanha.Text = "Campanha";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(349, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Gerenciador de Mesa de RPG";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.BtnConcluirMissao);
            this.groupBox1.Controls.Add(this.BtnAddMissao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvMissoes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnEditarMissao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 300);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // BtnConcluirMissao
            // 
            this.BtnConcluirMissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConcluirMissao.Location = new System.Drawing.Point(940, 16);
            this.BtnConcluirMissao.Name = "BtnConcluirMissao";
            this.BtnConcluirMissao.Size = new System.Drawing.Size(103, 28);
            this.BtnConcluirMissao.TabIndex = 43;
            this.BtnConcluirMissao.Text = "Concluir";
            this.BtnConcluirMissao.UseVisualStyleBackColor = true;
            this.BtnConcluirMissao.Click += new System.EventHandler(this.BtnConcluirMissao_Click);
            // 
            // BtnAddMissao
            // 
            this.BtnAddMissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddMissao.Location = new System.Drawing.Point(162, 13);
            this.BtnAddMissao.Name = "BtnAddMissao";
            this.BtnAddMissao.Size = new System.Drawing.Size(103, 28);
            this.BtnAddMissao.TabIndex = 42;
            this.BtnAddMissao.Text = "Adicionar";
            this.BtnAddMissao.UseVisualStyleBackColor = true;
            this.BtnAddMissao.Click += new System.EventHandler(this.BtnAddMissao_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 33;
            // 
            // dgvMissoes
            // 
            this.dgvMissoes.AllowUserToOrderColumns = true;
            this.dgvMissoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMissoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMissoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMissoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissoes.Location = new System.Drawing.Point(6, 51);
            this.dgvMissoes.MultiSelect = false;
            this.dgvMissoes.Name = "dgvMissoes";
            this.dgvMissoes.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMissoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMissoes.RowHeadersWidth = 70;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMissoes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMissoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMissoes.Size = new System.Drawing.Size(1037, 231);
            this.dgvMissoes.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Missões";
            // 
            // BtnEditarMissao
            // 
            this.BtnEditarMissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditarMissao.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditarMissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditarMissao.Enabled = false;
            this.BtnEditarMissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarMissao.ForeColor = System.Drawing.Color.Black;
            this.BtnEditarMissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarMissao.Location = new System.Drawing.Point(271, 13);
            this.BtnEditarMissao.Name = "BtnEditarMissao";
            this.BtnEditarMissao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnEditarMissao.Size = new System.Drawing.Size(103, 28);
            this.BtnEditarMissao.TabIndex = 24;
            this.BtnEditarMissao.Text = "&Editar";
            this.BtnEditarMissao.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.txtUltimoResultado);
            this.groupBox2.Controls.Add(this.txtResultadoRolagem);
            this.groupBox2.Controls.Add(this.BtnD100);
            this.groupBox2.Controls.Add(this.BtnD20);
            this.groupBox2.Controls.Add(this.BtnD24);
            this.groupBox2.Controls.Add(this.BtnD30);
            this.groupBox2.Controls.Add(this.BtnD60);
            this.groupBox2.Controls.Add(this.BtnD12);
            this.groupBox2.Controls.Add(this.BtnD6);
            this.groupBox2.Controls.Add(this.BtnD8);
            this.groupBox2.Controls.Add(this.BtnD10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnD4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cBoxPersonagem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(1067, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 374);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rolagens";
            // 
            // txtUltimoResultado
            // 
            this.txtUltimoResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUltimoResultado.Location = new System.Drawing.Point(11, 304);
            this.txtUltimoResultado.Name = "txtUltimoResultado";
            this.txtUltimoResultado.Size = new System.Drawing.Size(229, 26);
            this.txtUltimoResultado.TabIndex = 49;
            // 
            // txtResultadoRolagem
            // 
            this.txtResultadoRolagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResultadoRolagem.Location = new System.Drawing.Point(11, 242);
            this.txtResultadoRolagem.Name = "txtResultadoRolagem";
            this.txtResultadoRolagem.Size = new System.Drawing.Size(229, 26);
            this.txtResultadoRolagem.TabIndex = 49;
            // 
            // BtnD100
            // 
            this.BtnD100.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD100.Location = new System.Drawing.Point(127, 162);
            this.BtnD100.Name = "BtnD100";
            this.BtnD100.Size = new System.Drawing.Size(113, 28);
            this.BtnD100.TabIndex = 45;
            this.BtnD100.Text = "D100";
            this.BtnD100.UseVisualStyleBackColor = true;
            this.BtnD100.Click += new System.EventHandler(this.BtnD100_Click);
            // 
            // BtnD20
            // 
            this.BtnD20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD20.Location = new System.Drawing.Point(68, 128);
            this.BtnD20.Name = "BtnD20";
            this.BtnD20.Size = new System.Drawing.Size(53, 28);
            this.BtnD20.TabIndex = 45;
            this.BtnD20.Text = "D20";
            this.BtnD20.UseVisualStyleBackColor = true;
            this.BtnD20.Click += new System.EventHandler(this.BtnD20_Click);
            // 
            // BtnD24
            // 
            this.BtnD24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD24.Location = new System.Drawing.Point(127, 128);
            this.BtnD24.Name = "BtnD24";
            this.BtnD24.Size = new System.Drawing.Size(53, 28);
            this.BtnD24.TabIndex = 46;
            this.BtnD24.Text = "D24";
            this.BtnD24.UseVisualStyleBackColor = true;
            this.BtnD24.Click += new System.EventHandler(this.BtnD24_Click);
            // 
            // BtnD30
            // 
            this.BtnD30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD30.Location = new System.Drawing.Point(187, 128);
            this.BtnD30.Name = "BtnD30";
            this.BtnD30.Size = new System.Drawing.Size(53, 28);
            this.BtnD30.TabIndex = 47;
            this.BtnD30.Text = "D30";
            this.BtnD30.UseVisualStyleBackColor = true;
            this.BtnD30.Click += new System.EventHandler(this.BtnD30_Click);
            // 
            // BtnD60
            // 
            this.BtnD60.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD60.Location = new System.Drawing.Point(11, 162);
            this.BtnD60.Name = "BtnD60";
            this.BtnD60.Size = new System.Drawing.Size(110, 28);
            this.BtnD60.TabIndex = 48;
            this.BtnD60.Text = "D60";
            this.BtnD60.UseVisualStyleBackColor = true;
            this.BtnD60.Click += new System.EventHandler(this.BtnD60_Click);
            // 
            // BtnD12
            // 
            this.BtnD12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD12.Location = new System.Drawing.Point(9, 128);
            this.BtnD12.Name = "BtnD12";
            this.BtnD12.Size = new System.Drawing.Size(53, 28);
            this.BtnD12.TabIndex = 48;
            this.BtnD12.Text = "D12";
            this.BtnD12.UseVisualStyleBackColor = true;
            this.BtnD12.Click += new System.EventHandler(this.BtnD12_Click);
            // 
            // BtnD6
            // 
            this.BtnD6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD6.Location = new System.Drawing.Point(70, 88);
            this.BtnD6.Name = "BtnD6";
            this.BtnD6.Size = new System.Drawing.Size(53, 28);
            this.BtnD6.TabIndex = 44;
            this.BtnD6.Text = "D6";
            this.BtnD6.UseVisualStyleBackColor = true;
            this.BtnD6.Click += new System.EventHandler(this.BtnD6_Click);
            // 
            // BtnD8
            // 
            this.BtnD8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD8.Location = new System.Drawing.Point(129, 88);
            this.BtnD8.Name = "BtnD8";
            this.BtnD8.Size = new System.Drawing.Size(53, 28);
            this.BtnD8.TabIndex = 44;
            this.BtnD8.Text = "D8";
            this.BtnD8.UseVisualStyleBackColor = true;
            this.BtnD8.Click += new System.EventHandler(this.BtnD8_Click);
            // 
            // BtnD10
            // 
            this.BtnD10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD10.Location = new System.Drawing.Point(189, 88);
            this.BtnD10.Name = "BtnD10";
            this.BtnD10.Size = new System.Drawing.Size(53, 28);
            this.BtnD10.TabIndex = 44;
            this.BtnD10.Text = "D10";
            this.BtnD10.UseVisualStyleBackColor = true;
            this.BtnD10.Click += new System.EventHandler(this.BtnD10_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 24);
            this.label8.TabIndex = 44;
            this.label8.Text = "Ultimo Resultado";
            // 
            // BtnD4
            // 
            this.BtnD4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD4.Location = new System.Drawing.Point(11, 88);
            this.BtnD4.Name = "BtnD4";
            this.BtnD4.Size = new System.Drawing.Size(53, 28);
            this.BtnD4.TabIndex = 44;
            this.BtnD4.Text = "D4";
            this.BtnD4.UseVisualStyleBackColor = true;
            this.BtnD4.Click += new System.EventHandler(this.BtnD4_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Personagens";
            // 
            // cBoxPersonagem
            // 
            this.cBoxPersonagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxPersonagem.FormattingEnabled = true;
            this.cBoxPersonagem.Items.AddRange(new object[] {
            "Atila (Sigfried)",
            "Luis (Doyakin)",
            "Max (Arthur)",
            "Rodrigo (PapaLegulas)",
            "Mestre"});
            this.cBoxPersonagem.Location = new System.Drawing.Point(11, 54);
            this.cBoxPersonagem.Name = "cBoxPersonagem";
            this.cBoxPersonagem.Size = new System.Drawing.Size(231, 28);
            this.cBoxPersonagem.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 33;
            // 
            // FrmGerenciarMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 733);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblCampanha);
            this.Controls.Add(this.LblMestre);
            this.Controls.Add(this.gboxMenuPrincipal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmGerenciarMesa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGerenciarMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gboxMenuPrincipal.ResumeLayout(false);
            this.gboxMenuPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissoes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConcluirMissao;
        private System.Windows.Forms.Button BtnAddMissao;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DataGridView dgvMissoes;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button BtnEditarMissao;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUltimoResultado;
        private System.Windows.Forms.TextBox txtResultadoRolagem;
        private System.Windows.Forms.Button BtnD20;
        private System.Windows.Forms.Button BtnD24;
        private System.Windows.Forms.Button BtnD30;
        private System.Windows.Forms.Button BtnD12;
        private System.Windows.Forms.Button BtnD6;
        private System.Windows.Forms.Button BtnD8;
        private System.Windows.Forms.Button BtnD10;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnD4;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxPersonagem;
        private System.Windows.Forms.Button BtnD100;
        private System.Windows.Forms.Button BtnD60;
    }
}