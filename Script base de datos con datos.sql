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
INSERT [Departamento] ([Id_Departamento], [Nom_Departamento], [Id_Jefe], [Presupuesto], [Monto_Proceso]) VALUES (3, N'Credito', NULL, 120000.0000, 0.0000)
INSERT [Departamento] ([Id_Departamento], [Nom_Departamento], [Id_Jefe], [Presupuesto], [Monto_Proceso]) VALUES (4, N'Cobros', NULL, 10000.0000, 0.0000)
INSERT [Departamento] ([Id_Departamento], [Nom_Departamento], [Id_Jefe], [Presupuesto], [Monto_Proceso]) VALUES (5, N'Tesoreria', NULL, 500000.0000, 0.0000)
INSERT [Departamento] ([Id_Departamento], [Nom_Departamento], [Id_Jefe], [Presupuesto], [Monto_Proceso]) VALUES (6, N'Captacion', NULL, 200000.0000, 0.0000)
INSERT [Departamento] ([Id_Departamento], [Nom_Departamento], [Id_Jefe], [Presupuesto], [Monto_Proceso]) VALUES (7, N'Contabilidad', NULL, 200000.0000, 0.0000)
SET IDENTITY_INSERT [Departamento] OFF

SET IDENTITY_INSERT [Usuario] ON 
INSERT [Usuario] ([Id_Usuario], [Nombre], [Apellido1], [Apellido2], [Nom_Login], [Contraseña], [Id_Departamento]) VALUES (1, N'Christopher', N'Suárez', NULL, N'csuarez', N'123', 1)
INSERT [Usuario] ([Id_Usuario], [Nombre], [Apellido1], [Apellido2], [Nom_Login], [Contraseña], [Id_Departamento]) VALUES (2, N'Hellen', N'Ríos', NULL, N'hrios', N'123', 2)
INSERT [Usuario] ([Id_Usuario], [Nombre], [Apellido1], [Apellido2], [Nom_Login], [Contraseña], [Id_Departamento]) VALUES (3, N'Bryan', N'Gonzalez', NULL, N'BryanAGB', N'abc', 3)
INSERT [Usuario] ([Id_Usuario], [Nombre], [Apellido1], [Apellido2], [Nom_Login], [Contraseña], [Id_Departamento]) VALUES (4, N'Sergio', N'Brenes', NULL, N'SerBrenes', N'abc', 4)
INSERT [Usuario] ([Id_Usuario], [Nombre], [Apellido1], [Apellido2], [Nom_Login], [Contraseña], [Id_Departamento]) VALUES (5, N'Sergio', N'Morales', NULL, N'Zercho', N'123', 5)
INSERT [Usuario] ([Id_Usuario], [Nombre], [Apellido1], [Apellido2], [Nom_Login], [Contraseña], [Id_Departamento]) VALUES (6, N'Jhonattan', N'Mora', NULL, N'Cinque', N'123abc', 6)
INSERT [Usuario] ([Id_Usuario], [Nombre], [Apellido1], [Apellido2], [Nom_Login], [Contraseña], [Id_Departamento]) VALUES (7, N'Juanito', N'Lopez', NULL, N'Juanito', N'123', 7)
SET IDENTITY_INSERT [Usuario] OFF

SET IDENTITY_INSERT [Proveedor] ON 
INSERT [Proveedor] ([Id_Proveedor], [Nom_Proveedor], [Descripcion]) VALUES (1, N'Proveedor 1', 'Multiservicios')
INSERT [Proveedor] ([Id_Proveedor], [Nom_Proveedor], [Descripcion]) VALUES (2, N'Proveedor 2', 'Motores')
INSERT [Proveedor] ([Id_Proveedor], [Nom_Proveedor], [Descripcion]) VALUES (3, N'Proveedor 3', 'Limpieza')
INSERT [Proveedor] ([Id_Proveedor], [Nom_Proveedor], [Descripcion]) VALUES (4, N'Proveedor 4', 'Tecnologico')
INSERT [Proveedor] ([Id_Proveedor], [Nom_Proveedor], [Descripcion]) VALUES (5, N'Proveedor 5', 'Seguridad')
SET IDENTITY_INSERT [Proveedor] OFF

