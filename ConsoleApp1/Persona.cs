namespace ConsoleApp1
{

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        // Constructor con parámetros
        public Persona(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }

        // Constructor sin parámetros
        public Persona()
        {
            Nombre = "";
            Edad = 0;
            Direccion = "";
        }

        // Método para mostrar la información de la clase
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la edad del empleado: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la dirección del empleado: ");
            string direccion = Console.ReadLine();

            Console.Write("Ingrese el salario base del empleado: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese los días trabajados: ");
            int diasTrabajados = int.Parse(Console.ReadLine());

            // Crear una instancia de Empleado
            Empleado empleado = new Empleado(nombre, edad, direccion, salario);

            Console.WriteLine("Calculando salario... ");
            await Task.Delay(5000);

            empleado.MostrarInformacion(diasTrabajados);
        }
    }
}