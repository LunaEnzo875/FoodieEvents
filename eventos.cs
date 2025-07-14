namespace FoodieEvents;

public class Eventos
{
    public string nombre { get; private set; }
    public string descripcion { get; private set; }
    public string tipoEvento { get; private set; }
    public DateTime inicio { get; private set; }
    public DateTime fin { get; private set; }
    public int capacidadMaxima { get; private set; }
    public int precioEntrada { get; private set; }
    public string ubicacion { get; private set; }

    public Eventos(string? nombre, string? descripcion, string tipoEvento, DateTime inicio, DateTime fin, string? ubicacion)
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.tipoEvento = tipoEvento;
        this.inicio = inicio;
        this.fin = fin;
        this.capacidadMaxima = capacidadMaxima;
        this.precioEntrada = precioEntrada;
        this.ubicacion = ubicacion;
    }

}