


using System.Text;

namespace EjercicioPolimorfismo
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta()
        {
        }
        
            public void Estado()
        {
            Console.WriteLine();
            Console.WriteLine($"{TipoVehiculo} esta encendido {Encender}");
            Console.WriteLine($"{TipoVehiculo} esta apagada {Apagar}");
        }
    }
}
