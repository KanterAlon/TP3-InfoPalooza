MostrarMenu();
int id = 0;

static void MostrarMenu()
{
    bool salida = false;

    while (!salida)
    {
        Console.WriteLine("==== InfoPalooza 2024 ====");
        Console.WriteLine("1. Nueva Inscripción");
        Console.WriteLine("2. Obtener Estadísticas del Evento");
        Console.WriteLine("3. Buscar Cliente");
        Console.WriteLine("4. Cambiar Entrada de un Cliente");
        Console.WriteLine("5. Salir");
        Console.WriteLine("==== InfoPalooza 2024 ====");
        Console.Write("Seleccione una opción: ");
        
        // Corrected the method call here by providing a proper message and limits.
        int opcion = preguntarINTconParametros("Ingrese una opción entre 1 y 5: ", 1, 5);

        switch (opcion)
        {
            case 1:
                opc1();
                break;
            case 2:
                opc2();
                break;
            case 3:
                // Implementar búsqueda de cliente
                break;
            case 4:
                // Implementar cambio de entrada del cliente
                break;
            case 5:
                salida = true;
                break;
            default:
                break;
        }
    }
}

static void opc1()
{
    Cliente cliente = new Cliente();
    cliente.Nombre = preguntarString("Ingrese el nombre del cliente: ");
    cliente.Apellido = preguntarString("Ingrese el apellido del cliente: ");
    cliente.DNI = preguntarINT("Ingrese el DNI del cliente: ");
    cliente.FechaInscripcion = preguntarFecha();
    cliente.TipoEntrada = preguntarINTconParametros("Ingrese el tipo entrada del cliente (Para el día 1, presione 1. Para el día 2, presione 2. Para el día 3, presione 3, para el Full Pass, presione 4): ", 1, 4);
    cliente.Cantidad = preguntarINT("Ingrese la cantidad de entradas del cliente: ");
    cliente.Abono = calculoAbono(cliente.TipoEntrada, cliente.Cantidad); 
    Tiquetera.AgregarCliente(cliente);
}

static void opc2()
{

List<string> lista = Tiquetera.EstadisticasTicketera();

foreach (string a in lista)
    {
        Console.WriteLine(a);
    }
}

static DateTime preguntarFecha()
{
    DateTime hoy = DateTime.Now;
    Console.WriteLine("Hoy es " + hoy + ". Desea cambiar la fecha (1) o continuar con la fecha actual (2)?");

    // Use the `preguntarINTconParametros` function correctly by providing a proper message.
    int opcion = preguntarINTconParametros("Elija 1 para cambiar la fecha, o 2 para continuar con la fecha actual: ", 1, 2);

    if (opcion == 2)
    {
        return hoy;
    }
    else
    {
        DateTime fecha = devolverDatetime();
        return fecha;
    }
}

static DateTime devolverDatetime()
{
    Console.WriteLine("Ingrese la fecha por favor:");
    string ingreso = Console.ReadLine();
    bool valido = DateTime.TryParse(ingreso, out DateTime fecha);
    while (!valido)
    {
        Console.WriteLine("Su ingreso no es válido. Por favor, ingrese una fecha válida.");
        ingreso = Console.ReadLine();
        valido = DateTime.TryParse(ingreso, out fecha);
    }
    return fecha;
}

static void pausa()
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
}

static int preguntarINT(string msj)
{
    int num = 0;
    Console.Write(msj);
    string ingreso = Console.ReadLine();
    while (!int.TryParse(ingreso, out num))
    {
        Console.WriteLine("Su ingreso no es válido. Por favor, ingrese un número entero.");
        ingreso = Console.ReadLine();
    }
    return num;
}

static string preguntarString(string msj)
{
    string ingreso;
    do
    {
        Console.Write(msj);
        ingreso = Console.ReadLine();
        if (ingreso == "")
        {
            Console.WriteLine("El campo no puede estar vacío. Por favor, ingrese algo.");
        }
    } 
    while (ingreso == "");
    return ingreso;
}

static int preguntarINTconParametros(string msj, int min, int max)
{
    int num = 0;
    bool valido = false;

    do
    {
        Console.Write(msj);
        string ingreso = Console.ReadLine();
        if (int.TryParse(ingreso, out num) && num >= min && num <= max)
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número entre " + min + " y " + max + ".");
        }
    } while (!valido);

    return num;
}

static int calculoAbono(int tipoEntrada, int cantidad)
{
    int abono = 0;

    const int opc1 = 45000;
    const int opc2 = 60000;
    const int opc3 = 30000;
    const int opc4 = 100000;

    switch (tipoEntrada)
    {
        case 1:
            abono = opc1;
            break;
        case 2:
            abono = opc2;
            break;
        case 3:
            abono = opc3;
            break;
        case 4:
            abono = opc4;
            break;
    }

    abono = abono * cantidad;
    return abono;
}