use AlmacenBancas;
go

create table HojaEntrada(EquipoId int, 
 MarcaEquipo varchar(20),
 TipoEquipo varchar(20),
 NumSer varchar(30));

go
create table Mensajero(Id int identity(1,1),
 Nombre varchar(30),
 Cedula varchar(11),
 Celular varchar(10),
 Telefono varchar(10),
 Direccion varchar(50),
 FechaNacimiento varchar(6),
 Sexo char);

 go
 create table Equipo(IdEquipo int identity(1,1),
  MarcaEquipo varchar(20),
  TipoEquipo varchar(12),
  SerialNum varchar(30));
  go

  create table Banca(NumeroBanca varchar(3),
   CelularBanquera varchar(10),
   NombreBanquera varchar(30),
   IdEquipo int,
   TiposEquipos varchar(12),
   Ruta varchar(3),
   CedulaMensajero varchar(11));

   go

   create table HojaSalida(IdEquipo int,
    NumeroBanca varchar(3),
	IdMEnsajero int,
	FechaSalida varchar(6));

	go

	create table HojaDevoluciones(IdEquipo int,
	NumroBanca varchar(3),
	FechaDevolucion varchar(6),
	MensajeroId int);





