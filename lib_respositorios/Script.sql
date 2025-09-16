Create database TiendaRopa
go
Use TiendaRopa
go

--TABLAS INDIVIDUALES SIN CLAVE FORANEA

Create table Clientes(
Id int Primary key IDENTITY(1,1),
Cedula nvarchar(50)  not null,
Nombre nvarchar(50) not null,
Apellido Nvarchar(50) not null,
Telefono int not null,
Direccion Nvarchar(50),
Email Nvarchar(100) unique not null,
);
go

Create table Puesto(
Id int primary key identity(1,1),
Nombre Nvarchar(50)  not null,
);
go

Create table Proveedores(
Id int Primary key IDENTITY(1,1),
RUT nvarchar(50)  not null,
Nombre_Empresa nvarchar(50) not null,
Nombre_Contacto Nvarchar(50) not null,
Telefono int not null,
Direccion Nvarchar(50),
Emaixl Nvarchar(100) unique not null,
);
go

Create table Marcas(
Id int primary key identity(1,1),
Nombre Nvarchar(50) not null,
Pais_Origen Nvarchar(50) not null,
);
go

Create table Categorias(
Id int primary key identity(1,1),
Nombre Nvarchar(50) not null,
);
go

Create table Colores(
Id int primary key identity(1,1),
Nombre Nvarchar(50) not null,
Codigo_Hexa Nvarchar(50) not null,
);
go

Create table Tallas(
Id int primary key identity(1,1),
Descripcion Nvarchar not null
);
go

Create table Promociones(
Id int primary key identity(1,1),
Codigo nvarchar(50) not null,
Descripcion Nvarchar(100) not null,
Porcentaje Decimal(10,2)  not null,
Valor_Descuento Decimal (10,2) not null,
Fecha_inicio DATETIME not null,
Fecha_Fin DATETIME not null,
);
go

--TABLAS CON CLAVES FORANEAS
Create table Empleados(
Id int Primary key IDENTITY(1,1),
Cedula nvarchar(50) not null,
Nombre nvarchar(50) not null,
Apellido Nvarchar(50) not null,
Telefono int not null,
Direccion Nvarchar(50),
Email Nvarchar(100) unique not null,
Id_Puesto int not null,
Fecha_Contratacion DATETIME not null,

foreign key (Id_Puesto) references Puesto(Id),
);
go
Create table Productos(
Id int primary key identity(1,1),

Id_Marca int not null,
Id_Categoria int not null,

Nombre Nvarchar(100) not null,
Descripcion Nvarchar(300) not null,
Precio_Compra Decimal (10,2) not null,
Precio_Venta Decimal (10,2) not null,

foreign key (Id_Marca) references Marcas(Id),
foreign key (Id_Categoria) references Categorias(Id),

);
go

Create table Inventario(
Id int primary key identity(1,1),
Id_Producto int not null,
Id_Talla int not null,
Id_Color int not null,
Cantidad int not null,

foreign key (Id_Producto) references Productos(Id),
foreign key (Id_Talla) references Tallas(Id),
foreign key (Id_Color) references Colores(Id),

);
go

Create table Compras(
Id int primary key identity(1,1),
Id_Proveedor int not null,
Id_Empleado int not null,
Fecha_Compra DATETIME not null,
Total Decimal(10,2) not null,
Impuestos Decimal(10,2) not null,

foreign key (Id_Proveedor) references Proveedores(Id),
foreign key (Id_Empleado) references Empleados(Id),

);
go

Create table DetalleCompras(
Id int primary key identity(1,1),
Id_Compra int not null,
Id_Producto int not null,
Id_Talla int not null,
Id_Color int not null,
Cantidad Int not null,
Precio_Unitario Decimal(10,2) not null,

foreign key (Id_Compra) references Compras(Id),
foreign key (Id_Producto) references Productos(Id),
foreign key (Id_Talla) references Tallas(Id),
foreign key (Id_Color) references Colores(Id),

);
go

Create table Ventas(
Id int primary key identity(1,1),
Id_Cliente int not null,
Id_Empleado int not null,
Fecha_Venta DATETIME not null,
Total Decimal(10,2) not null,
Impuestos Decimal(10,2) not null,

foreign key (Id_Cliente) references Clientes(Id),
foreign key (Id_Empleado) references Empleados(Id),

);
go

