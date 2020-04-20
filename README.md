# ReclamosApp

Reclamos App es una aplicación de escritorio para la gestión de reclamos hecho en Visual Studio 2019, lenguaje C#, con SQL Server 2019 de gestor de base de datos. Se realizó como complemento de la materia de Sistema y Tecnología de Información.


El proyecto de gestión de reclamos cuenta con un archivo de configuracion (config) en la ruta "\Reclamos_Sol\Reclamos\bin\Debug" de dicho proyecto. Este archivo denominado "Reclamos.exe" contiene los parámetros para la autentificación del servidor de base de datos Sql Server.

Ejemplo del formato del config:

<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <configSections>
    </configSections>
    <connectionStrings>
        <add name="Reclamos.Properties.Settings.Cadenasql" connectionString="Data Source=@NOMSERVIDORSQL;Initial Catalog=@BASEDEDATOS;User ID=@USER;Password=@PASS" />
    </connectionStrings>
</configuration>

Fin del ejemplo del formato del config.

Parámetros:

1. @NOMSERVIDORSQL = NOMBRE DEL SERVIDOR
2. @BASEDEDATOS = NOMBRE DE LA BASE DE DATOS
3. @USER = USUARIO PARA AUTENTIFICACION DEL LOGIN SQLSERVER.
4. @PASS = CLAVE PARA AUTENTIFICACION DEL LOGIN SQLSERVER.

Para modificar este config debes arrastrar el archivo a el bloc de notas y cambiar los parámetros antes mencionados.

Link del proyecto en GitHub:

https://github.com/MiltonJGrullon/ReclamosApp

Rutas para backup de la base de datos (.bak) (.sql):

•	Reclamos_Sol\BACKUP\RECLAMOS.BAK = (recomendable cuando tienes la version de sqlserver mayor o igual al 2018)

•	Reclamos_Sol\BACKUP\RECLAMOSSCHEMA.SQL / Reclamos_Sol\BACKUP\RECLAMOSDATA.SQL = en caso de usar este metodo para restaurar el backup,


Primero, se ejecuta el reclamos schema y luego el reclamos data. (recomendable cuando tienes la versión de sqlserver menor al 2018)

Notas: “Esto debe ser restaurado en tu sql server antes de configurar y ejecutar el sistema”
