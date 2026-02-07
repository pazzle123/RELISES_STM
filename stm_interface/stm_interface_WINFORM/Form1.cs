using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace stm_interface_1
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
            GetPort();
            startStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeSerialPort()
        {
            // Создаем новый объект SerialPort
            serialPort = new SerialPort();
       
            // Настраиваем основные параметры
            serialPort.BaudRate = 115200;          // Скорость передачи
            serialPort.Parity = Parity.None;      // Контроль четности
            serialPort.DataBits = 8;              // Биты данных
            serialPort.StopBits = StopBits.One;   // Стоп-биты
            serialPort.Handshake = Handshake.None; // Управление потоком

            // Подписываемся на события
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            serialPort.ErrorReceived += new SerialErrorReceivedEventHandler(serialPort1_ErrorReceived);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            // Код для обработки полученных данных

        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {

        }

        private void serialPort1_PinChanged(object sender, SerialPinChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("1");
                MessageBox.Show("Данные отправлены");
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("2");
                MessageBox.Show("Данные отправлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void startStatus()
        {
            label1.Text = "ОТКЛЮЧЕНО";
            label1.ForeColor = Color.Red;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GetPort()
        {
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void buttonPort_Click(object sender, EventArgs e)
        {
            GetPort(); 
        }

        private void button_conn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = comboBox1.Text.ToString();
                label1.Text = "Подключено";
                label1.ForeColor = Color.Green;
                serialPort.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("COM порт не может быть пустым");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
