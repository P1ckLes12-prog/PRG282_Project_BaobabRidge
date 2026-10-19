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
            btnUpdate = new Button();
            dgvDisp = new DataGridView();
            btnDispAll = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDisp).BeginInit();
            SuspendLayout();
            // 
            // lblUpdateHeader
            // 
            lblUpdateHeader.AutoSize = true;
            lblUpdateHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblUpdateHeader.Location = new Point(266, 12);
            lblUpdateHeader.Margin = new Padding(5, 0, 5, 0);
            lblUpdateHeader.Name = "lblUpdateHeader";
            lblUpdateHeader.Size = new Size(357, 37);
            lblUpdateHeader.TabIndex = 0;
            lblUpdateHeader.Text = "Update an Animals Record";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl1.Location = new Point(19, 56);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(70, 20);
            lbl1.TabIndex = 1;
            lbl1.Text = "AnimalID";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl2.Location = new Point(19, 88);
            lbl2.Margin = new Padding(2, 0, 2, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(48, 20);
            lbl2.TabIndex = 2;
            lbl2.Text = "Name";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl3.Location = new Point(19, 128);
            lbl3.Margin = new Padding(2, 0, 2, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(55, 20);
            lbl3.TabIndex = 3;
            lbl3.Text = "Species";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl4.Location = new Point(19, 164);
            lbl4.Margin = new Padding(2, 0, 2, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(76, 20);
            lbl4.TabIndex = 4;
            lbl4.Text = "Age(years)";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl5.Location = new Point(19, 204);
            lbl5.Margin = new Padding(2, 0, 2, 0);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(103, 20);
            lbl5.TabIndex = 5;
            lbl5.Text = "Recovery score";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Font = new Font("Segoe UI", 9F);
            txtAnimalID.Location = new Point(134, 52);
            txtAnimalID.Margin = new Padding(2, 3, 2, 3);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(199, 27);
            txtAnimalID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.Location = new Point(134, 88);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 27);
            txtName.TabIndex = 7;
            // 
            // txtSpecies
            // 
            txtSpecies.Font = new Font("Segoe UI", 9F);
            txtSpecies.Location = new Point(134, 128);
            txtSpecies.Margin = new Padding(2, 3, 2, 3);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(199, 27);
            txtSpecies.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9F);
            txtAge.Location = new Point(134, 164);
            txtAge.Margin = new Padding(2, 3, 2, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(199, 27);
            txtAge.TabIndex = 9;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Font = new Font("Segoe UI", 9F);
            txtRecoveryScore.Location = new Point(134, 200);
            txtRecoveryScore.Margin = new Padding(2, 3, 2, 3);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(199, 27);
            txtRecoveryScore.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(134, 249);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(74, 32);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
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
            dgvDisp.Location = new Point(378, 59);
            dgvDisp.Margin = new Padding(2, 3, 2, 3);
            dgvDisp.Name = "dgvDisp";
            dgvDisp.RowHeadersWidth = 51;
            dgvDisp.Size = new Size(497, 172);
            dgvDisp.TabIndex = 12;
            dgvDisp.CellClick += dgvDisp_CellClick;
            // 
            // btnDispAll
            // 
            btnDispAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDispAll.Location = new Point(541, 251);
            btnDispAll.Margin = new Padding(3, 4, 3, 4);
            btnDispAll.Name = "btnDispAll";
            btnDispAll.Size = new Size(149, 31);
            btnDispAll.TabIndex = 13;
            btnDispAll.Text = "DisplayAll/Refresh";
            btnDispAll.UseVisualStyleBackColor = true;
            btnDispAll.Click += btnDispAll_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(789, 251);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 14;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmUpdateAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 317);
            Controls.Add(btnBack);
            Controls.Add(btnDispAll);
            Controls.Add(dgvDisp);
            Controls.Add(btnUpdate);
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
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdateAnimal";
            Text = "BaobabRidge - Update";
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
        private Button btnUpdate;
        private DataGridView dgvDisp;
        private Button btnDispAll;
        private Button btnBack;
    }
}