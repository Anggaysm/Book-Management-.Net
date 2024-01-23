namespace Kelompok8_celestial_management_shop
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            label1 = new Label();
            BTitleTb = new TextBox();
            BAuthorTb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            QtyTb = new TextBox();
            PriceTb = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ResetBtn = new Button();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            label10 = new Label();
            label11 = new Label();
            ResetFilter = new Button();
            label12 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BCatCb = new ComboBox();
            BookDGV = new DataGridView();
            CatTbSearchTb = new ComboBox();
            IdBook = new Label();
            BId = new TextBox();
            editBtn = new Button();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Old English Text MT", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(70, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 9;
            label1.Text = "CMS";
            // 
            // BTitleTb
            // 
            BTitleTb.Location = new Point(289, 40);
            BTitleTb.Margin = new Padding(2);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(140, 27);
            BTitleTb.TabIndex = 27;
            // 
            // BAuthorTb
            // 
            BAuthorTb.Location = new Point(445, 39);
            BAuthorTb.Margin = new Padding(2);
            BAuthorTb.Name = "BAuthorTb";
            BAuthorTb.Size = new Size(144, 27);
            BAuthorTb.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 9F);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(284, 17);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 30;
            label5.Text = "Book Title";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 9F);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(442, 18);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 31;
            label6.Text = "Author";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 9F);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(607, 20);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 32;
            label7.Text = "Categories";
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(289, 103);
            QtyTb.Margin = new Padding(2);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(140, 27);
            QtyTb.TabIndex = 33;
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(445, 104);
            PriceTb.Margin = new Padding(2);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(144, 27);
            PriceTb.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 9F);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(284, 81);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 35;
            label8.Text = "Quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 9F);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(442, 83);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 36;
            label9.Text = "Price";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = SystemColors.ButtonFace;
            ResetBtn.Font = new Font("Segoe UI", 8F);
            ResetBtn.Location = new Point(668, 106);
            ResetBtn.Margin = new Padding(2);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(53, 27);
            ResetBtn.TabIndex = 41;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.ButtonFace;
            DeleteBtn.Font = new Font("Segoe UI", 8F);
            DeleteBtn.Location = new Point(568, 183);
            DeleteBtn.Margin = new Padding(2);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(60, 27);
            DeleteBtn.TabIndex = 40;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = SystemColors.ButtonFace;
            SaveBtn.Font = new Font("Segoe UI", 8F);
            SaveBtn.Location = new Point(612, 106);
            SaveBtn.Margin = new Padding(2);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(52, 27);
            SaveBtn.TabIndex = 38;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 9F);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(394, 288);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(513, 231);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(71, 18);
            label11.TabIndex = 43;
            label11.Text = "Book List";
            // 
            // ResetFilter
            // 
            ResetFilter.BackColor = SystemColors.ButtonFace;
            ResetFilter.Font = new Font("Segoe UI", 8F);
            ResetFilter.Location = new Point(566, 264);
            ResetFilter.Margin = new Padding(2);
            ResetFilter.Name = "ResetFilter";
            ResetFilter.Size = new Size(62, 27);
            ResetFilter.TabIndex = 45;
            ResetFilter.Text = "Refresh";
            ResetFilter.UseVisualStyleBackColor = false;
            ResetFilter.Click += ResetFilter_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 9F);
            label12.ForeColor = Color.DarkSlateGray;
            label12.Location = new Point(70, 564);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 49;
            label12.Text = "Logout";
            label12.Click += label12_Click;
            // 
            // BCatCb
            // 
            BCatCb.FormattingEnabled = true;
            BCatCb.Items.AddRange(new object[] { "Sastra", "Komik", "Novel", "Fiksi", "Non Fiksi", "Fantasi", "Bisnis & Ekonomi " });
            BCatCb.Location = new Point(609, 40);
            BCatCb.Name = "BCatCb";
            BCatCb.Size = new Size(171, 28);
            BCatCb.TabIndex = 50;
            BCatCb.Text = "pilih";
            // 
            // BookDGV
            // 
            BookDGV.AllowUserToOrderColumns = true;
            BookDGV.BackgroundColor = SystemColors.ActiveCaption;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDGV.GridColor = SystemColors.HotTrack;
            BookDGV.Location = new Point(301, 309);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersWidth = 51;
            BookDGV.Size = new Size(462, 273);
            BookDGV.TabIndex = 51;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // CatTbSearchTb
            // 
            CatTbSearchTb.FormattingEnabled = true;
            CatTbSearchTb.Items.AddRange(new object[] { "mtk", "bahasa", "ips", "ipa", "budaya" });
            CatTbSearchTb.Location = new Point(445, 264);
            CatTbSearchTb.Name = "CatTbSearchTb";
            CatTbSearchTb.Size = new Size(116, 28);
            CatTbSearchTb.TabIndex = 52;
            CatTbSearchTb.Text = "pilih";
            CatTbSearchTb.SelectionChangeCommitted += CatTbSearchTb_SelectionChangeCommitted;
            // 
            // IdBook
            // 
            IdBook.AutoSize = true;
            IdBook.BackColor = Color.Transparent;
            IdBook.Font = new Font("Century Gothic", 9F);
            IdBook.ForeColor = Color.DarkSlateGray;
            IdBook.Location = new Point(443, 159);
            IdBook.Margin = new Padding(2, 0, 2, 0);
            IdBook.Name = "IdBook";
            IdBook.Size = new Size(65, 20);
            IdBook.TabIndex = 54;
            IdBook.Text = "Book Id";
            // 
            // BId
            // 
            BId.Location = new Point(445, 183);
            BId.Margin = new Padding(2);
            BId.Name = "BId";
            BId.Size = new Size(117, 27);
            BId.TabIndex = 53;
            // 
            // editBtn
            // 
            editBtn.BackColor = SystemColors.ButtonFace;
            editBtn.Font = new Font("Segoe UI", 8F);
            editBtn.Location = new Point(725, 106);
            editBtn.Margin = new Padding(2);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(55, 27);
            editBtn.TabIndex = 55;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(120, 183);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 10;
            label4.Text = "Books";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(128, 302);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 22);
            label2.TabIndex = 11;
            label2.Text = "User";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(105, 422);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 22);
            label3.TabIndex = 12;
            label3.Text = "Dashboard";
            label3.Click += label3_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(803, 609);
            Controls.Add(editBtn);
            Controls.Add(IdBook);
            Controls.Add(BId);
            Controls.Add(CatTbSearchTb);
            Controls.Add(BookDGV);
            Controls.Add(BCatCb);
            Controls.Add(label12);
            Controls.Add(ResetFilter);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(ResetBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(PriceTb);
            Controls.Add(QtyTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BAuthorTb);
            Controls.Add(BTitleTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox BTitleTb;
        private TextBox BAuthorTb;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox QtyTb;
        private TextBox PriceTb;
        private Label label8;
        private Label label9;
        private Button ResetBtn;
        private Button DeleteBtn;
        private Button SaveBtn;
        private Label label10;
        private Label label11;
        private Button ResetFilter;
        private Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox BCatCb;
        private DataGridView BookDGV;
        private ComboBox CatTbSearchTb;
        private Label IdBook;
        private TextBox BId;
        private Button editBtn;
        private Label label4;
        private Label label2;
        private Label label3;
    }
}