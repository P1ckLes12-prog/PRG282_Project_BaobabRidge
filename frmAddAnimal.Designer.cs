namespace PRG282_Project_BaobabRidge
{
    partial class frmAddAnimal
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
            lblAnimalID = new Label();
            lblName = new Label();
            lblSpecies = new Label();
            lblAge = new Label();
            lblRecoveryScore = new Label();
            txtAnimalID = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtScore = new TextBox();
            btnAddAnimal = new Button();
            SuspendLayout();
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(205, 92);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(78, 20);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(205, 125);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(205, 158);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(62, 20);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(205, 191);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(83, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age(years):";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(205, 224);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(113, 20);
            lblRecoveryScore.TabIndex = 4;
            lblRecoveryScore.Text = "Recovery Score:";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(353, 89);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(213, 27);
            txtAnimalID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(353, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 27);
            txtName.TabIndex = 6;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(353, 155);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(213, 27);
            txtSpecies.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(353, 188);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(213, 27);
            txtAge.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(353, 221);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(213, 27);
            txtScore.TabIndex = 9;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Location = new Point(310, 310);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(94, 29);
            btnAddAnimal.TabIndex = 10;
            btnAddAnimal.Text = "Add";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // frmAddAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddAnimal);
            Controls.Add(txtScore);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(txtAnimalID);
            Controls.Add(lblRecoveryScore);
            Controls.Add(lblAge);
            Controls.Add(lblSpecies);
            Controls.Add(lblName);
            Controls.Add(lblAnimalID);
            Name = "frmAddAnimal";
            Text = "Add New Animal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnimalID;
        private Label lblName;
        private Label lblSpecies;
        private Label lblAge;
        private Label lblRecoveryScore;
        private TextBox txtAnimalID;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private TextBox txtScore;
        private Button btnAddAnimal;
    }
}