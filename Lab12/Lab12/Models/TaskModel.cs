using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12.Models
{
    internal class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
