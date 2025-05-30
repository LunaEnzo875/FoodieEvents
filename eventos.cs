namespace FoodieEvents;

public class Eventos
{
    private string nombre="";
    public string descripcion="";
    public int tipoEvento;
    public DateTime inicio;
    public DateTime fin;
    public int capacidadMaxima = 100;
    public int precioEntrada = 35;
    public string ubicacion="";

    public Eventos(string? nombre, string? descripcion, int tipoEvento, DateTime inicio, DateTime fin, string? ubicacion)
    {
this.nombre = nombre;
this.descripcion = descripcion;
Validaciones.ValidarEvento(tipoEvento);
this.tipoEvento = tipoEvento;
this.inicio = inicio;
this.fin = fin;
this.capacidadMaxima = capacidadMaxima;
this.precioEntrada = precioEntrada;
this.ubicacion = ubicacion;
    }
    public void TipoDeEventos()
    {
        if (tipoEvento == 1)
        Console.WriteLine("Cata");

        else if(tipoEvento == 2)
        Console.WriteLine("feria");

        else if(tipoEvento == 3)
        Console.WriteLine("Clase");

        else if(tipoEvento == 4)
        Console.WriteLine("Cena tematica");
    }

    public string getNombre()
    {
        return this.nombre;
    }
}
