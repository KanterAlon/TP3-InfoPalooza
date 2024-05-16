using System;
using System.Collections.Generic;

public static class Tiquetera
{
    private static int ultimoIdEntrada = 0;
    private static Dictionary<int, Cliente> dicClientes = new Dictionary<int, Cliente>();

    public static void Iniciar()
    {
        dicClientes.Clear();
        ultimoIdEntrada = 0;
    }

    public static int DevolverUltimoID()
    {
        int id = ultimoIdEntrada;
        return id;
    }

    public static void AgregarCliente(Cliente cliente)
    {
        dicClientes.Add(DevolverUltimoID() + 1, cliente);
        ultimoIdEntrada++;
    }

public static List<string> ObtenerClientePorId(int id)
{
    List<string> resultado = new List<string>();

    if (!dicClientes.ContainsKey(id))
    {
        resultado.Add("No existe el código en el diccionario");
    }
    else
    {
        Cliente cliente = dicClientes[id];
        resultado.Add("Nombre del cliente: " + cliente.Nombre);
        resultado.Add("Apellido del cliente: " + cliente.Apellido);
        resultado.Add("DNI del cliente: " + cliente.DNI.ToString());
        resultado.Add("Tipo de entrada del cliente: " + cliente.TipoEntrada.ToString());
        resultado.Add("Cantidad del cliente: " + cliente.Cantidad.ToString());
        resultado.Add("Fecha de inscripción del cliente: " + cliente.FechaInscripcion.ToString());
    }

    return resultado;
}

    public static bool CambiarEntrada(int ID, int tipoEntrada, int cantidad)
    {
        if (dicClientes.ContainsKey(ID))
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("El diccionario contiene la clave " + ID);
            Console.ResetColor();

            dicClientes[ID].TipoEntrada = tipoEntrada;
            dicClientes[ID].Cantidad = cantidad;
            return true;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("El diccionario no contiene la clave " + ID);
            Console.ResetColor();

            return false;
        }
    }

    public static List<string> EstadisticasTicketera()
    {
        Console.Clear();
        List<string> estadisticas = new List<string>();
        Dictionary<int, int> conteoEntradas = new Dictionary<int, int>();
        Dictionary<int, int> recaudacionPorTipo = new Dictionary<int, int>();
        int totalEntradas = 0;
        int recaudacionTotal = 0;

        foreach (Cliente cliente in dicClientes.Values)
        {
            if (!conteoEntradas.ContainsKey(cliente.TipoEntrada))
            {
                conteoEntradas[cliente.TipoEntrada] = 0;
                recaudacionPorTipo[cliente.TipoEntrada] = 0;
            }
            conteoEntradas[cliente.TipoEntrada] += cliente.Cantidad;
            totalEntradas += cliente.Cantidad;
            recaudacionPorTipo[cliente.TipoEntrada] += cliente.Abono;
            recaudacionTotal += cliente.Abono;
        }

        estadisticas.Add("Cantidad de clientes inscriptos: " + dicClientes.Count.ToString());
        estadisticas.Add("----------------");

        foreach (int tipoEntrada in conteoEntradas.Keys)
        {
            estadisticas.Add("Tipo de Entrada: " + tipoEntrada + ", Cantidad vendida: " + conteoEntradas[tipoEntrada].ToString());
        }
        estadisticas.Add("----------------");

        foreach (int tipoEntrada in conteoEntradas.Keys)
        {
            int cantidad = conteoEntradas[tipoEntrada];
            double porcentaje = (100.0 * cantidad) / totalEntradas;
            estadisticas.Add("Tipo de Entrada: " + tipoEntrada + ", Porcentaje del total: " + porcentaje.ToString("0.00") + "%");
        }
        estadisticas.Add("----------------");

        foreach (int tipoEntrada in recaudacionPorTipo.Keys)
        {
            estadisticas.Add("Tipo de Entrada: " + tipoEntrada + ", Recaudación: " + recaudacionPorTipo[tipoEntrada].ToString());
        }
        estadisticas.Add("----------------");

        estadisticas.Add("Recaudación total: " + recaudacionTotal.ToString());

        return estadisticas;
    }
}
