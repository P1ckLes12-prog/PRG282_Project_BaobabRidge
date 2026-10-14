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
            lblAddHeader = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(38, 66);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(62, 15);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(38, 91);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(38, 115);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(49, 15);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(38, 140);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(66, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age(years):";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(38, 165);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(90, 15);
            lblRecoveryScore.TabIndex = 4;
            lblRecoveryScore.Text = "Recovery Score:";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(168, 64);
            txtAnimalID.Margin = new Padding(3, 2, 3, 2);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(187, 23);
            txtAnimalID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 89);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 23);
            txtName.TabIndex = 6;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(168, 113);
            txtSpecies.Margin = new Padding(3, 2, 3, 2);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(187, 23);
            txtSpecies.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(168, 138);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(187, 23);
            txtAge.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(168, 163);
            txtScore.Margin = new Padding(3, 2, 3, 2);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(187, 23);
            txtScore.TabIndex = 9;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Location = new Point(129, 220);
            btnAddAnimal.Margin = new Padding(3, 2, 3, 2);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(82, 22);
            btnAddAnimal.TabIndex = 10;
            btnAddAnimal.Text = "Add";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // lblAddHeader
            // 
            lblAddHeader.AutoSize = true;
            lblAddHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAddHeader.Location = new Point(99, 20);
            lblAddHeader.Name = "lblAddHeader";
            lblAddHeader.Size = new Size(165, 30);
            lblAddHeader.TabIndex = 11;
            lblAddHeader.Text = "Add an Animal";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(290, 232);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmAddAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 267);
            Controls.Add(btnBack);
            Controls.Add(lblAddHeader);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblAddHeader;
        private Button btnBack;
    }
}