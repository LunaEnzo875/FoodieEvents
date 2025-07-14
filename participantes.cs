namespace FoodieEvents;

public class Participantes
{
    private int DNI { get; private set; }
    private string restriccionAlimentaria { get;private set; }
    public List<Reserva> reservasList = new List<Reserva>();
    
    public Participantes(  int DNI,string restriccionAlimentaria)
    :base(nombreCompleto,correo,telefono){
        this.DNI=DNI;
        this.restriccionAlimentaria=restriccionAlimentaria;
}
}
