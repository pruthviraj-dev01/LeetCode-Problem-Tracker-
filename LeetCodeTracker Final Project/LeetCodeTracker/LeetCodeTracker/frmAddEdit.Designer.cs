namespace LeetCodeTracker
{
    partial class frmAddEdit
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
            label1 = new Label();
            lblName = new Label();
            lblDateAcquired = new Label();
            lblTopic = new Label();
            grpDifficulty = new GroupBox();
            rdoHard = new RadioButton();
            rdoMedium = new RadioButton();
            rdoEasy = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSave = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            chkIsSolved = new CheckBox();
            dtpDateAcquired = new DateTimePicker();
            txtTopic = new TextBox();
            lblDiscription = new Label();
            txtDiscription = new TextBox();
            grpDifficulty.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 33);
            label1.Name = "label1";
            label1.Size = new Size(310, 32);
            label1.TabIndex = 0;
            label1.Text = "Add/Edit LeetCode Problem";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(80, 129);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 32);
            lblName.TabIndex = 1;
            lblName.Text = "&Name :";
            // 
            // lblDateAcquired
            // 
            lblDateAcquired.AutoSize = true;
            lblDateAcquired.Location = new Point(82, 200);
            lblDateAcquired.Name = "lblDateAcquired";
            lblDateAcquired.Size = new Size(76, 32);
            lblDateAcquired.TabIndex = 3;
            lblDateAcquired.Text = "&Date :";
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.Location = new Point(80, 283);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(82, 32);
            lblTopic.TabIndex = 5;
            lblTopic.Text = "&Topic :";
            // 
            // grpDifficulty
            // 
            grpDifficulty.Controls.Add(rdoHard);
            grpDifficulty.Controls.Add(rdoMedium);
            grpDifficulty.Controls.Add(rdoEasy);
            grpDifficulty.Location = new Point(127, 348);
            grpDifficulty.Name = "grpDifficulty";
            grpDifficulty.Size = new Size(400, 241);
            grpDifficulty.TabIndex = 7;
            grpDifficulty.TabStop = false;
            grpDifficulty.Text = "Difficulty";
            // 
            // rdoHard
            // 
            rdoHard.AutoSize = true;
            rdoHard.Location = new Point(49, 158);
            rdoHard.Name = "rdoHard";
            rdoHard.Size = new Size(96, 36);
            rdoHard.TabIndex = 2;
            rdoHard.TabStop = true;
            rdoHard.Text = "&Hard";
            rdoHard.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            rdoMedium.AutoSize = true;
            rdoMedium.Location = new Point(49, 105);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(135, 36);
            rdoMedium.TabIndex = 1;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "&Medium";
            rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoEasy
            // 
            rdoEasy.AutoSize = true;
            rdoEasy.Location = new Point(49, 52);
            rdoEasy.Name = "rdoEasy";
            rdoEasy.Size = new Size(91, 36);
            rdoEasy.TabIndex = 0;
            rdoEasy.TabStop = true;
            rdoEasy.Text = "&Easy";
            rdoEasy.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(352, 747);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 9;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(564, 747);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(207, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 2;
            // 
            // chkIsSolved
            // 
            chkIsSolved.AutoSize = true;
            chkIsSolved.Location = new Point(82, 693);
            chkIsSolved.Name = "chkIsSolved";
            chkIsSolved.Size = new Size(141, 36);
            chkIsSolved.TabIndex = 8;
            chkIsSolved.Text = "&Is Solved";
            chkIsSolved.UseVisualStyleBackColor = true;
            // 
            // dtpDateAcquired
            // 
            dtpDateAcquired.Location = new Point(207, 202);
            dtpDateAcquired.Name = "dtpDateAcquired";
            dtpDateAcquired.Size = new Size(396, 39);
            dtpDateAcquired.TabIndex = 4;
            // 
            // txtTopic
            // 
            txtTopic.Location = new Point(207, 275);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new Size(200, 39);
            txtTopic.TabIndex = 6;
            // 
            // lblDiscription
            // 
            lblDiscription.AutoSize = true;
            lblDiscription.Location = new Point(80, 611);
            lblDiscription.Name = "lblDiscription";
            lblDiscription.Size = new Size(147, 32);
            lblDiscription.TabIndex = 11;
            lblDiscription.Text = "&Description :";
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new Point(243, 611);
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(284, 39);
            txtDiscription.TabIndex = 12;
            // 
            // frmAddEdit
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 843);
            Controls.Add(txtDiscription);
            Controls.Add(lblDiscription);
            Controls.Add(txtTopic);
            Controls.Add(dtpDateAcquired);
            Controls.Add(chkIsSolved);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grpDifficulty);
            Controls.Add(lblTopic);
            Controls.Add(lblDateAcquired);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "frmAddEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddEdit";
            grpDifficulty.ResumeLayout(false);
            grpDifficulty.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblDateAcquired;
        private Label lblTopic;
        private GroupBox grpDifficulty;
        private RadioButton rdoHard;
        private RadioButton rdoMedium;
        private RadioButton rdoEasy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtName;
        private CheckBox chkIsSolved;
        private DateTimePicker dtpDateAcquired;
        private TextBox txtTopic;
        private Label lblDiscription;
        private TextBox txtDiscription;
    }
}