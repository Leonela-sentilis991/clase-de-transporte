
// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using transporte;

Console.WriteLine("boleto de transporte ");
Console.WriteLine();

double ResultadoMultiplicacion;


Console.WriteLine("introduzca los datos del recorrido del taxi");


Taxi multiplicacion = new Taxi();
Console.WriteLine("introduzca el destino");
multiplicacion.destino = Console.ReadLine();
Console.WriteLine();
Console.Write("introduzca la distancia en kilometros: ");
multiplicacion.distancia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("costo por kilometros: ");
multiplicacion.costo = Convert.ToInt32(Console.ReadLine());
ResultadoMultiplicacion = multiplicacion.operar();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("El destino es: " + multiplicacion.destino);
Console.WriteLine();
Console.WriteLine($"La distancia son:   {multiplicacion.distancia} kilometros");
Console.WriteLine();
Console.WriteLine("El costo por kilometros es: " + multiplicacion.costo);
Console.WriteLine();
Console.WriteLine($"El costo del boleto del taxi es :  {ResultadoMultiplicacion}");
Console.WriteLine();

Console.WriteLine("introduzca los datos del recorrido del bus_urbano");

Bus_urbano bus = new Bus_urbano();
Console.WriteLine("introduzca el tipo de corredor");
bus.corredor = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("El corredor es: " + bus.corredor);
Console.Write("EL PRECIO DEL CORREDOR ES: ");
bus.Operar();
Console.WriteLine();

Console.WriteLine("introduzca los datos del recorrido del bus_interUrbano");

Businterurbano busint = new Businterurbano();
Console.WriteLine("Intruduzca el destino del Bus_interUrbano:");
busint.destino = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Intruduzca la compañia:");
busint.compañia = Console.ReadLine();
Console.WriteLine("Intruduzca el costo del boleto:");
busint.costo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("EL destino es:" + busint.destino);
Console.WriteLine();
Console.WriteLine("La compañia es:" + busint.compañia);
Console.WriteLine();
Console.WriteLine("EL costo del boleto es:" + busint.costo);


Console.WriteLine("introduzca los datos del recorrido del metro");

metro metro = new metro();
Console.WriteLine("Intruduzca la compañia del metro:");
metro.compañia = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Intruduzca la linea del metro:");
metro.linea = Console.ReadLine();
Console.WriteLine("Intruduzca el costo del boleto:");
metro.costo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("la compañia es:" + metro.compañia);
Console.WriteLine();
Console.WriteLine("La linea es:" + metro.linea);
Console.WriteLine();
Console.WriteLine("EL costo del boleto es:" + metro.costo);


Console.WriteLine("introduzca los datos del recorrido del teleferico");

teleferico teleferico = new teleferico();
Console.WriteLine("Intruduzca la compañia del teleferico:");
teleferico.compañia = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Intruduzca la linea del teleferico:");
teleferico.linea = Console.ReadLine();
Console.WriteLine("Intruduzca el costo del boleto:");
teleferico.costo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("la compañia es:" + teleferico.compañia);
Console.WriteLine();
Console.WriteLine("La linea es:" + teleferico.linea);
Console.WriteLine();
Console.WriteLine("EL costo del boleto es:" + teleferico.costo);
