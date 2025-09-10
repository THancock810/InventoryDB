namespace InventoryDB
{
    partial class Main
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
            DGV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            splitContainer = new SplitContainer();
            pictureBox1 = new PictureBox();
            txtItemDesc = new TextBox();
            txtSerialNumber = new TextBox();
            txtItemName = new TextBox();
            lblItemImg = new Label();
            lblItemDesc = new Label();
            lblSerialNum = new Label();
            lblItemName = new Label();
            lblAddtitle = new Label();
            txtSearch = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToResizeRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Dock = DockStyle.Fill;
            DGV.EditMode = DataGridViewEditMode.EditOnKeystroke;
            DGV.Location = new Point(0, 0);
            DGV.Name = "DGV";
            DGV.RowHeadersVisible = false;
            DGV.Size = new Size(984, 210);
            DGV.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 13);
            button1.Name = "button1";
            button1.Size = new Size(57, 24);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 13);
            button2.Name = "button2";
            button2.Size = new Size(57, 24);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(pictureBox1);
            splitContainer.Panel1.Controls.Add(txtItemDesc);
            splitContainer.Panel1.Controls.Add(txtSerialNumber);
            splitContainer.Panel1.Controls.Add(txtItemName);
            splitContainer.Panel1.Controls.Add(lblItemImg);
            splitContainer.Panel1.Controls.Add(lblItemDesc);
            splitContainer.Panel1.Controls.Add(lblSerialNum);
            splitContainer.Panel1.Controls.Add(lblItemName);
            splitContainer.Panel1.Controls.Add(lblAddtitle);
            splitContainer.Panel1.Controls.Add(txtSearch);
            splitContainer.Panel1.Controls.Add(button3);
            splitContainer.Panel1.Controls.Add(button1);
            splitContainer.Panel1.Controls.Add(button2);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(DGV);
            splitContainer.Size = new Size(984, 761);
            splitContainer.SplitterDistance = 550;
            splitContainer.SplitterWidth = 1;
            splitContainer.TabIndex = 3;
            splitContainer.SizeChanged += splitContainer_SizeChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(500, 207);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 306);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txtItemDesc
            // 
            txtItemDesc.Anchor = AnchorStyles.Top;
            txtItemDesc.Location = new Point(60, 410);
            txtItemDesc.Multiline = true;
            txtItemDesc.Name = "txtItemDesc";
            txtItemDesc.Size = new Size(278, 103);
            txtItemDesc.TabIndex = 12;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Anchor = AnchorStyles.Top;
            txtSerialNumber.Location = new Point(60, 321);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(278, 23);
            txtSerialNumber.TabIndex = 11;
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.Top;
            txtItemName.Location = new Point(60, 206);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(278, 23);
            txtItemName.TabIndex = 10;
            // 
            // lblItemImg
            // 
            lblItemImg.Anchor = AnchorStyles.Top;
            lblItemImg.AutoSize = true;
            lblItemImg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemImg.Location = new Point(500, 183);
            lblItemImg.Name = "lblItemImg";
            lblItemImg.Size = new Size(162, 21);
            lblItemImg.TabIndex = 9;
            lblItemImg.Text = "Item Image (Optional)";
            // 
            // lblItemDesc
            // 
            lblItemDesc.Anchor = AnchorStyles.Top;
            lblItemDesc.AutoSize = true;
            lblItemDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemDesc.Location = new Point(60, 386);
            lblItemDesc.Name = "lblItemDesc";
            lblItemDesc.Size = new Size(198, 21);
            lblItemDesc.TabIndex = 8;
            lblItemDesc.Text = "Item Description (Optional)";
            // 
            // lblSerialNum
            // 
            lblSerialNum.Anchor = AnchorStyles.Top;
            lblSerialNum.AutoSize = true;
            lblSerialNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSerialNum.Location = new Point(60, 297);
            lblSerialNum.Name = "lblSerialNum";
            lblSerialNum.Size = new Size(136, 21);
            lblSerialNum.TabIndex = 7;
            lblSerialNum.Text = "Serial # (Optional)";
            // 
            // lblItemName
            // 
            lblItemName.Anchor = AnchorStyles.Top;
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemName.Location = new Point(60, 182);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(87, 21);
            lblItemName.TabIndex = 6;
            lblItemName.Text = "Item Name";
            // 
            // lblAddtitle
            // 
            lblAddtitle.Anchor = AnchorStyles.Top;
            lblAddtitle.AutoSize = true;
            lblAddtitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblAddtitle.Location = new Point(360, 94);
            lblAddtitle.Name = "lblAddtitle";
            lblAddtitle.Size = new Size(239, 65);
            lblAddtitle.TabIndex = 5;
            lblAddtitle.Text = "Add Item";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(478, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(494, 23);
            txtSearch.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(174, 13);
            button3.Name = "button3";
            button3.Size = new Size(57, 24);
            button3.TabIndex = 3;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(splitContainer);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private SplitContainer splitContainer;
        private DataGridView DGV;
        private Button button3;
        private TextBox txtSearch;
        private Label lblAddtitle;
        private TextBox txtItemDesc;
        private TextBox txtSerialNumber;
        private TextBox txtItemName;
        private Label lblItemImg;
        private Label lblItemDesc;
        private Label lblSerialNum;
        private Label lblItemName;
        private PictureBox pictureBox1;
    }
}