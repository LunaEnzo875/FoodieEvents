using System;
namespace FoodieEvents
{
    public static class Validaciones
    {
        public static void ValidarEvento(int tipoEvento)
        {
            if (tipoEvento > 4)
            {
                throw new ArgumentException("evento no encontrado");
            }
        }
        public static void ValidarParticipantes(int restriccionAlimentaria)
        {
            if (restriccionAlimentaria > 4)
            {
                throw new ArgumentException("No valido");
            }
        }
        public static void ValidarReserva(int estadoReserva)
        {
            if (estadoReserva > 3)
            {
                throw new ArgumentException("Esta mal en algo");
            }
        }


        public static void ValidadorFecha(DateTime inicio, DateTime fin)
        {
            if (fin < inicio)
            {
                throw new ArgumentException("La fecha de fin no puede ser menor a la fecha de inicio");
            }
        }

        public static void ValidarOpcion(int opcion, int minimo, int maximo)
        {
            if (opcion < minimo || opcion > maximo)
            {
                throw new ArgumentException($"La opción debe estar entre {minimo} y {maximo}");
            }

        }
        public static void ValidarNumero(int Telefono)
        {
            if (Telefono < 100000000 || Telefono > 999999999)
            {
                throw new ArgumentException("El número de teléfono debe tener 9 dígitos");
            }
        }
                public static void ValidarTelefono(int telefono)
        {
            if (telefono < 100000000 || telefono > 999999999)
            {
                throw new ArgumentException("El número de teléfono debe tener 9 dígitos");
            }
        }
        public static void ValidarCorreo(string Correo)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(Correo, pattern);

            Console.WriteLine($"Is the email '{Correo}' valid? {isValid}");
        }

        public static void Validarcorreo(string correo)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(correo, pattern);
            
        Console.WriteLine($"este email '{correo}'  no es valido");
        }
    }
}

