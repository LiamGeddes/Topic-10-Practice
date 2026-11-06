namespace Topic_10_Practice
{
    partial class Form1
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
            this.imgMarioSleep1 = new System.Windows.Forms.PictureBox();
            this.imgMario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMarioSleep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMarioSleep1
            // 
            this.imgMarioSleep1.Image = global::Topic_10_Practice.Properties.Resources.MarioAsleep;
            this.imgMarioSleep1.Location = new System.Drawing.Point(231, 36);
            this.imgMarioSleep1.Name = "imgMarioSleep1";
            this.imgMarioSleep1.Size = new System.Drawing.Size(100, 50);
            this.imgMarioSleep1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMarioSleep1.TabIndex = 1;
            this.imgMarioSleep1.TabStop = false;
            this.imgMarioSleep1.Click += new System.EventHandler(this.imgMarioSleep_Click);
            // 
            // imgMario
            // 
            this.imgMario.Image = global::Topic_10_Practice.Properties.Resources.MarioAsleep;
            this.imgMario.Location = new System.Drawing.Point(37, 36);
            this.imgMario.Name = "imgMario";
            this.imgMario.Size = new System.Drawing.Size(100, 50);
            this.imgMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMario.TabIndex = 0;
            this.imgMario.TabStop = false;
            this.imgMario.Click += new System.EventHandler(this.imgMario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 132);
            this.Controls.Add(this.imgMarioSleep1);
            this.Controls.Add(this.imgMario);
            this.Name = "Form1";
            this.Text = "Resources";
            ((System.ComponentModel.ISupportInitialize)(this.imgMarioSleep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMario;
        private System.Windows.Forms.PictureBox imgMarioSleep1;
    }
}

