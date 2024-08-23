namespace AsyncAwait
{
    public class DataReader
    {
        //metodo asincronico leer datos 
        public async Task<string> LeerDatosAsync()
        {
            await Task.Delay(1000);//milesegundos

            return "Datos leidos con exito";
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            // se crea una instancia
            DataReader dataReader =  new DataReader();

            string resultado = await dataReader.LeerDatosAsync();

            Console.WriteLine(resultado);
        }
    }
}
