namespace PRG282_Project_BaobabRidge
{
    partial class frmSummary
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
            btnGenerate = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblTotal = new Label();
            lblAge = new Label();
            lblScore = new Label();
            lblCritical = new Label();
            lblSerious = new Label();
            lblStable = new Label();
            lblRecovering = new Label();
            lblRelease = new Label();
            lblSummaryHeading = new Label();
            lblSummaryInfo = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerate.Location = new Point(80, 303);
            btnGenerate.Margin = new Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(86, 31);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate Summary";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(285, 303);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 102);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 2;
            label1.Text = "Total Animals: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 3;
            label2.Text = "Average Age: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 4;
            label3.Text = "Average Score: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 231);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 5;
            label4.Text = "Critical: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(248, 185);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 6;
            label5.Text = "Serious: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(248, 231);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 7;
            label6.Text = "Stable: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(248, 102);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 8;
            label7.Text = "Recovering: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(248, 141);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 9;
            label8.Text = "Release-Ready: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(134, 102);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(21, 20);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "--";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(134, 141);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(21, 20);
            lblAge.TabIndex = 11;
            lblAge.Text = "--";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(145, 185);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(21, 20);
            lblScore.TabIndex = 12;
            lblScore.Text = "--";
            // 
            // lblCritical
            // 
            lblCritical.AutoSize = true;
            lblCritical.Location = new Point(89, 231);
            lblCritical.Name = "lblCritical";
            lblCritical.Size = new Size(21, 20);
            lblCritical.TabIndex = 13;
            lblCritical.Text = "--";
            // 
            // lblSerious
            // 
            lblSerious.AutoSize = true;
            lblSerious.Location = new Point(334, 185);
            lblSerious.Name = "lblSerious";
            lblSerious.Size = new Size(21, 20);
            lblSerious.TabIndex = 14;
            lblSerious.Text = "--";
            // 
            // lblStable
            // 
            lblStable.AutoSize = true;
            lblStable.Location = new Point(334, 231);
            lblStable.Name = "lblStable";
            lblStable.Size = new Size(21, 20);
            lblStable.TabIndex = 15;
            lblStable.Text = "--";
            // 
            // lblRecovering
            // 
            lblRecovering.AutoSize = true;
            lblRecovering.Location = new Point(362, 102);
            lblRecovering.Name = "lblRecovering";
            lblRecovering.Size = new Size(21, 20);
            lblRecovering.TabIndex = 16;
            lblRecovering.Text = "--";
            // 
            // lblRelease
            // 
            lblRelease.AutoSize = true;
            lblRelease.Location = new Point(384, 141);
            lblRelease.Name = "lblRelease";
            lblRelease.Size = new Size(21, 20);
            lblRelease.TabIndex = 17;
            lblRelease.Text = "--";
            // 
            // lblSummaryHeading
            // 
            lblSummaryHeading.AutoSize = true;
            lblSummaryHeading.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSummaryHeading.Location = new Point(12, 9);
            lblSummaryHeading.Name = "lblSummaryHeading";
            lblSummaryHeading.Size = new Size(498, 37);
            lblSummaryHeading.TabIndex = 18;
            lblSummaryHeading.Text = "Statistical Summary for BaobabRidge";
            // 
            // lblSummaryInfo
            // 
            lblSummaryInfo.AutoSize = true;
            lblSummaryInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSummaryInfo.Location = new Point(12, 46);
            lblSummaryInfo.Name = "lblSummaryInfo";
            lblSummaryInfo.Size = new Size(229, 20);
            lblSummaryInfo.TabIndex = 19;
            lblSummaryInfo.Text = "Click \"Generate\" to view Summary";
            // 
            // frmSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 347);
            Controls.Add(lblSummaryInfo);
            Controls.Add(lblSummaryHeading);
            Controls.Add(lblRelease);
            Controls.Add(lblRecovering);
            Controls.Add(lblStable);
            Controls.Add(lblSerious);
            Controls.Add(lblCritical);
            Controls.Add(lblScore);
            Controls.Add(lblAge);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnGenerate);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSummary";
            Text = "BaobabRidge - Summary";
            Load += frmSummary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblTotal;
        private Label lblAge;
        private Label lblScore;
        private Label lblCritical;
        private Label lblSerious;
        private Label lblStable;
        private Label lblRecovering;
        private Label lblRelease;
        private Label lblSummaryHeading;
        private Label lblSummaryInfo;
    }
}