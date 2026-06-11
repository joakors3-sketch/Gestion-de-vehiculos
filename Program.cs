using System;
class Program
{
    static void Main(string[] args)
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        int opcion;

        do
        {
            Console.WriteLine("Bienvenido a Sistema De Vehiculos");
            Console.WriteLine("1 - Agregar Vehiculo");
            Console.WriteLine("2 - Agregar Moto");
            Console.WriteLine("3 - Ver Vehiculos");
            Console.WriteLine("4 - Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
    {
        case 1:

            Console.Write("Marca: ");
            string marcaAuto = Console.ReadLine();

            Console.Write("Modelo: ");
            string modeloAuto = Console.ReadLine();

            vehiculos.Add(new Auto(marcaAuto, modeloAuto));

            Console.WriteLine("Auto registrado correctamente.");
            break;

        case 2:

            Console.Write("Marca: ");
            string marcaMoto = Console.ReadLine();

            Console.Write("Modelo: ");

            string modeloMoto = Console.ReadLine();

            vehiculos.Add(new Moto(marcaMoto, modeloMoto));

            Console.WriteLine("Moto registrada correctamente.");
            break;

        case 3:

            foreach (Vehiculo v in vehiculos)
            {

                v.MostrarInfo();

                Console.WriteLine("Acelerando...");
                v.Acelerar();
                v.MostrarInfo();

                Console.WriteLine("Frenando...");
                v.Frenar();
                v.MostrarInfo();
            }

            break;

    }

        } while (opcion != 4);
    }
}
