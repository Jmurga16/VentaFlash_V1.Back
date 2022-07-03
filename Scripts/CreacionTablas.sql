USE DB_Oferton_V1
GO

--CREACION DE TABLAS

--TABLA Alumnos
CREATE TABLE Producto(
    nIdProducto		 INT NOT NULL IDENTITY(1,1) PRIMARY KEY ,
    sNombreProducto	VARCHAR(MAX),
	sDescripcion	VARCHAR(MAX),
	nCalificacion	DECIMAL(4,2),
    nPrecio			DECIMAL(9,2),
	nStock			INT,
    sRutaImagen		VARCHAR(MAX)	
)
GO

--TABLA Cursos
CREATE TABLE Cliente(
    nIdCliente	INT NOT NULL IDENTITY(1,1) PRIMARY KEY ,
	sNombre		VARCHAR(MAX),
	sCorreo		VARCHAR(MAX),    
    sDireccion	VARCHAR(MAX)	
)
GO

--TABLA Notas
CREATE TABLE Ordenes(
    nIdOrden		 INT NOT NULL IDENTITY(1,1) PRIMARY KEY ,
	nIdProducto INT,
	FOREIGN KEY (nIdProducto) REFERENCES Producto(nIdProducto),
	nIdCliente  INT,
	FOREIGN KEY (nIdCliente) REFERENCES Cliente(nIdCliente),
	bEstado BIT
)
GO

