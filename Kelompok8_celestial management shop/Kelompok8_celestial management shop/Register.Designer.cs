using Kelompok8_Book;

namespace Kelompok8_celestial_management_shop
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            LoginBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            UnameTb = new TextBox();
            UPassTb = new TextBox();
            RegisterBtn = new Button();
            label5 = new Label();
            PhoneTb = new TextBox();
            label7 = new Label();
            AddTb = new TextBox();
            label8 = new Label();
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
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.CadetBlue;
            LoginBtn.ForeColor = SystemColors.ButtonHighlight;
            LoginBtn.Location = new Point(574, 480);
            LoginBtn.Margin = new Padding(2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(90, 39);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Cancel";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(441, 224);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 2;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(440, 388);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // UnameTb
            // 
            UnameTb.BackColor = SystemColors.Info;
            UnameTb.Location = new Point(553, 224);
            UnameTb.Margin = new Padding(2);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(150, 27);
            UnameTb.TabIndex = 4;
            // 
            // UPassTb
            // 
            UPassTb.BackColor = SystemColors.Info;
            UPassTb.Location = new Point(553, 386);
            UPassTb.Margin = new Padding(2);
            UPassTb.Name = "UPassTb";
            UPassTb.Size = new Size(150, 27);
            UPassTb.TabIndex = 5;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.CadetBlue;
            RegisterBtn.ForeColor = SystemColors.ButtonHighlight;
            RegisterBtn.Location = new Point(465, 480);
            RegisterBtn.Margin = new Padding(2);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(90, 39);
            RegisterBtn.TabIndex = 6;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Old English Text MT", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(447, 86);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(257, 71);
            label5.TabIndex = 8;
            label5.Text = "Sign Up";
            // 
            // PhoneTb
            // 
            PhoneTb.BackColor = SystemColors.Info;
            PhoneTb.Location = new Point(553, 277);
            PhoneTb.Margin = new Padding(2);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(150, 27);
            PhoneTb.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(441, 277);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 10;
            label7.Text = "Phone :";
            // 
            // AddTb
            // 
            AddTb.BackColor = SystemColors.Info;
            AddTb.Location = new Point(553, 333);
            AddTb.Margin = new Padding(2);
            AddTb.Name = "AddTb";
            AddTb.Size = new Size(150, 27);
            AddTb.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(441, 333);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(91, 22);
            label8.TabIndex = 12;
            label8.Text = "Address :";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(761, 625);
            Controls.Add(AddTb);
            Controls.Add(label8);
            Controls.Add(PhoneTb);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(RegisterBtn);
            Controls.Add(UPassTb);
            Controls.Add(UnameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Register";
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
        private Label label2;
        private Label label3;
        private TextBox UnameTb;
        private TextBox UPassTb;
        private Button RegisterBtn;
        private Label label5;
        private TextBox PhoneTb;
        private Label label7;
        private TextBox AddTb;
        private Label label8;
    }
}