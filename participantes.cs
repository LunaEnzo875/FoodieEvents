namespace FoodieEvents;

public class Participantes
{
    private string nombreCompleto="";
    private string correo="";
    private int telefono;
    private int DNI;
    private string restriccionAlimentaria;
    public List<Reserva> reservasList = new List<Reserva>();
    
    public Participantes(string nombreCompleto,string correo,int telefono,int DNI,string restriccionAlimentaria){
this.nombreCompleto=nombreCompleto;
this.correo=correo; 
this.telefono=telefono;
this.DNI=DNI;
this.restriccionAlimentaria=restriccionAlimentaria;
}
    public string getnombreCompleto()
    {
        return this.nombreCompleto;
    }
    public string getcorreo()
    {
        return this.correo;
    }
    public int gettelefono(){
        return this.telefono;
    }
        public int getDNI(){
        return this.DNI;
    }
    public string getrestriccionAlimentaria(){
        return this.restriccionAlimentaria;
    }
}
