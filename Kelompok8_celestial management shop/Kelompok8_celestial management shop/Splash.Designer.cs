using System.Drawing;
using System.Windows.Forms;

namespace Kelompok8_Book
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            label2 = new Label();
            myprogress = new ProgressBar();
            persen = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(291, 409);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 24);
            label1.TabIndex = 2;
            label1.Text = "Loading...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Old English Text MT", 16F, FontStyle.Bold);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(149, 358);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(411, 32);
            label2.TabIndex = 3;
            label2.Text = "Book Shop Management System";
            // 
            // myprogress
            // 
            myprogress.BackColor = Color.CadetBlue;
            myprogress.Location = new Point(27, 437);
            myprogress.Margin = new Padding(3, 4, 3, 4);
            myprogress.Name = "myprogress";
            myprogress.Size = new Size(642, 29);
            myprogress.TabIndex = 5;
            // 
            // persen
            // 
            persen.AutoSize = true;
            persen.BackColor = Color.Transparent;
            persen.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic);
            persen.ForeColor = Color.CadetBlue;
            persen.Location = new Point(377, 409);
            persen.Name = "persen";
            persen.Size = new Size(24, 24);
            persen.TabIndex = 6;
            persen.Text = "%";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, 67);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Salmon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(711, 474);
            Controls.Add(pictureBox1);
            Controls.Add(persen);
            Controls.Add(myprogress);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ProgressBar myprogress;
        
        private Label persen;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

