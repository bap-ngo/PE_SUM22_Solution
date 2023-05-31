namespace PE_SUM22
{
    partial class Management
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
            dgvList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label4 = new Label();
            label5 = new Label();
            txtAccountId = new TextBox();
            txtAccountName = new TextBox();
            txtOpenDate = new TextBox();
            txtBranchName = new TextBox();
            btnDel = new Button();
            btnReset = new Button();
            cbTypeId = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(22, 26);
            dgvList.Margin = new Padding(6);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 82;
            dgvList.RowTemplate.Height = 25;
            dgvList.Size = new Size(1441, 316);
            dgvList.TabIndex = 0;
            dgvList.CellDoubleClick += dgvList_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 429);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 1;
            label1.Text = "AccountID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 513);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 2;
            label2.Text = "AccountName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 600);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 3;
            label3.Text = "OpenDate";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(991, 387);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(274, 39);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1288, 380);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(153, 46);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 779);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 6;
            label4.Text = "TypeID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 695);
            label5.Name = "label5";
            label5.Size = new Size(151, 32);
            label5.TabIndex = 7;
            label5.Text = "BranchName";
            // 
            // txtAccountId
            // 
            txtAccountId.Location = new Point(282, 423);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.Size = new Size(477, 39);
            txtAccountId.TabIndex = 8;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(282, 510);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(477, 39);
            txtAccountName.TabIndex = 9;
            // 
            // txtOpenDate
            // 
            txtOpenDate.Location = new Point(282, 593);
            txtOpenDate.Name = "txtOpenDate";
            txtOpenDate.Size = new Size(477, 39);
            txtOpenDate.TabIndex = 10;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(282, 688);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(477, 39);
            txtBranchName.TabIndex = 11;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(991, 513);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 46);
            btnDel.TabIndex = 13;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(609, 771);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // cbTypeId
            // 
            cbTypeId.FormattingEnabled = true;
            cbTypeId.Location = new Point(282, 771);
            cbTypeId.Name = "cbTypeId";
            cbTypeId.Size = new Size(242, 40);
            cbTypeId.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1253, 513);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(991, 627);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbTypeId);
            Controls.Add(btnReset);
            Controls.Add(btnDel);
            Controls.Add(txtBranchName);
            Controls.Add(txtOpenDate);
            Controls.Add(txtAccountName);
            Controls.Add(txtAccountId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvList);
            Margin = new Padding(6);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvList;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label4;
        private Label label5;
        private TextBox txtAccountId;
        private TextBox txtAccountName;
        private TextBox txtOpenDate;
        private TextBox txtBranchName;
        private TextBox txtTypeId;
        private Button btnDel;
        private Button btnReset;
        private ComboBox cbTypeId;
        private Button btnAdd;
        private Button btnUpdate;
    }
}