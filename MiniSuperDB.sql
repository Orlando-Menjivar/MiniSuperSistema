-- bd de minisuper

create database MinisuperDB;
go

use MinisuperDB;
go

create table Negocio(
	NegocioId int primary key identity (1,1) not null,
	NombreNegocio varchar (100) not null,
	Direccion varchar (200) not null,
	Telefono varchar (15) not null,
	MensajeTicket varchar (250) null
);
go

Create table Estado(
	EstadoId int primary key identity(1,1) not null,
	TipoEstado varchar(35) not null unique
);
go

Create table EstadoUsuario(
	EstadoUsuarioId int primary key identity (1,1) not null,
	TipoEstado varchar(35) not null unique
);
go

Create table EstadoProveedor(
	EstadoProveedorId int primary key identity (1,1) not null,
	TipoEstado varchar(35) not null unique
);
go

create table EstadoProducto(
	EstadoProductoId int primary key identity (1,1) not null,
	TipoEstado varchar (50) not null unique
);
go

create table FormaPago(
	FormaPagoId int primary key identity (1,1) not null,
	TipoPago varchar (50) not null unique
);
go

create table TipoMovimientoInventario(
	TipoMovimientoId int primary key identity(1,1) not null,
	TipoMovimiento varchar(50) not null unique
);
go

Create table Cliente(
	ClienteId int primary key identity (1,1) not null,
	TipoCliente varchar(50) not null,
	DUI varchar(10) null, 
	constraint CHK_Cliente_DUI check(
	DUI is null 
	or DUI Like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]')
);
go

CREATE UNIQUE INDEX UX_Cliente_DUI ON Cliente (DUI) WHERE DUI IS NOT NULL;
GO

Create table Cargo(
	CargoId int primary key identity(1,1) not null,
	Nombrecargo varchar(30) unique not null,
	EstadoId int foreign key references Estado(EstadoId)
);
go

Create table Rol(
	RolId int primary key identity (1,1) not null,
	TipoRol varchar(35) unique not null,
	Descripcion varchar(150) null,
	EstadoId int foreign key references Estado(EstadoId)
);
go

create table Categoria(
	CategoriaId int primary key identity (1,1) not null,
	NombreCategoria varchar(50) unique not null,
	EstadoId int foreign key references Estado(EstadoId)
);
go

create table Proveedor(
	ProveedorId int primary key identity (1,1) not null,
	NombreEmpresa varchar(50) null,
	NombreProveedor varchar (50) not null,
	ApellidoProveedor varchar(50) not null,
	TipoProveedor varchar (50) check(TipoProveedor in('individual', 'Empresa')) not null,
	DUI varchar(10) not null unique,
	Telefono varchar (10) not null unique,
	Correo varchar (100) not null unique,
	Direccion varchar (100) not null,
	EstadoProveedorId int foreign key references EstadoProveedor(EstadoProveedorId),
	constraint CHK_Proveedor_DUI check(DUI Like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]')
);
go

CREATE UNIQUE INDEX UX_Proveedor_NombreEmpresa
    ON Proveedor (NombreEmpresa) WHERE NombreEmpresa IS NOT NULL;
GO



Create table Empleado(
	EmpleadoId int primary key identity(1,1) not null,
	PrimerNombre varchar(25) not null,
	SegundoNombre varchar(25) null,
	PrimerApellido varchar(25) not null,
	SegundoApellido varchar(25) null,
	DUI varchar(10) not null unique,
	Telefono varchar(10) not null unique,
	Correo varchar(100) not null unique,
	FechaNac date not null,
	Direccion varchar(100) not null,
	CargoId int foreign key references Cargo(CargoId),
	EstadoUsuarioId int foreign key references EstadoUsuario(EstadoUsuarioId),
	constraint CHK_Empleado_DUI check(DUI Like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]')
);
go

Create table Usuario(
	UsuarioId int primary key identity(1,1) not null,
	NombreUsuario varchar(50) not null unique,
	Clave varchar(100) not null,
	FechaCreacion datetime not null default getdate(),
	RolId int foreign key references Rol(RolId),
	EmpleadoId int foreign key references Empleado(EmpleadoId) unique,
	EstadoUsuarioId int foreign key references EstadoUsuario(EstadoUsuarioId)
);
go

