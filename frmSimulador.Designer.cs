namespace TesteBalanca
{
	partial class frmSimulador
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
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtPortaVirtual = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.cboIC2012FechaPalete = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtIC2012Partida = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtIC2012Defeito = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtIC2012Vinculo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtIC2012PosicaoPalete = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIC2012Area = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtIC2012Peso = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label12 = new System.Windows.Forms.Label();
			this.txtNBNArea = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtNBNSequencia = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtMessage
			// 
			this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMessage.Location = new System.Drawing.Point(7, 180);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(396, 64);
			this.txtMessage.TabIndex = 0;
			// 
			// btnSend
			// 
			this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSend.Location = new System.Drawing.Point(328, 8);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 1;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtPortaVirtual
			// 
			this.txtPortaVirtual.Location = new System.Drawing.Point(81, 10);
			this.txtPortaVirtual.Name = "txtPortaVirtual";
			this.txtPortaVirtual.Size = new System.Drawing.Size(50, 20);
			this.txtPortaVirtual.TabIndex = 2;
			this.txtPortaVirtual.Text = "COM6";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Porta Virtual*:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 258);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(270, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "*Utilize o programa com0com para emular portas virtuais";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(7, 36);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(396, 125);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.cboIC2012FechaPalete);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.txtIC2012Partida);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.txtIC2012Defeito);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.txtIC2012Vinculo);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.txtIC2012PosicaoPalete);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.txtIC2012Area);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.txtIC2012Peso);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(388, 99);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "RB IC2012";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// cboIC2012FechaPalete
			// 
			this.cboIC2012FechaPalete.FormattingEnabled = true;
			this.cboIC2012FechaPalete.Items.AddRange(new object[] {
            "0",
            "1"});
			this.cboIC2012FechaPalete.Location = new System.Drawing.Point(91, 72);
			this.cboIC2012FechaPalete.Name = "cboIC2012FechaPalete";
			this.cboIC2012FechaPalete.Size = new System.Drawing.Size(44, 21);
			this.cboIC2012FechaPalete.TabIndex = 22;
			this.cboIC2012FechaPalete.Text = "0";
			this.cboIC2012FechaPalete.SelectedIndexChanged += new System.EventHandler(this.ctrIC2012_Changed);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(291, 23);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(43, 13);
			this.label11.TabIndex = 21;
			this.label11.Text = "Partida:";
			// 
			// txtIC2012Partida
			// 
			this.txtIC2012Partida.Location = new System.Drawing.Point(338, 21);
			this.txtIC2012Partida.MaxLength = 1;
			this.txtIC2012Partida.Name = "txtIC2012Partida";
			this.txtIC2012Partida.Size = new System.Drawing.Size(44, 20);
			this.txtIC2012Partida.TabIndex = 20;
			this.txtIC2012Partida.Text = "1";
			this.txtIC2012Partida.TextChanged += new System.EventHandler(this.ctrIC2012_Changed);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(151, 75);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(49, 13);
			this.label10.TabIndex = 19;
			this.label10.Text = "Defeitos:";
			// 
			// txtIC2012Defeito
			// 
			this.txtIC2012Defeito.Location = new System.Drawing.Point(238, 72);
			this.txtIC2012Defeito.MaxLength = 4;
			this.txtIC2012Defeito.Name = "txtIC2012Defeito";
			this.txtIC2012Defeito.Size = new System.Drawing.Size(44, 20);
			this.txtIC2012Defeito.TabIndex = 18;
			this.txtIC2012Defeito.Text = "1234";
			this.txtIC2012Defeito.TextChanged += new System.EventHandler(this.ctrIC2012_Changed);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(151, 50);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "Vínculo:";
			// 
			// txtIC2012Vinculo
			// 
			this.txtIC2012Vinculo.Location = new System.Drawing.Point(238, 47);
			this.txtIC2012Vinculo.MaxLength = 3;
			this.txtIC2012Vinculo.Name = "txtIC2012Vinculo";
			this.txtIC2012Vinculo.Size = new System.Drawing.Size(44, 20);
			this.txtIC2012Vinculo.TabIndex = 16;
			this.txtIC2012Vinculo.Text = "100";
			this.txtIC2012Vinculo.TextChanged += new System.EventHandler(this.ctrIC2012_Changed);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(151, 23);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Posição Palete:";
			// 
			// txtIC2012PosicaoPalete
			// 
			this.txtIC2012PosicaoPalete.Location = new System.Drawing.Point(238, 21);
			this.txtIC2012PosicaoPalete.MaxLength = 2;
			this.txtIC2012PosicaoPalete.Name = "txtIC2012PosicaoPalete";
			this.txtIC2012PosicaoPalete.Size = new System.Drawing.Size(44, 20);
			this.txtIC2012PosicaoPalete.TabIndex = 14;
			this.txtIC2012PosicaoPalete.Text = "1";
			this.txtIC2012PosicaoPalete.TextChanged += new System.EventHandler(this.ctrIC2012_Changed);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Fecha Palete:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Área:";
			// 
			// txtIC2012Area
			// 
			this.txtIC2012Area.Location = new System.Drawing.Point(91, 47);
			this.txtIC2012Area.MaxLength = 5;
			this.txtIC2012Area.Name = "txtIC2012Area";
			this.txtIC2012Area.Size = new System.Drawing.Size(44, 20);
			this.txtIC2012Area.TabIndex = 10;
			this.txtIC2012Area.Text = "12345";
			this.txtIC2012Area.TextChanged += new System.EventHandler(this.ctrIC2012_Changed);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Peso:";
			// 
			// txtIC2012Peso
			// 
			this.txtIC2012Peso.Location = new System.Drawing.Point(91, 21);
			this.txtIC2012Peso.MaxLength = 6;
			this.txtIC2012Peso.Name = "txtIC2012Peso";
			this.txtIC2012Peso.Size = new System.Drawing.Size(44, 20);
			this.txtIC2012Peso.TabIndex = 8;
			this.txtIC2012Peso.Text = "123456";
			this.txtIC2012Peso.TextChanged += new System.EventHandler(this.ctrIC2012_Changed);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(252, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Formato: $CRAAAAAABBBBBCDDEEEFFFFG<CR>";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.txtNBNArea);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.txtNBNSequencia);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(388, 99);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "NBN MD SORT";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 59);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 13);
			this.label12.TabIndex = 16;
			this.label12.Text = "Área:";
			// 
			// txtNBNArea
			// 
			this.txtNBNArea.Location = new System.Drawing.Point(91, 57);
			this.txtNBNArea.MaxLength = 3;
			this.txtNBNArea.Name = "txtNBNArea";
			this.txtNBNArea.Size = new System.Drawing.Size(44, 20);
			this.txtNBNArea.TabIndex = 15;
			this.txtNBNArea.Text = "123";
			this.txtNBNArea.TextChanged += new System.EventHandler(this.ctrNBN_Changed);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 33);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(61, 13);
			this.label13.TabIndex = 14;
			this.label13.Text = "Sequencia:";
			// 
			// txtNBNSequencia
			// 
			this.txtNBNSequencia.Location = new System.Drawing.Point(91, 31);
			this.txtNBNSequencia.MaxLength = 4;
			this.txtNBNSequencia.Name = "txtNBNSequencia";
			this.txtNBNSequencia.Size = new System.Drawing.Size(44, 20);
			this.txtNBNSequencia.TabIndex = 13;
			this.txtNBNSequencia.Text = "0001";
			this.txtNBNSequencia.TextChanged += new System.EventHandler(this.ctrNBN_Changed);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 13);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(247, 13);
			this.label14.TabIndex = 12;
			this.label14.Text = "Formato: NNNNbbbbbAAA<21>SQbDM<LF><CR>";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Texto para envio:";
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(345, 253);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(31, 20);
			this.lblStatus.TabIndex = 22;
			this.lblStatus.Text = "OK";
			// 
			// frmSimulador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 280);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPortaVirtual);
			this.Controls.Add(this.btnSend);
			this.Name = "frmSimulador";
			this.Text = "Simulador de Envio de Protocolo";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSimulador_FormClosed);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtPortaVirtual;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboIC2012FechaPalete;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtIC2012Partida;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtIC2012Defeito;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtIC2012Vinculo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtIC2012PosicaoPalete;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIC2012Area;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtIC2012Peso;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtNBNArea;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtNBNSequencia;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lblStatus;
	}
}