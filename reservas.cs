namespace FoodieEvents;

public class Reserva
{
    public Participantes participante { get; private set; }
    public string inscripcion { get; private set; }
    public DateTime fecha { get; private set; }
    public int metodoPago { get; private set; }
    public int estadoReserva { get; private set; }

    public Reserva(Participantes participante, string inscripcion, DateTime fecha, int metodoPago, int estadoReserva)
    {
        this.estadoReserva = estadoReserva;
        this.metodoPago = metodoPago;
        this.participante = participante;
        this.inscripcion = inscripcion;
        this.fecha = fecha;
        this.estadoReserva = estadoReserva;

    }
}