Create table DetalleVentas(
Id int primary key identity(1,1),
Id_Venta int not null,
Id_Producto int not null,
Id_Talla int not null,
Id_Color int not null,
Id_Promocion int null,
Cantidad Int not null,
Precio_Unitario Decimal(10,2) not null,

foreign key (Id_Venta) references Ventas(Id),
foreign key (Id_Producto) references Productos(Id),
foreign key (Id_Talla) references Tallas(Id),
foreign key (Id_Color) references Colores(Id),
foreign key (Id_Promocion) references Promociones(Id),

);
go

Create table Devoluciones(
Id int primary key identity(1,1),
Id_Venta int not null,
Id_Producto int not null,
Id_Talla int not null,
Id_Color int not null,
Cantidad Int not null,
Motivo Nvarchar(300) not null,
Fecha_Devolucion DATETIME not null,

foreign key (Id_Venta) references Ventas(Id),
foreign key (Id_Producto) references Productos(Id),
foreign key (Id_Talla) references Tallas(Id),
foreign key (Id_Color) references Colores(Id),
);
go
Insert into Clientes(Cedula, Nombre, Apellido, Telefono, Direccion, Email)
values
('10','Juan', 'Pérez', '3001234567', 'Calle 10 #15-20', 'juan.perez@mail.com'),
('20','María', 'Gómez', '3019876543', 'Carrera 25 #8-30', 'maria.gomez@mail.com'),
('30','Carlos', 'Ruiz', '3024567890', 'Avenida 3 #45-67', 'carlos.ruiz@mail.com'),
('40','Laura', 'Torres', '3031122334', 'Calle 50 #22-15', 'laura.torres@mail.com'),
('50','Pedro', 'López', '3049988776', 'Carrera 12 #5-40', 'pedro.lopez@mail.com');
go
insert into Puesto(Nombre)
values
('Gerente'),
('Asesor'),
('Auxiliar de Bodega'),
('Jefe de Bodega'),
('Jefe de Ventas');
go 
insert into Proveedores (RUT,Nombre_Empresa,Nombre_Contacto,Telefono, Direccion, Email)
values
('900123456-7', 'Moda Urbana S.A.', 'Laura Martínez', '3104567890', 'Calle 12 #45-30 Bogotá', 'contacto@modaurbana.com'),
('901234567-8', 'Estilo y Confort Ltda.', 'Carlos Ramírez', '3119876543', 'Carrera 7 #80-25 Medellín', 'ventas@estiloyconfort.com'),
('902345678-9', 'Ropa Joven S.A.S.', 'Ana Torres', '3121234567', 'Avenida 30 #10-15 Cali', 'info@ropajoven.com'),
('903456789-0', 'Fashion Plus', 'Jorge López', '3137654321', 'Calle 100 #15-20 Barranquilla', 'jorge@fashionplus.com'),
('904567890-1', 'Trendy Clothes', 'Mariana Gómez', '3148765432', 'Carrera 50 #22-35 Bucaramanga', 'mariana@trendyclothes.com');
go

insert into Marcas(Nombre, Pais_Origen)
values
('Nike'),
('Puma'),
('Diesel'),
('Zara'),
('Adidas');
go
insert into Categorias(Nombre)
values
('Camiseta'),
('Pantalon'),
('Sudadera'),
('Buso'),
('Vestido');
go
insert into Colores(Nombre, Codigo_Hexa)
values
('Blanco', '#FFFFFF'),
('Negro', '#000000'),
('Rojo', '#FF0000'),
('Azul', '#0000FF'),
('Verde', '#008000'),
('Amarillo', '#FFFF00'),
('Naranja', '#FFA500'),
('Morado', '#800080'),  
('Gris', '#808080'),
('Rosa', '#FFC0CB');
go
insert into Tallas(Descripcion)
values
('2'),
('4'),
('6'),
('8'),
('10'),
('12'),
('14'),
('16'),
('18'),
('20'),
('28'),
('30'),
('32'),
('34'),
('36'),
('38'),
('40'),
('XS'),
('S'),
('M'),
('L'),
('XL'),
('XXL');
go
Insert into Promociones(Codigo, Descripcion, Porcentaje,Valor_Descuento, Fecha_inicio, Fecha_Fin)
values
('PROMO10', 'Descuento de apertura del 10%', 0.1, 0.00, '2025-09-01', '2025-09-15'),
('PROMO20K', 'Descuento de $20,000 en compras superiores a $100,000', 0.00, 20000.00, '2025-09-10', '2025-09-30'),
('PROMO15', '15% de descuento en toda la tienda', 0.15, 0.00, '2025-10-01', '2025-10-15'),
('PROMO50', 'Mitad de precio en prendas seleccionadas', 0.50, 0.00, '2025-11-01', '2025-11-05'),
('PROMOENVIO', 'Envío gratis por compras mayores a $80,000', 0.00, 15000.00, '2025-09-20', '2025-10-10');
go

