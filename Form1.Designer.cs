namespace PRG282_Project_BaobabRidge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGoToAdd = new Button();
            lblMainHeader = new Label();
            btnUpdateAnimal = new Button();
            btnView = new Button();
            btnDelete = new Button();
            btnSOV = new Button();
            dgvAnimals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // btnGoToAdd
            // 
            btnGoToAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnGoToAdd.Location = new Point(149, 248);
            btnGoToAdd.Name = "btnGoToAdd";
            btnGoToAdd.Size = new Size(98, 37);
            btnGoToAdd.TabIndex = 0;
            btnGoToAdd.Text = "Add Animal";
            btnGoToAdd.UseVisualStyleBackColor = true;
            btnGoToAdd.Click += btnGoToAdd_Click;
            // 
            // lblMainHeader
            // 
            lblMainHeader.AutoSize = true;
            lblMainHeader.Font = new Font("Georgia", 16F, FontStyle.Bold);
            lblMainHeader.Location = new Point(1, 12);
            lblMainHeader.Name = "lblMainHeader";
            lblMainHeader.Size = new Size(602, 31);
            lblMainHeader.TabIndex = 1;
            lblMainHeader.Text = "BaobabRidge Animal Management System";
            // 
            // btnUpdateAnimal
            // 
            btnUpdateAnimal.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnUpdateAnimal.Location = new Point(24, 248);
            btnUpdateAnimal.Margin = new Padding(3, 4, 3, 4);
            btnUpdateAnimal.Name = "btnUpdateAnimal";
            btnUpdateAnimal.Size = new Size(84, 37);
            btnUpdateAnimal.TabIndex = 2;
            btnUpdateAnimal.Text = "Update Animal";
            btnUpdateAnimal.UseVisualStyleBackColor = true;
            btnUpdateAnimal.Click += btnUpdateAnimal_Click;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnView.Location = new Point(279, 248);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(80, 37);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.Location = new Point(406, 248);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 37);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSOV
            // 
            btnSOV.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSOV.Location = new Point(356, 93);
            btnSOV.Margin = new Padding(3, 4, 3, 4);
            btnSOV.Name = "btnSOV";
            btnSOV.Size = new Size(159, 37);
            btnSOV.TabIndex = 5;
            btnSOV.Text = "Summary Overview";
            btnSOV.UseVisualStyleBackColor = true;
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(24, 46);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.Size = new Size(268, 139);
            dgvAnimals.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 328);
            Controls.Add(dgvAnimals);
            Controls.Add(btnSOV);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnUpdateAnimal);
            Controls.Add(lblMainHeader);
            Controls.Add(btnGoToAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGoToAdd;
        private Label lblMainHeader;
        private Button btnUpdateAnimal;
        private Button btnView;
        private Button btnDelete;
        private Button btnSOV;
        private DataGridView dgvAnimals;
    }
}
