﻿namespace TaskManagerSystem.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string UserId { get; set; }         // Foreign key to link the task to the user

        public ApplicationUser User { get; set; } // Navigation property for the user
    }
}
