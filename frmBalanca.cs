using System;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Collections.Generic;
using Corporate.Balancas.Protocolo;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;

namespace TesteBalanca
{
    public partial class frmBalanca : Form
    {
        #region Attributes

        private Protocol protocolo;

        #endregion

        #region Properties
        #endregion

        #region Constants

        private const string CK_PropertiesIC2012 = @"Peso : {0} - Área : {1} - Palete Fechado : {2} - Vinculo : {3} - Defeito : {4} - Partida : {5}";
        #endregion

        #region Constructors

        public frmBalanca()
        {
            InitializeComponent();

            btnDesconectar.Enabled = !btnConectar.Enabled;
            cboDelay.SelectedIndex = 0;
            cboEncode.SelectedIndex = 0;



            cboProtocolo.DataSource = Enum.GetNames(typeof(ProtocolType));
            cboPorta.DataSource = SerialPort.GetPortNames();



#if DEBUG
            try
            {
                cboProtocolo.Text = ConfigurationManager.AppSettings.Get("protocolo");
                cboBaudRate.Text = ConfigurationManager.AppSettings.Get("baudrate");
                cboDataBits.Text = ConfigurationManager.AppSettings.Get("databits");
                cboParidade.Text = ConfigurationManager.AppSettings.Get("paridade");
                cboStopBits.Text = ConfigurationManager.AppSettings.Get("stopbits");
                cboPorta.Text = ConfigurationManager.AppSettings.Get("porta");
                txtcaminho.Text = ConfigurationManager.AppSettings.Get("caminho");
                txtcorrigevalor.Text = ConfigurationManager.AppSettings.Get("corrigevalor");


            }
            catch
            {
            }
#endif
        }

        #endregion

        #region Methods

        #region Private

        /// <summary>
        /// Atualiza Label
        /// </summary>
        /// <param name="ctrl">controle</param>
        /// <param name="value">o valor</param>
        private void RecebeBuffer(Label ctrl, string value)
        {
            try
            {

                // ReSharper disable PossibleNullReferenceException
                if (ctrl != null && ctrl.InvokeRequired && !ctrl.IsDisposed && !ctrl.FindForm().IsDisposed)
                // ReSharper restore PossibleNullReferenceException
                {
                    txtBuffer.BeginInvoke(new EventHandler(delegate
                    {
                        ctrl.SuspendLayout();
                        value = Regex.Replace(value, @"[^\d]", "");
                        value = Convert.ToString(Convert.ToInt64(value) / Convert.ToInt32(txtcorrigevalor.Text));
                        ctrl.Text = value;
                        ctrl.Refresh();
                        ctrl.ResumeLayout();
                    }));


                    ctrl.ForeColor = System.Drawing.Color.Blue;
                }
            }
            catch

            {
                MessageBox.Show("ERRO");
            }
        }

        /// <summary>
        /// Atualiza MemoBuffer
        /// </summary>
        /// <param name="ctrl">controle</param>
        /// <param name="value">o valor</param>
        private static void RecebeBuffer(TextBox ctrl, string value)
        {


            // ReSharper disable PossibleNullReferenceException


            try
            {
                if (ctrl != null && ctrl.InvokeRequired && !ctrl.IsDisposed && !ctrl.FindForm().IsDisposed)
                // ReSharper restore PossibleNullReferenceException
                {
                    ctrl.BeginInvoke(new EventHandler(delegate
                    {
                        ctrl.SuspendLayout();
                        value = Regex.Replace(value, @"[^\d]", "#,#");
                        ctrl.Text += value;
                        ctrl.SelectionStart = ctrl.Text.Length;
                        ctrl.ScrollToCaret();
                        ctrl.Refresh();
                        ctrl.ResumeLayout();


                    }));

                    ctrl.ForeColor = System.Drawing.Color.Blue;
                }

            }
            catch
            {
                MessageBox.Show("ERRO");
            }

        }

        #endregion

        #region Public
        #endregion

        #endregion

        #region Events

