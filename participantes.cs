namespace FoodieEvents;

public class Participantes
{
    private string nombreCompleto="";
    private string correo="";
    private int telefono;
    private int DNI;
    private int restriccionAlimentaria;
    public Participantes(string nombreCompleto,string correo,int telefono,int DNI,int restriccionAlimentaria){
this.nombreCompleto=nombreCompleto;
this.correo=correo; 
this.telefono=telefono;
this.DNI=DNI;

Validaciones.ValidarParticipantes(restriccionAlimentaria);
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
    public int getrestriccionAlimentaria(){
        return this.restriccionAlimentaria;
    }
}
