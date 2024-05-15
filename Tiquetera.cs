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
            dicClientes.Add(DevolverUltimoID()+1, cliente);
            ultimoIdEntrada++;
    }

    public static Cliente BuscarCliente(int DNI)
    {
        return dicClientes[DNI];
    }

    public static bool CambiarEntrada(int ID, int tipoEntrada, int cantidad)
    {
        return true;
    }

    public static List<string> EstadisticasTicketera()
{
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
