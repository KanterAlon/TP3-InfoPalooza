public class Cliente
{
    public int DNI { get;  set; }
    public string Nombre { get;  set; }
    public string Apellido { get;  set; }
    public DateTime FechaInscripcion { get; set; }
    public int TipoEntrada { get; set; }
    public int Cantidad { get; set; }
    public int Abono { get; set; }

    public Cliente(int id, string nombre, string apellido, int dni, DateTime fechaInscripcion, int tipoEntrada, int cantidad, int abono)
    {
        Nombre = nombre;
        Apellido = apellido;
        DNI = dni;
        FechaInscripcion = fechaInscripcion;
        TipoEntrada = tipoEntrada;
        Cantidad = cantidad;
        Abono = abono;
        
    }

    public Cliente()
    {
    }
}