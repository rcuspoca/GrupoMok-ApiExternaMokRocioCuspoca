# GrupoMok-ApiExternaMokRocioCuspoca

1.  Esta es una Api secundaria llamada APIExternaMok para consultar la Identificación del Tipo de Documento basado la abreviatura del tipo de documento que ingresa como parámetro.
2.  Posee un controlador llamado TipoDocumento.Controller con un método de petición GET.
3. Contiene un tabla llamada TipoIdentificacion, es necesario alimentar la tabla previo a lanzar la consulta. Se adjunta el script de inserción de datos:
4. INSERT [dbo].[TipoIdentificacion] ([IdTipoIdentificacion], [Abreviatura], [Descripcion], [Activo]) VALUES (1, N'CC', N'CedulaCiudadanía', 1)
INSERT [dbo].[TipoIdentificacion] ([IdTipoIdentificacion], [Abreviatura], [Descripcion], [Activo]) VALUES (2, N'TI', N'TarjetaIdentidad', 1)
INSERT [dbo].[TipoIdentificacion] ([IdTipoIdentificacion], [Abreviatura], [Descripcion], [Activo]) VALUES (4, N'CI', N'CedulaCiudadanía', 1)
INSERT [dbo].[TipoIdentificacion] ([IdTipoIdentificacion], [Abreviatura], [Descripcion], [Activo]) VALUES (5, N'PA', N'Pasaporte', 1)
INSERT [dbo].[TipoIdentificacion] ([IdTipoIdentificacion], [Abreviatura], [Descripcion], [Activo]) VALUES (6, N'MSI', N'MenorSinIdentificacion', 1)
INSERT [dbo].[TipoIdentificacion] ([IdTipoIdentificacion], [Abreviatura], [Descripcion], [Activo]) VALUES (7, N'ASI', N'AdultoSinIdentificacion', 1)
5. Se usa el ORM(Object Relational Mapping) : EntityFramework instalando el paquete Microsoft.EntityFrameworkCore.SqlServer.
6. Esta Api es consumida por la APINetMok cuando se está creando un estudiante.
