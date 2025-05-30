namespace FoodieEvents;

public class Eventos
{
    private string nombre="";
    private string descripcion="";
    private int tipoEvento;
    private DateTime inicio;
    private DateTime fin;
    private int capacidadMaxima = 100;
    private int precioEntrada = 35;
    private string ubicacion="";

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
    public string getdescripcion(){
        return this.descripcion;
    }
    public int gettipoEvento(){
        return this.tipoEvento;
    }
    public DateTime getinicio(){
    return this.inicio;
    }
    public DateTime getFin(){
        return this.fin;
    }
    public int getcapacidadMaxima(){
        return this.capacidadMaxima;
    }
public int getprecioEntrada(){
    return this.precioEntrada;
}
public string getubicacion(){
    return this.ubicacion;
}
}
