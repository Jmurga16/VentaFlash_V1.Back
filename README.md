Prueba Tecnica Venta Flash
Back - End  C# .Net
Version 1 - 3 Capas ( Entidad, Negocio, Datos )

Pasos despues de clonar el repositorio
Para Abrir en local:

Ejecutar SQL Server y crear la Base de Datos
CREATE DATABASE DB_Oferton_V2

Abrir la Carpeta "Scripts"
Ejecutar los scripts de Sql Server en el siguiente orden:
1. CreacionTablas.sql
2. InsertarProducto.sql
3. USP_GET_Producto.sql
4. USP_MNT_Orden.sql

Luego...
En el archivo appsettings.json colocar la cadena de conexión a la base de datos local o nube.

Ejemplo:
"ConnectionStrings": {
    "connectionString": "server=.;database=DB_Oferton_V2;Trusted_Connection=True;"
}

Compilar.
