namespace LeetCodeTracker
{
    public partial class frmAddEdit : Form
    {
        private LeetCodeProblem problem = null;

        public frmAddEdit()
        {
            InitializeComponent();
        }

        public LeetCodeProblem GetNewProblem()
        {
            this.Text = "Add LeetCode Problem";
            this.ShowDialog();
            return problem;
        }

        public LeetCodeProblem EditProblem(LeetCodeProblem existing)
        {
            this.Text = "Edit LeetCode Problem";
            txtName.Text = existing.Name;
            txtTopic.Text = existing.Topic;
            txtDiscription.Text = existing.Description;

            if (!string.IsNullOrEmpty(existing.DateAcquired))
            {
                try
                {
                    dtpDateAcquired.Value = DateTime.Parse(existing.DateAcquired);
                }
                catch
                {
                    dtpDateAcquired.Value = DateTime.Now;
                }
            }

            if (existing.Difficulty == "Easy") rdoEasy.Checked = true;
            else if (existing.Difficulty == "Medium") rdoMedium.Checked = true;
            else if (existing.Difficulty == "Hard") rdoHard.Checked = true;

            chkIsSolved.Checked = existing.IsSolved;

            this.ShowDialog();
            return problem;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtName.Text.Trim(), "Name");
            errorMessage += Validator.IsPresent(txtTopic.Text.Trim(), "Topic");

            if (errorMessage != "")
            {
                MessageBox.Show(
                    errorMessage, "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string difficulty = "Easy";
            if (rdoMedium.Checked) difficulty = "Medium";
            else if (rdoHard.Checked) difficulty = "Hard";

            string dateAcquired = dtpDateAcquired.Value.ToString("M/d/yyyy");

            problem = new LeetCodeProblem(
                txtName.Text.Trim(),
                dateAcquired,
                txtDiscription.Text.Trim(),
                txtTopic.Text.Trim(),
                difficulty,
                chkIsSolved.Checked);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}