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


--INSERSIÓN DE DATOS

SET IDENTITY_INSERT [Departamento] ON 
INSERT [Departamento] ([Id_Departamento], [Nom_Departamento], [Id_Jefe], [Presupuesto], [Monto_Proceso]) VALUES (1, N'Tecnología', NULL, 100000.0000, 0.0000)
INSERT [Departamento] ([Id_Departamento], [Nom_Departamento], [Id_Jefe], [Presupuesto], [Monto_Proceso]) VALUES (2, N'Gerencia', NULL, 1000000.0000, 0.0000)
SET IDENTITY_INSERT [Departamento] OFF

SET IDENTITY_INSERT [Usuario] ON 
INSERT [Usuario] ([Id_Usuario], [Nombre], [Apellido1], [Apellido2], [Nom_Login], [Contraseña], [Id_Departamento]) VALUES (1, N'Christopher', N'Suárez', NULL, N'csuarez', N'123', 1)
INSERT [Usuario] ([Id_Usuario], [Nombre], [Apellido1], [Apellido2], [Nom_Login], [Contraseña], [Id_Departamento]) VALUES (2, N'Hellen', N'Ríos', NULL, N'hrios', N'123', 2)
SET IDENTITY_INSERT [Usuario] OFF

SET IDENTITY_INSERT [Proveedor] ON 
INSERT [Proveedor] ([Id_Proveedor], [Nom_Proveedor], [Descripcion]) VALUES (1, N'Proveedor 1', NULL)
INSERT [Proveedor] ([Id_Proveedor], [Nom_Proveedor], [Descripcion]) VALUES (2, N'Proveedor 2', NULL)
SET IDENTITY_INSERT [Proveedor] OFF

SET IDENTITY_INSERT [Producto] ON 
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (1, 1, N'Producto', N'Producto 1', 10000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (2, 1, N'Producto', N'Producto 2', 15000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (3, 1, N'Servicio', N'Servicio 1', 50000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (4, 1, N'Servicio', N'Servicio 2', 70000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (5, 2, N'Producto', N'Producto 3', 12000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (6, 2, N'Servicio', N'Servicio 3', 65000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (7, 2, N'Servicio', N'Servicio 4', 80000.0000)
SET IDENTITY_INSERT [Producto] OFF

SET IDENTITY_INSERT [Compra] ON 
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (1, N'Pago de servicio', N'Desc', 100000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (2, N'Pago de servicio', N'Desc', 800000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (3, N'Compra de moto', N'Desc', 2000000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (4, N'Compra de carro', N'Desc', 8000000.0000)
SET IDENTITY_INSERT [Compra] OFF

SET IDENTITY_INSERT [Solicitud] ON 
INSERT [Solicitud] ([Id_Solicitud], [Id_Usuario], [Id_Compra], [Fecha_Solicitud], [Jefe_Aprovado], [Fecha_Jefe_Apro], [Gerencia_Aprovado], [Fecha_Gerencia_Apro], [Estado]) VALUES (1, 1, 1, CAST(N'2017-01-01' AS Date), NULL, NULL, NULL, NULL, N'Solicitada')
INSERT [Solicitud] ([Id_Solicitud], [Id_Usuario], [Id_Compra], [Fecha_Solicitud], [Jefe_Aprovado], [Fecha_Jefe_Apro], [Gerencia_Aprovado], [Fecha_Gerencia_Apro], [Estado]) VALUES (2, 1, 2, CAST(N'2017-01-01' AS Date), NULL, NULL, NULL, NULL, N'Solicitada')
INSERT [Solicitud] ([Id_Solicitud], [Id_Usuario], [Id_Compra], [Fecha_Solicitud], [Jefe_Aprovado], [Fecha_Jefe_Apro], [Gerencia_Aprovado], [Fecha_Gerencia_Apro], [Estado]) VALUES (4, 1, 3, CAST(N'2017-08-05' AS Date), NULL, NULL, NULL, NULL, N'Solicitada')
INSERT [Solicitud] ([Id_Solicitud], [Id_Usuario], [Id_Compra], [Fecha_Solicitud], [Jefe_Aprovado], [Fecha_Jefe_Apro], [Gerencia_Aprovado], [Fecha_Gerencia_Apro], [Estado]) VALUES (7, 1, 4, CAST(N'2017-08-05' AS Date), NULL, NULL, NULL, NULL, N'Solicitada')
SET IDENTITY_INSERT [Solicitud] OFF