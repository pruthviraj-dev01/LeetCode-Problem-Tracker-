namespace LeetCodeTracker
{
    public static class CollectionDB
    {
        private static string filePath = "LeetCodeProblems.txt";

        // Saves the list of problems to a text file
        public static void Save(List<LeetCodeProblem> problems)
        {
            // Create the output stream for a text file
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(filePath, FileMode.Create, FileAccess.Write));

            // Write each problem as a pipe-separated line
            foreach (LeetCodeProblem problem in problems)
            {
                textOut.Write(problem.Name + "|");
                textOut.Write(problem.DateAcquired + "|");
                textOut.Write(problem.Description + "|");
                textOut.Write(problem.Topic + "|");
                textOut.Write(problem.Difficulty + "|");
                textOut.WriteLine(problem.IsSolved);
            }

            // Close the file
            textOut.Close();
        }

        // Reads problems from a text file and returns a list
        public static List<LeetCodeProblem> Open()
        {
            // Create the list for problems
            List<LeetCodeProblem> problems = new List<LeetCodeProblem>();

            // If the file doesn't exist, return empty list
            if (!File.Exists(filePath))
                return problems;

            // Create the object for the input stream
            StreamReader textIn =
                new StreamReader(
                    new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read));

            // Read the data from the file
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split('|');
                if (columns.Length >= 6)
                {
                    LeetCodeProblem problem = new LeetCodeProblem(
                        columns[0],
                        columns[1],
                        columns[2],
                        columns[3],
                        columns[4],
                        bool.Parse(columns[5])
                    );
                    problems.Add(problem);
                }
            }

            // Close the file
            textIn.Close();
            return problems;
        }
    }
}