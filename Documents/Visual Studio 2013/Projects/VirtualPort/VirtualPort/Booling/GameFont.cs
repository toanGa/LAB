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

namespace VirtualPort.Booling
{
    public partial class GameFont : Form
    {
        Boolean display = true;
        byte time = 0;
        Image imageBackground = null;


        System.Drawing.Graphics graphics = null;
        public GameFont()
        {
            InitializeComponent();
            CreatGraphics();
            
        }

        void CreatGraphics()
        {
            graphics = pictureBox1.CreateGraphics();
            imageBackground = Image.FromFile("C:\\Users\\toan\\Desktop\\hinh\\jangmi.jpg");

        }

        private void GameFont_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
           

        }


        private void onPain(){

            Random r = new Random();
            Color c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            Color ca = Color.Blue;

            Pen p = new Pen(c, 10);

            Graphics g = panel1.CreateGraphics();

            g.DrawLine(p, 0, 0, 50, 50);
            g.Dispose();
        }

        private void GameFont_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            onPain();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (display == true)
            {
                new Thread(DrawIt).Start();
                display = false;
            }
            else if (display == false)
            {
                pictureBox1.Image = imageBackground;
                display = true;
                //this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            }
        }

        private void DrawIt()
        {
            
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
                50, 100, 150, 150);

            
            graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);
        }

        private void DrawRectangle()
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            panel1.BackColor = Color.FromArgb(time, time, time);
            label1.Text = "" + time;
            if (time == 1000)
                graphics.Dispose();
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }

}
