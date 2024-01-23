namespace Kelompok8_celestial_management_shop
{
    partial class user_bookshop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_bookshop));
            label1 = new Label();
            label2 = new Label();
            UserNameLb = new Label();
            label4 = new Label();
            BTitleTb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            PrintBill = new Button();
            QtyTb = new TextBox();
            PriceTb = new TextBox();
            ClientNameTb = new TextBox();
            ResetBtn = new Button();
            SaveBtn = new Button();
            BillDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            BookDGV = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            TotalBill = new Label();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Old English Text MT", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(73, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 1;
            label1.Text = "CMS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(71, 565);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Logout";
            label2.Click += label2_Click;
            // 
            // UserNameLb
            // 
            UserNameLb.AutoSize = true;
            UserNameLb.BackColor = Color.Transparent;
            UserNameLb.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            UserNameLb.ForeColor = Color.DarkSlateGray;
            UserNameLb.Location = new Point(366, 45);
            UserNameLb.Margin = new Padding(2, 0, 2, 0);
            UserNameLb.Name = "UserNameLb";
            UserNameLb.Size = new Size(101, 18);
            UserNameLb.TabIndex = 4;
            UserNameLb.Text = "Lorem Ipsum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 9F);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(55, 132);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 5;
            label4.Text = "Book Name";
            // 
            // BTitleTb
            // 
            BTitleTb.Enabled = false;
            BTitleTb.Location = new Point(58, 158);
            BTitleTb.Margin = new Padding(2);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(161, 27);
            BTitleTb.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 9F);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(55, 277);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 7;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 9F);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(55, 350);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 9;
            label6.Text = "Client Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 9F);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(56, 203);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 11;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(302, 346);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 18);
            label8.TabIndex = 13;
            label8.Text = "Book List";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(301, 96);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(77, 18);
            label9.TabIndex = 17;
            label9.Text = "Book Bills";
            // 
            // PrintBill
            // 
            PrintBill.BackColor = Color.CadetBlue;
            PrintBill.Location = new Point(668, 325);
            PrintBill.Margin = new Padding(2);
            PrintBill.Name = "PrintBill";
            PrintBill.Size = new Size(120, 38);
            PrintBill.TabIndex = 22;
            PrintBill.Text = "Print";
            PrintBill.UseVisualStyleBackColor = false;
            PrintBill.Click += PrintBill_Click;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(58, 304);
            QtyTb.Margin = new Padding(2);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(161, 27);
            QtyTb.TabIndex = 23;
            // 
            // PriceTb
            // 
            PriceTb.Enabled = false;
            PriceTb.Location = new Point(58, 231);
            PriceTb.Margin = new Padding(2);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(161, 27);
            PriceTb.TabIndex = 25;
            // 
            // ClientNameTb
            // 
            ClientNameTb.Location = new Point(58, 379);
            ClientNameTb.Margin = new Padding(2);
            ClientNameTb.Name = "ClientNameTb";
            ClientNameTb.Size = new Size(161, 27);
            ClientNameTb.TabIndex = 24;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.LightBlue;
            ResetBtn.Font = new Font("Segoe UI", 8F);
            ResetBtn.Location = new Point(106, 493);
            ResetBtn.Margin = new Padding(2);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(55, 27);
            ResetBtn.TabIndex = 43;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = SystemColors.ButtonFace;
            SaveBtn.Font = new Font("Segoe UI", 8F);
            SaveBtn.Location = new Point(74, 453);
            SaveBtn.Margin = new Padding(2);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(120, 27);
            SaveBtn.TabIndex = 42;
            SaveBtn.Text = "Add To Bill";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // BillDGV
            // 
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            BillDGV.Location = new Point(303, 123);
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersWidth = 51;
            BillDGV.Size = new Size(485, 196);
            BillDGV.TabIndex = 44;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Books";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // BookDGV
            // 
            BookDGV.AllowUserToOrderColumns = true;
            BookDGV.BackgroundColor = SystemColors.ActiveCaption;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDGV.GridColor = SystemColors.HotTrack;
            BookDGV.Location = new Point(303, 375);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersWidth = 51;
            BookDGV.Size = new Size(485, 247);
            BookDGV.TabIndex = 52;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // TotalBill
            // 
            TotalBill.AutoSize = true;
            TotalBill.BackColor = Color.Transparent;
            TotalBill.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalBill.ForeColor = Color.DarkSlateGray;
            TotalBill.Location = new Point(560, 334);
            TotalBill.Margin = new Padding(2, 0, 2, 0);
            TotalBill.Name = "TotalBill";
            TotalBill.Size = new Size(46, 19);
            TotalBill.TabIndex = 21;
            TotalBill.Text = "Total";
            TotalBill.TextAlign = ContentAlignment.TopRight;
            // 
            // user_bookshop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 629);
            Controls.Add(BookDGV);
            Controls.Add(BillDGV);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(PriceTb);
            Controls.Add(ClientNameTb);
            Controls.Add(QtyTb);
            Controls.Add(PrintBill);
            Controls.Add(TotalBill);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BTitleTb);
            Controls.Add(label4);
            Controls.Add(UserNameLb);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "user_bookshop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "user_bookshop_3";
            Load += user_bookshop_Load;
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label UserNameLb;
        private Label label4;
        private TextBox BTitleTb;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button PrintBill;
        private TextBox QtyTb;
        private TextBox PriceTb;
        private TextBox ClientNameTb;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private Button ResetBtn;
        private Button SaveBtn;
        private DataGridView BillDGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView BookDGV;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label TotalBill;
    }
}