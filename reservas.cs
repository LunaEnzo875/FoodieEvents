namespace FoodieEvents;

public class Reserva
{
    public Participantes participante;
    public string inscripcion="";
    public DateTime fecha ;
    public int metodoPago;
    public int estadoReserva;

    public Reserva (Participantes participante,string inscripcion, DateTime fecha,int metodoPago, int estadoReserva){

Validaciones.ValidarReserva(estadoReserva);
this.estadoReserva=estadoReserva;
this.metodoPago=metodoPago;
this.participante = participante;
this.inscripcion=inscripcion;
this.fecha = fecha;

this.estadoReserva=estadoReserva;
    }
}
