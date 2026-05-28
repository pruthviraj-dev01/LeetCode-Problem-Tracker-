using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTracker
{
    public class LeetCodeProblem : CollectionItem
    {
        // Properties 
        public string Topic { get; set; } = "";
        public string Difficulty { get; set; } = "";
        public bool IsSolved { get; set; } = false;

        // Constructor 
        public LeetCodeProblem() : base("", "", "") { }

        public LeetCodeProblem(string name , string dateAcquired, string description,
            string topic,string difficulty,bool isSolved) 
            : base(name, dateAcquired, description)
        {
            Topic = topic;
            Difficulty = difficulty;
            IsSolved = isSolved;
        }
        // Methods
        /// <summary>
        /// Returns a summary of the LeetCode problem.
        /// </summary>
        /// <returns>A formatted string with the problem name, topic, and difficulty.</returns>
        public override string GetSummary()
        {
            return $"{Name} ({Topic}) - {Difficulty}";
        }
    }
   
    


}
