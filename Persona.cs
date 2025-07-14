namespace FoodieEvents {
    public class Persona
    {
        public string NombreCompleto { get; private set; }
        public string Correo { get; private set; }
        public int telefono { get; private set; }

        public Persona(string NombreCompleto, string correo, int telefono)
        {
            NombreCompleto = NombreCompleto;
            Correo = correo;
            Validaciones.ValidarCorreo(Correo);
            Telefono = telefono;
            Validaciones.ValidarTelefono(Telefono);
        }
    }
}