use AlmacenBancas;

CREATE TABLE [dbo].[Banqueras] (
    [BanqueraId] INT IDENTITY(1,1) primary key,
    [Nombres]    VARCHAR(80),
    [Apellidos]  Varchar(80),
    [Direccion]  VARCHAR(100),
    [Cedula]     VARCHAR(13),
    [Celular]    VARCHAR(12),
    [Telefono]   VARCHAR(12),
    [Fecha]      DATETIME,
    [Sexo]       varchar(1)
);

go

CREATE TABLE [dbo].[Mensajeros] (
    [MensajeroId]     INT IDENTITY(1,1) primary key,
    [Nombre]          VARCHAR(80),
    Apellido	      varchar(80),	
    [Cedula]          VARCHAR(13),
    [Celular]         VARCHAR(12),
    [Telefono]        VARCHAR(12),
    [Direccion]       VARCHAR(100),
    [FechaNacimiento] DATETIME,
    [Sexo]            varchar(1)
);

Go

CREATE TABLE [dbo].[PermisoUsuarios](
	[IdPermiso] [int] IDENTITY(1,1) primary key,
	[Detalle] [varchar](30),
);

go

Insert into PermisoUsuarios(Detalle)
 values('Administrador');

Insert into PermisoUsuarios(Detalle)
 values('Inivitado');


go

CREATE TABLE [dbo].[Usuarios] (
    [Usuarioid]     INT IDENTITY(1,1) primary key,
    [nombreusuario] VARCHAR(30),
    [contraseña]    VARCHAR(20),
    [nombre]        VARCHAR(30),
    [apellido]      VARCHAR(30),
    IdPermiso int references PermisoUsuarios(IdPermiso)
);

go






CREATE TABLE [dbo].[Rutas] (
    [RutaId]      INT IDENTITY(1,1) primary key,
    [MensajeroId] INT references Mensajeros(MensajeroId),
    [Direccion]   VARCHAR(100),
    [Ciudad]      VARCHAR(50),
    [Referencia]  VARCHAR(200),
    IdPermiso int references PermisoUsuarios
);


go

create table TiposEquipos(
 TipoId int identity(1,1) primary key,
 Detalle varchar(50)
);

Insert into Tiposequipos(Detalle)
 values('CPU');

Insert into Tiposequipos(Detalle)
 values('Monitor');

Insert into Tiposequipos(Detalle)
 values('Printer');

Insert into Tiposequipos(Detalle)
 values('Teclado');

Insert into Tiposequipos(Detalle)
 values('Mouse');



go

CREATE TABLE [dbo].[Equipos] (
    [EquipoId]    INT IDENTITY(1,1) primary key,
    [MarcaEquipo] VARCHAR(20),
    [TipoId]  int References TiposEquipos(TipoId),
    [SerialNum]   VARCHAR(30),
	FechaIngreso  Datetime
    
);

go
create table EquiposAsignados(
 IdEquiposAsignados int identity(1,1) primary key,
 Detalle varchar(100)

);

go


CREATE TABLE [dbo].[Bancas] (
    BancaId    INT IDENTITY(1, 1) primary key,
    [BanqueraId] INT references Banqueras(BanqueraId),
    IdEquiposAsignados int references EquiposAsignados(IdequiposAsignados),
    [RutaId]     INT references Rutas(RutaId)
);

go

CREATE TABLE [dbo].[Entradas] (
    [EntradaId] INT primary key,
    [EquipoId]  INT references Equipos(EquipoId),
    FechaEntrada DateTime
);



go


CREATE TABLE [dbo].[Prestamos] (
    [IdPrestamo]  int identity(1,1) primary key,
    EquipoId    INT references Equipos(EquipoId),
    [IdBanca]     INT references Bancas(BancaId),
    [IdMEnsajero] INT references Mensajeros(MensajeroId),
    [FechaSalida] DATETIME
);

go

create table PaqueteEquipos(
 Id int identity(1,1) primary key,
 EquipoId int references Equipos(EquipoId),
 IdEquiposAsignados int references EquiposAsignados(IdEquiposAsignados)

  
);