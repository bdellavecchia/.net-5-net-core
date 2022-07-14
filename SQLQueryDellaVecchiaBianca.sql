USE master;
GO
CREATE DATABASE Parcial2;
GO

USE Parcial2;
GO

CREATE TABLE Equipo (
	Id int NOT NULL PRIMARY KEY,
	Nombre nvarchar(50) NOT NULL
);
GO

CREATE TABLE Jugador (
	Id int IDENTITY(1,1) PRIMARY KEY,
	Nombre nvarchar(50) NOT NULL,
	IdEquipo int NOT NULL REFERENCES Equipo(Id)
);
GO

INSERT INTO Equipo VALUES (1, 'Boca'),(2, 'River'), (3, 'San Lorenzo');