SET IDENTITY_INSERT [Producto] ON 
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (1, 1, N'Producto', N'Gafetes', 9000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (2, 1, N'Producto', N'PortaGafetes', 5000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (3, 1, N'Producto', N'Valla Publicitaria', 20000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (4, 2, N'Producto', N'Moto', 700000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (5, 2, N'Producto', N'Carro', 120000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (6, 2, N'Producto', N'Carro', 115000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (7, 3, N'Servicio', N'Alfombras', 80000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (8, 3, N'Servicio', N'Vidrios', 70000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (9, 3, N'Servicio', N'Paredes', 76000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (10, 4, N'Producto', N'Computadoras', 2200000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (11, 4, N'Producto', N'Tintas', 860000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (12, 4, N'Producto', N'Cable', 60000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (13, 5, N'Servicio', N'Guardas de Seguridad', 130000.0000)
INSERT [Producto] ([Id_Producto], [Id_Proveedor], [Tipo], [Nom_Producto], [Precio]) VALUES (14, 5, N'Producto', N'Camaras', 120000.0000)
SET IDENTITY_INSERT [Producto] OFF

SET IDENTITY_INSERT [Compra] ON 
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (1, N'Pago de servicio', N'Desc', 10000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (2, N'Pago de servicio', N'Desc', 30000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (3, N'Compra de moto', N'Desc', 2000000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (4, N'Compra de carro', N'Desc', 8000000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (5, N'Pago de servicio', N'Desc', 90000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (6, N'Pago de servicio', N'Desc', 92000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (7, N'Compra Articulos', N'Desc', 9000000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (8, N'Pago de servicio', N'Desc', 200000.0000)
INSERT [Compra] ([Id_Compra], [Titulo], [Descripcion], [Valor]) VALUES (9, N'Compra Articulos', N'Desc', 190000.0000)
SET IDENTITY_INSERT [Compra] OFF


INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (1, 1, 120)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (2, 2, 120)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (3, 3, 3)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (4, 4, 4)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (4, 5, 1)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (4, 6, 1)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (5, 7, 20)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (6, 8, 100)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (5, 9, 5)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (7, 10, 100)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (7, 11, 35)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (7, 12, 100)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (8, 13, 15)
INSERT [ProductoCompra] ([Id_Compra], [Id_Producto], [Cantidad]) VALUES (9, 14, 20)



SET IDENTITY_INSERT [Solicitud] ON 
INSERT [Solicitud] ([Id_Solicitud], [Id_Usuario], [Id_Compra], [Fecha_Solicitud], [Jefe_Aprovado], [Fecha_Jefe_Apro], [Gerencia_Aprovado], [Fecha_Gerencia_Apro], [Estado]) VALUES (1, 1, 1, CAST(N'2017-01-01' AS Date), NULL, NULL, NULL, NULL, N'Solicitada')
INSERT [Solicitud] ([Id_Solicitud], [Id_Usuario], [Id_Compra], [Fecha_Solicitud], [Jefe_Aprovado], [Fecha_Jefe_Apro], [Gerencia_Aprovado], [Fecha_Gerencia_Apro], [Estado]) VALUES (2, 1, 2, CAST(N'2017-01-01' AS Date), NULL, NULL, NULL, NULL, N'Solicitada')
INSERT [Solicitud] ([Id_Solicitud], [Id_Usuario], [Id_Compra], [Fecha_Solicitud], [Jefe_Aprovado], [Fecha_Jefe_Apro], [Gerencia_Aprovado], [Fecha_Gerencia_Apro], [Estado]) VALUES (4, 1, 3, CAST(N'2017-08-05' AS Date), NULL, NULL, NULL, NULL, N'Solicitada')
INSERT [Solicitud] ([Id_Solicitud], [Id_Usuario], [Id_Compra], [Fecha_Solicitud], [Jefe_Aprovado], [Fecha_Jefe_Apro], [Gerencia_Aprovado], [Fecha_Gerencia_Apro], [Estado]) VALUES (7, 1, 4, CAST(N'2017-08-05' AS Date), NULL, NULL, NULL, NULL, N'Solicitada')
SET IDENTITY_INSERT [Solicitud] OFF