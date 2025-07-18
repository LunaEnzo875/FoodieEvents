namespace FoodieEvents
{
    public class ParticipanteEspecial:Persona
    {
        public string Critica { get; private set; }
        public int Estrellas { get; private set; }
        public List<Reserva> reservasList = new List<Reserva>();
        public ParticipanteEspecial(string NombreCompleto, string Correo, int telefono, string Critica, int Estrellas)
        : base(NombreCompleto, Correo, telefono)
        {
            this.Critica = Critica;
            this.Estrellas = Estrellas;
            Validaciones.ValidarEstrellas(Estrellas);
        }
    }
}