insert into Empleados(Cedula, Nombre, Apellido, Telefono, Direccion, Email, Id_Puesto, Fecha_Contratacion)
VALUES

('60', 'Andrés', 'Ramírez', '3104567890', 'Calle 12 #45-30 Medellin', 'andres.ramirez@mail.com', 1, '2023-05-15'),
('70', 'Camila', 'Gómez', '3119876543', 'Carrera 7 #80-25 Medellín', 'camila.gomez@mail.com', 2, '2022-11-01'),
('80', 'Julián', 'Torres', '3121234567', 'Avenida 30 #10-15 Medellín', 'julian.torres@mail.com', 3, '2024-01-10'),
('90', 'Valentina', 'López', '3137654321', 'Calle 100 #15-20 Medellín', 'valentina.lopez@mail.com', 4, '2021-09-05'),
('100', 'Esteban', 'Martínez', '3148765432', 'Carrera 50 #22-35 Medellín', 'esteban.martinez@mail.com', 5, '2020-03-20');
go

Insert into Productos(Id_Marca, Id_Categoria, Nombre, Descripcion, Precio_Compra, Precio_Venta)
values
(1,1, 'Camiseta Nike Ultra', 'Camiseta oversize Color rojo',30000, 80000),
(2,2, 'Pantalon Puma','Pantalon baggie color negro', 70000, 160000),
(3,3, 'Sudadera Hyper','Sudadera estampada color gris', 45000, 110000),
(4,5, 'Vestido Floral', ' Vestido Florado rosado', 30000, 80000 ),
(5,4,'Buso Adidas premium', ' Buso Azul Estampado', 60000, 120000);
go

insert into Inventario(Id_Producto, Id_Talla, Id_Color, Cantidad)
values
(1,21, 3, 200),
(2, 20, 2, 20),
(3, 20, 9 ,30  ),
(4, 15, 10, 15),
(5, 21, 4, 60);
go

Insert into Compras(Id_Proveedor, Id_Empleado, Fecha_Compra, Total, Impuestos)
values
(1,1,GETDATE(), 6060000, 60000 ),
(2,2,GETDATE(), 1414000, 14000 ),
(3,3,GETDATE(), 1363500, 13500 ),
(4,4,GETDATE(), 4545000, 45000 ),
(5,5,GETDATE(), 3636000, 36000);
go

insert into DetalleCompras(Id_Compra, Id_Producto, Id_Talla, Id_Color, Cantidad, Precio_Unitario)
values 
(1,1,21,3,200, 30000),
(2,2,20,2,20,70000),
(3,3,20,9,30,45000),
(4,4,15,10,15,30000),
(5,5,21,4,60,60000);

insert into Ventas(Id_Cliente,Id_Empleado,Fecha_Venta,Total,Impuestos)
values
(1,1,GETDATE(),80000, 15200  ),
(2,2, GETDATE(),320000,60800 ),
(3,3, GETDATE(), 110000, 20900),
(4,4, GETDATE(), 80000, 15200),
(5,5, GETDATE(), 60000, 11400);
go
insert into DetalleVentas(Id_Venta,Id_Producto, Id_Talla, Id_Color, Id_Promocion, Cantidad, Precio_Unitario)
values
(1,1,21,3,null, 1,80000 ),
(2,2,20,2,null,2, 160000),
(3,3,20,9,null,1,110000),
(4,4,15,10,null,1,80000),
(5,5,21,4,null,1,60000);
go

insert into Devoluciones( Id_Venta, Id_Producto, Id_Talla, Id_Color, Cantidad, Motivo, Fecha_Devolucion )
values
(1,1,21,3,1, 'Inconformidad con la prenda', GETDATE()),
(2,2,20,2,2, 'Inconformidad con la prenda', GETDATE()),
(3,3,20,9,1, 'Inconformidad con la prenda', GETDATE()),
(4,4,15,10,1, 'Inconformidad con la prenda', GETDATE()),
(5,5,21,4,1, 'Inconformidad con la prenda', GETDATE());

