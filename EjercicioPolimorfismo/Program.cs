using EjercicioPolimorfismo;

string Encender, Apagar, TipoVehiculo;
string Motocicleta, behiculo;

Vehiculo vehiculo = new Vehiculo();
Motocicleta motocicleta = new Motocicleta();
Automovil automovil = new Automovil();

Console.WriteLine("tipo de vehiculo");
TipoVehiculo = Console.ReadLine();

Console.WriteLine("encender:");
Encender = Console.ReadLine();

Console.WriteLine("apagar");
Apagar = Console.ReadLine();

vehiculo.TipoVehiculo = TipoVehiculo;
vehiculo.Encender = Encender;
vehiculo.Apagar = Apagar;
vehiculo.Estado();

motocicleta.TipoVehiculo = TipoVehiculo;
motocicleta.Encender = Encender;
motocicleta.Apagar = Apagar;
motocicleta.Estado();

automovil.TipoVehiculo = TipoVehiculo;
automovil.Encender = Encender;
automovil.Apagar = Apagar;
automovil.Estado();