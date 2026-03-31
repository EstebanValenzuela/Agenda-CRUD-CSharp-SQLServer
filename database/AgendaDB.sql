CREATE database Agenda;
GO

use Agenda;
Create table Contactos 
(
	Id int identity (1,1) primary key,
	Nombre nvarchar(25),
	Apellido nvarchar(25),
	FechaNacimiento Date,
	Direccion nvarchar (100),
	Genero nvarchar(15),
	EstadoCivil nvarchar(20),
	Movil nvarchar(20),
	Telefono nvarchar(20),
	CorreoElectronico nvarchar(100),

	
	constraint Movil_format
	check (Movil like '([0-9][0-9][0-9])-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),

	constraint Telefono_format
	check (Telefono like '([0-9][0-9][0-9])-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),

	CONSTRAINT CK_Email_Formato
    CHECK (CorreoElectronico LIKE '%@%.%')
);

select * from Contactos;
select * from Usuarios;

create table Usuarios
(
	id int identity primary key,
	usuario varchar(20),
	clave varchar(20)
);

insert into Usuarios values
('admin','1234')


go
CREATE PROCEDURE sp_InsertarContacto

    @Nombre NVARCHAR(25),
    @Apellido NVARCHAR(25),
    @FechaNacimiento DATE,
    @Direccion NVARCHAR(100),
    @Genero NVARCHAR(15),
    @EstadoCivil NVARCHAR(20),
    @Movil NVARCHAR(20),
    @Telefono NVARCHAR(20),
    @Correo NVARCHAR(100)
AS
BEGIN
   INSERT INTO Contactos
    (Nombre, Apellido, FechaNacimiento, Direccion, Genero, EstadoCivil, Movil, Telefono, CorreoElectronico)
   VALUES
    (@Nombre, @Apellido, @FechaNacimiento, @Direccion, @Genero, @EstadoCivil, @Movil, @Telefono, @Correo)
END

go
create procedure sp_ListaContactos
	as
	begin
		select * from Contactos
end

go
CREATE PROCEDURE sp_BuscarContacto
    @Nombre NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Contactos
    WHERE Nombre LIKE '%' + @Nombre + '%'
END

go
CREATE PROCEDURE sp_ModificarContacto
    @Id INT,
    @Nombre NVARCHAR(25),
    @Apellido NVARCHAR(25),
    @FechaNacimiento DATE,
    @Direccion NVARCHAR(100),
    @Genero NVARCHAR(15),
    @EstadoCivil NVARCHAR(20),
    @Movil NVARCHAR(20),
    @Telefono NVARCHAR(20),
    @Correo NVARCHAR(100)
AS
BEGIN
    UPDATE Contactos SET
        Nombre = @Nombre,
        Apellido = @Apellido,
        FechaNacimiento = @FechaNacimiento,
        Direccion = @Direccion,
        Genero = @Genero,
        EstadoCivil = @EstadoCivil,
        Movil = @Movil,
        Telefono = @Telefono,
        CorreoElectronico = @Correo
    WHERE Id = @Id
END

go
create procedure sp_EliminarContacto
    @Id INT
   as
   begin
    delete from Contactos where Id = @Id
   end