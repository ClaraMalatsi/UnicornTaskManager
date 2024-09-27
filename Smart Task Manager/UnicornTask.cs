using System;
using System.ComponentModel.DataAnnotations;

namespace UnicornTaskManager.Models
{
    public class UnicornTask
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public string TaskPriority { get; set; } = "low"; // low, medium, high
        public string Recurrence { get; set; } = null; // daily, weekly, monthly
    }
}
