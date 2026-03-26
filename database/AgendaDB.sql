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