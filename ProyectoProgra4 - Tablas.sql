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
	Id_Jefe INT,
	Presupuesto MONEY NOT NULL,
	Monto_Proceso MONEY NOT NULL
);


--Tabla Usuario
CREATE TABLE Usuario (
	Id_Usuario INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(45) NOT NULL,
	Apellido1 VARCHAR(45) NOT NULL,
	Apellido2 VARCHAR(45),
	Nom_Login VARCHAR(20) NOT NULL,
	CONSTRAINT AK_LOGIN UNIQUE(Nom_Login),
	Contraseña VARCHAR(45) NOT NULL,
	Id_Departamento INT FOREIGN KEY REFERENCES Departamento(Id_Departamento)
);


--Tabla Proveedores
CREATE TABLE Proveedor (
	Id_Proveedor INT IDENTITY(1,1) PRIMARY KEY,
	Nom_Proveedor VARCHAR(60) NOT NULL,
	Descripcion VARCHAR(120)
);


--Tabla Productos
CREATE TABLE Producto (
	Id_Producto INT IDENTITY(1,1) PRIMARY KEY,
	Id_Proveedor INT FOREIGN KEY REFERENCES Proveedor(Id_Proveedor),
	Tipo VARCHAR(15) NOT NULL,
	Nom_Producto VARCHAR(60) NOT NULL,
	Precio MONEY NOT NULL
);


--Tabla Compras
CREATE TABLE Compra (
	Id_Compra INT IDENTITY(1,1) PRIMARY KEY,
	Titulo VARCHAR(60) NOT NULL,
	Descripcion VARCHAR(100),
	Valor MONEY
);


--Tabla Productos Compra
CREATE TABLE ProductoCompra (
	Id_Compra INT FOREIGN KEY REFERENCES Compra(Id_Compra),
	Id_Producto INT FOREIGN KEY REFERENCES Producto(Id_Producto),
	PRIMARY KEY (Id_Compra, Id_Producto),
	Cantidad INT
);


--Tabla Solicitudes
CREATE TABLE Solicitud (
	Id_Solicitud INT IDENTITY(1,1) PRIMARY KEY,
	Id_Usuario INT FOREIGN KEY REFERENCES Usuario(Id_Usuario),
	Id_Compra INT FOREIGN KEY REFERENCES Compra(Id_Compra),
	Fecha_Solicitud DATE NOT NULL,
	Jefe_Aprovado VARCHAR(45) NULL,
	Fecha_Jefe_Apro DATE NULL,
	Gerencia_Aprovado VARCHAR(45) NULL,
	Fecha_Gerencia_Apro DATE NULL,
	Estado VARCHAR(10) NOT NULL
);


--Tabla Ordenes de Compra
CREATE TABLE OrdenCompra (
	Id_Orden INT IDENTITY(1,1) PRIMARY KEY,
	Id_Solicitud INT FOREIGN KEY REFERENCES Solicitud(Id_Solicitud),
	Id_Proveedor INT FOREIGN KEY REFERENCES Proveedor(Id_Proveedor),
	Fecha_OrdenCompra DATE NOT NULL
);


--Tablas Movimientos
CREATE TABLE Movimiento (
	Id_Movimiento INT IDENTITY(1,1) PRIMARY KEY,
	Id_Departamento INT FOREIGN KEY REFERENCES Departamento(Id_Departamento),
	Id_Compra INT FOREIGN KEY REFERENCES Compra(Id_Compra),
	Fecha DATE NOT NULL,
	Tesorero_Proceso INT
);

