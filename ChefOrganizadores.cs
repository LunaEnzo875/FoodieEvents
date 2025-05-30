namespace FoodieEvents;

public class ChefOrganizadores{

    private string NombreCompleto="";
    private int especialidad;
    private int nacionalidad;
    private int cantidadExperiencia;
    private string Correo="";
    private int Telefono;
public ChefOrganizadores(string nombreCompleto,int especialidad,int nacionalidad,int cantidadExperiencia,string Correo,int Telefono){
this.NombreCompleto=nombreCompleto;
this.especialidad=especialidad;
this.nacionalidad=nacionalidad;
this.Correo=Correo;
this.Telefono=Telefono;
}
    public string getNombreCompleto()
    {
        return this.NombreCompleto;
    }
    public int getespecialidad(){
        return this.especialidad;
    }
    public int getNacionalidad(){
        return this.nacionalidad;
    }
    public int getcantidadExperiencia(){
        return this.cantidadExperiencia;
    }
    public string GetCorreo()
    {
        return this.Correo;
    }
    public int GetTelefono(){
        return this.Telefono;
    }
}
