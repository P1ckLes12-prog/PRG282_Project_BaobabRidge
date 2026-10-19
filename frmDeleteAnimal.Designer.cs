namespace PRG282_Project_BaobabRidge
{
    partial class frmDeleteAnimal
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
            lblDeleteHeading = new Label();
            btnDelete = new Button();
            btnBack = new Button();
            dgvDeleteDisplay = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteDisplay).BeginInit();
            SuspendLayout();
            // 
            // lblDeleteHeading
            // 
            lblDeleteHeading.AutoSize = true;
            lblDeleteHeading.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDeleteHeading.Location = new Point(145, 9);
            lblDeleteHeading.Name = "lblDeleteHeading";
            lblDeleteHeading.Size = new Size(504, 37);
            lblDeleteHeading.TabIndex = 0;
            lblDeleteHeading.Text = "Delete an Animal by selecting the row";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(202, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(495, 293);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvDeleteDisplay
            // 
            dgvDeleteDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteDisplay.Location = new Point(12, 59);
            dgvDeleteDisplay.Name = "dgvDeleteDisplay";
            dgvDeleteDisplay.RowHeadersWidth = 51;
            dgvDeleteDisplay.Size = new Size(776, 209);
            dgvDeleteDisplay.TabIndex = 3;
            // 
            // frmDeleteAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 347);
            Controls.Add(dgvDeleteDisplay);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(lblDeleteHeading);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDeleteAnimal";
            Text = "BaobabRidge - Delete";
            Load += frmDeleteAnimal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeleteDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDeleteHeading;
        private Button btnDelete;
        private Button btnBack;
        private DataGridView dgvDeleteDisplay;
    }
}