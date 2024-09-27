using System;
using System.ComponentModel.DataAnnotations;

namespace SmartTaskManagerAPI.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; } = false;
        public string Priority { get; set; } = "low"; // low, medium, high
        public string Recurrence { get; set; } = null; // daily, weekly, monthly
    }
}
