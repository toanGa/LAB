namespace VirtualPort.Booling
{
    partial class Draw
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
            this.nutVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nutVe
            // 
            this.nutVe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nutVe.Location = new System.Drawing.Point(13, 13);
            this.nutVe.Name = "nutVe";
            this.nutVe.Size = new System.Drawing.Size(97, 30);
            this.nutVe.TabIndex = 0;
            this.nutVe.Text = "draw";
            this.nutVe.UseVisualStyleBackColor = false;
            this.nutVe.Click += new System.EventHandler(this.nutVe_Click);
            // 
            // Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 437);
            this.Controls.Add(this.nutVe);
            this.Name = "Draw";
            this.Text = "Draw";
            this.Load += new System.EventHandler(this.Draw_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nutVe;
    }
}