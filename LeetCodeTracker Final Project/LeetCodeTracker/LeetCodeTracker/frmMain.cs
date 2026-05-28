namespace LeetCodeTracker
{
    public partial class frmMain : Form
    {
        // The master list of all problems
        private List<LeetCodeProblem> problemList = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Load problems from file
            problemList = CollectionDB.Open();
            // Fill the ListBox with problems
            refreshListBox();
        }

        private void refreshListBox()
        {
            // Clear the list box before adding to it
            lstProblems.Items.Clear();
            foreach (LeetCodeProblem thisProblem in problemList)
            {
                lstProblems.Items.Add(thisProblem.GetSummary());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit addEditForm = new frmAddEdit();
            LeetCodeProblem myNewProblem = addEditForm.GetNewProblem();

            if (myNewProblem != null)
            {
                // Add the new problem to the list
                problemList.Add(myNewProblem);
                // Save the list to the file
                CollectionDB.Save(problemList);
                // Refresh the ListBox
                refreshListBox();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Make sure user actually chose SOMETHING
            int selectedIndex = lstProblems.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a problem to edit.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Who was chosen?
            LeetCodeProblem selectedProblem = problemList[selectedIndex];

            // Open the form pre-filled with the selected problem's data
            frmAddEdit addEditForm = new frmAddEdit();
            LeetCodeProblem updatedProblem = addEditForm.EditProblem(selectedProblem);

            if (updatedProblem != null)
            {
                // Replace the old problem with the updated one
                problemList[selectedIndex] = updatedProblem;
                // Save the list to the file
                CollectionDB.Save(problemList);
                // Refresh the ListBox
                refreshListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Make sure user actually chose SOMETHING
            int selectedIndex = lstProblems.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a problem to delete.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Who was chosen?
            LeetCodeProblem chosenProblem = problemList[selectedIndex];

            // Be sure to confirm the delete operation
            string confirmationMessage = "Are you sure you want to delete " +
                chosenProblem.Name + "?";

            // Show the confirmation window
            DialogResult chosenButton = MessageBox.Show(
                confirmationMessage, "Are you sure?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (chosenButton == DialogResult.No)
            {
                // Don't do anything
                return;
            }

            // Remove the selected problem from the list
            problemList.Remove(chosenProblem);
            // Save the list to the file
            CollectionDB.Save(problemList);
            // Refresh the ListBox
            refreshListBox();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Load problems from the file
            problemList = CollectionDB.Open();
            // Refresh the ListBox
            refreshListBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the current list to the file
            CollectionDB.Save(problemList);
            MessageBox.Show("Collection saved successfully!",
                "Save", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}