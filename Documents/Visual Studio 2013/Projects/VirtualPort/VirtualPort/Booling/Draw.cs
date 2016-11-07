using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPort.Booling
{
    public partial class Draw : Form
    {
        public Draw()
        {
            InitializeComponent();
        }

        private void Draw_Load(object sender, EventArgs e)
        {

        }


        private void DrawIt()
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
                50, 100, 150, 150);
            graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);
        }

        private void nutVe_Click(object sender, EventArgs e)
        {
            DrawIt();
        }
    }
}
