using System;

namespace BackendTodoASP.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime? Deadline { get; set; }
    }
}

