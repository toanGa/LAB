using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPort.UART
{
    public partial class UART : Form
    {
        public UART()
        {
            InitializeComponent();
        }
        String dataIn;

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            dataIn = sp.ReadExisting();
        }

        private void UART_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = dataIn;
        }
    }
}
