namespace FoodieEvents;

public class Participantes:Persona
{
    public int DNI { get; private set; }
    public string restriccionAlimentaria { get;private set; }
    public List<Reserva> reservasList = new List<Reserva>();
    
    public Participantes(string NombreCompleto, string Correo,int telefono,  int DNI,string restriccionAlimentaria)
    :base(NombreCompleto,Correo,telefono){
        this.DNI=DNI;
        this.restriccionAlimentaria=restriccionAlimentaria;
}
}
