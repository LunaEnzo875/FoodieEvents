namespace FoodieEvents
{
    public class ParticipanteEspecial
    {
        public string Critica { get; private set; }
        public int Estrellas { get; private set; }
        public List<Reserva> reservasList = new List<Reserva>();
        public ParticipanteEspecial(string Critica, int Estrellas, Reservas reservas)
        : base(NombreCompleto, Correo, Telefono)
        {
            Critica = Critica;
            Estrellas = Estrellas;
            reservas = reservas;
        }
    }
}
