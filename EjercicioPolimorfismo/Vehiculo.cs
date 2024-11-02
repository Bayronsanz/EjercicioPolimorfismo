
namespace EjercicioPolimorfismo
{
    public class Vehiculo {
        public string TipoVehiculo { get; set; }
        public string Encender {  get; set; }
        public string Apagar { get; set; } 

        public Vehiculo()
        {
        }

        public void Estado()
        {
            Console.WriteLine();
            Console.WriteLine($"El vehiculo {TipoVehiculo} esta encendido {Encender}");
            Console.WriteLine($"El vehiculo {TipoVehiculo} esta  apagado {Apagar}");
        }
    }
}
