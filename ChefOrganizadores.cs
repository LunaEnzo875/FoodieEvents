namespace FoodieEvents;

public class ChefOrganizadores : Persona
{
    public  string especialidad{ get; private set; }
    public string nacionalidad{ get; private set; }
    public int cantidadExperiencia{ get; private set; }
    public ChefOrganizadores(string NombreCompleto, string Correo,int telefono, string especialidad, string nacionalidad, int cantidadExperiencia)
        : base(NombreCompleto, Correo, telefono)
    {
        this.especialidad = especialidad;
        this.nacionalidad = nacionalidad;
        this.cantidadExperiencia = cantidadExperiencia;
    }
}