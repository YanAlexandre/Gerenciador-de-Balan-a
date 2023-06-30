namespace TesteBalanca
{
    partial class frmBalanca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBalanca));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.grpConfiguracao = new System.Windows.Forms.GroupBox();
            this.txtConfiguracao = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuffer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpPeso = new System.Windows.Forms.GroupBox();
            this.lblMedicao = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabBalanca = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtcaminho = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtcorrigevalor = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.grpCorte = new System.Windows.Forms.GroupBox();
            this.txtCorte = new System.Windows.Forms.TextBox();
            this.grpInicio = new System.Windows.Forms.GroupBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnSimulador = new System.Windows.Forms.Button();
            this.txtPropriedadesProtocolo = new System.Windows.Forms.TextBox();
            this.btnBuffer = new System.Windows.Forms.Button();
            this.grpEnconde = new System.Windows.Forms.GroupBox();
            this.cboEncode = new System.Windows.Forms.ComboBox();
            this.chkFullBuffer = new System.Windows.Forms.CheckBox();
            this.grpStable = new System.Windows.Forms.GroupBox();
            this.chkStable = new System.Windows.Forms.CheckBox();
            this.grpReadInterval = new System.Windows.Forms.GroupBox();
            this.txtReadInterval = new System.Windows.Forms.TextBox();
            this.grpRandomMax = new System.Windows.Forms.GroupBox();
            this.txtRandomMax = new System.Windows.Forms.TextBox();
            this.grpDelay = new System.Windows.Forms.GroupBox();
            this.cboDelay = new System.Windows.Forms.ComboBox();
            this.grpRandomMin = new System.Windows.Forms.GroupBox();
            this.txtRandomMin = new System.Windows.Forms.TextBox();
            this.grpDataBits = new System.Windows.Forms.GroupBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.grpStopBits = new System.Windows.Forms.GroupBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.grpBaudRate = new System.Windows.Forms.GroupBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.grpParidade = new System.Windows.Forms.GroupBox();
            this.cboParidade = new System.Windows.Forms.ComboBox();
            this.grpPorta = new System.Windows.Forms.GroupBox();
            this.cboPorta = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboProtocolo = new System.Windows.Forms.ComboBox();
            this.tabRetorno = new System.Windows.Forms.TabPage();
            this.btnFullBuffer = new System.Windows.Forms.Button();
            this.chkReadBytes = new System.Windows.Forms.CheckBox();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullBuffer = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpConfiguracao.SuspendLayout();
            this.grpPeso.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabBalanca.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpCorte.SuspendLayout();
            this.grpInicio.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpEnconde.SuspendLayout();
            this.grpStable.SuspendLayout();
            this.grpReadInterval.SuspendLayout();
            this.grpRandomMax.SuspendLayout();
            this.grpDelay.SuspendLayout();
            this.grpRandomMin.SuspendLayout();
            this.grpDataBits.SuspendLayout();
            this.grpStopBits.SuspendLayout();
            this.grpBaudRate.SuspendLayout();
            this.grpParidade.SuspendLayout();
            this.grpPorta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabRetorno.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabBalanca);
            this.tabMain.Controls.Add(this.tabRetorno);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabMain.ItemSize = new System.Drawing.Size(90, 22);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(2379, 1050);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtReal);
            this.tabPage1.Controls.Add(this.grpConfiguracao);
            this.tabPage1.Controls.Add(this.btnConectar);
            this.tabPage1.Controls.Add(this.btnDesconectar);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txtBuffer);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.grpPeso);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(2371, 1020);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Medição";
            // 
            // txtReal
            // 
            this.txtReal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReal.Location = new System.Drawing.Point(480, 876);
            this.txtReal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReal.Multiline = true;
            this.txtReal.Name = "txtReal";
            this.txtReal.ReadOnly = true;
            this.txtReal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReal.Size = new System.Drawing.Size(532, 184);
            this.txtReal.TabIndex = 26;
            // 
            // grpConfiguracao
            // 
            this.grpConfiguracao.Controls.Add(this.txtConfiguracao);
            this.grpConfiguracao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConfiguracao.Location = new System.Drawing.Point(6, 1242);
            this.grpConfiguracao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpConfiguracao.Name = "grpConfiguracao";
            this.grpConfiguracao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpConfiguracao.Size = new System.Drawing.Size(1278, 114);
            this.grpConfiguracao.TabIndex = 21;
            this.grpConfiguracao.TabStop = false;
            this.grpConfiguracao.Text = "Protocolo";
            this.grpConfiguracao.Visible = false;
            // 
            // txtConfiguracao
            // 
            this.txtConfiguracao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfiguracao.Location = new System.Drawing.Point(9, 31);
            this.txtConfiguracao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfiguracao.Multiline = true;
            this.txtConfiguracao.Name = "txtConfiguracao";
            this.txtConfiguracao.ReadOnly = true;
            this.txtConfiguracao.Size = new System.Drawing.Size(1258, 63);
            this.txtConfiguracao.TabIndex = 10;
            this.txtConfiguracao.Visible = false;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnConectar.Location = new System.Drawing.Point(15, 664);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(434, 88);
            this.btnConectar.TabIndex = 20;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnDesconectar.Location = new System.Drawing.Point(15, 761);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(434, 88);
            this.btnDesconectar.TabIndex = 15;
            this.btnDesconectar.Text = "DESCONECTAR";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button2.Location = new System.Drawing.Point(12, 569);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(436, 88);
            this.button2.TabIndex = 13;
            this.button2.Text = "CONFIGURAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuffer
            // 
            this.txtBuffer.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuffer.Location = new System.Drawing.Point(10, 1216);
            this.txtBuffer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuffer.Multiline = true;
            this.txtBuffer.Name = "txtBuffer";
            this.txtBuffer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBuffer.Size = new System.Drawing.Size(281, 18);
            this.txtBuffer.TabIndex = 12;
            this.txtBuffer.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(480, 569);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1012, 280);
            this.button1.TabIndex = 5;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpPeso
            // 
            this.grpPeso.Controls.Add(this.lblMedicao);
            this.grpPeso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPeso.Location = new System.Drawing.Point(10, 48);
            this.grpPeso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPeso.Name = "grpPeso";
            this.grpPeso.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPeso.Size = new System.Drawing.Size(1487, 506);
            this.grpPeso.TabIndex = 4;
            this.grpPeso.TabStop = false;
            this.grpPeso.Text = "Medição";
            // 
            // lblMedicao
            // 
            this.lblMedicao.Font = new System.Drawing.Font("Tahoma", 80F, System.Drawing.FontStyle.Bold);
            this.lblMedicao.ForeColor = System.Drawing.Color.Red;
            this.lblMedicao.Location = new System.Drawing.Point(9, 134);
            this.lblMedicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicao.Name = "lblMedicao";
            this.lblMedicao.Size = new System.Drawing.Size(1449, 282);
            this.lblMedicao.TabIndex = 1;
            this.lblMedicao.Text = "DESCONECTADO";
            this.lblMedicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtHistorico);
            this.groupBox6.Controls.Add(this.btnHistorico);
            this.groupBox6.Location = new System.Drawing.Point(6, 858);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(443, 211);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CONSULTAR VALORES";
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(9, 74);
            this.txtHistorico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(427, 129);
            this.txtHistorico.TabIndex = 23;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(228, 19);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(208, 48);
            this.btnHistorico.TabIndex = 22;
            this.btnHistorico.Text = "SELECIONAR ARQUIVO";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblNome);
            this.groupBox7.Location = new System.Drawing.Point(1019, 876);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(474, 185);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Arquivo de dados";
            // 
            // lblNome
            // 
            this.lblNome.AutoEllipsis = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNome.Location = new System.Drawing.Point(18, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(431, 134);
            this.lblNome.TabIndex = 27;
            // 
            // tabBalanca
            // 
            this.tabBalanca.Controls.Add(this.button4);
            this.tabBalanca.Controls.Add(this.btnsalvar);
            this.tabBalanca.Controls.Add(this.groupBox5);
            this.tabBalanca.Controls.Add(this.groupBox4);
            this.tabBalanca.Controls.Add(this.button3);
            this.tabBalanca.Controls.Add(this.grpCorte);
            this.tabBalanca.Controls.Add(this.grpInicio);
            this.tabBalanca.Controls.Add(this.groupBox3);
            this.tabBalanca.Controls.Add(this.groupBox2);
            this.tabBalanca.Controls.Add(this.btnSimulador);
            this.tabBalanca.Controls.Add(this.txtPropriedadesProtocolo);
            this.tabBalanca.Controls.Add(this.btnBuffer);
            this.tabBalanca.Controls.Add(this.grpEnconde);
            this.tabBalanca.Controls.Add(this.chkFullBuffer);
            this.tabBalanca.Controls.Add(this.grpStable);
            this.tabBalanca.Controls.Add(this.grpReadInterval);
            this.tabBalanca.Controls.Add(this.grpRandomMax);
            this.tabBalanca.Controls.Add(this.grpDelay);
            this.tabBalanca.Controls.Add(this.grpRandomMin);
            this.tabBalanca.Controls.Add(this.grpDataBits);
            this.tabBalanca.Controls.Add(this.grpStopBits);
            this.tabBalanca.Controls.Add(this.grpBaudRate);
            this.tabBalanca.Controls.Add(this.grpParidade);
            this.tabBalanca.Controls.Add(this.grpPorta);
            this.tabBalanca.Controls.Add(this.groupBox1);
            this.tabBalanca.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBalanca.Location = new System.Drawing.Point(4, 26);
            this.tabBalanca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBalanca.Name = "tabBalanca";
            this.tabBalanca.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBalanca.Size = new System.Drawing.Size(2156, 1289);
            this.tabBalanca.TabIndex = 0;
            this.tabBalanca.Text = "Configurações";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(436, 348);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 39);
            this.button4.TabIndex = 23;
            this.button4.Text = "Selecionar Pasta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnsalvar.Location = new System.Drawing.Point(205, 459);
            this.btnsalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(291, 70);
            this.btnsalvar.TabIndex = 21;
            this.btnsalvar.Text = "SALVAR CONFIG.";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtcaminho);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(192, 274);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(403, 61);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Caminho";
            // 
            // txtcaminho
            // 
            this.txtcaminho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaminho.Location = new System.Drawing.Point(9, 22);
            this.txtcaminho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcaminho.Name = "txtcaminho";
            this.txtcaminho.Size = new System.Drawing.Size(384, 27);
            this.txtcaminho.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtcorrigevalor);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 274);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(166, 61);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Corrigir Valor";
            // 
            // txtcorrigevalor
            // 
            this.txtcorrigevalor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorrigevalor.Location = new System.Drawing.Point(9, 22);
            this.txtcorrigevalor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcorrigevalor.Name = "txtcorrigevalor";
            this.txtcorrigevalor.Size = new System.Drawing.Size(144, 27);
            this.txtcorrigevalor.TabIndex = 9;
            this.txtcorrigevalor.Text = "10000";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(26, 459);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 70);
            this.button3.TabIndex = 19;
            this.button3.Text = "VOLTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grpCorte
            // 
            this.grpCorte.Controls.Add(this.txtCorte);
            this.grpCorte.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCorte.Location = new System.Drawing.Point(192, 398);
            this.grpCorte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCorte.Name = "grpCorte";
            this.grpCorte.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCorte.Size = new System.Drawing.Size(166, 61);
            this.grpCorte.TabIndex = 18;
            this.grpCorte.TabStop = false;
            this.grpCorte.Text = "Corte";
            this.grpCorte.Visible = false;
            // 
            // txtCorte
            // 
            this.txtCorte.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorte.Location = new System.Drawing.Point(9, 22);
            this.txtCorte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorte.Name = "txtCorte";
            this.txtCorte.Size = new System.Drawing.Size(144, 27);
            this.txtCorte.TabIndex = 10;
            // 
            // grpInicio
            // 
            this.grpInicio.Controls.Add(this.txtInicio);
            this.grpInicio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInicio.Location = new System.Drawing.Point(17, 398);
            this.grpInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInicio.Name = "grpInicio";
            this.grpInicio.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInicio.Size = new System.Drawing.Size(166, 61);
            this.grpInicio.TabIndex = 11;
            this.grpInicio.TabStop = false;
            this.grpInicio.Text = "Início";
            this.grpInicio.Visible = false;
            // 
            // txtInicio
            // 
            this.txtInicio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicio.Location = new System.Drawing.Point(9, 22);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(144, 27);
            this.txtInicio.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblArea);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(910, 161);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(219, 61);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Área";
            this.groupBox3.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArea.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(3, 26);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(213, 31);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Área";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPeso);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(712, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(192, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Peso";
            this.groupBox2.Visible = false;
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeso.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(3, 26);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(186, 31);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSimulador
            // 
            this.btnSimulador.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulador.Location = new System.Drawing.Point(640, 9);
            this.btnSimulador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimulador.Name = "btnSimulador";
            this.btnSimulador.Size = new System.Drawing.Size(153, 86);
            this.btnSimulador.TabIndex = 17;
            this.btnSimulador.Text = "Simulador de Envio";
            this.btnSimulador.UseVisualStyleBackColor = true;
            this.btnSimulador.Visible = false;
            this.btnSimulador.Click += new System.EventHandler(this.btnSimulador_Click);
            // 
            // txtPropriedadesProtocolo
            // 
            this.txtPropriedadesProtocolo.Location = new System.Drawing.Point(17, 645);
            this.txtPropriedadesProtocolo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPropriedadesProtocolo.Name = "txtPropriedadesProtocolo";
            this.txtPropriedadesProtocolo.Size = new System.Drawing.Size(781, 27);
            this.txtPropriedadesProtocolo.TabIndex = 16;
            this.txtPropriedadesProtocolo.Visible = false;
            // 
            // btnBuffer
            // 
            this.btnBuffer.Location = new System.Drawing.Point(979, 232);
            this.btnBuffer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuffer.Name = "btnBuffer";
            this.btnBuffer.Size = new System.Drawing.Size(75, 35);
            this.btnBuffer.TabIndex = 15;
            this.btnBuffer.Text = "Limpar";
            this.btnBuffer.UseVisualStyleBackColor = true;
            this.btnBuffer.Visible = false;
            this.btnBuffer.Click += new System.EventHandler(this.btnBuffer_Click);
            // 
            // grpEnconde
            // 
            this.grpEnconde.Controls.Add(this.cboEncode);
            this.grpEnconde.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEnconde.Location = new System.Drawing.Point(377, 9);
            this.grpEnconde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnconde.Name = "grpEnconde";
            this.grpEnconde.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnconde.Size = new System.Drawing.Size(255, 86);
            this.grpEnconde.TabIndex = 14;
            this.grpEnconde.TabStop = false;
            this.grpEnconde.Text = "Encode Text";
            this.grpEnconde.Visible = false;
            // 
            // cboEncode
            // 
            this.cboEncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEncode.FormattingEnabled = true;
            this.cboEncode.Items.AddRange(new object[] {
            "ASCII",
            "UTF-8",
            "UTF-7"});
            this.cboEncode.Location = new System.Drawing.Point(9, 32);
            this.cboEncode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboEncode.Name = "cboEncode";
            this.cboEncode.Size = new System.Drawing.Size(235, 29);
            this.cboEncode.TabIndex = 0;
            // 
            // chkFullBuffer
            // 
            this.chkFullBuffer.AutoSize = true;
            this.chkFullBuffer.Enabled = false;
            this.chkFullBuffer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFullBuffer.ForeColor = System.Drawing.Color.Maroon;
            this.chkFullBuffer.Location = new System.Drawing.Point(24, 598);
            this.chkFullBuffer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFullBuffer.Name = "chkFullBuffer";
            this.chkFullBuffer.Size = new System.Drawing.Size(671, 25);
            this.chkFullBuffer.TabIndex = 13;
            this.chkFullBuffer.Text = "Após conectar marque esta caixa para enviar o arquivo de retorno para TI.";
            this.chkFullBuffer.UseVisualStyleBackColor = true;
            this.chkFullBuffer.Visible = false;
            this.chkFullBuffer.CheckedChanged += new System.EventHandler(this.chkFullBuffer_CheckedChanged);
            // 
            // grpStable
            // 
            this.grpStable.Controls.Add(this.chkStable);
            this.grpStable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStable.Location = new System.Drawing.Point(192, 332);
            this.grpStable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStable.Name = "grpStable";
            this.grpStable.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStable.Size = new System.Drawing.Size(166, 61);
            this.grpStable.TabIndex = 8;
            this.grpStable.TabStop = false;
            this.grpStable.Visible = false;
            // 
            // chkStable
            // 
            this.chkStable.AutoSize = true;
            this.chkStable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStable.Location = new System.Drawing.Point(12, 26);
            this.chkStable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkStable.Name = "chkStable";
            this.chkStable.Size = new System.Drawing.Size(113, 25);
            this.chkStable.TabIndex = 0;
            this.chkStable.Text = "Estabilizar";
            this.chkStable.UseVisualStyleBackColor = true;
            // 
            // grpReadInterval
            // 
            this.grpReadInterval.Controls.Add(this.txtReadInterval);
            this.grpReadInterval.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReadInterval.Location = new System.Drawing.Point(17, 332);
            this.grpReadInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpReadInterval.Name = "grpReadInterval";
            this.grpReadInterval.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpReadInterval.Size = new System.Drawing.Size(166, 61);
            this.grpReadInterval.TabIndex = 7;
            this.grpReadInterval.TabStop = false;
            this.grpReadInterval.Text = "Read Interval";
            this.grpReadInterval.Visible = false;
            // 
            // txtReadInterval
            // 
            this.txtReadInterval.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadInterval.Location = new System.Drawing.Point(9, 22);
            this.txtReadInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReadInterval.Name = "txtReadInterval";
            this.txtReadInterval.Size = new System.Drawing.Size(144, 27);
            this.txtReadInterval.TabIndex = 10;
            // 
            // grpRandomMax
            // 
            this.grpRandomMax.Controls.Add(this.txtRandomMax);
            this.grpRandomMax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRandomMax.Location = new System.Drawing.Point(652, 361);
            this.grpRandomMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRandomMax.Name = "grpRandomMax";
            this.grpRandomMax.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRandomMax.Size = new System.Drawing.Size(166, 61);
            this.grpRandomMax.TabIndex = 8;
            this.grpRandomMax.TabStop = false;
            this.grpRandomMax.Text = "Random Max";
            this.grpRandomMax.Visible = false;
            // 
            // txtRandomMax
            // 
            this.txtRandomMax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRandomMax.Location = new System.Drawing.Point(9, 22);
            this.txtRandomMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRandomMax.Name = "txtRandomMax";
            this.txtRandomMax.Size = new System.Drawing.Size(144, 27);
            this.txtRandomMax.TabIndex = 10;
            // 
            // grpDelay
            // 
            this.grpDelay.Controls.Add(this.cboDelay);
            this.grpDelay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDelay.Location = new System.Drawing.Point(192, 202);
            this.grpDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDelay.Name = "grpDelay";
            this.grpDelay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDelay.Size = new System.Drawing.Size(166, 61);
            this.grpDelay.TabIndex = 8;
            this.grpDelay.TabStop = false;
            this.grpDelay.Text = "Delay";
            // 
            // cboDelay
            // 
            this.cboDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDelay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDelay.FormattingEnabled = true;
            this.cboDelay.Items.AddRange(new object[] {
            "500",
            "700",
            "800",
            "1000",
            "1200",
            "1500",
            "2000"});
            this.cboDelay.Location = new System.Drawing.Point(9, 22);
            this.cboDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDelay.Name = "cboDelay";
            this.cboDelay.Size = new System.Drawing.Size(144, 29);
            this.cboDelay.TabIndex = 0;
            // 
            // grpRandomMin
            // 
            this.grpRandomMin.Controls.Add(this.txtRandomMin);
            this.grpRandomMin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRandomMin.Location = new System.Drawing.Point(652, 290);
            this.grpRandomMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRandomMin.Name = "grpRandomMin";
            this.grpRandomMin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRandomMin.Size = new System.Drawing.Size(166, 61);
            this.grpRandomMin.TabIndex = 7;
            this.grpRandomMin.TabStop = false;
            this.grpRandomMin.Text = "Random Min";
            this.grpRandomMin.Visible = false;
            // 
            // txtRandomMin
            // 
            this.txtRandomMin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRandomMin.Location = new System.Drawing.Point(9, 22);
            this.txtRandomMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRandomMin.Name = "txtRandomMin";
            this.txtRandomMin.Size = new System.Drawing.Size(144, 27);
            this.txtRandomMin.TabIndex = 9;
            // 
            // grpDataBits
            // 
            this.grpDataBits.Controls.Add(this.cboDataBits);
            this.grpDataBits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataBits.Location = new System.Drawing.Point(17, 202);
            this.grpDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDataBits.Name = "grpDataBits";
            this.grpDataBits.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDataBits.Size = new System.Drawing.Size(166, 61);
            this.grpDataBits.TabIndex = 7;
            this.grpDataBits.TabStop = false;
            this.grpDataBits.Text = "Data Bits";
            // 
            // cboDataBits
            // 
            this.cboDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataBits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Items.AddRange(new object[] {
            "dbFive",
            "dbSix",
            "dbSeven",
            "dbEight"});
            this.cboDataBits.Location = new System.Drawing.Point(9, 22);
            this.cboDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(144, 29);
            this.cboDataBits.TabIndex = 0;
            // 
            // grpStopBits
            // 
            this.grpStopBits.Controls.Add(this.cboStopBits);
            this.grpStopBits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStopBits.Location = new System.Drawing.Point(192, 139);
            this.grpStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStopBits.Name = "grpStopBits";
            this.grpStopBits.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStopBits.Size = new System.Drawing.Size(166, 61);
            this.grpStopBits.TabIndex = 6;
            this.grpStopBits.TabStop = false;
            this.grpStopBits.Text = "Stop Bits";
            // 
            // cboStopBits
            // 
            this.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopBits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Items.AddRange(new object[] {
            "sbOneStopBit",
            "sbOne5StopBits",
            "sbTwoStopBits"});
            this.cboStopBits.Location = new System.Drawing.Point(9, 22);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(144, 29);
            this.cboStopBits.TabIndex = 0;
            // 
            // grpBaudRate
            // 
            this.grpBaudRate.Controls.Add(this.cboBaudRate);
            this.grpBaudRate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBaudRate.Location = new System.Drawing.Point(192, 74);
            this.grpBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBaudRate.Name = "grpBaudRate";
            this.grpBaudRate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBaudRate.Size = new System.Drawing.Size(166, 61);
            this.grpBaudRate.TabIndex = 4;
            this.grpBaudRate.TabStop = false;
            this.grpBaudRate.Text = "BaudRate";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaudRate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "brCustom",
            "br110",
            "br300",
            "br600",
            "br1200",
            "br2400",
            "br4800",
            "br9600",
            "br14400",
            "br19200",
            "br38400",
            "br56000",
            "br57600",
            "br115200",
            "br128000",
            "br256000"});
            this.cboBaudRate.Location = new System.Drawing.Point(9, 22);
            this.cboBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(144, 29);
            this.cboBaudRate.TabIndex = 0;
            // 
            // grpParidade
            // 
            this.grpParidade.Controls.Add(this.cboParidade);
            this.grpParidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpParidade.Location = new System.Drawing.Point(17, 139);
            this.grpParidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpParidade.Name = "grpParidade";
            this.grpParidade.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpParidade.Size = new System.Drawing.Size(166, 61);
            this.grpParidade.TabIndex = 5;
            this.grpParidade.TabStop = false;
            this.grpParidade.Text = "Paridade";
            // 
            // cboParidade
            // 
            this.cboParidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParidade.FormattingEnabled = true;
            this.cboParidade.Items.AddRange(new object[] {
            "prEven",
            "prNone",
            "prOdd",
            "prMark",
            "prSpace"});
            this.cboParidade.Location = new System.Drawing.Point(9, 22);
            this.cboParidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboParidade.Name = "cboParidade";
            this.cboParidade.Size = new System.Drawing.Size(144, 29);
            this.cboParidade.TabIndex = 0;
            // 
            // grpPorta
            // 
            this.grpPorta.Controls.Add(this.cboPorta);
            this.grpPorta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPorta.Location = new System.Drawing.Point(17, 74);
            this.grpPorta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPorta.Name = "grpPorta";
            this.grpPorta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPorta.Size = new System.Drawing.Size(166, 61);
            this.grpPorta.TabIndex = 3;
            this.grpPorta.TabStop = false;
            this.grpPorta.Text = "Porta";
            // 
            // cboPorta
            // 
            this.cboPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPorta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPorta.FormattingEnabled = true;
            this.cboPorta.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cboPorta.Location = new System.Drawing.Point(9, 22);
            this.cboPorta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPorta.Name = "cboPorta";
            this.cboPorta.Size = new System.Drawing.Size(144, 29);
            this.cboPorta.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboProtocolo);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(342, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Protocolo";
            // 
            // cboProtocolo
            // 
            this.cboProtocolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProtocolo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProtocolo.FormattingEnabled = true;
            this.cboProtocolo.Location = new System.Drawing.Point(-6, 22);
            this.cboProtocolo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboProtocolo.Name = "cboProtocolo";
            this.cboProtocolo.Size = new System.Drawing.Size(319, 29);
            this.cboProtocolo.TabIndex = 0;
            this.cboProtocolo.TextChanged += new System.EventHandler(this.cboProtocolo_TextChanged);
            // 
            // tabRetorno
            // 
            this.tabRetorno.Controls.Add(this.btnFullBuffer);
            this.tabRetorno.Controls.Add(this.chkReadBytes);
            this.tabRetorno.Controls.Add(this.btnRetorno);
            this.tabRetorno.Controls.Add(this.label1);
            this.tabRetorno.Controls.Add(this.txtFullBuffer);
            this.tabRetorno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRetorno.Location = new System.Drawing.Point(4, 26);
            this.tabRetorno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRetorno.Name = "tabRetorno";
            this.tabRetorno.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRetorno.Size = new System.Drawing.Size(2156, 1289);
            this.tabRetorno.TabIndex = 1;
            this.tabRetorno.Text = "Retorno";
            // 
            // btnFullBuffer
            // 
            this.btnFullBuffer.Location = new System.Drawing.Point(702, 691);
            this.btnFullBuffer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFullBuffer.Name = "btnFullBuffer";
            this.btnFullBuffer.Size = new System.Drawing.Size(75, 35);
            this.btnFullBuffer.TabIndex = 16;
            this.btnFullBuffer.Text = "Limpar";
            this.btnFullBuffer.UseVisualStyleBackColor = true;
            this.btnFullBuffer.Click += new System.EventHandler(this.btnFullBuffer_Click);
            // 
            // chkReadBytes
            // 
            this.chkReadBytes.AutoSize = true;
            this.chkReadBytes.Location = new System.Drawing.Point(6, 2);
            this.chkReadBytes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkReadBytes.Name = "chkReadBytes";
            this.chkReadBytes.Size = new System.Drawing.Size(160, 25);
            this.chkReadBytes.TabIndex = 3;
            this.chkReadBytes.Text = "Leitura em bytes";
            this.chkReadBytes.UseVisualStyleBackColor = true;
            // 
            // btnRetorno
            // 
            this.btnRetorno.Location = new System.Drawing.Point(832, 691);
            this.btnRetorno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetorno.Name = "btnRetorno";
            this.btnRetorno.Size = new System.Drawing.Size(179, 48);
            this.btnRetorno.TabIndex = 2;
            this.btnRetorno.Text = "Salvar Retorno";
            this.btnRetorno.UseVisualStyleBackColor = true;
            this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 739);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Se no Grid acima é exibido Linhas clique em Salvar. Deixe um peso na balança ante" +
    "s de salvar o arquivo.";
            // 
            // txtFullBuffer
            // 
            this.txtFullBuffer.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullBuffer.Location = new System.Drawing.Point(0, 31);
            this.txtFullBuffer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullBuffer.Multiline = true;
            this.txtFullBuffer.Name = "txtFullBuffer";
            this.txtFullBuffer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFullBuffer.Size = new System.Drawing.Size(806, 696);
            this.txtFullBuffer.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmBalanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2379, 1050);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBalanca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBalanca_FormClosing);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpConfiguracao.ResumeLayout(false);
            this.grpConfiguracao.PerformLayout();
            this.grpPeso.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tabBalanca.ResumeLayout(false);
            this.tabBalanca.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpCorte.ResumeLayout(false);
            this.grpCorte.PerformLayout();
            this.grpInicio.ResumeLayout(false);
            this.grpInicio.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpEnconde.ResumeLayout(false);
            this.grpStable.ResumeLayout(false);
            this.grpStable.PerformLayout();
            this.grpReadInterval.ResumeLayout(false);
            this.grpReadInterval.PerformLayout();
            this.grpRandomMax.ResumeLayout(false);
            this.grpRandomMax.PerformLayout();
            this.grpDelay.ResumeLayout(false);
            this.grpRandomMin.ResumeLayout(false);
            this.grpRandomMin.PerformLayout();
            this.grpDataBits.ResumeLayout(false);
            this.grpStopBits.ResumeLayout(false);
            this.grpBaudRate.ResumeLayout(false);
            this.grpParidade.ResumeLayout(false);
            this.grpPorta.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabRetorno.ResumeLayout(false);
            this.tabRetorno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabBalanca;
        private System.Windows.Forms.GroupBox grpBaudRate;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.GroupBox grpPorta;
        private System.Windows.Forms.ComboBox cboPorta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboProtocolo;
        private System.Windows.Forms.TabPage tabRetorno;
        private System.Windows.Forms.GroupBox grpStable;
        private System.Windows.Forms.CheckBox chkStable;
        private System.Windows.Forms.GroupBox grpReadInterval;
        private System.Windows.Forms.TextBox txtReadInterval;
        private System.Windows.Forms.GroupBox grpRandomMax;
        private System.Windows.Forms.TextBox txtRandomMax;
        private System.Windows.Forms.GroupBox grpDelay;
        private System.Windows.Forms.ComboBox cboDelay;
        private System.Windows.Forms.GroupBox grpRandomMin;
        private System.Windows.Forms.TextBox txtRandomMin;
        private System.Windows.Forms.GroupBox grpDataBits;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.GroupBox grpStopBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.GroupBox grpParidade;
        private System.Windows.Forms.ComboBox cboParidade;
        private System.Windows.Forms.TextBox txtFullBuffer;
        private System.Windows.Forms.CheckBox chkFullBuffer;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpEnconde;
        private System.Windows.Forms.ComboBox cboEncode;
        private System.Windows.Forms.CheckBox chkReadBytes;
        private System.Windows.Forms.Button btnBuffer;
        private System.Windows.Forms.Button btnFullBuffer;
        private System.Windows.Forms.TextBox txtPropriedadesProtocolo;
		  private System.Windows.Forms.Button btnSimulador;
		  private System.Windows.Forms.GroupBox groupBox3;
		  private System.Windows.Forms.Label lblArea;
		  private System.Windows.Forms.GroupBox groupBox2;
          private System.Windows.Forms.Label lblPeso;
          private System.Windows.Forms.GroupBox grpCorte;
          private System.Windows.Forms.TextBox txtCorte;
          private System.Windows.Forms.GroupBox grpInicio;
          private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpPeso;
        private System.Windows.Forms.Label lblMedicao;
        private System.Windows.Forms.TextBox txtBuffer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.GroupBox grpConfiguracao;
        private System.Windows.Forms.TextBox txtConfiguracao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtcorrigevalor;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtcaminho;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnHistorico;
        internal System.Windows.Forms.TabPage tabPage1;
        protected internal System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

