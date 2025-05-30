using FoodieEvents;

//eventos
Console.WriteLine("Ingrese el nombre del evento");
string  nombre =Console.ReadLine();

Console.WriteLine("Ingrese una descripcion del evento");
string descripcion =Console.ReadLine();

Console.WriteLine("Ingrese el tipo de evento(1-cata,2-feria,3-clase,4-cena temática)");
int tipoEvento = int.Parse(Console.ReadLine());
Validaciones.ValidarOpcion(tipoEvento, 1, 4);

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
Console.WriteLine("Nombre:" + eventos.getNombre());
Console.WriteLine("Descripcion:"+ eventos.descripcion);
Console.WriteLine("El tipo del evento es:"+eventos.tipoEvento);
Console.WriteLine("inicio del evento:"+eventos.inicio);
Console.WriteLine("Fin del evento:"+eventos.fin);
Console.WriteLine("Capacidad Maxima de entradas"+eventos.capacidadMaxima);
Console.WriteLine("Precio de la entrada"+eventos.precioEntrada);
Console.WriteLine("La ubicacion es: "+eventos.ubicacion);

//Participantes
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
int restriccionAlimentaria=int.Parse(Console.ReadLine());

Participantes participantes=new Participantes(nombreCompleto,correo,telefono,DNI,restriccionAlimentaria);
Console.WriteLine("El nombre Completo:"+participantes.nombreCompleto);
Console.WriteLine("El correo electronico es:"+participantes.correo);
Console.WriteLine("Su numero de telefono es:"+participantes.telefono);
Console.WriteLine("Su DNI es:"+ participantes.DNI);
Console.WriteLine("Tiene restriccion Alimentaria?:"+ participantes.restriccionAlimentaria);

//Chef Organizadores
Console.WriteLine("Ingrese nombre completo  del chef/Organizador");
string NombreCompleto=Console.ReadLine();

Console.WriteLine("Ingrese su especialidad");
int especialidad=int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu nacionalidad");
int nacionalidad=int.Parse(Console.ReadLine());

Console.WriteLine("Cuantos años de experiencia tienes?");
int cantidadExperiencia=int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa correo del chef/Organizador");
string Correo =Console.ReadLine();
Validaciones.ValidarCorreo(Correo);

Console.WriteLine("Ingrese su numero de telefono(Chef/Organizador)");
int Telefono=int.Parse(Console.ReadLine());
Validaciones.ValidarNumero(Telefono);

ChefOrganizadores chefOrganizadores=new ChefOrganizadores(NombreCompleto,especialidad,nacionalidad,cantidadExperiencia,Correo,Telefono);
Console.WriteLine("El nombre Completo:"+chefOrganizadores.NombreCompleto);
Console.WriteLine("Su especialidad:"+chefOrganizadores.especialidad);
Console.WriteLine("Su nacionalidad es:"+chefOrganizadores.nacionalidad);
Console.WriteLine("Años de experiencia:"+chefOrganizadores.cantidadExperiencia);
Console.WriteLine("El correo electronico es:"+chefOrganizadores.Correo);
Console.WriteLine("Su numero de telefono es:"+chefOrganizadores.Telefono);

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
Console.WriteLine(" su inscripcion:" + reserva.inscripcion);
Console.WriteLine(" la fecha del evento :" + reserva.fecha);
Console.WriteLine(" el metodo de pago:" + reserva.metodoPago);
Console.WriteLine("el estado de la reserva:" + reserva.estadoReserva);
