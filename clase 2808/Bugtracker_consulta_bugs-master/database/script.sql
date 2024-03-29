USE [ProyectoGranEsquina]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON
INSERT [dbo].[Perfiles] ([id_perfil], [nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Perfiles] ([id_perfil], [nombre]) VALUES (2, N'Tester')
INSERT [dbo].[Perfiles] ([id_perfil], [nombre]) VALUES (3, N'Desarrollador')
INSERT [dbo].[Perfiles] ([id_perfil], [nombre]) VALUES (4, N'Responsable de Reportes')
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
/****** Object:  Table [dbo].[Formularios]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Formularios](
	[id_formulario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Formularios] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estados](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Estados] ON
INSERT [dbo].[Estados] ([id_estado], [nombre]) VALUES (1, N'Nuevo')
INSERT [dbo].[Estados] ([id_estado], [nombre]) VALUES (2, N'Asignado')
INSERT [dbo].[Estados] ([id_estado], [nombre]) VALUES (3, N'Cerrado')
INSERT [dbo].[Estados] ([id_estado], [nombre]) VALUES (4, N'En testing')
SET IDENTITY_INSERT [dbo].[Estados] OFF
/****** Object:  Table [dbo].[Criticidades]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Criticidades](
	[id_criticidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Criticidades] PRIMARY KEY CLUSTERED 
(
	[id_criticidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Criticidades] ON
INSERT [dbo].[Criticidades] ([id_criticidad], [nombre]) VALUES (1, N'LEVE')
INSERT [dbo].[Criticidades] ([id_criticidad], [nombre]) VALUES (2, N'GRAVE')
INSERT [dbo].[Criticidades] ([id_criticidad], [nombre]) VALUES (3, N'INVALIDANTE')
SET IDENTITY_INSERT [dbo].[Criticidades] OFF
/****** Object:  Table [dbo].[Categorias]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON
INSERT [dbo].[Categorias] ([id_categoria], [nombre]) VALUES (1, N'Pastas')
INSERT [dbo].[Categorias] ([id_categoria], [nombre]) VALUES (2, N'Lacteos')
INSERT [dbo].[Categorias] ([id_categoria], [nombre]) VALUES (3, N'Porotos')
INSERT [dbo].[Categorias] ([id_categoria], [nombre]) VALUES (4, N'Bebidas')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
/****** Object:  Table [dbo].[Empleados]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[dni] [int] IDENTITY NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[usuario] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[dni]
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON
INSERT [dbo].[Empleados] ([dni], [nombre],[usuario]) VALUES (38182155, N'Aldana',1)
SET ANSI_NULLS ON
INSERT [dbo].[Empleados] ([dni], [nombre],[usuario]) VALUES (38001419, N'Ezequiel',2)
SET IDENTITY_INSERT [dbo].[Empleados] OFF
/****** Object:  Table [dbo].[Proveedores]    Script Date: 09/06/2019 23:42:23 ******/
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedores](
	[nroProveedor] [int] IDENTITY(1,1) NOT NULL,
	[razonSocial] [varchar](50) NOT NULL,
	[CUIT] [int] NOT NULL,
	[telefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[nroProveedor]
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON
INSERT [dbo].[Proveedores] ([nroProveedor],[razonSocial],[CUIT],[telefono]) VALUES (1, N'La Lacteo SRL',125447,N'25547463')
INSERT [dbo].[Proveedores] ([nroProveedor],[razonSocial],[CUIT],[telefono]) VALUES (2, N'Mariotti',36547,N'4854233')
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
/****** Object:  Table [dbo].[Compras]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compras](
	[nroComprobante] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[empleado] [int] NOT NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[nroComprobante]
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Compras] ON
INSERT [dbo].[Compras] ([nroComprobante],[fecha],[empleado]) VALUES (1000, N'2019-05-25',N'38182155')
INSERT [dbo].[Compras] ([nroComprobante],[fecha],[empleado]) VALUES (1001, N'2019-08-10',N'38001419')
SET IDENTITY_INSERT [dbo].[Compras] OFF
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[codDetalle] [int] IDENTITY(1,1) NOT NULL,
	[idCompra] [int] NOT NULL,
	[codProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
 CONSTRAINT [PK_DetalleCompra] PRIMARY KEY CLUSTERED 
(
	[codDetalle],
	[idCompra]
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleCompra] ON
INSERT [dbo].[DetalleCompra] ([idCompra],[codDetalle],[codProducto],[cantidad],[precio]) VALUES (1000,1, 1,10,50.0)
INSERT [dbo].[DetalleCompra] ([idCompra],[codDetalle],[codProducto],[cantidad],[precio]) VALUES (1001,1,2,5,20.5)
SET IDENTITY_INSERT [dbo].[DetalleCompra] OFF
/****** Object:  Table [dbo].[Venta]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[nroComprobante] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[empleado] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[nroComprobante]
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON
INSERT [dbo].[Venta] ([nroComprobante], [fecha], [empleado]) VALUES (1000,N'2019-09-04',38182155)
INSERT [dbo].[Venta] ([nroComprobante], [fecha], [empleado]) VALUES (1001,N'2019-09-14',38001419)
SET IDENTITY_INSERT [dbo].[Venta] OFF
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[idVenta] [int] NOT NULL,
	[codDetalle] [int] IDENTITY(1,1) NOT NULL,
	[codProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[idVenta],
	[codDetalle]
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleVenta] ON
INSERT [dbo].[DetalleVenta] ([idVenta],[codDetalle], [codProducto], [cantidad], [precio]) VALUES (1000,1, 1,5,100.0)
INSERT [dbo].[DetalleVenta] ([idVenta],[codDetalle], [codProducto], [cantidad], [precio]) VALUES (1001,2,2,2,50.0)
SET IDENTITY_INSERT [dbo].[DetalleVenta] OFF
/****** Object:  Table [dbo].[Prioridades]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prioridades](
	[id_prioridad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Prioridades] PRIMARY KEY CLUSTERED 
(
	[id_prioridad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Prioridades] ON
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre]) VALUES (1, N'BAJA')
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre]) VALUES (2, N'MEDIA')
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre]) VALUES (3, N'ALTA')
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre]) VALUES (4, N'URGENTE')
SET IDENTITY_INSERT [dbo].[Prioridades] OFF
/****** Object:  Table [dbo].[Productos]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[precioVenta] [float] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_categoria], [precioVenta]) VALUES (1, N'Fideos Michetti', 1, 25)
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_categoria], [precioVenta]) VALUES (2, N'Leche', 2, 50)
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_categoria], [precioVenta]) VALUES (3, N'Yogur', 2, 60)
SET IDENTITY_INSERT [dbo].[Productos] OFF
/****** Object:  Table [dbo].[Permisos]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC,
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = ON, STATISTICS_NORECOMPUTE  = ON, IGNORE_DUP_KEY = ON, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (1, 1, N'ADMIN', N'123', N'admin@bt.com', N'S')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (2, 2, N'acme', N'test123', N'test123', N'N')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (4, 3, N'Test3', N'test', N'test2@bt.com', N'')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (5, 2, N'one21', N'fhkjasdhfa', N'fhkjasdhfa', N'N')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (6, 3, N'Test11-09', N'123', N'test1109@bugs.com.ar', N'N')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (7, 4, N'Melisa', N'123', N'meli@gmail.com', N'S')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Table [dbo].[Bugs]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bugs](
	[id_bug] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[fecha_alta] [date] NOT NULL,
	[id_usuario_responsable] [int] NULL,
	[id_usuario_asignado] [int] NOT NULL,
	[id_producto] [int] NULL,
	[id_prioridad] [int] NULL,
	[id_criticidad] [int] NULL,
	[id_estado] [int] NOT NULL,
 CONSTRAINT [PK_Bugs] PRIMARY KEY CLUSTERED 
(
	[id_bug] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Bugs] ON
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado]) VALUES (2, N'Test', N'First bug of test', CAST(0x0D400B00 AS Date), 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado]) VALUES (3, N'TEST FIRST BUG', N'hsfhkADSFHAKDS', CAST(0xEE3F0B00 AS Date), 1, 2, 1, 1, 1, 2)
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado]) VALUES (5, N'Tercer bug test', N'Tercer bug test', CAST(0xEF3F0B00 AS Date), 1, 2, 1, 2, 3, 3)
SET IDENTITY_INSERT [dbo].[Bugs] OFF
/****** Object:  Table [dbo].[Stock]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[codProducto] [int] NOT NULL,
	[cantActual] [int] NOT NULL,
	[cantMin] [int] NOT NULL,
 CONSTRAINT [PK_CodProductos] PRIMARY KEY CLUSTERED 
(
	[codProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Stock] ([codProducto], [cantActual], [cantMin]) VALUES (1, 50, 25)
INSERT [dbo].[Stock] ([codProducto], [cantActual], [cantMin]) VALUES (2, 30, 15)
INSERT [dbo].[Stock] ([codProducto], [cantActual], [cantMin]) VALUES (3, 10, 15)
/****** Object:  Table [dbo].[BugsHistorico]    Script Date: 09/06/2019 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BugsHistorico](
	[id_bug_historico] [int] NOT NULL,
	[fecha_hitorico] [date] NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[id_bug] [int] NOT NULL,
	[id_usuario_responsable] [int] NOT NULL,
	[id_usuario_asignado] [int] NULL,
	[id_producto] [int] NULL,
	[id_prioridad] [int] NULL,
	[id_criticidad] [int] NULL,
	[id_estado] [int] NOT NULL,
 CONSTRAINT [PK_BugsHistorico] PRIMARY KEY CLUSTERED 
(
	[id_bug_historico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Bugs_Criticidades]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Criticidades] FOREIGN KEY([id_criticidad])
REFERENCES [dbo].[Criticidades] ([id_criticidad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Criticidades]
GO
/****** Object:  ForeignKey [FK_Bugs_Estados]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Estados] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estados] ([id_estado])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Estados]
GO
/****** Object:  ForeignKey [FK_Bugs_Prioridades]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Prioridades] FOREIGN KEY([id_prioridad])
REFERENCES [dbo].[Prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Prioridades]
GO
/****** Object:  ForeignKey [FK_Bugs_Productos]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Productos]
GO
/****** Object:  ForeignKey [FK_Bugs_Usuarios]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Usuarios] FOREIGN KEY([id_usuario_asignado])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Usuarios]
GO
/****** Object:  ForeignKey [FK_Bugs_Usuarios1]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Usuarios1] FOREIGN KEY([id_usuario_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Usuarios1]
GO
/****** Object:  ForeignKey [FK_BugsHistorico_Bugs]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Bugs] FOREIGN KEY([id_bug])
REFERENCES [dbo].[Bugs] ([id_bug])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Bugs]
GO
/****** Object:  ForeignKey [FK_BugsHistorico_Criticidades]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Criticidades] FOREIGN KEY([id_criticidad])
REFERENCES [dbo].[Criticidades] ([id_criticidad])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Criticidades]
GO
/****** Object:  ForeignKey [FK_BugsHistorico_Estados]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Estados] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estados] ([id_estado])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Estados]
GO
/****** Object:  ForeignKey [FK_BugsHistorico_Prioridades]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Prioridades] FOREIGN KEY([id_prioridad])
REFERENCES [dbo].[Prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Prioridades]
GO
/****** Object:  ForeignKey [FK_BugsHistorico_Productos]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Productos]
GO
/****** Object:  ForeignKey [FK_BugsHistorico_Usuarios]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Usuarios] FOREIGN KEY([id_usuario_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Usuarios]
GO
/****** Object:  ForeignKey [FK_BugsHistorico_Usuarios1]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Usuarios1] FOREIGN KEY([id_usuario_asignado])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Usuarios1]
GO
/****** Object:  ForeignKey [FK_Permisos_Formularios]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Formularios]
GO
/****** Object:  ForeignKey [FK_Permisos_Perfiles]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Perfiles]
GO
/****** Object:  ForeignKey [FK_Productos_Categoria]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id_categoria])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categoria]
GO
/****** Object:  ForeignKey [FK_Stock_Productos]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Productos] FOREIGN KEY([codProducto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_Productos]
GO
/****** Object:  ForeignKey [FK_Usuarios_Perfiles]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
/****** Object:  ForeignKey [FK_Usuarios_Empleados]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Empleados] FOREIGN KEY([usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Usuarios_Empleados]
GO
/****** Object:  ForeignKey [FK_Compras_Empleados]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Empleados] FOREIGN KEY([empleado])
REFERENCES [dbo].[Empleados] ([dni])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Empleados]
GO
/****** Object:  ForeignKey [FK_DetalleCompra_Compras]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Compras] FOREIGN KEY([idCompra])
REFERENCES [dbo].[Compras] ([nroComprobante])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_DetalleCompra_Compras]
GO
/****** Object:  ForeignKey [FK_DetalleCompra_Productos]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Productos] FOREIGN KEY([codProducto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_DetalleCompra_Productos]
GO
/****** Object:  ForeignKey [FK_Venta_Empleados]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Empleados] FOREIGN KEY([empleado])
REFERENCES [dbo].[Empleados] ([dni])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Empleados]
GO
/****** Object:  ForeignKey [FK_DetalleVenta_Venta]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Venta] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Venta] ([nroComprobante])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Venta]
GO
/****** Object:  ForeignKey [FK_DetalleVenta_Productos]    Script Date: 09/06/2019 23:42:23 ******/
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Productos] FOREIGN KEY([codProducto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Productos]
GO