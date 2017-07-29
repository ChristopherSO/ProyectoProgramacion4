--CREACION DE LA BASE DE DATOS PARA EL PROYECTO
CREATE DATABASE ProyectoProgra4;
GO

--USAR BD ProyectoProgra4
USE ProyectoProgra4;
GO

--CREACION DE TABLAS

--Tabla Departamento
CREATE TABLE Departamento (
	Id_Departamento INT IDENTITY(1,1) PRIMARY KEY,
	Nom_Departamento Varchar(20) NOT NULL,
	Id_Jefe INT NOT NULL,
	Presupuesto MONEY NOT NULL,
	Monto_Proceso MONEY NOT NULL
);


--Tabla Usuario
CREATE TABLE Usuario (
	Id_Usuario INT NOT NULL PRIMARY KEY,
	Nombre VARCHAR(45) NOT NULL,
	Apellido1 VARCHAR(45) NOT NULL,
	Apellido2 VARCHAR(45) NOT NULL,
	Contraseña VARCHAR(45) NOT NULL,
	Id_Departamento INT FOREIGN KEY REFERENCES Departamento(Id_Departamento)
);


--Tabla Proveedores
CREATE TABLE Proveedores (
	Id_Proveedor INT IDENTITY(1,1) PRIMARY KEY,
	Nom_Proveedor VARCHAR(60) NOT NULL,
	Descripcion VARCHAR(120)
);


--Tabla Productos
CREATE TABLE Productos (
	Id_Producto INT IDENTITY(1,1) PRIMARY KEY,
	Id_Proveedor INT FOREIGN KEY REFERENCES Proveedores(Id_Proveedor),
	Tipo VARCHAR(15) NOT NULL,
	Nom_Producto VARCHAR(60) NOT NULL,
	Precio MONEY NOT NULL
);


--Tabla Compras
CREATE TABLE Compras (
	Id_Compra INT IDENTITY(1,1) PRIMARY KEY,
	Titulo VARCHAR(60) NOT NULL,
	Descripcion VARCHAR(100) NOT NULL,
	Valor MONEY
);


--Tabla Productos Compra
CREATE TABLE ProductosCompra (
	Id_Compra INT FOREIGN KEY REFERENCES Compras(Id_Compra),
	Id_Producto INT FOREIGN KEY REFERENCES Productos(Id_Producto),
	PRIMARY KEY (Id_Compra, Id_Producto),
	Cantidad INT
);


--Tabla Solicitudes
CREATE TABLE Solicitudes (
	Id_Solicitud INT IDENTITY(1,1) PRIMARY KEY,
	Id_Usuario INT FOREIGN KEY REFERENCES Usuario(Id_Usuario),
	Id_Compra INT FOREIGN KEY REFERENCES Compras(Id_Compra),
	Fecha_Solicitud DATE NOT NULL,
	Id_Jefe_Aprovado INT NULL,
	Fecha_Jefe_Apro DATE NULL,
	Gerencia_Aprovado INT NULL,
	Fecha_Gerencia_Apro DATE NULL
);


--Tabla Ordenes de Compra
CREATE TABLE OrdenesCompra (
	Id_Orden INT IDENTITY(1,1) PRIMARY KEY,
	Id_Solicitud INT FOREIGN KEY REFERENCES Solicitudes(Id_Solicitud),
	Id_Proveedor INT FOREIGN KEY REFERENCES Proveedores(Id_Proveedor),
	Fecha_OrdenCompra DATE NOT NULL
);


--Tablas Movimientos
CREATE TABLE Movimientos (
	Id_Movimiento INT IDENTITY(1,1) PRIMARY KEY,
	Id_Departamento INT FOREIGN KEY REFERENCES Departamento(Id_Departamento),
	Id_Compra INT FOREIGN KEY REFERENCES Compras(Id_Compra),
	Fecha DATE NOT NULL,
	Tesorero_Proceso INT
);