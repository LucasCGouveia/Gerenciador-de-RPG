namespace Gerenciador
{
    partial class FrmAddAtributos
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.cBoxRaca = new System.Windows.Forms.ComboBox();
            this.cBoxAlinhamento = new System.Windows.Forms.ComboBox();
            this.cBoxClasse = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblPersonagem = new System.Windows.Forms.Label();
            this.gbResultadoDaPesquisa = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSAB = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCON = new System.Windows.Forms.TextBox();
            this.txtCAR = new System.Windows.Forms.TextBox();
            this.txtJades = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtINT = new System.Windows.Forms.TextBox();
            this.txtFOR = new System.Windows.Forms.TextBox();
            this.txtDES = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtIniciativa = new System.Windows.Forms.TextBox();
            this.txtExperiencia = new System.Windows.Forms.TextBox();
            this.txtClasseArmadura = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPontosAtaque = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPontosVidaAtuais = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPontosVida = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.dgvArmas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPericias = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSkills = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.BtnSkills = new System.Windows.Forms.Button();
            this.BtnArmas = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnPericias = new System.Windows.Forms.Button();
            this.LblCampanha = new System.Windows.Forms.Label();
            this.LblAtributo = new System.Windows.Forms.Label();
            this.gbResultadoDaPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPericias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(1276, 9);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(40, 13);
            this.LblCodigo.TabIndex = 168;
            this.LblCodigo.Text = "Codigo";
            this.LblCodigo.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(1114, 595);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(215, 72);
            this.btnSair.TabIndex = 164;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cBoxRaca
            // 
            this.cBoxRaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxRaca.Enabled = false;
            this.cBoxRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cBoxRaca.FormattingEnabled = true;
            this.cBoxRaca.Location = new System.Drawing.Point(232, 49);
            this.cBoxRaca.Name = "cBoxRaca";
            this.cBoxRaca.Size = new System.Drawing.Size(215, 26);
            this.cBoxRaca.TabIndex = 1;
            // 
            // cBoxAlinhamento
            // 
            this.cBoxAlinhamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxAlinhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cBoxAlinhamento.FormattingEnabled = true;
            this.cBoxAlinhamento.Items.AddRange(new object[] {
            "BOM - LEAL",
            "BOM - CAOTICO",
            "BOM - NEUTRO",
            "MAL - LEAL",
            "MAL - CAOTICO",
            "MAL - NEUTRO",
            "NEUTRO - LEAL",
            "NEUTRO - CAOTICO",
            "NEUTRO"});
            this.cBoxAlinhamento.Location = new System.Drawing.Point(674, 49);
            this.cBoxAlinhamento.Name = "cBoxAlinhamento";
            this.cBoxAlinhamento.Size = new System.Drawing.Size(215, 26);
            this.cBoxAlinhamento.TabIndex = 3;
            // 
            // cBoxClasse
            // 
            this.cBoxClasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxClasse.Enabled = false;
            this.cBoxClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cBoxClasse.FormattingEnabled = true;
            this.cBoxClasse.Location = new System.Drawing.Point(453, 49);
            this.cBoxClasse.Name = "cBoxClasse";
            this.cBoxClasse.Size = new System.Drawing.Size(215, 26);
            this.cBoxClasse.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNome.Location = new System.Drawing.Point(11, 49);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 24);
            this.txtNome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(675, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alinhamento:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(674, 190);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(215, 47);
            this.btnAtualizar.TabIndex = 162;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblPersonagem
            // 
            this.lblPersonagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonagem.AutoSize = true;
            this.lblPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonagem.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPersonagem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPersonagem.Location = new System.Drawing.Point(562, 36);
            this.lblPersonagem.Name = "lblPersonagem";
            this.lblPersonagem.Size = new System.Drawing.Size(220, 46);
            this.lblPersonagem.TabIndex = 166;
            this.lblPersonagem.Text = "Personagens";
            // 
            // gbResultadoDaPesquisa
            // 
            this.gbResultadoDaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbResultadoDaPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbResultadoDaPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbResultadoDaPesquisa.Controls.Add(this.cBoxRaca);
            this.gbResultadoDaPesquisa.Controls.Add(this.label11);
            this.gbResultadoDaPesquisa.Controls.Add(this.btnAtualizar);
            this.gbResultadoDaPesquisa.Controls.Add(this.cBoxAlinhamento);
            this.gbResultadoDaPesquisa.Controls.Add(this.label26);
            this.gbResultadoDaPesquisa.Controls.Add(this.label1);
            this.gbResultadoDaPesquisa.Controls.Add(this.label25);
            this.gbResultadoDaPesquisa.Controls.Add(this.cBoxClasse);
            this.gbResultadoDaPesquisa.Controls.Add(this.label5);
            this.gbResultadoDaPesquisa.Controls.Add(this.label24);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtSAB);
            this.gbResultadoDaPesquisa.Controls.Add(this.label23);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtCON);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtCAR);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtJades);
            this.gbResultadoDaPesquisa.Controls.Add(this.label13);
            this.gbResultadoDaPesquisa.Controls.Add(this.label14);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtINT);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtFOR);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtDES);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtNivel);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtIniciativa);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtExperiencia);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtNome);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtClasseArmadura);
            this.gbResultadoDaPesquisa.Controls.Add(this.label15);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtPontosAtaque);
            this.gbResultadoDaPesquisa.Controls.Add(this.label18);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtPontosVidaAtuais);
            this.gbResultadoDaPesquisa.Controls.Add(this.label22);
            this.gbResultadoDaPesquisa.Controls.Add(this.txtPontosVida);
            this.gbResultadoDaPesquisa.Controls.Add(this.label16);
            this.gbResultadoDaPesquisa.Controls.Add(this.label17);
            this.gbResultadoDaPesquisa.Controls.Add(this.label19);
            this.gbResultadoDaPesquisa.Controls.Add(this.label21);
            this.gbResultadoDaPesquisa.Controls.Add(this.label10);
            this.gbResultadoDaPesquisa.Controls.Add(this.label20);
            this.gbResultadoDaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultadoDaPesquisa.Location = new System.Drawing.Point(12, 85);
            this.gbResultadoDaPesquisa.Name = "gbResultadoDaPesquisa";
            this.gbResultadoDaPesquisa.Size = new System.Drawing.Size(897, 255);
            this.gbResultadoDaPesquisa.TabIndex = 165;
            this.gbResultadoDaPesquisa.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(450, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Classe:";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(671, 133);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 16);
            this.label26.TabIndex = 18;
            this.label26.Text = "Nivel:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Iniciativa:";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(450, 133);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 16);
            this.label25.TabIndex = 18;
            this.label25.Text = "Experiencia:";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(448, 182);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 16);
            this.label24.TabIndex = 11;
            this.label24.Text = "SABEDORIA:";
            // 
            // txtSAB
            // 
            this.txtSAB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSAB.Location = new System.Drawing.Point(451, 201);
            this.txtSAB.MaxLength = 50;
            this.txtSAB.Name = "txtSAB";
            this.txtSAB.Size = new System.Drawing.Size(104, 24);
            this.txtSAB.TabIndex = 30;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(228, 182);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 16);
            this.label23.TabIndex = 11;
            this.label23.Text = "CONSTITUIÇÃO:";
            // 
            // txtCON
            // 
            this.txtCON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCON.Location = new System.Drawing.Point(231, 201);
            this.txtCON.MaxLength = 50;
            this.txtCON.Name = "txtCON";
            this.txtCON.Size = new System.Drawing.Size(104, 24);
            this.txtCON.TabIndex = 30;
            // 
            // txtCAR
            // 
            this.txtCAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCAR.Location = new System.Drawing.Point(561, 201);
            this.txtCAR.MaxLength = 50;
            this.txtCAR.Name = "txtCAR";
            this.txtCAR.Size = new System.Drawing.Size(104, 24);
            this.txtCAR.TabIndex = 31;
            // 
            // txtJades
            // 
            this.txtJades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtJades.Location = new System.Drawing.Point(232, 152);
            this.txtJades.MaxLength = 50;
            this.txtJades.Name = "txtJades";
            this.txtJades.Size = new System.Drawing.Size(215, 24);
            this.txtJades.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(8, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "FORÇA:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(229, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Jades(Dinheiro):";
            // 
            // txtINT
            // 
            this.txtINT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtINT.Location = new System.Drawing.Point(341, 201);
            this.txtINT.MaxLength = 50;
            this.txtINT.Name = "txtINT";
            this.txtINT.Size = new System.Drawing.Size(104, 24);
            this.txtINT.TabIndex = 31;
            // 
            // txtFOR
            // 
            this.txtFOR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFOR.Location = new System.Drawing.Point(11, 201);
            this.txtFOR.MaxLength = 50;
            this.txtFOR.Name = "txtFOR";
            this.txtFOR.Size = new System.Drawing.Size(104, 24);
            this.txtFOR.TabIndex = 30;
            // 
            // txtDES
            // 
            this.txtDES.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDES.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDES.Location = new System.Drawing.Point(122, 201);
            this.txtDES.MaxLength = 50;
            this.txtDES.Name = "txtDES";
            this.txtDES.Size = new System.Drawing.Size(104, 24);
            this.txtDES.TabIndex = 31;
            // 
            // txtNivel
            // 
            this.txtNivel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNivel.Location = new System.Drawing.Point(674, 152);
            this.txtNivel.MaxLength = 50;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(215, 24);
            this.txtNivel.TabIndex = 0;
            // 
            // txtIniciativa
            // 
            this.txtIniciativa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIniciativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIniciativa.Location = new System.Drawing.Point(11, 152);
            this.txtIniciativa.MaxLength = 50;
            this.txtIniciativa.Name = "txtIniciativa";
            this.txtIniciativa.Size = new System.Drawing.Size(215, 24);
            this.txtIniciativa.TabIndex = 0;
            // 
            // txtExperiencia
            // 
            this.txtExperiencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtExperiencia.Location = new System.Drawing.Point(453, 152);
            this.txtExperiencia.MaxLength = 50;
            this.txtExperiencia.Name = "txtExperiencia";
            this.txtExperiencia.Size = new System.Drawing.Size(215, 24);
            this.txtExperiencia.TabIndex = 0;
            // 
            // txtClasseArmadura
            // 
            this.txtClasseArmadura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClasseArmadura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClasseArmadura.Location = new System.Drawing.Point(11, 102);
            this.txtClasseArmadura.MaxLength = 50;
            this.txtClasseArmadura.Name = "txtClasseArmadura";
            this.txtClasseArmadura.Size = new System.Drawing.Size(215, 24);
            this.txtClasseArmadura.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(8, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Classe de Armadura:";
            // 
            // txtPontosAtaque
            // 
            this.txtPontosAtaque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPontosAtaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPontosAtaque.Location = new System.Drawing.Point(674, 102);
            this.txtPontosAtaque.MaxLength = 50;
            this.txtPontosAtaque.Name = "txtPontosAtaque";
            this.txtPontosAtaque.Size = new System.Drawing.Size(215, 24);
            this.txtPontosAtaque.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(558, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 16);
            this.label18.TabIndex = 14;
            this.label18.Text = "CARISMA:";
            // 
            // txtPontosVidaAtuais
            // 
            this.txtPontosVidaAtuais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPontosVidaAtuais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPontosVidaAtuais.Location = new System.Drawing.Point(453, 102);
            this.txtPontosVidaAtuais.MaxLength = 50;
            this.txtPontosVidaAtuais.Name = "txtPontosVidaAtuais";
            this.txtPontosVidaAtuais.Size = new System.Drawing.Size(215, 24);
            this.txtPontosVidaAtuais.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(338, 182);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 16);
            this.label22.TabIndex = 14;
            this.label22.Text = "INTELIGENCIA:";
            // 
            // txtPontosVida
            // 
            this.txtPontosVida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPontosVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPontosVida.Location = new System.Drawing.Point(232, 102);
            this.txtPontosVida.MaxLength = 50;
            this.txtPontosVida.Name = "txtPontosVida";
            this.txtPontosVida.Size = new System.Drawing.Size(215, 24);
            this.txtPontosVida.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(118, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "DESTREZA:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(229, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "Raça:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(8, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 16);
            this.label19.TabIndex = 17;
            this.label19.Text = "Nome:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(671, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(157, 16);
            this.label21.TabIndex = 19;
            this.label21.Text = "Pontos de Ataque/Magia";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(450, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Pontos de Vida(Atuais):";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(229, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 16);
            this.label20.TabIndex = 19;
            this.label20.Text = "Pontos de Vida:";
            // 
            // LblUser
            // 
            this.LblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(1214, 9);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(56, 13);
            this.LblUser.TabIndex = 169;
            this.LblUser.Text = "USUARIO";
            this.LblUser.Visible = false;
            // 
            // dgvArmas
            // 
            this.dgvArmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArmas.Location = new System.Drawing.Point(16, 25);
            this.dgvArmas.Name = "dgvArmas";
            this.dgvArmas.Size = new System.Drawing.Size(416, 194);
            this.dgvArmas.TabIndex = 170;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dgvPericias);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(915, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 243);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pericias / Historia ";
            // 
            // dgvPericias
            // 
            this.dgvPericias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPericias.Location = new System.Drawing.Point(6, 18);
            this.dgvPericias.Name = "dgvPericias";
            this.dgvPericias.Size = new System.Drawing.Size(195, 201);
            this.dgvPericias.TabIndex = 171;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(207, 18);
            this.txtDescricao.MaxLength = 20;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(193, 201);
            this.txtDescricao.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.dgvArmas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(463, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 243);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARMAS";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.dgvSkills);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(13, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 243);
            this.groupBox3.TabIndex = 167;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skills/Magias";
            // 
            // dgvSkills
            // 
            this.dgvSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkills.Location = new System.Drawing.Point(16, 25);
            this.dgvSkills.Name = "dgvSkills";
            this.dgvSkills.Size = new System.Drawing.Size(416, 194);
            this.dgvSkills.TabIndex = 170;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.dgvInventario);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(917, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 243);
            this.groupBox4.TabIndex = 167;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "INVENTARIO";
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(16, 25);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(416, 194);
            this.dgvInventario.TabIndex = 170;
            // 
            // BtnSkills
            // 
            this.BtnSkills.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSkills.BackColor = System.Drawing.Color.Transparent;
            this.BtnSkills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSkills.ForeColor = System.Drawing.Color.Black;
            this.BtnSkills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSkills.Location = new System.Drawing.Point(12, 595);
            this.BtnSkills.Name = "BtnSkills";
            this.BtnSkills.Size = new System.Drawing.Size(215, 72);
            this.BtnSkills.TabIndex = 163;
            this.BtnSkills.Text = "&Skills / Magias";
            this.BtnSkills.UseVisualStyleBackColor = false;
            // 
            // BtnArmas
            // 
            this.BtnArmas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnArmas.BackColor = System.Drawing.Color.Transparent;
            this.BtnArmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnArmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArmas.ForeColor = System.Drawing.Color.Black;
            this.BtnArmas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnArmas.Location = new System.Drawing.Point(244, 595);
            this.BtnArmas.Name = "BtnArmas";
            this.BtnArmas.Size = new System.Drawing.Size(215, 72);
            this.BtnArmas.TabIndex = 163;
            this.BtnArmas.Text = "&ARMAS";
            this.BtnArmas.UseVisualStyleBackColor = false;
            // 
            // BtnInventario
            // 
            this.BtnInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInventario.BackColor = System.Drawing.Color.Transparent;
            this.BtnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.Black;
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.Location = new System.Drawing.Point(465, 596);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(215, 72);
            this.BtnInventario.TabIndex = 163;
            this.BtnInventario.Text = "&INVENTARIO";
            this.BtnInventario.UseVisualStyleBackColor = false;
            // 
            // BtnPericias
            // 
            this.BtnPericias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPericias.BackColor = System.Drawing.Color.Transparent;
            this.BtnPericias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPericias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPericias.ForeColor = System.Drawing.Color.Black;
            this.BtnPericias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPericias.Location = new System.Drawing.Point(694, 596);
            this.BtnPericias.Name = "BtnPericias";
            this.BtnPericias.Size = new System.Drawing.Size(215, 72);
            this.BtnPericias.TabIndex = 163;
            this.BtnPericias.Text = "&PERICIAS";
            this.BtnPericias.UseVisualStyleBackColor = false;
            // 
            // LblCampanha
            // 
            this.LblCampanha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCampanha.BackColor = System.Drawing.Color.Transparent;
            this.LblCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampanha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCampanha.Location = new System.Drawing.Point(1135, 9);
            this.LblCampanha.Name = "LblCampanha";
            this.LblCampanha.Size = new System.Drawing.Size(73, 18);
            this.LblCampanha.TabIndex = 170;
            this.LblCampanha.Text = "Campanha";
            // 
            // LblAtributo
            // 
            this.LblAtributo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAtributo.BackColor = System.Drawing.Color.Transparent;
            this.LblAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtributo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblAtributo.Location = new System.Drawing.Point(1056, 9);
            this.LblAtributo.Name = "LblAtributo";
            this.LblAtributo.Size = new System.Drawing.Size(73, 18);
            this.LblAtributo.TabIndex = 171;
            this.LblAtributo.Text = "Atributo";
            // 
            // FrmAddAtributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 679);
            this.Controls.Add(this.LblAtributo);
            this.Controls.Add(this.LblCampanha);
            this.Controls.Add(this.BtnPericias);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.BtnArmas);
            this.Controls.Add(this.BtnSkills);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.lblPersonagem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbResultadoDaPesquisa);
            this.Controls.Add(this.LblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddAtributos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddAtributos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAddAtributos_Load);
            this.gbResultadoDaPesquisa.ResumeLayout(false);
            this.gbResultadoDaPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPericias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblCodigo;
        internal System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.ComboBox cBoxRaca;
        public System.Windows.Forms.ComboBox cBoxAlinhamento;
        public System.Windows.Forms.ComboBox cBoxClasse;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btnAtualizar;
        internal System.Windows.Forms.Label lblPersonagem;
        internal System.Windows.Forms.GroupBox gbResultadoDaPesquisa;
        public System.Windows.Forms.Label LblUser;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.TextBox txtSAB;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox txtCON;
        public System.Windows.Forms.TextBox txtCAR;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtINT;
        public System.Windows.Forms.TextBox txtFOR;
        public System.Windows.Forms.TextBox txtDES;
        public System.Windows.Forms.TextBox txtNivel;
        public System.Windows.Forms.TextBox txtExperiencia;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtClasseArmadura;
        public System.Windows.Forms.TextBox txtJades;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtPontosAtaque;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtPontosVidaAtuais;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtPontosVida;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvArmas;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPericias;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSkills;
        public System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvInventario;
        internal System.Windows.Forms.Button BtnSkills;
        internal System.Windows.Forms.Button BtnArmas;
        internal System.Windows.Forms.Button BtnInventario;
        internal System.Windows.Forms.Button BtnPericias;
        internal System.Windows.Forms.Label LblCampanha;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIniciativa;
        internal System.Windows.Forms.Label LblAtributo;
    }
}