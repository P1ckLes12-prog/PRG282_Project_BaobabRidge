namespace PRG282_Project_BaobabRidge
{
    partial class frmViewAnimals
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
            dgvViewAnimals = new DataGridView();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvViewAnimals).BeginInit();
            SuspendLayout();
            // 
            // dgvViewAnimals
            // 
            dgvViewAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewAnimals.Location = new Point(31, 36);
            dgvViewAnimals.Name = "dgvViewAnimals";
            dgvViewAnimals.Size = new Size(697, 305);
            dgvViewAnimals.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(348, 360);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 2;
            label1.Text = "All Animals in Care";
            // 
            // frmViewAnimals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 395);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgvViewAnimals);
            Name = "frmViewAnimals";
            Text = "frmViewAnimals";
            Load += frmViewAnimals_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvViewAnimals;
        private Button btnBack;
        private Label label1;
    }
}