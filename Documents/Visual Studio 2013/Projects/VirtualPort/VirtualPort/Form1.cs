using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace VirtualPort
{
    public partial class PortForm : Form
    {
        SerialPort mySerialPort;
        public PortForm()
        {
            InitializeComponent();
        }

        private void PortForm_Load(object sender, EventArgs e)
        {
            try
            {
                //
                //Thread th = new Thread(ShowThreadInformation);
                //th.Start();

                //Thread th1 = new Thread(TestData);
                //th1.Start();

                MessageBox.Show("open serialport");

                mySerialPort = new SerialPort("COM2");

                mySerialPort.BaudRate = 9600;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;
                mySerialPort.Handshake = Handshake.None;
                mySerialPort.RtsEnable = true;

                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                mySerialPort.Open();

            }
            catch
            {
                MessageBox.Show("cant open serial port");
            }
        }

        /// <summary>
        /// creat a new serial port
        /// </summary>
        /// <param name="port"></param>
        void CreatSerial(String port)
        {
            SerialPort p = new SerialPort(port);
            p.BaudRate = 9600;
            p.Parity = Parity.None;
            p.StopBits = StopBits.One;
            p.DataBits = 8;
            p.Handshake = Handshake.None;
            p.RtsEnable = true;

            p.Open();
        }


        /// <summary>
        /// serial port receive data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        String indata;
        private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            //Console.WriteLine("Data Received:");
            //Console.Write(indata);
            
            //ssp.Write(indata);
            this.indata = indata;
            Thread t = new Thread(show);
            t.Start();
            //Console.WriteLine(indata);

            //MessageBox.Show(indata);
            
        }
        void show()
        {
            //button.Text = indata;
        }
        /// <summary>
        /// class for thread
        /// </summary>
        /// <param name="state"></param>
        private  void ShowThreadInformation(Object state)
        {
            lock (new Object())
            {
                for (int i = 0; i < 10000000; i++)
                {
                    Console.WriteLine(i);
                    
                }
            }
        }

        private  void TestData()
        {
            
            {
                for (int i = 0; i < 10000000; i++)
                {
                    Console.WriteLine("two" + i);

                 }
            }

        }

        private void PortForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mySerialPort.IsOpen)
                mySerialPort.Close();
            MessageBox.Show("closed the virtual port");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mySerialPort.Write("anh toan");
                
            }
            catch
            {
                
            }
        }
    }
}
