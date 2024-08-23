namespace PrinSolid
{
    internal class ProgramBase
    {
        private void Main(string[] args)
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
            var taskId = new Guid("ID_DE_LA_TAREA");

            //mostrar tareas despues de completar una
            Console.WriteLine("\nTareas des de completar una:");
            taskUI.CompleteTask(taskId);
            taskUI.ShowAllTasks();

        }
    }
}