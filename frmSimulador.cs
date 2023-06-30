using Corporate.Balancas.Protocolo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesteBalanca
{
	public partial class frmSimulador : Form
	{
		private SerialPort COM;

		public frmSimulador()
		{
			InitializeComponent();
			lblStatus.Text = "";
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			try
			{
				OpenConnection();
				lblStatus.Text = "";
				COM.Write(txtMessage.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void OpenConnection()
		{
			if (COM == null || COM.PortName != txtPortaVirtual.Text)
			{
				CloseConnection();
				COM = new SerialPort(txtPortaVirtual.Text);
				COM.Open();
				COM.WriteTimeout = 1000;

				COM.DataReceived += COM_DataReceived;
			}
		}

		void COM_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			lblStatus.BeginInvoke(new EventHandler(delegate
			{
				lblStatus.Text = COM.ReadExisting();
			}));
		}

		private void CloseConnection()
		{
			try
			{
				COM.Close();
				COM = null;
			}
			catch { }

		}

		private void ctrIC2012_Changed(object sender, EventArgs e)
		{
			//Formato: $CRAAAAAABBBBBCDDEEEFFFFG<CR>
			txtMessage.Text = "$CR" +
									PadSize(txtIC2012Peso.Text, 6) +
									PadSize(txtIC2012Area.Text, 5) +
									PadSize(cboIC2012FechaPalete.Text, 1) +
									PadSize(txtIC2012PosicaoPalete.Text, 2) +
									PadSize(txtIC2012Vinculo.Text, 3) +
									PadSize(txtIC2012Defeito.Text, 4) +
									PadSize(txtIC2012Partida.Text, 1) +
									"\r\n";
		}

		private void ctrNBN_Changed(object sender, EventArgs e)
		{
			//Formato: NNNNbbbbbAAA<21>SQbDM<LF><CR>
			txtMessage.Text = PadSize(txtNBNSequencia.Text, 4) +
									"     " +
									PadSize(txtNBNArea.Text, 3) +
									"\tSQbD                      " +
									"\r\n";
		}

		private string PadSize(string text, int size)
		{
			return text.PadLeft(size, '0').Substring(0, size);
		}

		private void frmSimulador_FormClosed(object sender, FormClosedEventArgs e)
		{
			CloseConnection();
		}
	}
}
