using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinSolid
{
    public interface ITaskManager
    {
        void AddTask(Task task);//agrega una nueva tarea
        void CompleteTask(Guid taskId);//marca una tarea como completada
        IEnumerable<Task> GetAllTasks();//devuelve todas las tareas almacenadas
    }
}
