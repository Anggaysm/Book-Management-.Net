using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace Kelompok8_Book
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            LoginBtn = new Button();
            RegisterBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            UPassTb = new TextBox();
            label3 = new Label();
            UnameTb = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Old English Text MT", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(91, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "CMS";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.CadetBlue;
            LoginBtn.ForeColor = SystemColors.ButtonHighlight;
            LoginBtn.Location = new Point(471, 421);
            LoginBtn.Margin = new Padding(2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(90, 39);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.CadetBlue;
            RegisterBtn.ForeColor = SystemColors.ButtonHighlight;
            RegisterBtn.Location = new Point(584, 421);
            RegisterBtn.Margin = new Padding(2);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(90, 39);
            RegisterBtn.TabIndex = 6;
            RegisterBtn.Text = "Sign Up";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new System.Drawing.Font("Goudy Old Style", 10F, FontStyle.Bold);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(539, 488);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 7;
            label4.Text = "Admin";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new System.Drawing.Font("Old English Text MT", 19.8000011F, FontStyle.Bold);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(423, 108);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(326, 40);
            label5.TabIndex = 8;
            label5.Text = "Expand Your Mind, ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new System.Drawing.Font("Old English Text MT", 19.8000011F, FontStyle.Bold);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(448, 152);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(257, 40);
            label6.TabIndex = 9;
            label6.Text = "Reading a Book";
            // 
            // UPassTb
            // 
            UPassTb.BackColor = SystemColors.Info;
            UPassTb.Location = new Point(562, 312);
            UPassTb.Margin = new Padding(2);
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '*';
            UPassTb.Size = new Size(150, 27);
            UPassTb.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(438, 314);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // UnameTb
            // 
            UnameTb.BackColor = SystemColors.Info;
            UnameTb.Location = new Point(562, 262);
            UnameTb.Margin = new Padding(2);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(150, 27);
            UnameTb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(439, 262);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 2;
            label2.Text = "Username :";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(761, 625);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(RegisterBtn);
            Controls.Add(UPassTb);
            Controls.Add(UnameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Button LoginBtn;
        private Button RegisterBtn;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox UPassTb;
        private Label label3;
        private TextBox UnameTb;
        private Label label2;
    }
}