        /// <summary>
        /// Conecta Protocolo
        /// </summary>
        private void btnConectar_Click(object sender, EventArgs e)
        {

            tabMain.SelectedTab = tabPage1;
            try
            {
                btnConectar.Enabled = false;

                if (cboProtocolo.Text == "")
                    throw new ArgumentException("Informe o protocolo.");

                if (cboPorta.Text == "")
                    throw new ArgumentException("Informe a porta para conexão.");

                if (cboBaudRate.Text == "")
                    throw new ArgumentException("Informe o BaudRate.");

                if (cboParidade.Text == "")
                    throw new ArgumentException("Informe a Paridade.");

                if (cboStopBits.Text == "")
                    throw new ArgumentException("Informe o StopBit");

                if (cboDataBits.Text == "")
                    throw new ArgumentException("Informe o Data Bit");

                int randomMin = 0;
                if (txtRandomMin.Text != string.Empty)
                    if (!int.TryParse(txtRandomMin.Text, out randomMin))
                        throw new ArgumentException("Valor inválido para o campo RandomMin.");

                int randomMax = 0;
                if (txtRandomMax.Text != string.Empty)
                    if (!int.TryParse(txtRandomMax.Text, out randomMax))
                        throw new ArgumentException("Valor inválido para o campo RandomMax.");

                if (randomMin > randomMax)
                    throw new ArgumentException("RandomMax tem que ser maior que RandomMin.");

                int readInterval;
                if (txtReadInterval.Text != string.Empty)
                    if (!int.TryParse(txtReadInterval.Text, out readInterval))
                        throw new ArgumentException("Valor inválido para o campo ReadInterval.");

                if (cboEncode.Text == "")
                    throw new ArgumentException("Informe o Encode Text");

                if (cboProtocolo.Text == @"wp_generico" && (txtInicio.Text == "" || txtCorte.Text == ""))
                    throw new ArgumentException("Para o protocolo genérico é preciso informar o início e o tamanho de corte do texto!");

                // Monta string de Configuração
                List<string> config = new List<string> { string.Format("Protocol={0}", cboProtocolo.Text) };

                if (cboProtocolo.Text != @"wpRandomWeight")
                {
                    config.Add(string.Format("Port={0}", cboPorta.Text));
                    config.Add(string.Format("BaudRate={0}", cboBaudRate.Text));
                    config.Add(string.Format("Parity={0}", cboParidade.Text));
                    config.Add(string.Format("DataBits={0}", cboDataBits.Text));
                    config.Add(string.Format("StopBits={0}", cboStopBits.Text));

                    if (cboProtocolo.Text == @"wp_generico")
                    {
                        config.Add(string.Format("Inicio={0}", txtInicio.Text));
                        config.Add(string.Format("Corte={0}", txtCorte.Text));
                    }
                    else
                    {
                        if ((cboProtocolo.Text != @"wpTeraTermVT")
                              || (cboProtocolo.Text != @"Lotos200")
                           )
                        {
                            config.Add(string.Format("Delay={0}", cboDelay.Text));
                            config.Add(string.Format("OnlyStability={0}", (chkStable.Checked) ? "True" : "False"));
                        }
                    }

                    if (txtReadInterval.Text != "")
                        config.Add(string.Format("ReadInterval={0}", txtReadInterval.Text));
                }
                else
                {
                    if (txtRandomMin.Text != "")
                        config.Add(string.Format("RandomMin={0}", txtRandomMin.Text));

                    if (txtRandomMax.Text != "")
                        config.Add(string.Format("RandomMax={0}", txtRandomMax.Text));
                }

                txtConfiguracao.Text = string.Join(",", config.ToArray());

                // abre conexão
                protocolo = Protocol.Create(txtConfiguracao.Text, cboEncode.Text);
                protocolo.BufferReceived += protocolo_BufferReceived;

                if (protocolo is IC2012)
                    ((IC2012)protocolo).OnResponseReceived += frmBalanca_OnResponseReceived;

                protocolo.StartRead();

                LimpaCampos();


            }
            catch (Exception ex)
            {
                if (protocolo != null)
                    protocolo.FinishRead();

                MessageBox.Show(ex.Message);
                btnConectar.Enabled = true;
            }
            finally
            {
                btnDesconectar.Enabled = !btnConectar.Enabled;
                chkFullBuffer.Checked = false;
            }
        }

        /// <summary>
        /// Desconecta Protocolo
        /// </summary>
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (protocolo != null)
                    protocolo.FinishRead();

                protocolo = null;

