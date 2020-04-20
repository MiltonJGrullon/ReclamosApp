USE [ReclamosDb]
GO
INSERT [Gen].[Tipos_Empleados] ([idcompania], [id], [descripcion]) VALUES (1, 1, N'Operadores.')
GO
INSERT [reclamos].[Departamentos] ([Idcompania], [Id], [Descripcion], [Idencargado], [Funcion], [Estado]) VALUES (1, 1, N'Departamento de ventas', 1, N'Ventas', 1)
GO
INSERT [reclamos].[Departamentos] ([Idcompania], [Id], [Descripcion], [Idencargado], [Funcion], [Estado]) VALUES (1, 2, N'Departamento de Compras', 1, N'Compras', 1)
GO
INSERT [reclamos].[Departamentos] ([Idcompania], [Id], [Descripcion], [Idencargado], [Funcion], [Estado]) VALUES (1, 3, N'Departamento de Devoluciones', 1, N'Devoluciones/ventas/compras', 1)
GO
INSERT [reclamos].[Departamentos] ([Idcompania], [Id], [Descripcion], [Idencargado], [Funcion], [Estado]) VALUES (1, 4, N'Almacen', 1, N'Control De productos', 1)
GO
INSERT [reclamos].[Departamentos] ([Idcompania], [Id], [Descripcion], [Idencargado], [Funcion], [Estado]) VALUES (1, 5, N'Cuentas por pagar', 2, N'cxp', 1)
GO
INSERT [reclamos].[Departamentos] ([Idcompania], [Id], [Descripcion], [Idencargado], [Funcion], [Estado]) VALUES (1, 6, N'Facturacion', 4, N'Area de facturacion', 1)
GO
SET IDENTITY_INSERT [Entidad].[Terceros] ON 
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 1, N'Milton')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 2, N'Jose Manuel')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 3, N'Julio Marcos')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 4, N'Adrian')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 5, N'Julio ')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 1005, N'a')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 1006, N'Adrian')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 1007, N'Admin')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 1008, N'Marcos')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 1009, N'Rocio')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 1010, N'Camilo')
GO
INSERT [Entidad].[Terceros] ([idcompania], [idterceros], [nombre]) VALUES (1, 1011, N'Susana')
GO
SET IDENTITY_INSERT [Entidad].[Terceros] OFF
GO
INSERT [Entidad].[Empleados] ([idcompania], [id], [idterceros], [idtipo], [iddepartamento], [horaentrada], [horasalida], [horabreaki], [horabreaks], [disponible], [fechareg], [estado]) VALUES (1, 1, 5, 1, 1, CAST(N'08:00:00' AS Time), CAST(N'05:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 1, CAST(N'2020-04-20T00:00:00.000' AS DateTime), 1)
GO
INSERT [Entidad].[Empleados] ([idcompania], [id], [idterceros], [idtipo], [iddepartamento], [horaentrada], [horasalida], [horabreaki], [horabreaks], [disponible], [fechareg], [estado]) VALUES (1, 2, 1008, 1, 4, CAST(N'17:45:23' AS Time), CAST(N'17:45:23' AS Time), CAST(N'17:45:23' AS Time), CAST(N'17:45:23' AS Time), 1, CAST(N'2020-04-20T17:45:38.980' AS DateTime), 1)
GO
INSERT [Entidad].[Empleados] ([idcompania], [id], [idterceros], [idtipo], [iddepartamento], [horaentrada], [horasalida], [horabreaki], [horabreaks], [disponible], [fechareg], [estado]) VALUES (1, 3, 1009, 1, 3, CAST(N'17:45:40' AS Time), CAST(N'17:45:40' AS Time), CAST(N'17:45:40' AS Time), CAST(N'17:45:40' AS Time), 1, CAST(N'2020-04-20T17:45:49.860' AS DateTime), 1)
GO
INSERT [Entidad].[Empleados] ([idcompania], [id], [idterceros], [idtipo], [iddepartamento], [horaentrada], [horasalida], [horabreaki], [horabreaks], [disponible], [fechareg], [estado]) VALUES (1, 4, 1011, 1, 1, CAST(N'18:20:36' AS Time), CAST(N'18:20:36' AS Time), CAST(N'18:20:36' AS Time), CAST(N'18:20:36' AS Time), 1, CAST(N'2020-04-20T18:20:55.917' AS DateTime), 1)
GO
INSERT [reclamos].[Tipos_Niveles] ([idcompania], [id], [descripcion], [nivel]) VALUES (1, 1, N'Prioritario ', 3)
GO
INSERT [reclamos].[Tipos_Niveles] ([idcompania], [id], [descripcion], [nivel]) VALUES (1, 2, N'Normal', 2)
GO
INSERT [reclamos].[Tipos_Niveles] ([idcompania], [id], [descripcion], [nivel]) VALUES (1, 3, N'Bajo', 1)
GO
INSERT [reclamos].[Tipos_Niveles] ([idcompania], [id], [descripcion], [nivel]) VALUES (1, 4, N'Puede esperar.', 0)
GO
INSERT [reclamos].[Tipo_Reclamos] ([idcompania], [id], [iddepartamento], [idnivel], [descripcion], [estado]) VALUES (1, 1, 1, 1, N'Vencimiento', 1)
GO
INSERT [reclamos].[Tipo_Reclamos] ([idcompania], [id], [iddepartamento], [idnivel], [descripcion], [estado]) VALUES (1, 2, 1, 1, N'Producto averiado', 1)
GO
INSERT [reclamos].[Tipo_Reclamos] ([idcompania], [id], [iddepartamento], [idnivel], [descripcion], [estado]) VALUES (1, 3, 5, 2, N'Cheque Erroneo', 1)
GO
INSERT [reclamos].[Tipo_Reclamos] ([idcompania], [id], [iddepartamento], [idnivel], [descripcion], [estado]) VALUES (1, 5, 6, 1, N'Ncf de la factura esta vencido', 1)
GO
INSERT [Gen].[Tipos_Clientes] ([idcompania], [id], [nombre]) VALUES (1, 1, N'Normal')
GO
INSERT [Entidad].[Clientes] ([idcompania], [id], [idtercero], [idtipo], [estado]) VALUES (1, 1, 2, 1, 1)
GO
INSERT [Entidad].[Clientes] ([idcompania], [id], [idtercero], [idtipo], [estado]) VALUES (1, 2, 3, 1, 1)
GO
INSERT [Entidad].[Clientes] ([idcompania], [id], [idtercero], [idtipo], [estado]) VALUES (1, 3, 4, 1, 1)
GO
INSERT [Entidad].[Clientes] ([idcompania], [id], [idtercero], [idtipo], [estado]) VALUES (1, 4, 1010, 1, 1)
GO
INSERT [reclamos].[Transacciones] ([idcompania], [id], [idtipo], [idcliente], [idoperador], [fecha], [HoraAtendido], [HoraDespachado], [estado], [nota]) VALUES (1, 1, 1, 1, 1, CAST(N'2020-04-16T17:10:33.900' AS DateTime), CAST(N'17:10:26' AS Time), CAST(N'2020-04-20T12:34:40.277' AS DateTime), 0, N'Muy bien')
GO
INSERT [reclamos].[Transacciones] ([idcompania], [id], [idtipo], [idcliente], [idoperador], [fecha], [HoraAtendido], [HoraDespachado], [estado], [nota]) VALUES (1, 2, 2, 2, 1, CAST(N'2020-04-16T17:12:48.620' AS DateTime), CAST(N'17:12:40' AS Time), CAST(N'1900-01-01T17:12:48.000' AS DateTime), 1, N'ok')
GO
INSERT [reclamos].[Transacciones] ([idcompania], [id], [idtipo], [idcliente], [idoperador], [fecha], [HoraAtendido], [HoraDespachado], [estado], [nota]) VALUES (1, 3, 1, 3, 1, CAST(N'2020-04-16T17:13:37.863' AS DateTime), CAST(N'17:13:20' AS Time), CAST(N'1900-01-01T17:13:37.000' AS DateTime), 1, N'ok;')
GO
INSERT [reclamos].[Transacciones] ([idcompania], [id], [idtipo], [idcliente], [idoperador], [fecha], [HoraAtendido], [HoraDespachado], [estado], [nota]) VALUES (1, 4, 1, 2, 1, CAST(N'2020-04-16T17:14:07.373' AS DateTime), CAST(N'17:14:04' AS Time), CAST(N'2020-04-20T12:54:37.923' AS DateTime), 0, N'')
GO
INSERT [reclamos].[Transacciones] ([idcompania], [id], [idtipo], [idcliente], [idoperador], [fecha], [HoraAtendido], [HoraDespachado], [estado], [nota]) VALUES (1, 5, 1, 1, 1, CAST(N'2020-04-18T14:43:55.853' AS DateTime), CAST(N'14:43:49' AS Time), CAST(N'1900-01-01T14:43:55.000' AS DateTime), 1, N'ok')
GO
INSERT [reclamos].[Transacciones] ([idcompania], [id], [idtipo], [idcliente], [idoperador], [fecha], [HoraAtendido], [HoraDespachado], [estado], [nota]) VALUES (1, 6, 1, 1, 1, CAST(N'2020-04-20T13:05:45.627' AS DateTime), CAST(N'13:05:38' AS Time), CAST(N'1900-01-01T13:05:45.000' AS DateTime), 1, N'muy buen')
GO
INSERT [reclamos].[Transacciones] ([idcompania], [id], [idtipo], [idcliente], [idoperador], [fecha], [HoraAtendido], [HoraDespachado], [estado], [nota]) VALUES (1, 7, 5, 4, 3, CAST(N'2020-04-20T18:28:20.323' AS DateTime), CAST(N'18:27:58' AS Time), CAST(N'2020-04-20T18:35:34.107' AS DateTime), 0, N'LA FACTURA NO. 9968')
GO
INSERT [reclamos].[Transacciones_Detalle] ([idcompania], [id], [idaccion], [idempleado], [finicio], [ffin], [Nota], [estado]) VALUES (1, 1, 1, 1, CAST(N'2020-04-20T11:49:14.000' AS DateTime), CAST(N'2020-04-20T11:49:14.000' AS DateTime), N'1', 1)
GO
INSERT [reclamos].[Transacciones_Detalle] ([idcompania], [id], [idaccion], [idempleado], [finicio], [ffin], [Nota], [estado]) VALUES (1, 1, 2, 1, CAST(N'2020-04-15T11:00:00.000' AS DateTime), CAST(N'2020-04-16T13:30:00.000' AS DateTime), N'completado correctamente', 1)
GO
INSERT [reclamos].[Transacciones_Detalle] ([idcompania], [id], [idaccion], [idempleado], [finicio], [ffin], [Nota], [estado]) VALUES (1, 4, 2, 1, CAST(N'2020-04-20T12:54:10.000' AS DateTime), CAST(N'2020-04-20T12:54:10.000' AS DateTime), N'', 1)
GO
INSERT [reclamos].[Transacciones_Detalle] ([idcompania], [id], [idaccion], [idempleado], [finicio], [ffin], [Nota], [estado]) VALUES (1, 7, 9, 2, CAST(N'2020-04-20T18:31:34.000' AS DateTime), CAST(N'2020-04-20T18:31:34.000' AS DateTime), N'ESTUVO VENCIDO', 1)
GO
INSERT [reclamos].[Transacciones_Detalle] ([idcompania], [id], [idaccion], [idempleado], [finicio], [ffin], [Nota], [estado]) VALUES (1, 7, 10, 1, CAST(N'2020-04-20T19:00:27.000' AS DateTime), CAST(N'2020-04-20T20:30:27.000' AS DateTime), N'recibido', 1)
GO
INSERT [reclamos].[Transacciones_Detalle] ([idcompania], [id], [idaccion], [idempleado], [finicio], [ffin], [Nota], [estado]) VALUES (1, 7, 11, 4, CAST(N'2020-04-20T18:35:09.000' AS DateTime), CAST(N'2020-04-20T18:35:09.000' AS DateTime), N'FACTURADO', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 1, N'Cambiar Producto', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 2, N'Investigar Existencia', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 3, N'Probar Producto', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 4, N'Verificar otro modelo a ofrecer', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 5, N'Verficar fecha', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 6, N'Verificar cheque', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 7, N'Elaborar Nuevo Cheque', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 8, N'Firmar', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 9, N'Verificar en dgii si esta vencido', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 10, N'Solicitar al contable Ncf', 1)
GO
INSERT [reclamos].[Acciones] ([idcompania], [id], [descripcion], [estado]) VALUES (1, 11, N'Asignar ncf a factura', 1)
GO
INSERT [reclamos].[Tipos_Reclamos_Acciones] ([idcompania], [idtipo], [idaccion], [representa], [estado]) VALUES (1, 1, 2, CAST(50.00 AS Numeric(8, 2)), 1)
GO
INSERT [reclamos].[Tipos_Reclamos_Acciones] ([idcompania], [idtipo], [idaccion], [representa], [estado]) VALUES (1, 1, 5, CAST(50.00 AS Numeric(8, 2)), 1)
GO
INSERT [reclamos].[Tipos_Reclamos_Acciones] ([idcompania], [idtipo], [idaccion], [representa], [estado]) VALUES (1, 3, 6, CAST(25.00 AS Numeric(8, 2)), 1)
GO
INSERT [reclamos].[Tipos_Reclamos_Acciones] ([idcompania], [idtipo], [idaccion], [representa], [estado]) VALUES (1, 3, 7, CAST(50.00 AS Numeric(8, 2)), 1)
GO
INSERT [reclamos].[Tipos_Reclamos_Acciones] ([idcompania], [idtipo], [idaccion], [representa], [estado]) VALUES (1, 3, 8, CAST(25.00 AS Numeric(8, 2)), 1)
GO
INSERT [reclamos].[Tipos_Reclamos_Acciones] ([idcompania], [idtipo], [idaccion], [representa], [estado]) VALUES (1, 5, 9, CAST(25.00 AS Numeric(8, 2)), 1)
GO
INSERT [reclamos].[Tipos_Reclamos_Acciones] ([idcompania], [idtipo], [idaccion], [representa], [estado]) VALUES (1, 5, 10, CAST(50.00 AS Numeric(8, 2)), 1)
GO
INSERT [reclamos].[Tipos_Reclamos_Acciones] ([idcompania], [idtipo], [idaccion], [representa], [estado]) VALUES (1, 5, 11, CAST(25.00 AS Numeric(8, 2)), 1)
GO
SET IDENTITY_INSERT [Dir].[Pais] ON 
GO
INSERT [Dir].[Pais] ([id], [nombre]) VALUES (1, N'Republica Dominicana')
GO
SET IDENTITY_INSERT [Dir].[Pais] OFF
GO
SET IDENTITY_INSERT [Dir].[Provincias] ON 
GO
INSERT [Dir].[Provincias] ([idpais], [id], [nombre]) VALUES (1, 1, N'Santiago')
GO
SET IDENTITY_INSERT [Dir].[Provincias] OFF
GO
SET IDENTITY_INSERT [Dir].[Municipios] ON 
GO
INSERT [Dir].[Municipios] ([idpais], [idprovincia], [id], [nombre]) VALUES (1, 1, 1, N'Tamboril')
GO
SET IDENTITY_INSERT [Dir].[Municipios] OFF
GO
SET IDENTITY_INSERT [Dir].[Sector] ON 
GO
INSERT [Dir].[Sector] ([idpais], [idprovincia], [idmunicipio], [id], [nombre]) VALUES (1, 1, 1, 1, N'Centro de Tamboril ')
GO
SET IDENTITY_INSERT [Dir].[Sector] OFF
GO
SET IDENTITY_INSERT [Dir].[Paraje] ON 
GO
INSERT [Dir].[Paraje] ([idpais], [idprovincia], [idmunicipio], [idsector], [id], [nombre]) VALUES (1, 1, 1, 1, 1, N'Los polancos')
GO
SET IDENTITY_INSERT [Dir].[Paraje] OFF
GO
SET IDENTITY_INSERT [Dir].[Calles] ON 
GO
INSERT [Dir].[Calles] ([idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [id], [nombre]) VALUES (1, 1, 1, 1, 1, 1, N'Calle 1')
GO
INSERT [Dir].[Calles] ([idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [id], [nombre]) VALUES (1, 1, 1, 1, 1, 2, N'Calle 2')
GO
INSERT [Dir].[Calles] ([idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [id], [nombre]) VALUES (1, 1, 1, 1, 1, 3, N'Calle 3')
GO
INSERT [Dir].[Calles] ([idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [id], [nombre]) VALUES (1, 1, 1, 1, 1, 4, N'Calle 4')
GO
INSERT [Dir].[Calles] ([idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [id], [nombre]) VALUES (1, 1, 1, 1, 1, 5, N'Calle 5')
GO
INSERT [Dir].[Calles] ([idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [id], [nombre]) VALUES (1, 1, 1, 1, 1, 6, N'Calle 6')
GO
INSERT [Dir].[Calles] ([idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [id], [nombre]) VALUES (1, 1, 1, 1, 1, 7, N'Calle 7')
GO
SET IDENTITY_INSERT [Dir].[Calles] OFF
GO
INSERT [Gen].[Tipos_Direcciones] ([idcompania], [id], [nombre]) VALUES (1, 1, N'Casa')
GO
INSERT [Gen].[Tipos_Direcciones] ([idcompania], [id], [nombre]) VALUES (1, 2, N'Trabajo')
GO
INSERT [Gen].[Tipos_Direcciones] ([idcompania], [id], [nombre]) VALUES (1, 3, N'Estudio')
GO
INSERT [Entidad].[Direcciones] ([idcompania], [idtercero], [idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [idcalle], [idtipo], [referencia]) VALUES (1, 2, 1, 1, 1, 1, 1, 1, 1, N'Al lado de la play municipal')
GO
INSERT [Entidad].[Direcciones] ([idcompania], [idtercero], [idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [idcalle], [idtipo], [referencia]) VALUES (1, 3, 1, 1, 1, 1, 1, 1, 1, N'sd')
GO
INSERT [Entidad].[Direcciones] ([idcompania], [idtercero], [idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [idcalle], [idtipo], [referencia]) VALUES (1, 4, 1, 1, 1, 1, 1, 1, 1, N'1')
GO
INSERT [Entidad].[Direcciones] ([idcompania], [idtercero], [idpais], [idprovincia], [idmunicipio], [idsector], [idparaje], [idcalle], [idtipo], [referencia]) VALUES (1, 1010, 1, 1, 1, 1, 1, 1, 1, N'Al lado de la cafeteria perez')
GO
INSERT [Gen].[Tipos_Usuarios] ([idcompania], [id], [nombre], [nota]) VALUES (1, 1, N'Administrador', N'')
GO
INSERT [Gen].[Tipos_Usuarios] ([idcompania], [id], [nombre], [nota]) VALUES (1, 2, N'General', N'g')
GO
INSERT [Entidad].[Usuarios] ([idcompania], [id], [idterceros], [idtipo], [usuario], [clave], [autorizar], [fecharegistro], [usuarioreg], [estado]) VALUES (1, 1, 1, 1, N'MILTON J', 0x0200CA6AC8958D5858DD440A9513EAA3660B2AD4D91774B5E271690CD2DCA0A84F360254E60C4998A613844FD192DA7CB01EEE5C5EC2F3A9083D56755B5E596E92A2FAEF4645, 1, CAST(N'2020-03-30T00:00:00.000' AS DateTime), N'Directo', 1)
GO
INSERT [Entidad].[Usuarios] ([idcompania], [id], [idterceros], [idtipo], [usuario], [clave], [autorizar], [fecharegistro], [usuarioreg], [estado]) VALUES (1, 2, 1005, 1, N'jj', 0x020025A181C8F9B84D6C5AFC9F51AB3D3B7DA75CFF722442E76A383C4626DFEC526EAE7946C1BD6845C2353A0D38952E411C376C01B0BEDA47CAC45E93CBBD884B9C50A36268, 1, CAST(N'2020-04-16T21:05:41.283' AS DateTime), N'Prueba', 1)
GO
INSERT [Entidad].[Usuarios] ([idcompania], [id], [idterceros], [idtipo], [usuario], [clave], [autorizar], [fecharegistro], [usuarioreg], [estado]) VALUES (1, 3, 1006, 1, N'Adrian', 0x02006DDCFB2DA6B69B8B9256A4DA7F94CA147965B62D7C7AB4123B41778A932FAF8F9BFF60BAEB069CA32420608A54DF9EE5E5310F9A925E184438D80F0E96FBDC2EEAD96F98, 1, CAST(N'2020-04-16T21:26:02.747' AS DateTime), N'Prueba', 1)
GO
INSERT [Entidad].[Usuarios] ([idcompania], [id], [idterceros], [idtipo], [usuario], [clave], [autorizar], [fecharegistro], [usuarioreg], [estado]) VALUES (1, 4, 1007, 1, N'Admin', 0x02007514C52E9D1D7155A0BFA4D430BCBCBCE3A68F4BC3952F2299FD361E3908E3BA8F0D83A6558503983CD8A9A4565018E0A2C851873E43AE27787A1594253CCAC91305C7E2, 1, CAST(N'2020-04-20T13:13:25.677' AS DateTime), N'MILTON J', 1)
GO
INSERT [Gen].[Tipos_RedesSociales] ([idcompania], [id], [nombre]) VALUES (1, 1, N'Facebook')
GO
INSERT [Gen].[Tipos_RedesSociales] ([idcompania], [id], [nombre]) VALUES (1, 2, N'Instagram')
GO
INSERT [Gen].[Tipos_RedesSociales] ([idcompania], [id], [nombre]) VALUES (1, 3, N'Whatsapp')
GO
INSERT [Gen].[Tipos_RedesSociales] ([idcompania], [id], [nombre]) VALUES (1, 4, N'Twitter')
GO
INSERT [Gen].[Tipos_RedesSociales] ([idcompania], [id], [nombre]) VALUES (1, 5, N'Telegram')
GO
INSERT [Gen].[Tipos_RedesSociales] ([idcompania], [id], [nombre]) VALUES (1, 6, N'Snapchat')
GO
INSERT [Gen].[Tipos_Correos] ([idcompania], [id], [nombre]) VALUES (1, 1, N'Personal')
GO
INSERT [Gen].[Tipos_Correos] ([idcompania], [id], [nombre]) VALUES (1, 2, N'Empresarial')
GO
INSERT [Gen].[Tipos_Correos] ([idcompania], [id], [nombre]) VALUES (1, 3, N'Estudiantil')
GO
INSERT [Entidad].[Correos] ([idcompania], [idterceros], [idtipo], [id], [correo]) VALUES (1, 2, 1, 1, N'miltonjcc@gmail.com')
GO
INSERT [Entidad].[Correos] ([idcompania], [idterceros], [idtipo], [id], [correo]) VALUES (1, 3, 1, 1, N'')
GO
INSERT [Entidad].[Correos] ([idcompania], [idterceros], [idtipo], [id], [correo]) VALUES (1, 4, 1, 1, N'')
GO
INSERT [Entidad].[Correos] ([idcompania], [idterceros], [idtipo], [id], [correo]) VALUES (1, 1005, 1, 1, N'll')
GO
INSERT [Entidad].[Correos] ([idcompania], [idterceros], [idtipo], [id], [correo]) VALUES (1, 1006, 1, 1, N'AdrianEmile@gmail.cm')
GO
INSERT [Entidad].[Correos] ([idcompania], [idterceros], [idtipo], [id], [correo]) VALUES (1, 1007, 1, 1, N'')
GO
INSERT [Entidad].[Correos] ([idcompania], [idterceros], [idtipo], [id], [correo]) VALUES (1, 1010, 1, 1, N'Camilo@gmail.com')
GO
INSERT [Entidad].[Personas] ([idcompania], [idterceros], [apellidos], [sexo], [estatura], [nacio], [estadocivil], [idestado], [extranjero], [idocupacion], [fecharegistro], [usuarioregistro], [estado]) VALUES (1, 2, N'Lopez', 0, N'', CAST(N'2020-04-13T11:50:51.580' AS DateTime), N'', 0, 0, 0, CAST(N'2020-04-13T11:50:51.580' AS DateTime), N'directo', 1)
GO
INSERT [Entidad].[Personas] ([idcompania], [idterceros], [apellidos], [sexo], [estatura], [nacio], [estadocivil], [idestado], [extranjero], [idocupacion], [fecharegistro], [usuarioregistro], [estado]) VALUES (1, 3, N'Martinez Pozo', 0, N'', CAST(N'2020-04-13T12:47:14.803' AS DateTime), N'', 0, 0, 0, CAST(N'2020-04-13T12:47:14.803' AS DateTime), N'directo', 1)
GO
INSERT [Entidad].[Personas] ([idcompania], [idterceros], [apellidos], [sexo], [estatura], [nacio], [estadocivil], [idestado], [extranjero], [idocupacion], [fecharegistro], [usuarioregistro], [estado]) VALUES (1, 4, N'', 0, N'', CAST(N'2020-04-13T12:48:39.480' AS DateTime), N'', 0, 0, 0, CAST(N'2020-04-13T12:48:39.480' AS DateTime), N'directo', 1)
GO
INSERT [Entidad].[Personas] ([idcompania], [idterceros], [apellidos], [sexo], [estatura], [nacio], [estadocivil], [idestado], [extranjero], [idocupacion], [fecharegistro], [usuarioregistro], [estado]) VALUES (1, 1005, N'd', 0, N'', CAST(N'2020-04-16T21:05:41.257' AS DateTime), N'', 0, 0, 0, CAST(N'2020-04-16T21:05:41.257' AS DateTime), N'directo', 1)
GO
INSERT [Entidad].[Personas] ([idcompania], [idterceros], [apellidos], [sexo], [estatura], [nacio], [estadocivil], [idestado], [extranjero], [idocupacion], [fecharegistro], [usuarioregistro], [estado]) VALUES (1, 1006, N'Collado', 0, N'', CAST(N'2020-04-16T21:26:02.727' AS DateTime), N'', 0, 0, 0, CAST(N'2020-04-16T21:26:02.727' AS DateTime), N'directo', 1)
GO
INSERT [Entidad].[Personas] ([idcompania], [idterceros], [apellidos], [sexo], [estatura], [nacio], [estadocivil], [idestado], [extranjero], [idocupacion], [fecharegistro], [usuarioregistro], [estado]) VALUES (1, 1007, N'Admin', 0, N'', CAST(N'2020-04-20T13:13:25.580' AS DateTime), N'', 0, 0, 0, CAST(N'2020-04-20T13:13:25.580' AS DateTime), N'directo', 1)
GO
INSERT [Entidad].[Personas] ([idcompania], [idterceros], [apellidos], [sexo], [estatura], [nacio], [estadocivil], [idestado], [extranjero], [idocupacion], [fecharegistro], [usuarioregistro], [estado]) VALUES (1, 1008, N'Hernandez', 0, N'', CAST(N'2020-04-20T17:45:39.000' AS DateTime), N'', 0, 0, 0, CAST(N'2020-04-20T17:45:39.000' AS DateTime), N'directo', 1)
GO
INSERT [Entidad].[Personas] ([idcompania], [idterceros], [apellidos], [sexo], [estatura], [nacio], [estadocivil], [idestado], [extranjero], [idocupacion], [fecharegistro], [usuarioregistro], [estado]) VALUES (1, 1009, N'Santana', 0, N'', CAST(N'2020-04-20T17:45:49.860' AS DateTime), N'', 0, 0, 0, CAST(N'2020-04-20T17:45:49.860' AS DateTime), N'directo', 1)
GO
INSERT [Entidad].[Personas] ([idcompania], [idterceros], [apellidos], [sexo], [estatura], [nacio], [estadocivil], [idestado], [extranjero], [idocupacion], [fecharegistro], [usuarioregistro], [estado]) VALUES (1, 1010, N'Martinez', 0, N'', CAST(N'2020-04-20T18:19:56.530' AS DateTime), N'', 0, 0, 0, CAST(N'2020-04-20T18:19:56.530' AS DateTime), N'directo', 1)
GO
INSERT [Entidad].[Personas] ([idcompania], [idterceros], [apellidos], [sexo], [estatura], [nacio], [estadocivil], [idestado], [extranjero], [idocupacion], [fecharegistro], [usuarioregistro], [estado]) VALUES (1, 1011, N'Jimenez', 0, N'', CAST(N'2020-04-20T18:20:55.930' AS DateTime), N'', 0, 0, 0, CAST(N'2020-04-20T18:20:55.930' AS DateTime), N'directo', 1)
GO
INSERT [Gen].[Tipos_Documentaciones] ([idcompania], [id], [nombre]) VALUES (1, 1, N'Cedula')
GO
INSERT [Gen].[Tipos_Documentaciones] ([idcompania], [id], [nombre]) VALUES (1, 2, N'Pasaporte')
GO
INSERT [Gen].[Tipos_Documentaciones] ([idcompania], [id], [nombre]) VALUES (1, 3, N'Rnc')
GO
INSERT [Gen].[Tipos_Documentaciones] ([idcompania], [id], [nombre]) VALUES (1, 4, N'Acta de nacimiento')
GO
INSERT [Gen].[Tipos_Telefonos] ([idcompania], [id], [nombre]) VALUES (1, 1, N'Casa')
GO
INSERT [Gen].[Tipos_Telefonos] ([idcompania], [id], [nombre]) VALUES (1, 2, N'Celular')
GO
INSERT [Gen].[Tipos_Telefonos] ([idcompania], [id], [nombre]) VALUES (1, 3, N'Flota')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 2, 1, 1, N'8095708848')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 2, 2, 1, N'8499189549')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 3, 1, 1, N'8095708850')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 3, 2, 1, N'')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 4, 1, 1, N'')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 4, 2, 1, N'')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 1005, 1, 1, N'80958888')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 1006, 1, 1, N'8099185696')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 1007, 1, 1, N'')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 1010, 1, 1, N'8095708550')
GO
INSERT [Entidad].[Telefonos] ([idcompania], [idterceros], [idtipo], [id], [telefono]) VALUES (1, 1010, 2, 1, N'')
GO
