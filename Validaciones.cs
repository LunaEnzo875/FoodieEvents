using System;
namespace FoodieEvents
{
    public static class Validaciones
    {

        public static void ValidadorFecha(DateTime inicio, DateTime fin)
        {
            if (fin < inicio)
            {
                throw new ArgumentException("La fecha de fin no puede ser menor a la fecha de inicio");
            }
        }

        public static void ValidarMaxima(int CapacidadMaxima)
        {
            if (CapacidadMaxima < 0 || CapacidadMaxima > 101)
            {
                throw new ArgumentException("La capacidad es imposible cuando debe ser mayor a 0 y menor a 101");
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

            Console.WriteLine($"Is the email '{Correo}' no es valido");
        }

        public static void Validarcorreo(string correo)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(correo, pattern);
            
        Console.WriteLine($"este email '{correo}'  no es valido");
        }
    }
}
