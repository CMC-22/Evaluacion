namespace PrinSolid
{
    public class TaskUI
    {
        private readonly ITaskManager _taskManager;

        public TaskUI(ITaskManager taskManger)
        {
            _taskManager = taskManger;
        }

        public void ShowAllTasks()
        {
            foreach (var task in _taskManager.GetAllTasks())
            {
                var status = task.IsCompleted ? "Completada" : "Pendiente";
                Console.WriteLine($"ID: {task.Id}, Descripción: {task.Description}, Estado: {status}");
            }
        }

        public void AddNewTask(string description)
        {
            var task = new Task(description);
            _taskManager.AddTask(task);
        }

        public void CompleteTask(Guid taskId)
        {
            _taskManager.CompleteTask(taskId);
        }
    }

    class Program
    {
        static  void Main(string[] args)
        {
            ITaskManager taskManager = new TaskManager();
            TaskUI taskUI = new TaskUI(taskManager);

            //añadir tareas
            taskUI.AddNewTask("Hacer la compra");
            taskUI.AddNewTask("Llamar al medico");

            //mostrar tareas iniciales
            Console.WriteLine("Tareas Iniciales:");
            taskUI.ShowAllTasks();

            //completa una tarea
            var taskId = new Guid("e8a8e5d4-065c-4c5b-a118-7e7f7e0123bc");

            //mostrar tareas despues de completar una
            Console.WriteLine("\nTareas des de completar una:");
            taskUI.CompleteTask(taskId);
            taskUI.ShowAllTasks();

        }
    }
}
