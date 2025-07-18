
using FoodieEvents;

//eventos
Console.WriteLine("Ingrese el nombre del evento");
string  nombre =Console.ReadLine();

Console.WriteLine("Ingrese una descripcion del evento");
string descripcion =Console.ReadLine();

Console.WriteLine("Ingrese el tipo de evento");
string tipoEvento = Console.ReadLine();

Console.WriteLine("Ingrese la fecha de inicio el evento(yyyy-MM-dd):"); 
DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
Console.WriteLine(inicio);

DateTime fin;

    Console.WriteLine("Ingrese la fecha del fin del evento(yyyy-MM-dd):");
    fin = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
    Validaciones.ValidadorFecha(inicio, fin);
    Console.WriteLine(fin);


Console.WriteLine("Ingrese la ubicacion donde estara el evento");
string ubicacion =Console.ReadLine();

Eventos eventos = new Eventos(nombre,descripcion,tipoEvento,inicio,fin,ubicacion);
Console.WriteLine("Nombre:" + nombre);
Console.WriteLine("Descripcion:"+ descripcion);
Console.WriteLine("El tipo del evento es:"+tipoEvento);
Console.WriteLine("inicio del evento:"+inicio);
Console.WriteLine("Fin del evento:"+fin);
Console.WriteLine("Capacidad Maxima de entradas"+ubicacion);



//Chef Organizadores

Console.WriteLine("Ingrese nombre completo  del chef/Organizador");
string? NombreCompleto=Console.ReadLine();

Console.WriteLine("Ingrese su especialidad");
string especialidad=Console.ReadLine();

Console.WriteLine("Ingresa tu nacionalidad");
string nacionalidad=Console.ReadLine();

Console.WriteLine("Cuantos años de experiencia tienes?");
int cantidadExperiencia=int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa correo del chef/Organizador");
string Correo =Console.ReadLine();
Validaciones.ValidarCorreo(Correo);

Console.WriteLine("Ingrese su numero de telefono(Chef/Organizador)");
int telefono=int.Parse(Console.ReadLine());

ChefOrganizadores chefOrganizadores=new ChefOrganizadores( NombreCompleto,  Correo, telefono,  especialidad,  nacionalidad,  cantidadExperiencia);
Console.WriteLine("El nombre Completo:"+chefOrganizadores.NombreCompleto);
Console.WriteLine("Su especialidad:"+chefOrganizadores.Correo);
Console.WriteLine("Su nacionalidad es:"+chefOrganizadores.telefono);
Console.WriteLine("Años de experiencia:"+chefOrganizadores.especialidad);
Console.WriteLine("El correo electronico es:"+chefOrganizadores.nacionalidad);
Console.WriteLine("Su numero de telefono es:" + chefOrganizadores.cantidadExperiencia);

//Participantes

Console.WriteLine("Ingrese su nombre completo de participante");
  NombreCompleto = Console.ReadLine();

Console.WriteLine("Ingrese su correo del participante");
 Correo =Console.ReadLine();
Validaciones.ValidarCorreo(Correo);

Console.WriteLine("Ingrese su numero de telefono de participante");
 telefono=int.Parse(Console.ReadLine());
Validaciones.ValidarTelefono(telefono);

Console.WriteLine("Ingrese su DNI");
int DNI=int.Parse(Console.ReadLine());

Console.WriteLine("¿Tiene una restriccion alimentaria?");
string restriccionAlimentaria=Console.ReadLine();

Participantes participantes=new Participantes(NombreCompleto,Correo,telefono,DNI,restriccionAlimentaria);
Console.WriteLine("El nombre Completo:"+NombreCompleto);
Console.WriteLine("El correo electronico es:"+Correo);
Console.WriteLine("Su numero de telefono es:"+telefono);
Console.WriteLine("Su DNI es:"+ DNI);
Console.WriteLine("Tiene restriccion Alimentaria?:"+ restriccionAlimentaria);


//Reservas

Console.WriteLine("Ingrese su inscripcion");
string inscripcion=Console.ReadLine();

Console.WriteLine("Indica la fecha del evento");
DateTime fecha=DateTime.ParseExact(Console.ReadLine(),"yyyy-MM-dd", null);

Console.WriteLine("Ingrese su metodo de pago");
int metodoPago=int.Parse(Console.ReadLine());

Console.WriteLine("Indique el estado de la reserva");
short estadoReserva=short.Parse(Console.ReadLine());

Reserva reserva=new Reserva(participantes,inscripcion, fecha, metodoPago, estadoReserva);
Console.WriteLine(" su inscripcion:" + participantes);
Console.WriteLine(" la fecha del evento :" + inscripcion);
Console.WriteLine(" el metodo de pago:" + fecha);
Console.WriteLine("el estado de la reserva:" + metodoPago);
Console.WriteLine("El estado de la reserva:"+estadoReserva);

//ParticipanteEspecial
Console.WriteLine("Ingrese su nombre completo de participante");
  NombreCompleto = Console.ReadLine();

Console.WriteLine("Ingrese su correo del participante");
 Correo =Console.ReadLine();
Validaciones.ValidarCorreo(Correo);

Console.WriteLine("Ingrese su numero de telefono de participante");
 telefono=int.Parse(Console.ReadLine());
Validaciones.ValidarTelefono(telefono);

Console.WriteLine("Ingrese su critica");
string Critica = Console.ReadLine();

Console.WriteLine("");
int Estrellas = int.Parse(Console.ReadLine());

ParticipanteEspecial participanteEspecial = new ParticipanteEspecial(NombreCompleto, Correo, telefono, Critica, Estrellas);
Console.WriteLine("Su nombre es:" + NombreCompleto);