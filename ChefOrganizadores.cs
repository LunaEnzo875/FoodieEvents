namespace FoodieEvents;

public class ChefOrganizadores{
    private string especialidad;
    private string nacionalidad;
    private int cantidadExperiencia;
    public ChefOrganizadores(string especialidad, string nacionalidad, int cantidadExperiencia)
        : base(NombreCompleto, Correo, Telefono)
    {
        this.especialidad = especialidad;
        this.nacionalidad = nacionalidad;
        this.cantidadExperiencia = cantidadExperiencia;
}
    public string getNombreCompleto()
    {
        return this.NombreCompleto;
    }
    public string getespecialidad(){
        return this.especialidad;
    }
    public string getNacionalidad(){
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
