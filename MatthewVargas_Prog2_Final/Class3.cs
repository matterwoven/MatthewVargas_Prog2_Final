using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewVargas_Prog2_Final
{

    public class TaskItem
    {
        public string? Completed { get; set; }
        public string? Name { get; set; }
        public string? HighImportance { get; set; }
        public string? TimeSensitive { get; set; }
        public string? Description { get; set; }

        private List<TaskItem> tasks = new List<TaskItem>();

        // Property to expose the tasks
        public List<TaskItem> Tasks
        {
            get { return tasks; }
        }

        // Add method to add a task to the category
    }
}
