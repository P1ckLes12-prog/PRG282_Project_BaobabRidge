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
            SuspendLayout();
            // 
            // btnGoToAdd
            // 
            btnGoToAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnGoToAdd.Location = new Point(69, 58);
            btnGoToAdd.Margin = new Padding(3, 2, 3, 2);
            btnGoToAdd.Name = "btnGoToAdd";
            btnGoToAdd.Size = new Size(139, 28);
            btnGoToAdd.TabIndex = 0;
            btnGoToAdd.Text = "Add Animal";
            btnGoToAdd.UseVisualStyleBackColor = true;
            btnGoToAdd.Click += btnGoToAdd_Click;
            // 
            // lblMainHeader
            // 
            lblMainHeader.AutoSize = true;
            lblMainHeader.Font = new Font("Georgia", 16F, FontStyle.Bold);
            lblMainHeader.Location = new Point(1, 9);
            lblMainHeader.Name = "lblMainHeader";
            lblMainHeader.Size = new Size(494, 27);
            lblMainHeader.TabIndex = 1;
            lblMainHeader.Text = "BaobabRidge Animal Management System";
            // 
            // btnUpdateAnimal
            // 
            btnUpdateAnimal.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnUpdateAnimal.Location = new Point(69, 137);
            btnUpdateAnimal.Name = "btnUpdateAnimal";
            btnUpdateAnimal.Size = new Size(139, 28);
            btnUpdateAnimal.TabIndex = 2;
            btnUpdateAnimal.Text = "Update Animal";
            btnUpdateAnimal.UseVisualStyleBackColor = true;
            btnUpdateAnimal.Click += btnUpdateAnimal_Click;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnView.Location = new Point(289, 58);
            btnView.Name = "btnView";
            btnView.Size = new Size(139, 28);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.Location = new Point(289, 137);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 28);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSOV
            // 
            btnSOV.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSOV.Location = new Point(179, 206);
            btnSOV.Name = "btnSOV";
            btnSOV.Size = new Size(139, 28);
            btnSOV.TabIndex = 5;
            btnSOV.Text = "Summary Overview";
            btnSOV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 246);
            Controls.Add(btnSOV);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnUpdateAnimal);
            Controls.Add(lblMainHeader);
            Controls.Add(btnGoToAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
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
    }
}
