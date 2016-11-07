using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPort.BaiTapLon
{
    class SerialPlay
    {
        String com;
        SerialPort serial = null;// = new SerialPort();
        String indata;

        Boolean hasDataIncome;
        public SerialPlay(String com)
        {
            this.com = com;
           
            Setup();
            hasDataIncome  = false;
        }

        public void Setup()
        {
            try
            {
                serial = new SerialPort(com);

                serial.BaudRate = 9600;
                serial.Parity = Parity.None;
                serial.StopBits = StopBits.One;
                serial.DataBits = 8;
                serial.Handshake = Handshake.None;
                serial.RtsEnable = true;

                serial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                serial.Open();
                Console.WriteLine("connect success");
            }
            catch (Exception e)
            {
                Console.WriteLine("cant connect port");
                MessageBox.Show("can't connect serial port " + com);
            }
            
        }

        
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
            hasDataIncome = true;

        }


        public Boolean IsDataIn()
        {
            return hasDataIncome;
        }

        public void ResetFlag()
        {
            hasDataIncome = false;
        }

        public void SendData(string data)
        {
            try
            {
                serial.Write(data);
            }
            catch (Exception e)
            {
                Console.WriteLine("eror while send data,may be error at open port");
            }
            

        }
        public string GetDataIncome()
        {
            return indata;
            
        }

        public void Close(){
            try
            {
                serial.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("can't close the serial port");
            }
        }

        public void Open()
        {
            try
            {
                serial.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("cant open the serial port");
            }
        }
    }
}