create table Producto(
	ProductoId int primary key identity (1,1) not null,
	CodigoBarra varchar(50) not null unique,
	NombreProducto varchar (50) not null,
	UnidadMedida varchar (50) null,
	PrecioVenta money not null check(PrecioVenta >= 0.00),
	CategoriaId int foreign key references Categoria(CategoriaId),
	EstadoProductoId int foreign key references EstadoProducto (EstadoProductoId)
);
go

create table Inventario(
	InventarioId int primary key identity (1,1) not null,
	ProductoId int unique foreign key references Producto(ProductoId),
	StockActual int not null default 0 check(StockActual >= 0), 
	StockMinimo int not null default 0 check(StockMinimo >= 0), 
	CostoPromedio decimal (10,2) not null default 0.00
 );
go

create table Compra(
	CompraId int primary key identity (1,1) not null,
	FechaHora datetime default getdate(),
	NumeroFactura varchar (25) not null,
	ProveedorId int foreign key references Proveedor(ProveedorId),
	UsuarioId int foreign key references Usuario(UsuarioId),
	Total money not null check(Total >= 0.00),
	constraint UQ_Compra_Proveedor_Factura unique (ProveedorId, NumeroFactura)
);
go


create table DetalleCompra(
	DetCompraId int primary key identity (1,1) not null,
	CompraId int foreign key references Compra(Compraid) not null,
	Cantidad int not null check(Cantidad > 0),
	ProductoId int foreign key references Producto(ProductoId) not null,
	PrecioCompra money not null check(PrecioCompra >= 0.00),
	SubTotal money not null check(SubTotal >= 0.00)
);
go

Create table LoteInventario(
	LoteInventarioId int primary key identity (1,1) not null,
	DetCompraId int unique foreign key references DetalleCompra(DetCompraId) not null,
	FechaIngreso datetime default getdate() not null,
	FechaCaducidad date null,
	StockInicialLote int not null check(StockInicialLote > 0),
	StockActualLote int not null,
	constraint CHK_Lote_StockActual check(
	StockActualLote >= 0 and StockActualLote <= StockInicialLote)
);
go

Create table Venta(
	VentaId int primary key identity(1,1) not null,
	FechaHora datetime default getdate(),
	NumeroTicket int not null unique,
	UsuarioId int foreign key references Usuario(UsuarioId),
	ClienteId int foreign key references Cliente(ClienteId),
	Iva money not null,
	Subtotal money not null,
	Total money not null,
	constraint CHK_Venta_Montos check(Iva >= 0.00 and Subtotal >= 0.00 and Total >= 0.00)
);
go

Create table DetalleVenta(
	DetVentaId int primary key identity(1,1) not null,
	VentaId int foreign key references Venta(VentaId),
	Cantidad int not null check(Cantidad > 0),
	ProductoId int foreign key references Producto(ProductoId),
	Precio money not null check(Precio >= 0.00),
	Subtotal money not null check(SubTotal >= 0.00)
);
go

create table Pago(
	PagoId int primary key identity (1,1) not null,
	VentaId int foreign key references Venta(VentaId),
	FormaPagoId int foreign key references FORMAPAGO(FormaPagoId),
	Monto money not null check(Monto > 0),
	MontoRecibido money null check(MontoRecibido >= 0),
	Cambio money null,
	DuiTitular varchar(10) null,
	FirmaTitular Bit null,
	constraint CHK_PagoEfectivo check((MontoRecibido is null or MontoRecibido >=0)
	and (Cambio is null or Cambio >= 0)),
	constraint CHK_Pago_DUI check(DuiTitular Like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]')
);
go

create table DetalleInventario(
	DetInventarioId int primary key identity(1,1) not null,
	InventarioId int foreign key references Inventario(InventarioId),
	LoteInventarioId int foreign key references LoteInventario(LoteInventarioId),
	FechaHoraMovimiento datetime not null default getdate(),
	Cantidad int not null check(Cantidad > 0),
	Observacion varchar(255) null,
	TipoMovimientoId int foreign key references TipoMovimientoInventario(TipoMovimientoId),
	DetVentaId int foreign key references DetalleVenta(DetVentaId)
);
go



