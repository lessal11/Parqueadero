internal class Program
{
    static void Main()
    {
        Parqueadero parqueadero = new Parqueadero();

        while (true)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    parqueadero.IngresarVehiculo();
                    break;

                case "2":
                    parqueadero.SalirVehiculo();
                    break;

                case "3":
                    parqueadero.MostrarEstado();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("--------- Menú ---------");
        Console.WriteLine("1. Ingresar Vehículo");
        Console.WriteLine("2. Sacar Vehículo");
        Console.WriteLine("3. Mostrar Estado del Parqueadero");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");
    }
}

class Parqueadero
{
    private List<string> espacios = new List<string>();

    public void IngresarVehiculo()
    {
        Console.Write("Ingrese la placa del vehículo: ");
        string placa = Console.ReadLine();

        if (espacios.Count < 10)
        {
            espacios.Add(placa);
            Console.WriteLine($"Vehículo con placa {placa} ingresado correctamente.");
        }
        else
        {
            Console.WriteLine("El parqueadero está lleno. No se puede ingresar más vehículos.");
        }
    }

    public void SalirVehiculo()
    {
        Console.Write("Ingrese la placa del vehículo que va a salir: ");
        string placa = Console.ReadLine();

        if (espacios.Contains(placa))
        {
            espacios.Remove(placa);
            Console.WriteLine($"Vehículo con placa {placa} salió del parqueadero.");
        }
        else
        {
            Console.WriteLine($"No se encontró un vehículo con placa {placa} en el parqueadero.");
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Estado del Parqueadero:");

        if (espacios.Count == 0)
        {
            Console.WriteLine("El parqueadero está vacío.");
        }
        else
        {
            for (int i = 0; i < espacios.Count; i++)
            {
                Console.WriteLine($"Espacio {i + 1}: {espacios[i]}");
            }
        }
    }
}