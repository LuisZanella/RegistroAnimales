CREATE DATABASE veterinaria
GO
USE veterinaria
GO
CREATE TABLE Animal(
 Id INT IDENTITY PRIMARY KEY,
 Nombre VARCHAR(30),
 Precio FLOAT,
 Tipo VARCHAR(30)
)
GO
CREATE TABLE Usuario(
 IdUsuario  INT IDENTITY PRIMARY KEY,
 username VARCHAR(30) NOT NULL UNIQUE,
 contrasenia VARCHAR(30) NOT NUll
 ) 
GO


INSERT INTO Usuario(username, contrasenia)
		VALUES('admin','admin'),('ventas','12345');

GO
CREATE PROCEDURE sp_autenticar
		@username VARCHAR(30),
		@contrasenia VARCHAR(30)
AS
SELECT * FROM Usuario WHERE username = @username AND contrasenia = @contrasenia;
GO


INSERT INTO Animal(Nombre, Precio, Tipo)
			VALUES('Siames',1200, 'Felino'), ('Husky Siberiano',3700,'Canino'),('Hamster Dorado',320,'Roedor')
			GO

CREATE PROCEDURE sp_agregar
	@nombre VARCHAR(30),
	@precio FLOAT,
	@tipo	VARCHAR(30)
AS

INSERT INTO Animal(Nombre, Precio, Tipo)
			VALUES(@nombre,@precio,@tipo)

GO

SELECT * FROM Animal
GO