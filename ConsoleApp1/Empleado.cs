using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Empleado : Persona, ICalculable
    {
        public decimal Salario { get; set; }

        // Constructor con parámetros
        public Empleado(string nombre, int edad, string direccion, decimal salario)
            : base(nombre, edad, direccion)
        {
            Salario = salario;
        }

        // Constructor sin parámetros
        public Empleado()
            : base()
        {
            Salario = 0.0m;
        }

        // Implementación del método CalcularSalarioAsync de la interfaz ICalculable
        public decimal CalcularSalario(int diasTrabajados)
        {
            return (Salario / 30) * diasTrabajados;
        }

        // Método para mostrar la información del empleado
        public async Task MostrarInformacion(int diasTrabajados)
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario por {diasTrabajados} días Trabajados: {CalcularSalario(diasTrabajados):C}");
        }
    }
}
 