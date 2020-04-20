USE [ReclamosDb]
GO
/****** Object:  Schema [Dir]    Script Date: 20/4/2020 6:42:09 p. m. ******/
CREATE SCHEMA [Dir]
GO
/****** Object:  Schema [Entidad]    Script Date: 20/4/2020 6:42:09 p. m. ******/
CREATE SCHEMA [Entidad]
GO
/****** Object:  Schema [Gen]    Script Date: 20/4/2020 6:42:09 p. m. ******/
CREATE SCHEMA [Gen]
GO
/****** Object:  Schema [reclamos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
CREATE SCHEMA [reclamos]
GO
/****** Object:  Table [Entidad].[Empleados]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Empleados](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[idterceros] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[iddepartamento] [int] NOT NULL,
	[horaentrada] [time](7) NULL,
	[horasalida] [time](7) NULL,
	[horabreaki] [time](7) NULL,
	[horabreaks] [time](7) NULL,
	[disponible] [bit] NULL,
	[fechareg] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [reclamos].[Departamentos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [reclamos].[Departamentos](
	[Idcompania] [int] NOT NULL,
	[Id] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Idencargado] [int] NOT NULL,
	[Funcion] [varchar](100) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[Idcompania] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Entidad].[Terceros]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Terceros](
	[idcompania] [int] NOT NULL,
	[idterceros] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_redsocial] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[idterceros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Entidad].[Personas]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Personas](
	[idcompania] [int] NOT NULL,
	[idterceros] [int] NOT NULL,
	[apellidos] [varchar](100) NOT NULL,
	[sexo] [bit] NULL,
	[estatura] [varchar](10) NULL,
	[nacio] [datetime] NULL,
	[estadocivil] [varchar](20) NULL,
	[idestado] [int] NULL,
	[extranjero] [bit] NULL,
	[idocupacion] [int] NULL,
	[fecharegistro] [datetime] NULL,
	[usuarioregistro] [varchar](50) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_per] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[idterceros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Departamentos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Departamentos]
AS
SELECT        ISNULL(Entidad.Personas.apellidos, '') AS apellidos, ISNULL(Entidad.Terceros.nombre, '') AS nombre, reclamos.Departamentos.Idcompania, reclamos.Departamentos.Id, reclamos.Departamentos.Descripcion, 
                         reclamos.Departamentos.Idencargado, reclamos.Departamentos.Funcion, reclamos.Departamentos.Estado
FROM            reclamos.Departamentos LEFT OUTER JOIN
                         Entidad.Empleados ON reclamos.Departamentos.Idencargado = Entidad.Empleados.id AND reclamos.Departamentos.Idcompania = Entidad.Empleados.idcompania LEFT OUTER JOIN
                         Entidad.Terceros ON Entidad.Empleados.idcompania = Entidad.Terceros.idcompania AND Entidad.Empleados.idterceros = Entidad.Terceros.idterceros LEFT OUTER JOIN
                         Entidad.Personas ON Entidad.Terceros.idcompania = Entidad.Personas.idcompania AND Entidad.Terceros.idterceros = Entidad.Personas.idterceros
GO
/****** Object:  Table [reclamos].[Acciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [reclamos].[Acciones](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[descripcion] [varchar](60) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Acciones] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [reclamos].[Tipos_Reclamos_Acciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [reclamos].[Tipos_Reclamos_Acciones](
	[idcompania] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[idaccion] [int] NOT NULL,
	[representa] [numeric](8, 2) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Tipos_Reclamos_Acciones] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[idtipo] ASC,
	[idaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Tipos_Reclamos_Acciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Tipos_Reclamos_Acciones]
AS
SELECT        reclamos.Acciones.descripcion, reclamos.Tipos_Reclamos_Acciones.idaccion, reclamos.Tipos_Reclamos_Acciones.idtipo, reclamos.Tipos_Reclamos_Acciones.idcompania, reclamos.Tipos_Reclamos_Acciones.representa, 
                         reclamos.Tipos_Reclamos_Acciones.estado
FROM            reclamos.Acciones INNER JOIN
                         reclamos.Tipos_Reclamos_Acciones ON reclamos.Acciones.idcompania = reclamos.Tipos_Reclamos_Acciones.idcompania AND reclamos.Acciones.id = reclamos.Tipos_Reclamos_Acciones.idaccion
GO
/****** Object:  View [dbo].[V_Empleados]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Empleados]
AS
SELECT        Entidad.Empleados.idcompania, Entidad.Empleados.id, Entidad.Empleados.idterceros, Entidad.Empleados.idtipo, Entidad.Empleados.horaentrada, Entidad.Terceros.nombre, ISNULL(Entidad.Personas.apellidos, '') AS apellidos, 
                         Entidad.Empleados.iddepartamento, Entidad.Empleados.horasalida, Entidad.Empleados.horabreaki, Entidad.Empleados.horabreaks, Entidad.Empleados.disponible, Entidad.Empleados.fechareg, 
                         Entidad.Empleados.estado
FROM            Entidad.Empleados INNER JOIN
                         Entidad.Terceros ON Entidad.Empleados.idcompania = Entidad.Terceros.idcompania AND Entidad.Empleados.idterceros = Entidad.Terceros.idterceros LEFT OUTER JOIN
                         Entidad.Personas ON Entidad.Terceros.idcompania = Entidad.Personas.idcompania AND Entidad.Terceros.idterceros = Entidad.Personas.idterceros
GO
/****** Object:  Table [Entidad].[Usuarios]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Usuarios](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[idterceros] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[clave] [varbinary](max) NOT NULL,
	[autorizar] [bit] NOT NULL,
	[fecharegistro] [datetime] NOT NULL,
	[usuarioreg] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios_1] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Usuarios]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Usuarios]
AS
SELECT        Entidad.Usuarios.id, Entidad.Usuarios.idcompania, Entidad.Usuarios.idterceros, Entidad.Usuarios.idtipo, Entidad.Usuarios.usuario, Entidad.Usuarios.clave, Entidad.Usuarios.autorizar, Entidad.Usuarios.fecharegistro, 
                         Entidad.Usuarios.usuarioreg, Entidad.Usuarios.estado, Entidad.Terceros.nombre, ISNULL(Entidad.Personas.apellidos, '') AS apellidos
FROM            Entidad.Usuarios INNER JOIN
                         Entidad.Terceros ON Entidad.Usuarios.idcompania = Entidad.Terceros.idcompania AND Entidad.Usuarios.idterceros = Entidad.Terceros.idterceros LEFT OUTER JOIN
                         Entidad.Personas ON Entidad.Terceros.idcompania = Entidad.Personas.idcompania AND Entidad.Terceros.idterceros = Entidad.Personas.idterceros
GO
/****** Object:  Table [reclamos].[Tipo_Reclamos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [reclamos].[Tipo_Reclamos](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[iddepartamento] [int] NOT NULL,
	[idnivel] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Tipo_Reclamos] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Tipos_Reclamos_Acciones2]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Tipos_Reclamos_Acciones2]
AS
SELECT        reclamos.Tipos_Reclamos_Acciones.idcompania, reclamos.Tipos_Reclamos_Acciones.idtipo, reclamos.Tipos_Reclamos_Acciones.idaccion, reclamos.Tipos_Reclamos_Acciones.representa, 
                         reclamos.Tipos_Reclamos_Acciones.estado, reclamos.Tipo_Reclamos.descripcion AS desac, reclamos.Acciones.descripcion AS desre
FROM            reclamos.Tipos_Reclamos_Acciones INNER JOIN
                         reclamos.Tipo_Reclamos ON reclamos.Tipos_Reclamos_Acciones.idcompania = reclamos.Tipo_Reclamos.idcompania AND reclamos.Tipos_Reclamos_Acciones.idtipo = reclamos.Tipo_Reclamos.id INNER JOIN
                         reclamos.Acciones ON reclamos.Tipos_Reclamos_Acciones.idcompania = reclamos.Acciones.idcompania AND reclamos.Tipos_Reclamos_Acciones.idaccion = reclamos.Acciones.id
GO
/****** Object:  View [dbo].[V_Operador]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Operador]
AS
SELECT        Entidad.Terceros.nombre, ISNULL(Entidad.Personas.apellidos, '') AS apellidos, Entidad.Empleados.idcompania, Entidad.Empleados.id, Entidad.Empleados.idterceros, Entidad.Empleados.idtipo, 
                         Entidad.Empleados.iddepartamento, Entidad.Empleados.horaentrada, Entidad.Empleados.horasalida, Entidad.Empleados.horabreaki, Entidad.Empleados.horabreaks, Entidad.Empleados.disponible, 
                         Entidad.Empleados.fechareg, Entidad.Empleados.estado
FROM            Entidad.Terceros LEFT OUTER JOIN
                         Entidad.Personas ON Entidad.Terceros.idcompania = Entidad.Personas.idcompania AND Entidad.Terceros.idterceros = Entidad.Personas.idterceros RIGHT OUTER JOIN
                         Entidad.Empleados ON Entidad.Terceros.idcompania = Entidad.Empleados.idcompania AND Entidad.Terceros.idterceros = Entidad.Empleados.idterceros
GO
/****** Object:  View [dbo].[V_reclamos_Departamentos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_reclamos_Departamentos]
AS
SELECT        Entidad.Empleados.idcompania, Entidad.Empleados.idterceros, Entidad.Empleados.iddepartamento, reclamos.Departamentos.Descripcion AS Descripcion
FROM            reclamos.Departamentos INNER JOIN
                         Entidad.Empleados ON reclamos.Departamentos.Id = Entidad.Empleados.iddepartamento
GO
/****** Object:  View [dbo].[V_Reclamosdepoper]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Reclamosdepoper]
AS
SELECT        Entidad.Empleados.idcompania, Entidad.Empleados.idterceros, Entidad.Empleados.iddepartamento, reclamos.Departamentos.Descripcion As Departamento 
FROM           reclamos.Departamentos INNER JOIN
                          Entidad.Empleados On reclamos.Departamentos.Id = Entidad.Empleados.iddepartamento
GO
/****** Object:  View [dbo].[V_Operador_Departamento]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Operador_Departamento]
AS
SELECT        Entidad.Personas.apellidos, Entidad.Terceros.nombre, Entidad.Empleados.id, Entidad.Empleados.idterceros, Entidad.Empleados.idtipo, Entidad.Empleados.idcompania,
Entidad.Empleados.horaentrada,Entidad.Empleados.horasalida,Entidad.Empleados.horabreaki,Entidad.Empleados.horabreaks, dbo.V_reclamos_Departamentos.iddepartamento, 
                         dbo.V_reclamos_Departamentos.Descripcion,Entidad.Empleados.estado 
                       
FROM            Entidad.Empleados INNER JOIN
                         Entidad.Terceros ON Entidad.Empleados.idcompania = Entidad.Terceros.idcompania AND Entidad.Empleados.idterceros = Entidad.Terceros.idterceros LEFT OUTER JOIN
                         dbo.V_reclamos_Departamentos ON Entidad.Empleados.idcompania = dbo.V_reclamos_Departamentos.idcompania AND Entidad.Empleados.idterceros = dbo.V_reclamos_Departamentos.idterceros LEFT OUTER JOIN
                         Entidad.Personas ON Entidad.Terceros.idcompania = Entidad.Personas.idcompania AND Entidad.Terceros.idterceros = Entidad.Personas.idterceros
GO
/****** Object:  Table [reclamos].[Transacciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [reclamos].[Transacciones](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[idcliente] [int] NOT NULL,
	[idoperador] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[HoraAtendido] [time](7) NULL,
	[HoraDespachado] [datetime] NULL,
	[estado] [bit] NOT NULL,
	[nota] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Transacciones] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Transacciones_Reclamos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Transacciones_Reclamos]
AS
SELECT        reclamos.Transacciones.*, reclamos.Tipo_Reclamos.descripcion, Entidad.Terceros.nombre, ISNULL(Entidad.Personas.apellidos, '') AS apellidos
FROM            reclamos.Transacciones INNER JOIN
                         reclamos.Tipo_Reclamos ON reclamos.Transacciones.idcompania = reclamos.Tipo_Reclamos.idcompania AND reclamos.Transacciones.idtipo = reclamos.Tipo_Reclamos.id INNER JOIN
                         Entidad.Empleados ON reclamos.Transacciones.idcompania = Entidad.Empleados.idcompania AND reclamos.Transacciones.idoperador = Entidad.Empleados.id INNER JOIN
                         Entidad.Terceros ON Entidad.Empleados.idcompania = Entidad.Terceros.idcompania AND Entidad.Empleados.idterceros = Entidad.Terceros.idterceros AND Entidad.Empleados.idcompania = Entidad.Terceros.idcompania AND 
                         Entidad.Empleados.idterceros = Entidad.Terceros.idterceros LEFT OUTER JOIN
                         Entidad.Personas ON Entidad.Terceros.idcompania = Entidad.Personas.idcompania AND Entidad.Terceros.idterceros = Entidad.Personas.idterceros AND Entidad.Terceros.idcompania = Entidad.Personas.idcompania AND 
                         Entidad.Terceros.idterceros = Entidad.Personas.idterceros
GO
/****** Object:  Table [reclamos].[Transacciones_Detalle]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [reclamos].[Transacciones_Detalle](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[idaccion] [int] NOT NULL,
	[idempleado] [int] NOT NULL,
	[finicio] [datetime] NOT NULL,
	[ffin] [datetime] NOT NULL,
	[Nota] [varchar](100) NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Transacciones_Detalle] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC,
	[idaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Transacciones_Detalles]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Transacciones_Detalles]
AS
SELECT        reclamos.Transacciones_Detalle.idcompania, reclamos.Transacciones_Detalle.id, reclamos.Transacciones_Detalle.idaccion, reclamos.Acciones.descripcion, reclamos.Transacciones_Detalle.idempleado, 
                         dbo.V_Empleados.nombre, dbo.V_Empleados.apellidos, reclamos.Transacciones_Detalle.finicio, reclamos.Transacciones_Detalle.ffin, reclamos.Transacciones_Detalle.Nota, reclamos.Transacciones_Detalle.estado
FROM            reclamos.Transacciones_Detalle INNER JOIN
                         reclamos.Acciones ON reclamos.Transacciones_Detalle.idcompania = reclamos.Acciones.idcompania AND reclamos.Transacciones_Detalle.idaccion = reclamos.Acciones.id INNER JOIN
                         dbo.V_Empleados ON reclamos.Transacciones_Detalle.idcompania = dbo.V_Empleados.idcompania AND reclamos.Transacciones_Detalle.idempleado = dbo.V_Empleados.id
GO
/****** Object:  Table [reclamos].[Tipos_Niveles]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [reclamos].[Tipos_Niveles](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[nivel] [int] NOT NULL,
 CONSTRAINT [PK_nivel] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Entidad].[Clientes]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Clientes](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[idtercero] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Clientes]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Clientes]
AS
SELECT        Entidad.Clientes.id, Entidad.Personas.apellidos, Entidad.Terceros.nombre, Entidad.Clientes.idcompania, Entidad.Clientes.idtercero, Entidad.Clientes.idtipo, Entidad.Clientes.estado
FROM            Entidad.Clientes INNER JOIN
                         Entidad.Personas ON Entidad.Clientes.idcompania = Entidad.Personas.idcompania INNER JOIN
                         Entidad.Terceros ON Entidad.Clientes.idcompania = Entidad.Terceros.idcompania AND Entidad.Clientes.idtercero = Entidad.Terceros.idterceros AND Entidad.Personas.idcompania = Entidad.Terceros.idcompania AND 
                         Entidad.Personas.idterceros = Entidad.Terceros.idterceros
GO
/****** Object:  View [dbo].[V_Reclamos_Niveles]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Reclamos_Niveles]
AS
SELECT        reclamos.Transacciones.idcompania, reclamos.Transacciones.id, reclamos.Transacciones.idtipo, reclamos.Transacciones.idcliente, reclamos.Transacciones.idoperador, reclamos.Transacciones.fecha, 
                         reclamos.Transacciones.HoraAtendido, reclamos.Transacciones.HoraDespachado, reclamos.Transacciones.estado, reclamos.Transacciones.nota, dbo.V_Clientes.apellidos, dbo.V_Clientes.nombre, 
                         reclamos.Tipo_Reclamos.idnivel, reclamos.Tipo_Reclamos.descripcion, reclamos.Tipos_Niveles.nivel
FROM            dbo.V_Clientes INNER JOIN
                         reclamos.Transacciones ON dbo.V_Clientes.idcompania = reclamos.Transacciones.idcompania AND dbo.V_Clientes.id = reclamos.Transacciones.idcliente INNER JOIN
                         reclamos.Tipo_Reclamos ON reclamos.Transacciones.idcompania = reclamos.Tipo_Reclamos.idcompania AND reclamos.Transacciones.idtipo = reclamos.Tipo_Reclamos.id AND 
                         reclamos.Transacciones.idcompania = reclamos.Tipo_Reclamos.idcompania AND reclamos.Transacciones.idtipo = reclamos.Tipo_Reclamos.id AND 
                         reclamos.Transacciones.idcompania = reclamos.Tipo_Reclamos.idcompania AND reclamos.Transacciones.idtipo = reclamos.Tipo_Reclamos.id AND 
                         reclamos.Transacciones.idcompania = reclamos.Tipo_Reclamos.idcompania AND reclamos.Transacciones.idtipo = reclamos.Tipo_Reclamos.id INNER JOIN
                         reclamos.Tipos_Niveles ON reclamos.Tipo_Reclamos.idcompania = reclamos.Tipos_Niveles.idcompania AND reclamos.Tipo_Reclamos.idnivel = reclamos.Tipos_Niveles.id AND 
                         reclamos.Tipo_Reclamos.idcompania = reclamos.Tipos_Niveles.idcompania AND reclamos.Tipo_Reclamos.idnivel = reclamos.Tipos_Niveles.id AND 
                         reclamos.Tipo_Reclamos.idcompania = reclamos.Tipos_Niveles.idcompania AND reclamos.Tipo_Reclamos.idnivel = reclamos.Tipos_Niveles.id AND 
                         reclamos.Tipo_Reclamos.idcompania = reclamos.Tipos_Niveles.idcompania AND reclamos.Tipo_Reclamos.idnivel = reclamos.Tipos_Niveles.id AND 
                         reclamos.Tipo_Reclamos.idcompania = reclamos.Tipos_Niveles.idcompania AND reclamos.Tipo_Reclamos.idnivel = reclamos.Tipos_Niveles.id
GO
/****** Object:  Table [Dir].[Calles]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Dir].[Calles](
	[idpais] [int] NOT NULL,
	[idprovincia] [int] NOT NULL,
	[idmunicipio] [int] NOT NULL,
	[idsector] [int] NOT NULL,
	[idparaje] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_calle] PRIMARY KEY CLUSTERED 
(
	[idpais] ASC,
	[idprovincia] ASC,
	[idmunicipio] ASC,
	[idsector] ASC,
	[idparaje] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Dir].[Municipios]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Dir].[Municipios](
	[idpais] [int] NOT NULL,
	[idprovincia] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_municipios] PRIMARY KEY CLUSTERED 
(
	[idpais] ASC,
	[idprovincia] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Dir].[Pais]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Dir].[Pais](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_pais] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Dir].[Paraje]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Dir].[Paraje](
	[idpais] [int] NOT NULL,
	[idprovincia] [int] NOT NULL,
	[idmunicipio] [int] NOT NULL,
	[idsector] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_paraje] PRIMARY KEY CLUSTERED 
(
	[idpais] ASC,
	[idprovincia] ASC,
	[idmunicipio] ASC,
	[idsector] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Dir].[Provincias]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Dir].[Provincias](
	[idpais] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_provincias] PRIMARY KEY CLUSTERED 
(
	[idpais] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Dir].[Sector]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Dir].[Sector](
	[idpais] [int] NOT NULL,
	[idprovincia] [int] NOT NULL,
	[idmunicipio] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_sectores] PRIMARY KEY CLUSTERED 
(
	[idpais] ASC,
	[idprovincia] ASC,
	[idmunicipio] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Entidad].[Direcciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Direcciones](
	[idcompania] [int] NOT NULL,
	[idtercero] [int] NOT NULL,
	[idpais] [int] NOT NULL,
	[idprovincia] [int] NOT NULL,
	[idmunicipio] [int] NOT NULL,
	[idsector] [int] NOT NULL,
	[idparaje] [int] NOT NULL,
	[idcalle] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[referencia] [varchar](max) NULL,
 CONSTRAINT [PK_dirter] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[idtercero] ASC,
	[idpais] ASC,
	[idprovincia] ASC,
	[idmunicipio] ASC,
	[idsector] ASC,
	[idparaje] ASC,
	[idcalle] ASC,
	[idtipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Entidades_Direcciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Entidades_Direcciones]
AS
SELECT        Entidad.Direcciones.idcompania, Entidad.Direcciones.idtercero, Entidad.Direcciones.idpais, Entidad.Direcciones.idprovincia, Entidad.Direcciones.idmunicipio, Entidad.Direcciones.idsector, Entidad.Direcciones.idparaje, 
                         Entidad.Direcciones.idcalle, Entidad.Direcciones.idtipo, Entidad.Direcciones.referencia, Dir.Pais.nombre AS Pais, Dir.Provincias.nombre AS Provincia, Dir.Municipios.nombre AS Municipio, Dir.Sector.nombre AS Sector, 
                         Dir.Paraje.nombre AS Paraje, Dir.Calles.nombre AS Calle
FROM            Dir.Calles INNER JOIN
                         Entidad.Direcciones ON Dir.Calles.idpais = Entidad.Direcciones.idpais AND Dir.Calles.idprovincia = Entidad.Direcciones.idprovincia AND Dir.Calles.idmunicipio = Entidad.Direcciones.idmunicipio AND 
                         Dir.Calles.idsector = Entidad.Direcciones.idsector AND Dir.Calles.idparaje = Entidad.Direcciones.idparaje AND Dir.Calles.id = Entidad.Direcciones.idcalle INNER JOIN
                         Dir.Municipios ON Dir.Calles.idpais = Dir.Municipios.idpais INNER JOIN
                         Dir.Pais ON Dir.Calles.id = Dir.Pais.id INNER JOIN
                         Dir.Paraje ON Dir.Calles.idpais = Dir.Paraje.idpais AND Dir.Calles.idprovincia = Dir.Paraje.idprovincia AND Dir.Calles.idmunicipio = Dir.Paraje.idmunicipio AND Dir.Calles.idsector = Dir.Paraje.idsector AND 
                         Dir.Calles.idparaje = Dir.Paraje.id INNER JOIN
                         Dir.Provincias ON Dir.Municipios.idpais = Dir.Provincias.idpais AND Dir.Municipios.idprovincia = Dir.Provincias.id AND Dir.Municipios.idpais = Dir.Provincias.idpais AND Dir.Municipios.idprovincia = Dir.Provincias.id AND 
                         Dir.Pais.id = Dir.Provincias.idpais AND Dir.Pais.id = Dir.Provincias.idpais INNER JOIN
                         Dir.Sector ON Dir.Municipios.idpais = Dir.Sector.idpais AND Dir.Municipios.idprovincia = Dir.Sector.idprovincia AND Dir.Municipios.id = Dir.Sector.idmunicipio AND Dir.Municipios.idpais = Dir.Sector.idpais AND 
                         Dir.Municipios.idprovincia = Dir.Sector.idprovincia AND Dir.Municipios.id = Dir.Sector.idmunicipio AND Dir.Paraje.idpais = Dir.Sector.idpais AND Dir.Paraje.idprovincia = Dir.Sector.idprovincia AND 
                         Dir.Paraje.idmunicipio = Dir.Sector.idmunicipio AND Dir.Paraje.idsector = Dir.Sector.id AND Dir.Paraje.idpais = Dir.Sector.idpais AND Dir.Paraje.idprovincia = Dir.Sector.idprovincia AND 
                         Dir.Paraje.idmunicipio = Dir.Sector.idmunicipio AND Dir.Paraje.idsector = Dir.Sector.id
GO
/****** Object:  View [dbo].[V_Clientes_Direcciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Clientes_Direcciones]
AS
SELECT        Entidad.Personas.apellidos, Entidad.Terceros.nombre, Entidad.Clientes.id, Entidad.Clientes.idtercero, Entidad.Clientes.idtipo, Entidad.Clientes.idcompania, dbo.V_Entidades_Direcciones.idpais, 
                         dbo.V_Entidades_Direcciones.idprovincia, dbo.V_Entidades_Direcciones.idmunicipio, dbo.V_Entidades_Direcciones.idsector, dbo.V_Entidades_Direcciones.idparaje, dbo.V_Entidades_Direcciones.idcalle, 
                         dbo.V_Entidades_Direcciones.idtipo AS idtipodir, dbo.V_Entidades_Direcciones.referencia, dbo.V_Entidades_Direcciones.Pais, dbo.V_Entidades_Direcciones.Provincia, dbo.V_Entidades_Direcciones.Municipio, 
                         dbo.V_Entidades_Direcciones.Sector, dbo.V_Entidades_Direcciones.Paraje, dbo.V_Entidades_Direcciones.Calle, Entidad.Clientes.estado
FROM            Entidad.Clientes INNER JOIN
                         Entidad.Terceros ON Entidad.Clientes.idcompania = Entidad.Terceros.idcompania AND Entidad.Clientes.idtercero = Entidad.Terceros.idterceros LEFT OUTER JOIN
                         dbo.V_Entidades_Direcciones ON Entidad.Clientes.idcompania = dbo.V_Entidades_Direcciones.idcompania AND Entidad.Clientes.idtercero = dbo.V_Entidades_Direcciones.idtercero LEFT OUTER JOIN
                         Entidad.Personas ON Entidad.Terceros.idcompania = Entidad.Personas.idcompania AND Entidad.Terceros.idterceros = Entidad.Personas.idterceros
GO
/****** Object:  Table [Entidad].[Telefonos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Telefonos](
	[idcompania] [int] NOT NULL,
	[idterceros] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[id] [int] NOT NULL,
	[telefono] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tel] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[idterceros] ASC,
	[idtipo] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Clientes_DirTel]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Clientes_DirTel]
AS
SELECT        dbo.V_Clientes_Direcciones.nombre, dbo.V_Clientes_Direcciones.apellidos, 
                         dbo.V_Clientes_Direcciones.Pais + ' ' + dbo.V_Clientes_Direcciones.Provincia + ' ' + dbo.V_Clientes_Direcciones.Municipio + ' ' + dbo.V_Clientes_Direcciones.Sector + ' ' + dbo.V_Clientes_Direcciones.Paraje + ' ' + dbo.V_Clientes_Direcciones.Calle
                          + ' ' + dbo.V_Clientes_Direcciones.referencia AS Direccion, ISNULL(Entidad.Telefonos.telefono, '') AS telefono, dbo.V_Clientes_Direcciones.id, dbo.V_Clientes_Direcciones.idcompania
FROM            dbo.V_Clientes_Direcciones LEFT OUTER JOIN
                         Entidad.Telefonos ON dbo.V_Clientes_Direcciones.idtercero = Entidad.Telefonos.idterceros AND dbo.V_Clientes_Direcciones.idcompania = Entidad.Telefonos.idcompania
WHERE        (Entidad.Telefonos.idtipo = 1)
GO
/****** Object:  View [dbo].[V_Reclamos_Detallado]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Reclamos_Detallado]
AS
SELECT        reclamos.Transacciones.idcompania, reclamos.Transacciones.id, reclamos.Transacciones.idtipo, reclamos.Transacciones.idcliente, reclamos.Transacciones.fecha, reclamos.Transacciones.nota, 
                         reclamos.Tipo_Reclamos.descripcion, dbo.V_Clientes.nombre, dbo.V_Clientes.apellidos
FROM            reclamos.Transacciones INNER JOIN
                         reclamos.Tipo_Reclamos ON reclamos.Transacciones.idcompania = reclamos.Tipo_Reclamos.idcompania AND reclamos.Transacciones.idtipo = reclamos.Tipo_Reclamos.id INNER JOIN
                         dbo.V_Clientes ON reclamos.Transacciones.id = dbo.V_Clientes.id
GO
/****** Object:  Table [Entidad].[Companias]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Companias](
	[idcompania] [int] NOT NULL,
	[idterceros] [int] NOT NULL,
	[slogan] [varchar](100) NULL,
	[logo] [varchar](200) NULL,
	[nombrepeq] [varchar](35) NOT NULL,
	[referencialugar] [varchar](80) NULL,
	[vision] [varchar](max) NULL,
	[mision] [varchar](max) NULL,
	[valores] [varchar](max) NULL,
	[fechaapertura] [datetime] NULL,
	[propietario] [varchar](100) NULL,
	[fechavence] [datetime] NULL,
	[fecharegistro] [datetime] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Companias] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Entidad].[Correos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Correos](
	[idcompania] [int] NOT NULL,
	[idterceros] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[id] [int] NOT NULL,
	[correo] [varchar](60) NOT NULL,
 CONSTRAINT [PK_correo] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[idterceros] ASC,
	[idtipo] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Entidad].[Documentaciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Documentaciones](
	[idcompania] [int] NOT NULL,
	[idtercero] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_docters] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[idtercero] ASC,
	[idtipo] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Entidad].[Familiares]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[Familiares](
	[idcompania] [int] NOT NULL,
	[idtercero] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[idtercerofam] [int] NOT NULL,
 CONSTRAINT [PK_tipfamiliares] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[idtercero] ASC,
	[idtipo] ASC,
	[idtercerofam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Entidad].[RedesSociales]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entidad].[RedesSociales](
	[idcompania] [int] NOT NULL,
	[idterceros] [int] NOT NULL,
	[idtipo] [int] NOT NULL,
	[id] [int] NOT NULL,
	[redsocial] [varchar](100) NOT NULL,
 CONSTRAINT [PK_RedesSociales] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[idterceros] ASC,
	[idtipo] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gen].[Tipos_Clientes]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gen].[Tipos_Clientes](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipClientes] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gen].[Tipos_Correos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gen].[Tipos_Correos](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[nombre] [varchar](80) NOT NULL,
 CONSTRAINT [PK_Tiposcorreo] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gen].[Tipos_Direcciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gen].[Tipos_Direcciones](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[nombre] [varchar](80) NOT NULL,
 CONSTRAINT [PK_Tiposdir] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gen].[Tipos_Documentaciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gen].[Tipos_Documentaciones](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[nombre] [varchar](80) NOT NULL,
 CONSTRAINT [PK_Tipos_Documentos] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gen].[Tipos_Empleados]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gen].[Tipos_Empleados](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [pk_Tipos_Empleados] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gen].[Tipos_RedesSociales]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gen].[Tipos_RedesSociales](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[nombre] [varchar](80) NOT NULL,
 CONSTRAINT [PK_Tipos] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gen].[Tipos_Telefonos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gen].[Tipos_Telefonos](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[nombre] [varchar](80) NOT NULL,
 CONSTRAINT [PK_Tipostel] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gen].[Tipos_Usuarios]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gen].[Tipos_Usuarios](
	[idcompania] [int] NOT NULL,
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[nota] [varchar](max) NULL,
 CONSTRAINT [PK_tipusuarios] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [reclamos].[Acciones_Dependientes]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [reclamos].[Acciones_Dependientes](
	[idcompania] [int] NOT NULL,
	[idaccion] [int] NOT NULL,
	[idempleado] [int] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Acciones_Dependientes] PRIMARY KEY CLUSTERED 
(
	[idcompania] ASC,
	[idaccion] ASC,
	[idempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [Entidad].[Companias] ADD  CONSTRAINT [DF_Companias_fecharegistro]  DEFAULT (getdate()) FOR [fecharegistro]
GO
ALTER TABLE [Entidad].[Companias] ADD  CONSTRAINT [DF_Companias_usuario]  DEFAULT ('directo') FOR [usuario]
GO
ALTER TABLE [Entidad].[Personas] ADD  CONSTRAINT [DF_Personas_sexo]  DEFAULT ((0)) FOR [sexo]
GO
ALTER TABLE [Entidad].[Personas] ADD  CONSTRAINT [DF_Personas_estatura]  DEFAULT ('') FOR [estatura]
GO
ALTER TABLE [Entidad].[Personas] ADD  CONSTRAINT [DF_Personas_nacio]  DEFAULT (getdate()) FOR [nacio]
GO
ALTER TABLE [Entidad].[Personas] ADD  CONSTRAINT [DF_Personas_estadocivil]  DEFAULT ('') FOR [estadocivil]
GO
ALTER TABLE [Entidad].[Personas] ADD  CONSTRAINT [DF_Personas_idestado]  DEFAULT ((0)) FOR [idestado]
GO
ALTER TABLE [Entidad].[Personas] ADD  CONSTRAINT [DF_Personas_extranjero]  DEFAULT ((0)) FOR [extranjero]
GO
ALTER TABLE [Entidad].[Personas] ADD  CONSTRAINT [DF_Personas_idocupacion]  DEFAULT ((0)) FOR [idocupacion]
GO
ALTER TABLE [Entidad].[Personas] ADD  CONSTRAINT [DF__Personas__fechar__75A278F5]  DEFAULT (getdate()) FOR [fecharegistro]
GO
ALTER TABLE [Entidad].[Personas] ADD  CONSTRAINT [DF__Personas__usuari__76969D2E]  DEFAULT ('directo') FOR [usuarioregistro]
GO
ALTER TABLE [Entidad].[Personas] ADD  CONSTRAINT [DF_Personas_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [Entidad].[Usuarios] ADD  CONSTRAINT [DF__Usuarios__fechar__619B8048]  DEFAULT (getdate()) FOR [fecharegistro]
GO
ALTER TABLE [Entidad].[Usuarios] ADD  CONSTRAINT [DF__Usuarios__usuari__628FA481]  DEFAULT ('directo') FOR [usuarioreg]
GO
ALTER TABLE [Dir].[Calles]  WITH CHECK ADD  CONSTRAINT [FK_Calles_Paraje1] FOREIGN KEY([idpais], [idprovincia], [idmunicipio], [idsector], [idparaje])
REFERENCES [Dir].[Paraje] ([idpais], [idprovincia], [idmunicipio], [idsector], [id])
GO
ALTER TABLE [Dir].[Calles] CHECK CONSTRAINT [FK_Calles_Paraje1]
GO
ALTER TABLE [Dir].[Municipios]  WITH CHECK ADD  CONSTRAINT [FK_Municipios_Provincias] FOREIGN KEY([idpais], [idprovincia])
REFERENCES [Dir].[Provincias] ([idpais], [id])
GO
ALTER TABLE [Dir].[Municipios] CHECK CONSTRAINT [FK_Municipios_Provincias]
GO
ALTER TABLE [Dir].[Paraje]  WITH CHECK ADD  CONSTRAINT [FK_Paraje_Sector] FOREIGN KEY([idpais], [idprovincia], [idmunicipio], [idsector])
REFERENCES [Dir].[Sector] ([idpais], [idprovincia], [idmunicipio], [id])
GO
ALTER TABLE [Dir].[Paraje] CHECK CONSTRAINT [FK_Paraje_Sector]
GO
ALTER TABLE [Dir].[Provincias]  WITH CHECK ADD  CONSTRAINT [FK_Provincias_Pais] FOREIGN KEY([idpais])
REFERENCES [Dir].[Pais] ([id])
GO
ALTER TABLE [Dir].[Provincias] CHECK CONSTRAINT [FK_Provincias_Pais]
GO
ALTER TABLE [Dir].[Sector]  WITH CHECK ADD  CONSTRAINT [FK_Sector_Municipios] FOREIGN KEY([idpais], [idprovincia], [idmunicipio])
REFERENCES [Dir].[Municipios] ([idpais], [idprovincia], [id])
GO
ALTER TABLE [Dir].[Sector] CHECK CONSTRAINT [FK_Sector_Municipios]
GO
ALTER TABLE [Entidad].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Terceros] FOREIGN KEY([idcompania], [idtercero])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[Clientes] CHECK CONSTRAINT [FK_Clientes_Terceros]
GO
ALTER TABLE [Entidad].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipos_Clientes] FOREIGN KEY([idcompania], [idtipo])
REFERENCES [Gen].[Tipos_Clientes] ([idcompania], [id])
GO
ALTER TABLE [Entidad].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipos_Clientes]
GO
ALTER TABLE [Entidad].[Companias]  WITH CHECK ADD  CONSTRAINT [FK_Companias1] FOREIGN KEY([idcompania], [idterceros])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[Companias] CHECK CONSTRAINT [FK_Companias1]
GO
ALTER TABLE [Entidad].[Correos]  WITH CHECK ADD  CONSTRAINT [FK_Correos_Terceros] FOREIGN KEY([idcompania], [idterceros])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[Correos] CHECK CONSTRAINT [FK_Correos_Terceros]
GO
ALTER TABLE [Entidad].[Correos]  WITH CHECK ADD  CONSTRAINT [FK_Correos_Tipos_Correos] FOREIGN KEY([idcompania], [idtipo])
REFERENCES [Gen].[Tipos_Correos] ([idcompania], [id])
GO
ALTER TABLE [Entidad].[Correos] CHECK CONSTRAINT [FK_Correos_Tipos_Correos]
GO
ALTER TABLE [Entidad].[Direcciones]  WITH CHECK ADD  CONSTRAINT [FK_Direcciones_Calles] FOREIGN KEY([idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [idcalle])
REFERENCES [Dir].[Calles] ([idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [id])
GO
ALTER TABLE [Entidad].[Direcciones] CHECK CONSTRAINT [FK_Direcciones_Calles]
GO
ALTER TABLE [Entidad].[Direcciones]  WITH CHECK ADD  CONSTRAINT [FK_Direcciones_Tipos_Direcciones] FOREIGN KEY([idcompania], [idtipo])
REFERENCES [Gen].[Tipos_Direcciones] ([idcompania], [id])
GO
ALTER TABLE [Entidad].[Direcciones] CHECK CONSTRAINT [FK_Direcciones_Tipos_Direcciones]
GO
ALTER TABLE [Entidad].[Documentaciones]  WITH CHECK ADD  CONSTRAINT [FK_documentaciones1] FOREIGN KEY([idcompania], [idtercero])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[Documentaciones] CHECK CONSTRAINT [FK_documentaciones1]
GO
ALTER TABLE [Entidad].[Documentaciones]  WITH CHECK ADD  CONSTRAINT [FK_documentaciones2] FOREIGN KEY([idcompania], [idtipo])
REFERENCES [Gen].[Tipos_Documentaciones] ([idcompania], [id])
GO
ALTER TABLE [Entidad].[Documentaciones] CHECK CONSTRAINT [FK_documentaciones2]
GO
ALTER TABLE [Entidad].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Departamentos] FOREIGN KEY([idcompania], [iddepartamento])
REFERENCES [reclamos].[Departamentos] ([Idcompania], [Id])
GO
ALTER TABLE [Entidad].[Empleados] CHECK CONSTRAINT [FK_Empleados_Departamentos]
GO
ALTER TABLE [Entidad].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Terceros] FOREIGN KEY([idcompania], [idterceros])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[Empleados] CHECK CONSTRAINT [FK_Empleados_Terceros]
GO
ALTER TABLE [Entidad].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Tipos_Empleados] FOREIGN KEY([idcompania], [idtipo])
REFERENCES [Gen].[Tipos_Empleados] ([idcompania], [id])
GO
ALTER TABLE [Entidad].[Empleados] CHECK CONSTRAINT [FK_Empleados_Tipos_Empleados]
GO
ALTER TABLE [Entidad].[Familiares]  WITH CHECK ADD  CONSTRAINT [FK_Familiares_Terceros] FOREIGN KEY([idcompania], [idtercero])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[Familiares] CHECK CONSTRAINT [FK_Familiares_Terceros]
GO
ALTER TABLE [Entidad].[Familiares]  WITH CHECK ADD  CONSTRAINT [FK_Familiares_Terceros1] FOREIGN KEY([idcompania], [idtercerofam])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[Familiares] CHECK CONSTRAINT [FK_Familiares_Terceros1]
GO
ALTER TABLE [Entidad].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Terceros] FOREIGN KEY([idcompania], [idterceros])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[Personas] CHECK CONSTRAINT [FK_Personas_Terceros]
GO
ALTER TABLE [Entidad].[RedesSociales]  WITH CHECK ADD  CONSTRAINT [FK_RedesSociales_Terceros] FOREIGN KEY([idcompania], [idterceros])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[RedesSociales] CHECK CONSTRAINT [FK_RedesSociales_Terceros]
GO
ALTER TABLE [Entidad].[RedesSociales]  WITH CHECK ADD  CONSTRAINT [FK_RedesSociales_Tipos_RedesSociales] FOREIGN KEY([idcompania], [idtipo])
REFERENCES [Gen].[Tipos_RedesSociales] ([idcompania], [id])
GO
ALTER TABLE [Entidad].[RedesSociales] CHECK CONSTRAINT [FK_RedesSociales_Tipos_RedesSociales]
GO
ALTER TABLE [Entidad].[Telefonos]  WITH CHECK ADD  CONSTRAINT [FK_Telefonos_Terceros] FOREIGN KEY([idcompania], [idterceros])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[Telefonos] CHECK CONSTRAINT [FK_Telefonos_Terceros]
GO
ALTER TABLE [Entidad].[Telefonos]  WITH CHECK ADD  CONSTRAINT [FK_Telefonos_Tipos_Telefonos] FOREIGN KEY([idcompania], [idtipo])
REFERENCES [Gen].[Tipos_Telefonos] ([idcompania], [id])
GO
ALTER TABLE [Entidad].[Telefonos] CHECK CONSTRAINT [FK_Telefonos_Tipos_Telefonos]
GO
ALTER TABLE [Entidad].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_tipouser] FOREIGN KEY([idcompania], [idtipo])
REFERENCES [Gen].[Tipos_Usuarios] ([idcompania], [id])
GO
ALTER TABLE [Entidad].[Usuarios] CHECK CONSTRAINT [FK_tipouser]
GO
ALTER TABLE [Entidad].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios1] FOREIGN KEY([idcompania], [idterceros])
REFERENCES [Entidad].[Terceros] ([idcompania], [idterceros])
GO
ALTER TABLE [Entidad].[Usuarios] CHECK CONSTRAINT [FK_usuarios1]
GO
ALTER TABLE [reclamos].[Acciones_Dependientes]  WITH CHECK ADD  CONSTRAINT [FK_Acciones_Dependientes_Acciones] FOREIGN KEY([idcompania], [idaccion])
REFERENCES [reclamos].[Acciones] ([idcompania], [id])
GO
ALTER TABLE [reclamos].[Acciones_Dependientes] CHECK CONSTRAINT [FK_Acciones_Dependientes_Acciones]
GO
ALTER TABLE [reclamos].[Tipo_Reclamos]  WITH CHECK ADD  CONSTRAINT [FK_Tipo_Reclamos_Departamentos] FOREIGN KEY([idcompania], [iddepartamento])
REFERENCES [reclamos].[Departamentos] ([Idcompania], [Id])
GO
ALTER TABLE [reclamos].[Tipo_Reclamos] CHECK CONSTRAINT [FK_Tipo_Reclamos_Departamentos]
GO
ALTER TABLE [reclamos].[Tipo_Reclamos]  WITH CHECK ADD  CONSTRAINT [FK_Tipo_Reclamos_Tipos_Niveles] FOREIGN KEY([idcompania], [idnivel])
REFERENCES [reclamos].[Tipos_Niveles] ([idcompania], [id])
GO
ALTER TABLE [reclamos].[Tipo_Reclamos] CHECK CONSTRAINT [FK_Tipo_Reclamos_Tipos_Niveles]
GO
ALTER TABLE [reclamos].[Tipos_Reclamos_Acciones]  WITH CHECK ADD  CONSTRAINT [FK_Tipos_Reclamos_Acciones_Tipo_Reclamos] FOREIGN KEY([idcompania], [idtipo])
REFERENCES [reclamos].[Tipo_Reclamos] ([idcompania], [id])
GO
ALTER TABLE [reclamos].[Tipos_Reclamos_Acciones] CHECK CONSTRAINT [FK_Tipos_Reclamos_Acciones_Tipo_Reclamos]
GO
ALTER TABLE [reclamos].[Transacciones]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Clientes] FOREIGN KEY([idcompania], [idcliente])
REFERENCES [Entidad].[Clientes] ([idcompania], [id])
GO
ALTER TABLE [reclamos].[Transacciones] CHECK CONSTRAINT [FK_Transacciones_Clientes]
GO
ALTER TABLE [reclamos].[Transacciones]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Empleados] FOREIGN KEY([idcompania], [idoperador])
REFERENCES [Entidad].[Empleados] ([idcompania], [id])
GO
ALTER TABLE [reclamos].[Transacciones] CHECK CONSTRAINT [FK_Transacciones_Empleados]
GO
ALTER TABLE [reclamos].[Transacciones]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Tipo_Reclamos] FOREIGN KEY([idcompania], [idtipo])
REFERENCES [reclamos].[Tipo_Reclamos] ([idcompania], [id])
GO
ALTER TABLE [reclamos].[Transacciones] CHECK CONSTRAINT [FK_Transacciones_Tipo_Reclamos]
GO
ALTER TABLE [reclamos].[Transacciones_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Detalle_Empleados] FOREIGN KEY([idcompania], [idempleado])
REFERENCES [Entidad].[Empleados] ([idcompania], [id])
GO
ALTER TABLE [reclamos].[Transacciones_Detalle] CHECK CONSTRAINT [FK_Transacciones_Detalle_Empleados]
GO
ALTER TABLE [reclamos].[Transacciones_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Detalle_Transacciones] FOREIGN KEY([idcompania], [id])
REFERENCES [reclamos].[Transacciones] ([idcompania], [id])
GO
ALTER TABLE [reclamos].[Transacciones_Detalle] CHECK CONSTRAINT [FK_Transacciones_Detalle_Transacciones]
GO
/****** Object:  StoredProcedure [dbo].[insertar_acciones_dependientes]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[insertar_acciones_dependientes]
@idcompania int ,
@idaccion int ,
@idempleado int,
@estado bit


--select * from reclamos.Tipos_Niveles
as
if exists(select * from reclamos.Acciones_Dependientes where idcompania = @idcompania and idaccion= @idaccion  and idempleado=@idempleado)
begin
update reclamos.Acciones_Dependientes set idaccion=@idaccion, idempleado=@idempleado,estado=@estado
where idcompania=@idcompania
end
	else
	begin
insert  reclamos.Acciones_Dependientes(idcompania,idaccion,idempleado,estado)
values(@idcompania,@idaccion,@idempleado,@estado)
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_tpsniveles]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_tpsniveles]
@idcompania int ,
@id int ,
@descripcion varchar(50),
@nivel int


--select * from reclamos.Tipos_Niveles
as
if exists(select * from reclamos.Tipos_Niveles where idcompania = @idcompania and id =@id)
begin
update reclamos.Tipos_Niveles set descripcion=@descripcion, nivel=@nivel
where id=@id
end
	else
	begin
insert  reclamos.Tipos_Niveles(idcompania,id,descripcion,nivel)
values(@idcompania,@id,@descripcion,@nivel)
end
GO
/****** Object:  StoredProcedure [Dir].[proc_pais]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Dir].[proc_pais]
	 
	 @id int ,
	 @nombre varchar(100)
	
AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from Dir.Pais where  id =@id)
	begin
		update Dir.Pais set  nombre = @nombre where id =@id
	end
	else
	begin
		insert into Dir.Pais (id,nombre) values(@id,@nombre)
	end
END
GO
/****** Object:  StoredProcedure [Entidad].[Proc_Clientes]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [Entidad].[Proc_Clientes]
	 @idcompania int ,
	 @id int,
	 @idtipo int, 
	 @nom varchar(100),
	 @ape varchar(100),
	 @tel varchar(20),
	 @cel varchar(20),
	 @correo varchar(60),
	 @pais  int ,
	 @prov  int ,
	 @muni  int ,
	 @sec   int ,
	 @par   int ,
	 @calle int ,
	 @dir   varchar(max) ,
	 @est bit
AS
BEGIN
declare @idtercero int
	if exists(select idtercero from entidad.Clientes where idcompania = @idcompania and id = @id)
	begin 
		set @idtercero = (select idtercero from entidad.Clientes where idcompania = @idcompania and id = @id)
		update Entidad.Terceros set nombre = @nom where idcompania = @idcompania and idterceros = @idtercero
		update Entidad.Clientes set estado = @est where idcompania = @idcompania and id = @id
    end
	else
	begin 
		insert into Entidad.Terceros(idcompania,nombre) values (@idcompania,@nom) 
		select @idtercero = @@IDENTITY 
		insert into Entidad.Clientes(idcompania,id,idtercero,idtipo,estado) values(@idcompania,@id,@idtercero,@idtipo,@est)
	end

		if exists(select apellidos from entidad.Personas where idcompania = @idcompania and idterceros = @idtercero)
		begin
			update entidad.Personas set apellidos = @ape where idcompania = @idcompania and idterceros = @idtercero
		end 
		else
		begin
		if(len(@ape) > 0)
			begin 
				insert Entidad.Personas(idcompania,idterceros,apellidos) values (@idcompania,@idtercero,@ape)
 			end
		end
 	end
	
	if exists(select * from entidad.Telefonos where idcompania= @idcompania and idterceros = @idtercero and idtipo = 1)
	begin
		update entidad.Telefonos set telefono = @tel where idcompania= @idcompania and idterceros = @idtercero and idtipo = 1
	end
	else
	begin
		insert Entidad.Telefonos(idcompania,idterceros,idtipo,id,telefono) values(@idcompania,@idtercero,1,1,@tel) 
	end


	if exists(select * from entidad.Telefonos where idcompania= @idcompania and idterceros = @idtercero and idtipo = 2)
	begin
		update entidad.Telefonos set telefono = @cel where idcompania= @idcompania and idterceros = @idtercero and idtipo = 2
	end
	else
	begin
		insert Entidad.Telefonos(idcompania,idterceros,idtipo,id,telefono) values(@idcompania,@idtercero,2,1,@cel) 
	end

	
	if exists(select * from entidad.Correos where idcompania= @idcompania and idterceros = @idtercero and idtipo = 1)
	begin
		update entidad.Correos set Correo = @correo where idcompania= @idcompania and idterceros = @idtercero and idtipo = 1
	end
	else
	begin
		insert Entidad.Correos(idcompania,idterceros,idtipo,id,correo) values(@idcompania,@idtercero,1,1,@correo) 
	end

	if(@pais <> 0)
	begin
	if exists(select * from entidad.Direcciones where idcompania= @idcompania and idtercero  = @idtercero and idtipo = 1)
	begin
		update entidad.Direcciones set idpais = @pais,idprovincia= @prov,idmunicipio = @muni,idsector = @sec,idparaje = @par,idcalle = @calle,referencia = @dir
		where idcompania= @idcompania and idtercero = @idtercero and idtipo = 1
	end
	else
	begin
		INSERT INTO Entidad.Direcciones(idcompania, idtercero, idpais, idprovincia, idmunicipio, idsector, idparaje, idcalle, idtipo, referencia)
		VALUES (@idcompania,@idtercero,@pais,@prov,@muni,@sec,@par,@calle,1,@dir)
	end
	end
GO
/****** Object:  StoredProcedure [Entidad].[proc_empleados]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Entidad].[proc_empleados]
	 @idcompania int ,
	 @id int,
	 @idtipo int, 
	 @nom varchar(100),
	 @ape varchar(100),
	 @iddep  int ,
	 @horaentrada time,
	 @horasalida  time, 
	 @horabreaki  time,
	 @horabreaks  time,
	 @est bit
AS
BEGIN
declare @idterceros int
	if exists(select idterceros from Entidad.Empleados where idcompania = @idcompania and id = @id)
	begin 
		set @idterceros = (select idterceros from Entidad.Empleados  where idcompania = @idcompania and id = @id)
		update Entidad.Terceros set nombre = @nom where idcompania = @idcompania and idterceros = @idterceros
		update Entidad.Empleados  set estado = @est, iddepartamento = @iddep, horaentrada = @horaentrada, horasalida=  @horaentrada,
		horabreaki = @horabreaki, horabreaks = @horabreaks
		 where idcompania = @idcompania and id = @id	  and idtipo = 1
    end
	else

	begin 
		insert into Entidad.Terceros(idcompania,nombre) values (@idcompania,@nom) 
		select @idterceros = @@IDENTITY 
		insert into Entidad.Empleados(idcompania,id,idterceros,idtipo,iddepartamento, horaentrada,horasalida,horabreaki,horabreaks,disponible,fechareg,estado) values(@idcompania,@id,@idterceros,@idtipo,@iddep,@horaentrada,@horasalida,@horabreaki,@horabreaks,1,getdate(),@est)
	
	end

		if exists(select apellidos from Entidad.Personas where idcompania = @idcompania and idterceros = @idterceros)
		begin
			update Entidad.Personas set apellidos = @ape where idcompania = @idcompania and idterceros = @idterceros
		end 
		else
		begin
		if(len(@ape) > 0)
			begin 
				insert Entidad.Personas(idcompania,idterceros,apellidos) values (@idcompania,@idterceros,@ape)
 			end
		end
 	end
GO
/****** Object:  StoredProcedure [Entidad].[Proc_Usuarios]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Entidad].[Proc_Usuarios] 
	@idcompania	int	,
	@id	int	,
	@nom	varchar(100)	,
	@ape varchar(100)	,
	@tel varchar(20)	,
	@correo varchar(60)	,
	@idtipo	int	,
	@usuario	varchar(30)	,
	@clave	varchar(MAX) 	,
	@autorizar	bit	,
	@usuarioreg	varchar(50)	,
	@estado	bit	
AS
BEGIN 
	 declare @idterceros int;

	 if(not exists(select id from entidad.Usuarios where idcompania = @idcompania and id =@id))
	 begin
		insert into terceros(idcompania,nombre) values(@idcompania,@nom)
		set @idterceros = @@IDENTITY
	 end
	 else
	 begin
		set @idterceros =(select idterceros from entidad.Usuarios where idcompania = @idcompania and id =@id)
		update entidad.Terceros set nombre =@nom where idcompania = @idcompania and idterceros =@idterceros
	 end 

	 if exists(select apellidos from entidad.Personas where idcompania = @idcompania and idterceros = @idterceros)
		begin
			update entidad.Personas set apellidos = @ape where idcompania = @idcompania and idterceros = @idterceros
		end 
		else
		begin
		if(len(@ape) > 0)
			begin 
				insert Entidad.Personas(idcompania,idterceros,apellidos) values (@idcompania,@idterceros,@ape)
 			end
		end

	if exists(select * from entidad.Telefonos where idcompania= @idcompania and idterceros = @idterceros and idtipo = 1)
	begin
		update entidad.Telefonos set telefono = @tel where idcompania= @idcompania and idterceros = @idterceros and idtipo = 1
	end
	else
	begin
		insert Entidad.Telefonos(idcompania,idterceros,idtipo,id,telefono) values(@idcompania,@idterceros,1,1,@tel) 
	end

 	if exists(select * from entidad.Correos where idcompania= @idcompania and idterceros = @idterceros and idtipo = 1)
	begin
		update entidad.Correos set Correo = @correo where idcompania= @idcompania and idterceros = @idterceros and idtipo = 1
	end
	else
	begin
		insert Entidad.Correos(idcompania,idterceros,idtipo,id,correo) values(@idcompania,@idterceros,1,1,@correo) 
	end

	 if (@id = 0 or not exists(select id from entidad.Usuarios where idcompania = @idcompania and id =@id))
	 begin 
		if(@id = 0)
		begin
			set @id = (select isnull(max(id),0)+1 as sec from entidad.Usuarios where idcompania = @idcompania) ;
		end
		INSERT INTO [Entidad].[Usuarios]
           ([idcompania]
           ,[id]
           ,[idterceros]
           ,[idtipo]
           ,[usuario]
           ,[clave]
           ,[autorizar]
           ,[fecharegistro]
           ,[usuarioreg]
           ,[estado])
     VALUES(
            @idcompania
           ,@id
		   ,@idterceros
           ,@idtipo
           ,@usuario
           ,PWDENCRYPT(@clave)
           ,@autorizar
           ,GETDATE()
           ,@usuarioreg
           ,@estado)
	 end
	 else
	 begin
		if (@clave <> '')
		begin 
			UPDATE [Entidad].[Usuarios]
			   SET 
				  [idterceros] =@idterceros
				  ,[idtipo] = @idtipo
				  ,[usuario] = @usuario
				  ,[clave] = PWDENCRYPT(@clave)
				  ,[autorizar] = @autorizar
				  ,[estado] = @estado
			 WHERE [idcompania] = @idcompania and [id] = @id 
		 end
		 else
		 begin
		 	  UPDATE [Entidad].[Usuarios]
			   SET 
				  [idterceros] =@idterceros
				  ,[idtipo] = @idtipo
				  ,[usuario] = @usuario 
				  ,[autorizar] = @autorizar
				  ,[estado] = @estado
			 WHERE [idcompania] = @idcompania and [id] = @id 

		 end
	 end


END
GO
/****** Object:  StoredProcedure [Gen].[proc_tclientes]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Tamar>
-- Create date: <Create Date,,>
-- Description:	<Procedimiento para los tipos de clientes>
-- =============================================
CREATE PROCEDURE [Gen].[proc_tclientes]
	 @idcompania int ,
	 @id int ,
	 @nombre varchar(50)
	
AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from Gen.Tipos_Clientes where idcompania = @idcompania and id =@id)
	begin
		update Gen.Tipos_Clientes set nombre = @nombre where idcompania = @idcompania and id =@id
	end
	else
	begin
		insert into Gen.Tipos_Clientes (idcompania,id,nombre) values(@idcompania,@id,@nombre)
	end
END
GO
/****** Object:  StoredProcedure [Gen].[proc_tcorreos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Tamar>
-- Create date: <Create Date,,>
-- Description:	<Procedimiento para los tiposde correo,,>
-- =============================================
CREATE PROCEDURE [Gen].[proc_tcorreos]
	 @idcompania int ,
	 @id int ,
	 @nombre varchar(80)
	
AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from Gen.Tipos_Correos where idcompania = @idcompania and id =@id)
	begin
		update Gen.Tipos_Correos set nombre = @nombre where idcompania = @idcompania and id =@id
	end
	else
	begin
		insert into Gen.Tipos_Correos (idcompania,id,nombre) values(@idcompania,@id,@nombre)
	end
END
GO
/****** Object:  StoredProcedure [Gen].[proc_tdirecciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gen].[proc_tdirecciones]
	 @idcompania int ,
	 @id int ,
	 @nombre varchar(80)
	
AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from Gen.Tipos_Direcciones where idcompania = @idcompania and id =@id)
	begin
		update Gen.Tipos_Direcciones set nombre = @nombre where idcompania = @idcompania and id =@id
	end
	else
	begin
		insert into Gen.Tipos_Direcciones(idcompania,id,nombre) values(@idcompania,@id,@nombre)
	end
END
GO
/****** Object:  StoredProcedure [Gen].[proc_tdocumentaciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gen].[proc_tdocumentaciones]
	 @idcompania int ,
	 @id int ,
	 @nombre varchar(80)
	
AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from Gen.Tipos_Documentaciones where idcompania = @idcompania and id =@id)
	begin
		update Gen.Tipos_Documentaciones set nombre = @nombre where idcompania = @idcompania and id =@id
	end
	else
	begin
		insert into Gen.Tipos_Documentaciones(idcompania,id,nombre) values(@idcompania,@id,@nombre)
	end
END
GO
/****** Object:  StoredProcedure [Gen].[proc_templeados]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Tamar>
-- Create date: <Create Date,,>
-- Description:	<Procedimiento para los tipos de clientes>
-- =============================================
CREATE PROCEDURE [Gen].[proc_templeados]
	 @idcompania int ,
	 @id int ,
	 @descripcion varchar(100)
	
AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from Gen.Tipos_Empleados where idcompania = @idcompania and id =@id)
	begin
		update Gen.Tipos_Empleados set descripcion = @descripcion where idcompania = @idcompania and id =@id
	end
	else
	begin
		insert into Gen.Tipos_Empleados(idcompania,id,descripcion) values(@idcompania,@id,@descripcion)
	end
END
GO
/****** Object:  StoredProcedure [Gen].[proc_tredessociales]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Tamar>
-- Create date: <Create Date,,>
-- Description:	<Procedimiento para los tipos redes sociales>
-- =============================================
CREATE PROCEDURE [Gen].[proc_tredessociales]
	 @idcompania int ,
	 @id int ,
	 @nombre varchar(80)
	
AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from Gen.Tipos_RedesSociales where idcompania = @idcompania and id =@id)
	begin
		update Gen.Tipos_RedesSociales set nombre = @nombre where idcompania = @idcompania and id =@id
	end
	else
	begin
		insert into Gen.Tipos_RedesSociales (idcompania,id,nombre) values(@idcompania,@id,@nombre)
	end
END
GO
/****** Object:  StoredProcedure [Gen].[proc_ttelefonos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gen].[proc_ttelefonos]
	 @idcompania int ,
	 @id int ,
	 @nombre varchar(80)
	
AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from Gen.Tipos_Telefonos where idcompania = @idcompania and id =@id)
	begin
		update Gen.Tipos_Telefonos set nombre = @nombre where idcompania = @idcompania and id =@id
	end
	else
	begin
		insert into Gen.Tipos_Telefonos(idcompania,id,nombre) values(@idcompania,@id,@nombre)
	end
END
GO
/****** Object:  StoredProcedure [Gen].[proc_tusuarios]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gen].[proc_tusuarios]
	 @idcompania int ,
	 @id int ,
	 @nombre varchar(50),
	 @nota varchar(max) null
	
AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from Gen.Tipos_Usuarios where idcompania = @idcompania and id =@id)
	begin
		update Gen.Tipos_Usuarios  set nombre = @nombre, nota = @nota where idcompania = @idcompania and id =@id
	end
	else
	begin
		insert into Gen.Tipos_Usuarios (idcompania,id,nombre,nota) values(@idcompania,@id,@nombre,@nota)
	end
END
GO
/****** Object:  StoredProcedure [reclamos].[pro_departamentos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create PROCEDURE [reclamos].[pro_departamentos]
	 @Idcompania int,
	 @Id int ,
	 @Descripcion varchar(50),
	 @Idencargado int ,
	 @Funcion varchar(100),
	 @Estado bit

AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from reclamos.Departamentos where Idcompania = @Idcompania and Id =@Id)
	begin
		update reclamos.Departamentos set Descripcion = @Descripcion,Idencargado=@Idencargado,Funcion=@Funcion, Estado = @Estado 
		where Idcompania = @Idcompania and Id =@Id
	end
	else
	begin
		insert into reclamos.Departamentos(Idcompania,Id,Descripcion,Idencargado,Funcion,Estado) values(@Idcompania, @Id, @Descripcion,
		@Idencargado, @Funcion, @Estado)
	end
END
GO
/****** Object:  StoredProcedure [reclamos].[proc_acciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [reclamos].[proc_acciones]
	 @idcomp int ,
	 @id int ,
	 @des varchar(60),
	 @est bit
AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from reclamos.Acciones where idcompania = @idcomp and id =@id)
	begin
		update reclamos.Acciones set descripcion = @des,estado = @est where idcompania = @idcomp and id =@id
	end
	else
	begin
		insert into reclamos.Acciones (idcompania,id,descripcion,estado) values(@idcomp,@id,@des,@est)
	end
END
GO
/****** Object:  StoredProcedure [reclamos].[Proc_Departamentos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [reclamos].[Proc_Departamentos]
	 @idcom int,
	 @id int,
	 @des varchar(50),
	 @idenc int,
	 @funcion varchar(100),
	 @est bit
AS
BEGIN
	 if exists(select id from reclamos.Departamentos where Idcompania = @idcom and id = @id)
	 begin
		UPDATE reclamos.Departamentos
		SET Descripcion =@des, Idencargado =@idenc, Funcion =@funcion, Estado =@est where Idcompania =@idcom and Id =@id
	 end
	 else
	 begin 
		 INSERT   INTO reclamos.Departamentos(Idcompania, Id, Descripcion, Idencargado, Funcion, Estado)
		VALUES        (@idcom,@id,@des,@idenc,@funcion,@est)
	 end
END
GO
/****** Object:  StoredProcedure [reclamos].[Proc_Tipos_Reclamos]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create PROCEDURE [reclamos].[Proc_Tipos_Reclamos]
	 @Idcompania int,
	 @Id int ,
	 @iddepartamento int ,
	 @idnivel int,
	 @Descripcion varchar(50),
	 @Estado bit

AS
BEGIN 
	SET NOCOUNT ON;
	
	if exists(select * from reclamos.Tipo_Reclamos where Idcompania = @Idcompania and Id =@Id)
	begin
		update reclamos.Tipo_Reclamos set Descripcion = @Descripcion,iddepartamento=@iddepartamento,idnivel=@idnivel, Estado = @Estado 
		where Idcompania = @Idcompania and Id =@Id
	end
	else
	begin
		insert into reclamos.Tipo_Reclamos(Idcompania,Id,Descripcion,iddepartamento,idnivel,Estado) values(@Idcompania, @Id, @Descripcion,
		@iddepartamento, @idnivel, @Estado)
	end
END
GO
/****** Object:  StoredProcedure [reclamos].[Proc_Tipos_Reclamos_Acciones]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [reclamos].[Proc_Tipos_Reclamos_Acciones]
	@idcompania	int,
	@idtipo	int	,
	@idaccion	int	,
	@representa	numeric(8, 2)	,
	@estado	bit	
AS
BEGIN 
 if exists(select idcompania from Reclamos.Tipos_Reclamos_Acciones where idcompania = @idcompania and idaccion = @idaccion and idtipo = @idtipo)
 begin
	update Reclamos.Tipos_Reclamos_Acciones set representa= @representa,estado= @estado where  idcompania = @idcompania and idaccion = @idaccion and idtipo = @idtipo
 end
 else
 begin
	INSERT 
	INTO              reclamos.Tipos_Reclamos_Acciones(idcompania, idtipo, idaccion, representa, estado)
	VALUES        (@idcompania,@idtipo,@idaccion,@representa,@estado)
 end
END
GO
/****** Object:  StoredProcedure [reclamos].[Proc_TransaccionesH]    Script Date: 20/4/2020 6:42:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [reclamos].[Proc_TransaccionesH]
	@idcompania	int			,
	@id	int					,
	@idtipo	int				,
	@idcliente	int			,
	@idoperador	int			,
	@HoraAtendido	time(7)	,
	@HoraDespachado	time(7)	,
	@estado	bit				,
	@nota	varchar(MAX)
	
AS
BEGIN
	 IF NOT EXISTS(select id from reclamos.Transacciones where idcompania = @idcompania and id=  @id)
	 begin
		declare @idsec int;
		set @idsec =(select isnull(max(id),0)+1 from reclamos.Transacciones where idcompania = @idcompania)
		INSERT 
		INTO reclamos.Transacciones(idcompania,id,idtipo, idcliente, idoperador, fecha, HoraAtendido, HoraDespachado, estado, nota)
		VALUES (@idcompania,@idsec,@idtipo,@idcliente,@idoperador,GETDATE(),@HoraAtendido,@HoraDespachado,@estado,@nota)
	 end
	 else
	 begin 
		UPDATE reclamos.Transacciones
		SET idtipo =@idtipo, idcliente =@idcliente, idoperador =@idoperador, HoraAtendido =@HoraAtendido, HoraDespachado =@HoraDespachado, estado =@estado, nota =@nota
		WHERE  (idcompania = @idcompania) AND (id = @id)
	 end
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Clientes (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Personas (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Terceros (Entidad)"
            Begin Extent = 
               Top = 41
               Left = 609
               Bottom = 154
               Right = 779
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Clientes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Clientes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Clientes (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 263
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Terceros (Entidad)"
            Begin Extent = 
               Top = 12
               Left = 286
               Bottom = 125
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "V_Entidades_Direcciones"
            Begin Extent = 
               Top = 164
               Left = 668
               Bottom = 294
               Right = 838
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Personas (Entidad)"
            Begin Extent = 
               Top = 14
               Left = 812
               Bottom = 144
               Right = 982
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 22
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Clientes_Direcciones'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 2475
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Clientes_Direcciones'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Clientes_Direcciones'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "V_Clientes_Direcciones"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 263
               Right = 603
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "Telefonos (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Clientes_DirTel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Clientes_DirTel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Departamentos (reclamos)"
            Begin Extent = 
               Top = 32
               Left = 73
               Bottom = 162
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Empleados (Entidad)"
            Begin Extent = 
               Top = 33
               Left = 400
               Bottom = 250
               Right = 572
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Terceros (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 458
               Bottom = 119
               Right = 628
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Personas (Entidad)"
            Begin Extent = 
               Top = 24
               Left = 748
               Bottom = 154
               Right = 918
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 2325
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Departamentos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Departamentos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Departamentos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Empleados (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 263
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Terceros (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 250
               Bottom = 119
               Right = 420
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Personas (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 458
               Bottom = 136
               Right = 628
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Empleados'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Empleados'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[36] 2[3] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Calles (Dir)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Direcciones (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Municipios (Dir)"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pais (Dir)"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 102
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Paraje (Dir)"
            Begin Extent = 
               Top = 85
               Left = 837
               Bottom = 215
               Right = 1007
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Provincias (Dir)"
            Begin Extent = 
               Top = 159
               Left = 104
               Bottom = 272
               Right = 274
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sector (Dir)"
            Begin Extent = 
               Top = 140
               Left = 429
               Bottom = 270
               Right = 599
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Entidades_Direcciones'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'           End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Entidades_Direcciones'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Entidades_Direcciones'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Terceros (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Personas (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Empleados (Entidad)"
            Begin Extent = 
               Top = 34
               Left = 701
               Bottom = 164
               Right = 875
            End
            DisplayFlags = 280
            TopColumn = 8
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Operador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Operador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Transacciones (reclamos)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Tipo_Reclamos (reclamos)"
            Begin Extent = 
               Top = 6
               Left = 256
               Bottom = 136
               Right = 430
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "V_Clientes"
            Begin Extent = 
               Top = 6
               Left = 468
               Bottom = 136
               Right = 638
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Reclamos_Detallado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Reclamos_Detallado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "V_Clientes"
            Begin Extent = 
               Top = 6
               Left = 28
               Bottom = 247
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tipos_Niveles (reclamos)"
            Begin Extent = 
               Top = 13
               Left = 841
               Bottom = 143
               Right = 1011
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tipo_Reclamos (reclamos)"
            Begin Extent = 
               Top = 8
               Left = 594
               Bottom = 138
               Right = 768
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Transacciones (reclamos)"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 252
               Right = 426
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 17
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         O' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Reclamos_Niveles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'utput = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Reclamos_Niveles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Reclamos_Niveles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Acciones (reclamos)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tipos_Reclamos_Acciones (reclamos)"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Tipos_Reclamos_Acciones'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Tipos_Reclamos_Acciones'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tipos_Reclamos_Acciones (reclamos)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Tipo_Reclamos (reclamos)"
            Begin Extent = 
               Top = 27
               Left = 338
               Bottom = 157
               Right = 512
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Acciones (reclamos)"
            Begin Extent = 
               Top = 22
               Left = 701
               Bottom = 152
               Right = 871
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Tipos_Reclamos_Acciones2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Tipos_Reclamos_Acciones2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Transacciones_Detalle (reclamos)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Acciones (reclamos)"
            Begin Extent = 
               Top = 46
               Left = 288
               Bottom = 176
               Right = 458
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "V_Empleados"
            Begin Extent = 
               Top = 20
               Left = 546
               Bottom = 150
               Right = 720
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Transacciones_Detalles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Transacciones_Detalles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -495
      End
      Begin Tables = 
         Begin Table = "Transacciones (reclamos)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 227
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tipo_Reclamos (reclamos)"
            Begin Extent = 
               Top = 31
               Left = 247
               Bottom = 161
               Right = 421
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Empleados (Entidad)"
            Begin Extent = 
               Top = 7
               Left = 452
               Bottom = 137
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Terceros (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 680
               Bottom = 119
               Right = 850
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Personas (Entidad)"
            Begin Extent = 
               Top = 59
               Left = 901
               Bottom = 189
               Right = 1071
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Transacciones_Reclamos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Transacciones_Reclamos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Transacciones_Reclamos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Usuarios (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Terceros (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Personas (Entidad)"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Usuarios'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Usuarios'
GO
