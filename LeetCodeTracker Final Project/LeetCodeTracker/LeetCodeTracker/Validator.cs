namespace LeetCodeTracker
{
    public static class Validator
    {
        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = $"{name} is a required field.{LineEnd}";
            }
            return msg;
        }
    }
}