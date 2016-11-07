using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPort.BaiTapLon
{
    public partial class Form1 : Form
    {
        Thread th = null;
        public Form1()
        {
            InitializeComponent();
            th = new Thread(ExecuteData);
            th.Start();
        }

        string dataincome = "123";
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //MessageBox.Show("receive data");
            dataincome = serialPort1.ReadExisting();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            serialPort1.Close();
            serialPort1.Dispose();
            try
            {
                th.Abort();
            }
            catch (Exception v)
            {
                Console.WriteLine("can't distroy thread");
            }
        }

        void ExecuteData()
        {
            while (true)
            {
                //label1.Text = dataincome;
                Thread.Sleep(300);
                Console.WriteLine(dataincome);
                //textBox1.Text = dataincome;
            }
            
        }
       
    }
}
