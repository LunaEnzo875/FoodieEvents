
//Participantes
List<Participantes> participantesList = new List<Participantes>
{

};

Console.WriteLine("Ingrese su nombre completo de participante");
string  nombreCompleto=Console.ReadLine();

Console.WriteLine("Ingrese su correo del participante");
string correo=Console.ReadLine();
Validaciones.Validarcorreo(correo);

Console.WriteLine("Ingrese su numero de telefono de participante");
int telefono=int.Parse(Console.ReadLine());
Validaciones.ValidarTelefono(telefono);

Console.WriteLine("Ingrese su DNI");
int DNI=int.Parse(Console.ReadLine());

Console.WriteLine("¿Tiene una restriccion alimentaria?");
string restriccionAlimentaria=Console.ReadLine();

Participantes participantes=new Participantes(nombreCompleto,correo,telefono,DNI,restriccionAlimentaria);
Console.WriteLine("El nombre Completo:"+participantes.getnombreCompleto());
Console.WriteLine("El correo electronico es:"+participantes.getcorreo());
Console.WriteLine("Su numero de telefono es:"+participantes.gettelefono());
Console.WriteLine("Su DNI es:"+ participantes.getDNI());
Console.WriteLine("Tiene restriccion Alimentaria?:"+ participantes.getrestriccionAlimentaria());
