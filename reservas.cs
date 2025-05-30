namespace FoodieEvents;

public class Reserva
{
    private Participantes participante;
    private string inscripcion="";
    private DateTime fecha ;
    private int metodoPago;
    private int estadoReserva;

    public Reserva (Participantes participante,string inscripcion, DateTime fecha,int metodoPago, int estadoReserva){

Validaciones.ValidarReserva(estadoReserva);
this.estadoReserva=estadoReserva;
this.metodoPago=metodoPago;
this.participante = participante;
this.inscripcion=inscripcion;
this.fecha = fecha;
this.estadoReserva=estadoReserva;
    
    }
    public string getinscripcion(){
    return this.inscripcion;
    }
    public DateTime getfecha (){
    return this.fecha;
    }
    public int getmetodoPago (){
    return this.metodoPago;
    }
    public int getestadoReserva (){
    return this.estadoReserva;
    }
}
