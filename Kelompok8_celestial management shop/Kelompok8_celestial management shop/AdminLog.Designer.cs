namespace Kelompok8_celestial_management_shop
{
    partial class AdminLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLog));
            label1 = new Label();
            label3 = new Label();
            UPassTb = new TextBox();
            RegisterBtn = new Button();
            label5 = new Label();
            Cencel = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Old English Text MT", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(89, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "CMS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(438, 341);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // UPassTb
            // 
            UPassTb.BackColor = SystemColors.Info;
            UPassTb.Location = new Point(559, 341);
            UPassTb.Margin = new Padding(2);
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '*';
            UPassTb.Size = new Size(150, 27);
            UPassTb.TabIndex = 5;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.CadetBlue;
            RegisterBtn.ForeColor = SystemColors.ButtonHighlight;
            RegisterBtn.Location = new Point(473, 445);
            RegisterBtn.Margin = new Padding(2);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(90, 39);
            RegisterBtn.TabIndex = 6;
            RegisterBtn.Text = "Login";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Old English Text MT", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(428, 110);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(320, 120);
            label5.TabIndex = 8;
            label5.Text = "Login \r\nAdministrator";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cencel
            // 
            Cencel.BackColor = Color.CadetBlue;
            Cencel.ForeColor = SystemColors.ButtonHighlight;
            Cencel.Location = new Point(578, 445);
            Cencel.Margin = new Padding(2);
            Cencel.Name = "Cencel";
            Cencel.Size = new Size(90, 39);
            Cencel.TabIndex = 10;
            Cencel.Text = "Cencel";
            Cencel.UseVisualStyleBackColor = false;
            Cencel.Click += Cencel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(492, 248);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 17);
            label2.TabIndex = 11;
            label2.Text = "Enter your password to login";
            // 
            // AdminLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(761, 625);
            Controls.Add(label2);
            Controls.Add(Cencel);
            Controls.Add(label5);
            Controls.Add(RegisterBtn);
            Controls.Add(UPassTb);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AdminLog";
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
        private Label label3;
        private TextBox UPassTb;
        private Button RegisterBtn;
        private Label label5;
        private Button Cencel;
        private Label label2;
    }
}