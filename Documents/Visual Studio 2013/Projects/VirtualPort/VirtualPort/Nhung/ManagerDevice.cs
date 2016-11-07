using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPort.BaiTapLon
{
    public partial class ManagerDevice : Form
    {
        //static Label l;
        //const string s = "null";
        //string serialName = "COM1";
        SerialHandler serial = null;
        string s = "COM3";
        
        //SerialHandler 
        public ManagerDevice()
        {
            InitializeComponent();
            serial = new SerialHandler(s,label1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serial.SendData("tran van toan");
            label1.Text = serial.GetDataIncome();
        }

        private void ManagerDevice_Load(object sender, EventArgs e)
        {

        }

        private void ManagerDevice_FormClosed(object sender, FormClosedEventArgs e)
        {
            serial.Close();
        }
    }
}
