using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinSolid
{
    public class TaskManager: ITaskManager
    {
        public readonly List<Task> _tasks = new List<Task>();
        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }
        public void CompleteTask(Guid taskId)
        {
            var task = _tasks.Find(t => t.Id == taskId);
            if (task != null)
            {
                task.MarkAsCompleted();
            }
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _tasks;
        }

    }
}
