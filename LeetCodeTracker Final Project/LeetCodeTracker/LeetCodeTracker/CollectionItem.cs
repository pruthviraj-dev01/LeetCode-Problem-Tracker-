using System;
using System.Globalization;

namespace LeetCodeTracker
{
    /// <summary>
    /// Represents an item in a collection with a name, date acquired, and description.
    /// This is an abstract class and cannot be instantiated directly.
    /// </summary>
    public abstract class CollectionItem
    {
      
        // Common properties for all collection items
        public string Name { get; set; } // Auto-implemented property
        private string dateAcquired;
        public string Description { get; set; } // Auto-implemented property

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionItem"/> class with the specified name, date acquired, and description.
        /// </summary>
        /// <param name="name">The name of the collection item.</param>
        /// <param name="dateAcquired">The date the item was acquired, in MM/DD/YYYY format, or null.</param>
        /// <param name="description">A description of the collection item.</param>
        protected CollectionItem(string name, string dateAcquired, string description)
        {
            Name = name;
            DateAcquired = dateAcquired; // Allows null or valid date format
            Description = description;
        }

        /// <summary>
        /// Gets or sets the date the item was acquired, in MM/DD/YYYY format, or null.
        /// </summary>
        public string DateAcquired
        {
            get => dateAcquired;
            set
            {
                if (string.IsNullOrEmpty(value) || IsValidDate(value))
                {
                    dateAcquired = value; // Accepts null or valid date format
                }
                else
                {
                    throw new ArgumentException("Date must be in MM/DD/YYYY format or empty.");
                }
            }
        }

        /// <summary>
        /// Validates if the provided date is in MM/DD/YYYY format.
        /// </summary>
        /// <param name="date">The date string to validate.</param>
        /// <returns>True if the date is in MM/DD/YYYY format; otherwise, false.</returns>
        private bool IsValidDate(string date)
        {
            return DateTime.TryParseExact(date, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }

        /// <summary>
        /// Displays a summary of the collection item.
        /// </summary>
        /// <returns>A string containing the summary of the collection item.</returns>
        public virtual string GetSummary()
        {
            string dateInfo = string.IsNullOrEmpty(DateAcquired) ? "Unknown" : DateAcquired;
            return $"{Name} - Acquired on {dateInfo}";
        }
    }
}
