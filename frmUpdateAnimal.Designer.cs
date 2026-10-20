namespace PRG282_Project_BaobabRidge
{
    partial class frmUpdateAnimal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblUpdateHeader = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            txtAnimalID = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtRecoveryScore = new TextBox();
            btnSaveChanges = new Button();
            dgvDisp = new DataGridView();
            btnDispAll = new Button();
            btnBack = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDisp).BeginInit();
            SuspendLayout();
            // 
            // lblUpdateHeader
            // 
            lblUpdateHeader.AutoSize = true;
            lblUpdateHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblUpdateHeader.Location = new Point(233, 9);
            lblUpdateHeader.Margin = new Padding(4, 0, 4, 0);
            lblUpdateHeader.Name = "lblUpdateHeader";
            lblUpdateHeader.Size = new Size(287, 30);
            lblUpdateHeader.TabIndex = 0;
            lblUpdateHeader.Text = "Update an Animals Record";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl1.Location = new Point(17, 93);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(57, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "AnimalID";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl2.Location = new Point(17, 115);
            lbl2.Margin = new Padding(2, 0, 2, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(39, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Name";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl3.Location = new Point(17, 145);
            lbl3.Margin = new Padding(2, 0, 2, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(45, 15);
            lbl3.TabIndex = 3;
            lbl3.Text = "Species";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl4.Location = new Point(17, 172);
            lbl4.Margin = new Padding(2, 0, 2, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(64, 15);
            lbl4.TabIndex = 4;
            lbl4.Text = "Age(years)";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl5.Location = new Point(17, 202);
            lbl5.Margin = new Padding(2, 0, 2, 0);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(82, 15);
            lbl5.TabIndex = 5;
            lbl5.Text = "Recovery score";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Font = new Font("Segoe UI", 9F);
            txtAnimalID.Location = new Point(117, 90);
            txtAnimalID.Margin = new Padding(2);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(175, 23);
            txtAnimalID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.Location = new Point(117, 115);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 7;
            // 
            // txtSpecies
            // 
            txtSpecies.Font = new Font("Segoe UI", 9F);
            txtSpecies.Location = new Point(117, 145);
            txtSpecies.Margin = new Padding(2);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(175, 23);
            txtSpecies.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9F);
            txtAge.Location = new Point(117, 172);
            txtAge.Margin = new Padding(2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(175, 23);
            txtAge.TabIndex = 9;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Font = new Font("Segoe UI", 9F);
            txtRecoveryScore.Location = new Point(117, 199);
            txtRecoveryScore.Margin = new Padding(2);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(175, 23);
            txtRecoveryScore.TabIndex = 10;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveChanges.Location = new Point(117, 236);
            btnSaveChanges.Margin = new Padding(2);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(65, 24);
            btnSaveChanges.TabIndex = 11;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click_1;
            // 
            // dgvDisp
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDisp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDisp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDisp.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDisp.Location = new Point(331, 93);
            dgvDisp.Margin = new Padding(2);
            dgvDisp.Name = "dgvDisp";
            dgvDisp.RowHeadersWidth = 51;
            dgvDisp.Size = new Size(435, 129);
            dgvDisp.TabIndex = 12;
            dgvDisp.CellClick += dgvDisp_CellClick;
            // 
            // btnDispAll
            // 
            btnDispAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDispAll.Location = new Point(473, 237);
            btnDispAll.Name = "btnDispAll";
            btnDispAll.Size = new Size(130, 23);
            btnDispAll.TabIndex = 13;
            btnDispAll.Text = "DisplayAll/Refresh";
            btnDispAll.UseVisualStyleBackColor = true;
            btnDispAll.Click += btnDispAll_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(662, 237);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(103, 23);
            btnBack.TabIndex = 14;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.Location = new Point(331, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(117, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(175, 23);
            txtSearch.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 45);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 17;
            label1.Text = "Enter AnimalID";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(331, 237);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 26);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmUpdateAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 285);
            Controls.Add(btnClear);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnBack);
            Controls.Add(btnDispAll);
            Controls.Add(dgvDisp);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtRecoveryScore);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(txtAnimalID);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lblUpdateHeader);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdateAnimal";
            Text = "BaobabRidge - Update";
            Load += frmUpdateAnimal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblUpdateHeader;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        private TextBox txtAnimalID;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private TextBox txtRecoveryScore;
        private Button btnSaveChanges;
        private DataGridView dgvDisp;
        private Button btnDispAll;
        private Button btnBack;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Button btnClear;
    }
}