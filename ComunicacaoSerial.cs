using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Corporate.Balancas.Protocolo
{
    /// <summary>
    /// Classe responsável por receber uma configuração e 
    /// conectar em uma porta serial. Receber e transmitir 
    /// os dados
    /// </summary>
    public class SerialComunication : IDisposable
    {
        #region Attributes

        private enum ConfigBaudRate
        {
            brCustom = 0,
            br110 = 110,
            br300 = 300,
            br600 = 600,
            br1200 = 1200,
            br2400 = 2400,
            br4800 = 4800,
            br9600 = 9600,
            br14400 = 14400,
            br19200 = 19200,
            br38400 = 38400,
            br56000 = 56000,
            br57600 = 57600,
            br115200 = 115200,
            br128000 = 128000,
            br256000 = 256000
        }

        private enum ConfigDataBits
        {
            dbFive = 5,
            dbSix = 6,
            dbSeven = 7,
            dbEight = 8
        }

        private enum ConfigParityBits
        {
            prNone = Parity.None,
            prOdd = Parity.Odd,
            prEven = Parity.Even,
            prMark = Parity.Mark,
            prSpace = Parity.Space
        }

        private enum ConfigStopBits
        {
            sbOneStopBit = System.IO.Ports.StopBits.One,
            sbOne5StopBits = System.IO.Ports.StopBits.OnePointFive,
            sbTwoStopBits = System.IO.Ports.StopBits.Two
        }

        private SerialPort serialPort;

        public delegate void DataReceivedEventHandler(byte[] data);

        /// <summary>
        /// Evento de leitura do Buffer da porta
        /// </summary>
        public event DataReceivedEventHandler DataReceived;

        #endregion

        #region Properties
        /// <summary>
        /// Parâmetros de configuração
        /// </summary>
        private Dictionary<string, string> Parameter { get; set; }

        /// <summary>
        /// indica se Porta está aberta
        /// </summary>
        public bool IsConnected
        {
            get
            {
                if (serialPort == null)
                    return false;
                return serialPort.IsOpen;
            }
        }

        /// <summary>
        /// Configuração do BaudRate
        /// </summary>
        private int BaudRate
        {
            get
            {
                if (!Parameter.ContainsKey(BAUD_RATE) || Parameter[BAUD_RATE] == "brCustom")
                    return serialPort.BaudRate;
                else
                    return (int)Enum.Parse(typeof(ConfigBaudRate), Parameter[BAUD_RATE], true);
            }
        }

        /// <summary>
        /// Configuração da Paridade
        /// </summary>
        private Parity Parity
        {
            get
            {
                if (!Parameter.ContainsKey(PARITY))
                    return serialPort.Parity;
                else
                    return (Parity)Enum.Parse(typeof(ConfigParityBits), Parameter[PARITY], true);
            }
        }

        /// <summary>
        /// Configuração do StopBits
        /// </summary>
        private StopBits StopBits
        {
            get
            {
                if (!Parameter.ContainsKey(STOP_BITS))
                    return serialPort.StopBits;
                else
                    return (StopBits)Enum.Parse(typeof(ConfigStopBits), Parameter[STOP_BITS], true);
            }
        }

        /// <summary>
        /// Configuração do DataBits
        /// </summary>
        private int DataBits
        {
            get
            {
                if (!Parameter.ContainsKey(DATA_BITS))
                    return serialPort.DataBits;
                else
                    return (int)Enum.Parse(typeof(ConfigDataBits), Parameter[DATA_BITS], true);
            }
        }

        /// <summary>
        /// Configuração do DataBits
        /// </summary>
        public int ReadInterval
        {
            get
            {
                if (!Parameter.ContainsKey(READ_INTERVAL))
                    return serialPort.ReadTimeout;
                else
                    return int.Parse(Parameter[READ_INTERVAL]);
            }
            set
            {
                serialPort.ReadTimeout = value;
            }
        }

        #endregion

        #region Constants

        /// Valore dos parametros sempre em minusculo
        private const string PORT = "port";
        private const string BAUD_RATE = "baudrate";
        private const string PARITY = "parity";
        private const string DATA_BITS = "databits";
        private const string STOP_BITS = "stopbits";
        private const string READ_INTERVAL = "readinterval";

        #endregion

        #region Constructors

        /// <summary>
        /// Construtor da Classe
        /// </summary>
        /// <param name="config">string de configuração</param>        
        public SerialComunication(string config)
        {
            Parameter = ReadParameters(config);

            serialPort = new SerialPort();

            // Configuração da Porta é Obrigatória
            serialPort.PortName = Parameter[PORT];

            // Demais Configurações opcionais, caso não tenha sido informada assume
            // valores default
            serialPort.BaudRate = this.BaudRate;
            serialPort.Parity = this.Parity;
            serialPort.StopBits = this.StopBits;
            serialPort.DataBits = this.DataBits;
            serialPort.ReadTimeout = this.ReadInterval;
            serialPort.ParityReplace = 0x0;

            if (     (config.Contains("wpTeraTermVT") )
                 || (config.Contains("wpLotos200")) 
               )
            { 
              serialPort.DtrEnable = true;
              serialPort.RtsEnable = true;
              serialPort.Handshake = Handshake.RequestToSendXOnXOff;
            }

            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
        }

        #endregion

        #region Methods

        #region Private
        #endregion

        #region Static

        /// <summary>
        /// Quebra string de Configuração alimentando um dicionário de Parâmetros
        /// </summary>
        /// <param name="config">a string de configuração</param>
        public static Dictionary<string, string> ReadParameters(string config)
        {
            Dictionary<string, string> parameter = new Dictionary<string, string>();

            // Quebra String na Vírgula
            foreach (var item in config.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
            {
                var namedValue = item.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);

                // Quebra String no Igual
                if (!parameter.ContainsKey(namedValue[0]))
                    parameter.Add(namedValue[0].ToLower(), namedValue[1]);
            }

            return parameter;
        }

        #endregion

        #region Public

        /// <summary>
        /// Conecta Porta
        /// </summary>
        public void Connect()
        {
            if (!IsConnected)
            {
                serialPort.Open();
            }
        }

        /// <summary>
        /// Desconecta Porta
        /// </summary>
        public void Disconnect()
        {
            if (IsConnected)
            {
                serialPort.BaseStream.Flush();
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();
                serialPort.Close();
            }
        }

        /// <summary>
        /// Descarta objeto
        /// </summary>
        public void Dispose()
        {
            if (serialPort != null)
            {
                this.Disconnect();
                serialPort.Dispose();
                serialPort = null;
            }

            DataReceived = null;
        }

        public void Write(byte[] data)
        {
            if (serialPort != null && serialPort.IsOpen && serialPort.BaseStream != null && serialPort.BaseStream.CanWrite)
                serialPort.Write(data, 0, data.Length);
        }
        #endregion

        #endregion

        #region Events

        /// <summary>
        /// Efetua leitura do buffer da Porta
        /// </summary>
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // tamanho da leitura atual
            int bytesToRead = serialPort.BytesToRead;
            byte[] newBytes = new byte[bytesToRead];

            // Lê o buffer atual
            serialPort.Read(newBytes, 0, bytesToRead);

            // Envia buffer para o evento
            if (DataReceived != null)
                DataReceived(newBytes);
        }

        #endregion
    }
}