                btnConectar.Enabled = true;
                btnDesconectar.Enabled = !btnConectar.Enabled;
                lblMedicao.Text = "DESCONECTADO";
                lblMedicao.ForeColor = Color.Red;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Controla check
        /// </summary>
        private void cboProtocolo_TextChanged(object sender, EventArgs e)
        {
            var value = cboProtocolo.Text;
            if (value == "wpNone")
                return;

            cboBaudRate.SelectedIndex = cboBaudRate.Items.IndexOf("br4800");
            cboParidade.SelectedIndex = cboParidade.Items.IndexOf("prEven");
            cboStopBits.SelectedIndex = cboStopBits.Items.IndexOf("sbOneStopBit");
            cboDataBits.SelectedIndex = cboDataBits.Items.IndexOf("dbSeven");

            string readInterval = "";

            string baudRate = "br9600";
            string paridade = "prEven";
            string stopBits = "sbOneStopBit";
            string dataBits = "dbSeven";

            switch (value)
            {
                case "wpToledo_9091_P03":
                case "wpToledo_9094":
                case "wpToledo_8530_NOSETPOINT":
                    baudRate = "br4800";
                    stopBits = "sbTwoStopBits";
                    break;

                case "wpToledo_JagXtreme":
                    baudRate = "br4800";
                    dataBits = "dbSeven";
                    stopBits = "sbOneStopBits";
                    readInterval = "100";
                    break;

                case "wpToledo_560Dyn":
                    baudRate = "br9600";
                    dataBits = "dbEight";
                    paridade = "prNone";
                    readInterval = "100";
                    break;

                case "wpDigitronDGN":
                    readInterval = "100";
                    break;

                case "wpAlFA_3102":
                    paridade = "prNone";
                    dataBits = "dbEight";
                    break;

                case "wpAlFA_3101":
                    paridade = "prNone";
                    dataBits = "dbEight";
                    readInterval = "100";
                    break;

                case "wp_weightech_WT21I":
                    paridade = "prNone";
                    dataBits = "dbEight";
                    readInterval = "100";
                    break;

                case "wpFilizola_ID10000":
                    paridade = "prNone";
                    dataBits = "dbEight";
                    break;

                case "Alpha/Lider 2052":
                    baudRate = "br2400";
                    paridade = "prNone";
                    dataBits = "dbEight";
                    break;

                case "wp_saturnoSBR140":
                    paridade = "prEven";
                    dataBits = "dbSeven";
                    break;

                case "wp_Balmak":
                    paridade = "prNone";
                    dataBits = "dbEight";
                    break;

                case "wp_Welmy":
                    paridade = "prNone";
                    dataBits = "dbEight";
                    break;

                case "wpGERLT300":
                    paridade = "prEven";
                    dataBits = "dbSeven";
                    baudRate = "br9600";
                    stopBits = "sbOneStopBit";
                    break;

                case "wpTeraTermVT":
                    paridade = "prNone";
                    dataBits = "dbEight";
                    baudRate = "br9600";
                    stopBits = "sbOneStopBit";
                    break;

                case "wpLotos200":
                    paridade = "prNone";
                    dataBits = "dbEight";
                    baudRate = "br9600";
                    stopBits = "sbOneStopBit";
                    break;

                case "wpSipel_Aries":
                    paridade = "prNone";
                    dataBits = "dbEight";
                    baudRate = "br9600";
                    stopBits = "sbOneStopBit";
                    break;

                case "wp_LiderB520":
                    paridade = "prNone";
                    dataBits = "dbEight";
                    baudRate = "br4800";
                    stopBits = "sbTwoStopBits";
                    break;

            }

            cboBaudRate.SelectedIndex = cboBaudRate.Items.IndexOf(baudRate);
            cboParidade.SelectedIndex = cboParidade.Items.IndexOf(paridade);
            cboStopBits.SelectedIndex = cboStopBits.Items.IndexOf(stopBits);
            cboDataBits.SelectedIndex = cboDataBits.Items.IndexOf(dataBits);
            txtReadInterval.Text = readInterval;
        }

