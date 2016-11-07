using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPort
{
    public partial class TestComponent : Form
    {
        public TestComponent()
        {
            InitializeComponent();
        }

        private void TestComponent_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;

            Console.WriteLine("x = " + posX + ".y = " + posY);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;

            Point p = Control.MousePosition;
            

            Console.WriteLine("x = " + posX + ".y = " + posY);
            label1.Text = "x = " + p.X + ".y = " + p.Y;
        }


    }
}
