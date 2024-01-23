using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Kelompok8_celestial_management_shop
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            PassTb = new TextBox();
            AddTb = new TextBox();
            PhoneTb = new TextBox();
            UnameTb = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SaveBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            ResetBtn = new Button();
            label9 = new Label();
            label10 = new Label();
            UserDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Old English Text MT", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(80, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 2;
            label1.Text = "CMS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(121, 182);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 6;
            label4.Text = "Books";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(127, 302);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 22);
            label2.TabIndex = 7;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(103, 417);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 22);
            label3.TabIndex = 8;
            label3.Text = "Dashboard";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(321, 58);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Username";
            // 
            // PassTb
            // 
            PassTb.Location = new Point(560, 153);
            PassTb.Margin = new Padding(2);
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(181, 27);
            PassTb.TabIndex = 29;
            // 
            // AddTb
            // 
            AddTb.Location = new Point(323, 154);
            AddTb.Margin = new Padding(2);
            AddTb.Name = "AddTb";
            AddTb.Size = new Size(178, 27);
            AddTb.TabIndex = 28;
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(560, 84);
            PhoneTb.Margin = new Padding(2);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(181, 27);
            PhoneTb.TabIndex = 27;
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(323, 84);
            UnameTb.Margin = new Padding(2);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(178, 27);
            UnameTb.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new System.Drawing.Font("Century Gothic", 9F);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(559, 61);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 30;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(321, 127);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 31;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(558, 126);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 32;
            label8.Text = "Password";
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = SystemColors.ButtonFace;
            SaveBtn.Font = new System.Drawing.Font("Segoe UI", 8F);
            SaveBtn.Location = new Point(398, 213);
            SaveBtn.Margin = new Padding(2);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(55, 27);
            SaveBtn.TabIndex = 34;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.ButtonFace;
            EditBtn.Font = new System.Drawing.Font("Segoe UI", 8F);
            EditBtn.Location = new Point(464, 213);
            EditBtn.Margin = new Padding(2);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(55, 27);
            EditBtn.TabIndex = 35;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.ButtonFace;
            DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 8F);
            DeleteBtn.Location = new Point(528, 213);
            DeleteBtn.Margin = new Padding(2);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(63, 27);
            DeleteBtn.TabIndex = 36;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = SystemColors.ButtonFace;
            ResetBtn.Font = new System.Drawing.Font("Segoe UI", 8F);
            ResetBtn.Location = new Point(604, 213);
            ResetBtn.Margin = new Padding(2);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(55, 27);
            ResetBtn.TabIndex = 37;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(500, 263);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 19);
            label9.TabIndex = 38;
            label9.Text = "User List";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new System.Drawing.Font("Century Gothic", 9F);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(78, 563);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 42;
            label10.Text = "Logout";
            label10.Click += label10_Click;
            // 
            // UserDGV
            // 
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDGV.Location = new Point(312, 296);
            UserDGV.Name = "UserDGV";
            UserDGV.RowHeadersWidth = 51;
            UserDGV.Size = new Size(462, 287);
            UserDGV.TabIndex = 43;
            UserDGV.CellContentClick += UserDGV_CellContentClick;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(803, 609);
            Controls.Add(UserDGV);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(ResetBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PassTb);
            Controls.Add(AddTb);
            Controls.Add(PhoneTb);
            Controls.Add(UnameTb);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox PassTb;
        private TextBox AddTb;
        private TextBox PhoneTb;
        private TextBox UnameTb;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button SaveBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button ResetBtn;
        private Label label9;
        private Label label10;
        private DataGridView UserDGV;

        public EventHandler textBox4_TextChanged { get; private set; }
    }
}