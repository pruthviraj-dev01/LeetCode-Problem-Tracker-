namespace LeetCodeTracker
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblTitle = new Label();
            lstProblems = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            btnSave = new Button();
            btnOpen = new Button();
            ManuMain = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addProblemToolStripMenuItem = new ToolStripMenuItem();
            editProblemToolStripMenuItem = new ToolStripMenuItem();
            deleteProblemToolStripMenuItem = new ToolStripMenuItem();
            toolStripMain = new ToolStrip();
            tsbtnAdd = new ToolStripButton();
            tsbtnEdit = new ToolStripButton();
            tsbtnDelete = new ToolStripButton();
            tsbtnOpen = new ToolStripButton();
            tsbtnSave = new ToolStripButton();
            tsbtnExit = new ToolStripButton();
            statusStripMain = new StatusStrip();
            tslStatus = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            ManuMain.SuspendLayout();
            toolStripMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(34, 126);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(305, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "&LeetCode Problem Tracker :";
            // 
            // lstProblems
            // 
            lstProblems.FormattingEnabled = true;
            lstProblems.Location = new Point(35, 199);
            lstProblems.Name = "lstProblems";
            lstProblems.Size = new Size(425, 228);
            lstProblems.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(575, 183);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(575, 274);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 46);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(575, 365);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(720, 546);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(537, 546);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(345, 546);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(150, 46);
            btnOpen.TabIndex = 5;
            btnOpen.Text = "&Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // ManuMain
            // 
            ManuMain.ImageScalingSize = new Size(32, 32);
            ManuMain.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem, editToolStripMenuItem });
            ManuMain.Location = new Point(0, 0);
            ManuMain.Name = "ManuMain";
            ManuMain.Size = new Size(908, 40);
            ManuMain.TabIndex = 0;
            ManuMain.Text = "mnuMain";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(71, 36);
            filesToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(206, 44);
            openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(206, 44);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(203, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(206, 44);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProblemToolStripMenuItem, editProblemToolStripMenuItem, deleteProblemToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(74, 36);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // addProblemToolStripMenuItem
            // 
            addProblemToolStripMenuItem.Name = "addProblemToolStripMenuItem";
            addProblemToolStripMenuItem.Size = new Size(313, 44);
            addProblemToolStripMenuItem.Text = "&Add Problem";
            // 
            // editProblemToolStripMenuItem
            // 
            editProblemToolStripMenuItem.Name = "editProblemToolStripMenuItem";
            editProblemToolStripMenuItem.Size = new Size(313, 44);
            editProblemToolStripMenuItem.Text = "&Edit Problem";
            // 
            // deleteProblemToolStripMenuItem
            // 
            deleteProblemToolStripMenuItem.Name = "deleteProblemToolStripMenuItem";
            deleteProblemToolStripMenuItem.Size = new Size(313, 44);
            deleteProblemToolStripMenuItem.Text = "&Delete Problem";
            // 
            // toolStripMain
            // 
            toolStripMain.ImageScalingSize = new Size(32, 32);
            toolStripMain.Items.AddRange(new ToolStripItem[] { tsbtnAdd, tsbtnEdit, tsbtnDelete, tsbtnOpen, tsbtnSave, tsbtnExit });
            toolStripMain.Location = new Point(0, 40);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new Size(908, 42);
            toolStripMain.TabIndex = 9;
            toolStripMain.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            tsbtnAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnAdd.Image = (Image)resources.GetObject("tsbtnAdd.Image");
            tsbtnAdd.ImageTransparentColor = Color.Magenta;
            tsbtnAdd.Name = "tsbtnAdd";
            tsbtnAdd.Size = new Size(75, 36);
            tsbtnAdd.Text = "[&Add]";
            // 
            // tsbtnEdit
            // 
            tsbtnEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnEdit.Image = (Image)resources.GetObject("tsbtnEdit.Image");
            tsbtnEdit.ImageTransparentColor = Color.Magenta;
            tsbtnEdit.Name = "tsbtnEdit";
            tsbtnEdit.Size = new Size(72, 36);
            tsbtnEdit.Text = "[&Edit]";
            // 
            // tsbtnDelete
            // 
            tsbtnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnDelete.Image = (Image)resources.GetObject("tsbtnDelete.Image");
            tsbtnDelete.ImageTransparentColor = Color.Magenta;
            tsbtnDelete.Name = "tsbtnDelete";
            tsbtnDelete.Size = new Size(102, 36);
            tsbtnDelete.Text = "[&Delete]";
            // 
            // tsbtnOpen
            // 
            tsbtnOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnOpen.Image = (Image)resources.GetObject("tsbtnOpen.Image");
            tsbtnOpen.ImageTransparentColor = Color.Magenta;
            tsbtnOpen.Name = "tsbtnOpen";
            tsbtnOpen.Size = new Size(91, 36);
            tsbtnOpen.Text = "[&Open]";
            // 
            // tsbtnSave
            // 
            tsbtnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnSave.Image = (Image)resources.GetObject("tsbtnSave.Image");
            tsbtnSave.ImageTransparentColor = Color.Magenta;
            tsbtnSave.Name = "tsbtnSave";
            tsbtnSave.Size = new Size(82, 36);
            tsbtnSave.Text = "[&Save]";
            // 
            // tsbtnExit
            // 
            tsbtnExit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnExit.Image = (Image)resources.GetObject("tsbtnExit.Image");
            tsbtnExit.ImageTransparentColor = Color.Magenta;
            tsbtnExit.Name = "tsbtnExit";
            tsbtnExit.Size = new Size(69, 36);
            tsbtnExit.Text = "[&Exit]";
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(32, 32);
            statusStripMain.Items.AddRange(new ToolStripItem[] { tslStatus });
            statusStripMain.Location = new Point(0, 634);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(908, 42);
            statusStripMain.TabIndex = 10;
            statusStripMain.Text = "ssMain";
            // 
            // tslStatus
            // 
            tslStatus.Name = "tslStatus";
            tslStatus.Size = new Size(78, 32);
            tslStatus.Text = "Ready";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LeetCodeTrackerImage;
            pictureBox1.Location = new Point(345, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 676);
            Controls.Add(pictureBox1);
            Controls.Add(statusStripMain);
            Controls.Add(toolStripMain);
            Controls.Add(btnOpen);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lstProblems);
            Controls.Add(lblTitle);
            Controls.Add(ManuMain);
            MainMenuStrip = ManuMain;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LeetCode Problem Tracker";
            Load += frmMain_Load;
            ManuMain.ResumeLayout(false);
            ManuMain.PerformLayout();
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstProblems;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExit;
        private Button btnSave;
        private Button btnOpen;
        private MenuStrip ManuMain;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addProblemToolStripMenuItem;
        private ToolStripMenuItem editProblemToolStripMenuItem;
        private ToolStripMenuItem deleteProblemToolStripMenuItem;
        private ToolStrip toolStripMain;
        private ToolStripButton tsbtnAdd;
        private ToolStripButton tsbtnEdit;
        private ToolStripButton tsbtnDelete;
        private ToolStripButton tsbtnOpen;
        private ToolStripButton tsbtnSave;
        private StatusStrip statusStripMain;
        private ToolStripButton tsbtnExit;
        private ToolStripStatusLabel tslStatus;
        private PictureBox pictureBox1;
    }
}
