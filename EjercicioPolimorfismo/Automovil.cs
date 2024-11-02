
namespace EjercicioPolimorfismo
{
    internal class Automovil : Vehiculo{
        public void Estado()
        {
            Console.WriteLine();
            Console.WriteLine($"El {TipoVehiculo} esta encendido {Encender}");
            Console.WriteLine($"El {TipoVehiculo} esta apagado {Apagar}");
        }
    }
}
