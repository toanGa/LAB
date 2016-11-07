namespace VirtualPort.BaiTapLon
{
    partial class TestMoving
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMoving));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pause = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.speedDown = new System.Windows.Forms.Button();
            this.speedUp = new System.Windows.Forms.Button();
            this.diemlan7 = new System.Windows.Forms.Label();
            this.diemlan6 = new System.Windows.Forms.Label();
            this.diemlan5 = new System.Windows.Forms.Label();
            this.diemlan4 = new System.Windows.Forms.Label();
            this.diemlan3 = new System.Windows.Forms.Label();
            this.diemlan2 = new System.Windows.Forms.Label();
            this.diemlan1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checker = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pause);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.ok);
            this.panel1.Controls.Add(this.speedDown);
            this.panel1.Controls.Add(this.speedUp);
            this.panel1.Location = new System.Drawing.Point(12, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 137);
            this.panel1.TabIndex = 9;
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(236, 88);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(69, 23);
            this.pause.TabIndex = 4;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(236, 17);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(69, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(73, 54);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(105, 23);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // speedDown
            // 
            this.speedDown.Location = new System.Drawing.Point(102, 88);
            this.speedDown.Name = "speedDown";
            this.speedDown.Size = new System.Drawing.Size(43, 23);
            this.speedDown.TabIndex = 1;
            this.speedDown.Text = "-";
            this.speedDown.UseVisualStyleBackColor = true;
            this.speedDown.Click += new System.EventHandler(this.speedDown_Click);
            // 
            // speedUp
            // 
            this.speedUp.Location = new System.Drawing.Point(102, 17);
            this.speedUp.Name = "speedUp";
            this.speedUp.Size = new System.Drawing.Size(43, 23);
            this.speedUp.TabIndex = 0;
            this.speedUp.Text = "+";
            this.speedUp.UseVisualStyleBackColor = true;
            this.speedUp.Click += new System.EventHandler(this.speedUp_Click);
            // 
            // diemlan7
            // 
            this.diemlan7.AutoSize = true;
            this.diemlan7.Location = new System.Drawing.Point(514, 168);
            this.diemlan7.Name = "diemlan7";
            this.diemlan7.Size = new System.Drawing.Size(55, 13);
            this.diemlan7.TabIndex = 16;
            this.diemlan7.Text = "diem lan 7";
            // 
            // diemlan6
            // 
            this.diemlan6.AutoSize = true;
            this.diemlan6.Location = new System.Drawing.Point(514, 139);
            this.diemlan6.Name = "diemlan6";
            this.diemlan6.Size = new System.Drawing.Size(55, 13);
            this.diemlan6.TabIndex = 15;
            this.diemlan6.Text = "diem lan 6";
            // 
            // diemlan5
            // 
            this.diemlan5.AutoSize = true;
            this.diemlan5.Location = new System.Drawing.Point(514, 109);
            this.diemlan5.Name = "diemlan5";
            this.diemlan5.Size = new System.Drawing.Size(55, 13);
            this.diemlan5.TabIndex = 14;
            this.diemlan5.Text = "diem lan 5";
            // 
            // diemlan4
            // 
            this.diemlan4.AutoSize = true;
            this.diemlan4.Location = new System.Drawing.Point(514, 83);
            this.diemlan4.Name = "diemlan4";
            this.diemlan4.Size = new System.Drawing.Size(55, 13);
            this.diemlan4.TabIndex = 13;
            this.diemlan4.Text = "diem lan 4";
            // 
            // diemlan3
            // 
            this.diemlan3.AutoSize = true;
            this.diemlan3.Location = new System.Drawing.Point(514, 56);
            this.diemlan3.Name = "diemlan3";
            this.diemlan3.Size = new System.Drawing.Size(55, 13);
            this.diemlan3.TabIndex = 12;
            this.diemlan3.Text = "diem lan 3";
            // 
            // diemlan2
            // 
            this.diemlan2.AutoSize = true;
            this.diemlan2.Location = new System.Drawing.Point(514, 26);
            this.diemlan2.Name = "diemlan2";
            this.diemlan2.Size = new System.Drawing.Size(55, 13);
            this.diemlan2.TabIndex = 11;
            this.diemlan2.Text = "diem lan 2";
            // 
            // diemlan1
            // 
            this.diemlan1.AutoSize = true;
            this.diemlan1.Location = new System.Drawing.Point(514, 0);
            this.diemlan1.Name = "diemlan1";
            this.diemlan1.Size = new System.Drawing.Size(55, 13);
            this.diemlan1.TabIndex = 10;
            this.diemlan1.Text = "diem lan 1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(210, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 10);
            this.label2.TabIndex = 17;
            // 
            // checker
            // 
            this.checker.AutoSize = true;
            this.checker.Location = new System.Drawing.Point(54, 9);
            this.checker.Name = "checker";
            this.checker.Size = new System.Drawing.Size(35, 13);
            this.checker.TabIndex = 18;
            this.checker.Text = "label2";
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // TestMoving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 550);
            this.Controls.Add(this.checker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diemlan7);
            this.Controls.Add(this.diemlan6);
            this.Controls.Add(this.diemlan5);
            this.Controls.Add(this.diemlan4);
            this.Controls.Add(this.diemlan3);
            this.Controls.Add(this.diemlan2);
            this.Controls.Add(this.diemlan1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestMoving";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestMoving";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TestMoving_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button speedDown;
        private System.Windows.Forms.Button speedUp;
        private System.Windows.Forms.Label diemlan7;
        private System.Windows.Forms.Label diemlan6;
        private System.Windows.Forms.Label diemlan5;
        private System.Windows.Forms.Label diemlan4;
        private System.Windows.Forms.Label diemlan3;
        private System.Windows.Forms.Label diemlan2;
        private System.Windows.Forms.Label diemlan1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label checker;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}