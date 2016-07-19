
create table Rutas(
 RutaId int identity(1,1) primary key,
 MensajeroId int references Mensajeros(MensajeroId),
 Direccion varchar(100),
 Ciudad varchar(50),
 Referencia varchar(200)
);

CREATE TABLE [dbo].[Bancas](
	[BancaId] [int] identity(1,1) primary key,
	[BanqueraId] [int] references Banqueras(BanqueraId),
	[EquipoId] [int] references Equipos(EquipoId),
	[RutaId] [int] references Rutas(RutaId)
);

create table Banqueras(
	BanqueraId int identity(1,1) primary key,
	Nombres varchar(80),
	Direccion varchar(100),
	Cedula varchar(10),
	Celular varchar(10),
	Telefono varchar(10),
	Fecha Datetime,
	Sexo bit
);

CREATE TABLE [dbo].[Equipos](
	[EquipoId] [int] identity(1,1) primary key,
	[MarcaEquipo] [varchar](20) NULL,
	[TipoEquipo] [varchar](12) NULL,
	[SerialNum] [varchar](30)
);

CREATE TABLE [dbo].[Entradas](
	[EntradaId] [int] NOT NULL,
	[EquipoId] [int] references Equipos(EquipoId),
);

CREATE TABLE [dbo].[Mensajeros](
	MensajeroId int IDENTITY(1,1) primary key,
	[Nombre] [varchar](30) NULL,
	[Cedula] [varchar](11) NULL,
	[Celular] [varchar](10) NULL,
	[Telefono] [varchar](10) NULL,
	[Direccion] [varchar](50) NULL,
	[FechaNacimiento] datetime,
	[Sexo] bit
) 

CREATE TABLE [dbo].[Prestamos](
	IdPrestamo int primary key,
	[IdEquipo] [int] references Equipos(EquipoId),
	IdBanca int references Bancas(BancaId),
	[IdMEnsajero] [int] references Mensajeros(MensajeroId),
	[FechaSalida] datetime NULL
);

CREATE TABLE [dbo].[Usuarios](
	Usuarioid int identity(1,1) primary key,
	[nombreusuario] [varchar](30) NULL,
	[contraseña] [varchar](20) NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL
);