        /// <summary>
        /// Exibe o buffer completo
        /// </summary>
        private void chkFullBuffer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFullBuffer.Checked)
                tabMain.SelectedIndex = 1;
        }

        /// <summary>
        /// Habilita check de buffer completo
        /// </summary>
        private void btnDesconectar_EnabledChanged(object sender, EventArgs e)
        {
            chkFullBuffer.Enabled = btnDesconectar.Enabled;
        }

        /// <summary>
        /// Salva Arquivo
        /// </summary>
        private void btnRetorno_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog { Filter = @"Text files (*.txt)|*.txt" };

            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(save.FileName);
                var sw = file.CreateText();
                sw.Write(txtFullBuffer.Text);
                sw.Close();
                sw.Dispose();

                MessageBox.Show(@"Arquivo Salvo em: " + save.FileName + @".Encaminhe este arquivo para a equipe de TI.");
            }

        }

        /// <summary>
        /// Fechamento do formulário
        /// </summary>
        private void frmBalanca_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (protocolo != null)
                protocolo.FinishRead();
        }

        /// <summary>
        /// Recebimento do Protocolo
        /// </summary>
        /// <param name="protocol">o protocolo</param>
        private void protocolo_BufferReceived(Protocol protocol)
        {
            var peso = protocolo.DefaultMeasure.ToString("N3") + ((protocol.Stable) ? " *" : "");

            RecebeBuffer(lblMedicao, peso);

            RecebeBuffer(txtBuffer, protocol.Buffer + "\r\n");

            RecebeResponse(protocol);

            if (chkFullBuffer.Checked)
            {
                if (chkReadBytes.Checked)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in protocol.ReadBytes)
                        sb.AppendFormat("[{0}]", ((int)b));

                    RecebeBuffer(txtFullBuffer, sb + "\r\n");
                }
                else
                {
                    RecebeBuffer(txtFullBuffer, protocol.ReadText + "\r\n");
                }
            }
        }

        private void LimpaCampos()
        {
            txtPropriedadesProtocolo.BeginInvoke(new EventHandler(delegate
            {
                txtPropriedadesProtocolo.Clear();
            }));
        }

        private void RecebeResponse(Protocol protocol)
        {
            lblPeso.BeginInvoke(new EventHandler(delegate
                                        {

                                            if (protocol.Response != null)
                                            {
                                                lblPeso.Text = protocol.Response.Weight.ToString("N3");
                                                lblArea.Text = protocol.Response.Area.ToString("N3");
                                            }
                                            else
                                            {
                                                lblPeso.Text = string.Empty;
                                                lblArea.Text = string.Empty;
                                            }
                                        }));
        }

        /// <summary>
        /// Recebimento do Protocolo IC2012
        /// </summary>
        private void frmBalanca_OnResponseReceived(IC2012_Response response)
        {
            txtPropriedadesProtocolo.BeginInvoke(new EventHandler(delegate
            {

                txtPropriedadesProtocolo.Text = string.Format(CK_PropertiesIC2012, response.Weight, response.Area,
                                                                             response.IsPalletClosed, response.Pallet, response.Falt,
                                                                             response.StartNumber);
                protocolo.ConfirmRead();
                //protocolo.SendError();
            }));
        }

        /// <summary>
        /// Limpa Buffer
        /// </summary>
        private void btnFullBuffer_Click(object sender, EventArgs e)
        {
            txtFullBuffer.Clear();
        }

        /// <summary>
        /// Limpa Buffer
        /// </summary>
        private void btnBuffer_Click(object sender, EventArgs e)
        {
            txtBuffer.Clear();
        }

        #endregion

        private void btnSimulador_Click(object sender, EventArgs e)
        {
            new frmSimulador().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pesando;

            Form form1 = new Form();
            Button button1 = new Button();
            Button button2 = new Button();
            Button button3 = new Button();
            form1.Size = new Size(650, 150);

            button1.Size = new Size(200, 100);
            button2.Size = new Size(200, 100);
            button3.Size = new Size(200, 100);

            button1.Text = "MATERIA PRIMA";
            button1.Location = new Point(10, 10);
            button2.Text = "PRODUTO ACABADO";
            button2.Location
               = new Point(button1.Width + button1.Left + 10, button1.Top);
            button3.Text = "OUTROS";
            button3.Location
               = new Point(button2.Width + button2.Left + 10, button2.Top);






            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
            button3.DialogResult = DialogResult.Abort;



            form1.Text = "OPÇÕES DE PESAGEM";
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.ControlBox = false;
            form1.MaximizeBox = false;
            form1.MinimizeBox = false;







            form1.StartPosition = FormStartPosition.CenterScreen;

            button1.Font = new Font("Arial", 15);
            button2.Font = new Font("Arial", 15);
            button3.Font = new Font("Arial", 15);
            form1.Controls.Add(button1);
            form1.Controls.Add(button2);
            form1.Controls.Add(button3);

            // Display the form as a modal dialog box.
            form1.ShowDialog();

            // Determine if the OK button was clicked on the dialog box.
            if (form1.DialogResult == DialogResult.OK)
            {
                pesando = "MATERIA PRIMA";
                form1.Dispose();
            }
            else if (form1.DialogResult == DialogResult.Cancel)
            {
                pesando = "PRODUTO ACABADO";
                form1.Dispose();
            }
            else
            {
                pesando = "OUTROS";
                form1.Dispose();

            }



            if (txtcaminho.Text != "")
            {

                string caminhoArq = txtcaminho.Text;
                string nomeArq = DateTime.Now.ToString("yyyyMMdd");
                SaveFileDialog salvarArquivo = new SaveFileDialog();



                string path = caminhoArq + nomeArq + ".txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {

                        sw.WriteLine("PESAGENS DO DIA " + DateTime.Now.ToString("dd/MM/yyyy"));
                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine("======PESSAGEM=======");
                    sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    sw.WriteLine(pesando);
                    sw.WriteLine("Peso : " + lblMedicao.Text);
                    sw.WriteLine("");




                    Form formmsg = new Form();
                    Button buttonok = new Button();
                    Label lblValidar = new Label();
                    formmsg.Font = new Font("Arial", 15);
                    lblValidar.Text = "Registrado com sucesso! Peso: " + lblMedicao.Text;
                    lblValidar.Location = new Point(15, 15);
                    buttonok.Dock = System.Windows.Forms.DockStyle.Bottom;
                    lblValidar.Size = new Size(650, 50);
                    formmsg.Size = new Size(650, 250);
                    buttonok.Size = new Size(200, 50);
                    buttonok.Text = "OK";
                    buttonok.DialogResult = DialogResult.OK;
                    formmsg.Text = "SALVO COM SUCESSO!";
                    formmsg.FormBorderStyle = FormBorderStyle.FixedDialog;
                    formmsg.ControlBox = false;
                    formmsg.MaximizeBox = false;
                    formmsg.MinimizeBox = false;

                    formmsg.StartPosition = FormStartPosition.CenterScreen;


                    formmsg.Controls.Add(buttonok);
                    formmsg.Controls.Add(lblValidar);

                    // Display the form as a modal dialog box.
                    formmsg.ShowDialog();

                    




                    // Determine if the OK button was clicked on the dialog box.
                    if (formmsg.DialogResult == DialogResult.OK)
                    {
                        form1.Dispose();
                    }






                }

                atualizarhist(path);
                lblNome.Text = path;

            }
            else
            {
                MessageBox.Show("Configure um caminho", "Error");
            }


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabBalanca;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabPage1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtcaminho.Text = folderBrowserDialog1.SelectedPath + "\\";
            }

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string cboprotocolo = cboProtocolo.Text;
            string cbobaudrate = cboBaudRate.Text;
            string cbodatabits = cboDataBits.Text;
            string cboparidade = cboParidade.Text;
            string cbostopbits = cboStopBits.Text;
            string cboporta = cboPorta.Text;
            string stxtcaminho = txtcaminho.Text;
            string stxtcorrigevalor = txtcorrigevalor.Text;


            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Clear();

            config.AppSettings.Settings.Add("protocolo", cboprotocolo);
            config.AppSettings.Settings.Add("baudrate", cbobaudrate);
            config.AppSettings.Settings.Add("databits", cbodatabits);
            config.AppSettings.Settings.Add("paridade", cboparidade);
            config.AppSettings.Settings.Add("stopbits", cbostopbits);
            config.AppSettings.Settings.Add("porta", cboporta);
            config.AppSettings.Settings.Add("caminho", stxtcaminho);
            config.AppSettings.Settings.Add("corrigevalor", stxtcorrigevalor);
            config.Save();

            MessageBox.Show("Salvo com sucesso", "Salvo");

        }


        private void atualizarhist(string file)
        {

            string text = System.IO.File.ReadAllText(file);

            txtReal.Text = text;
              
            this.txtReal.SelectionStart = txtReal.Text.Length;
            this.txtReal.ScrollToCaret();
        }
    

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                {
                    string text = System.IO.File.ReadAllText(openFileDialog1.FileName);

                    txtHistorico.Text = text;
                }
            }
            this.txtHistorico.SelectionStart = txtHistorico.Text.Length;
            this.txtHistorico.ScrollToCaret();
        }
    }
}
