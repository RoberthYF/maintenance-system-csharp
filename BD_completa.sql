CREATE DATABASE DBmantenimiento;
GO---
USE DBmantenimiento
GO---

CREATE TABLE dbo.[Proveedor](
    [idProveedor] int IDENTITY(1,1) NOT NULL,
    [nombreProveedor] nvarchar(50) NOT NULL,
    [RUC] nvarchar(20) NOT NULL,
    [direccion] nvarchar(100) NULL,
    [rubro] nvarchar(50) NULL,
    [idCiudad] int NOT NULL,
    [estProveedor] bit NULL,
    CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
    (
        [idProveedor] ASC
    ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];

GO--
CREATE PROCEDURE dbo.[spListaProveedor]
AS
BEGIN
    SELECT idProveedor, nombreProveedor, RUC, direccion, rubro, idCiudad, estProveedor
    FROM Proveedor
    WHERE estProveedor = 1;
END;
GO

CREATE PROCEDURE dbo.[spInsertaProveedor]
    @nombreProveedor nvarchar(50),
    @RUC nvarchar(20),
    @direccion nvarchar(100),
    @rubro nvarchar(50),
    @idCiudad int,
    @estProveedor bit
AS
BEGIN
    INSERT INTO Proveedor (nombreProveedor, RUC, direccion, rubro, idCiudad, estProveedor)
    VALUES (@nombreProveedor, @RUC, @direccion, @rubro, @idCiudad, @estProveedor);
END;
GO

CREATE PROCEDURE dbo.[spEditaProveedor]
    @idProveedor int,
    @nombreProveedor nvarchar(50),
    @RUC nvarchar(20),
    @direccion nvarchar(100),
    @rubro nvarchar(50),
    @idCiudad int,
    @estProveedor bit
AS
BEGIN
    UPDATE Proveedor
    SET 
        nombreProveedor = @nombreProveedor,
        RUC = @RUC,
        direccion = @direccion,
        rubro = @rubro,
        idCiudad = @idCiudad,
        estProveedor = @estProveedor
    WHERE idProveedor = @idProveedor;
END;
GO

CREATE PROCEDURE dbo.[spDeshabilitaProveedor]
    @idProveedor int
AS
BEGIN
    UPDATE Proveedor
    SET estProveedor = 0
    WHERE idProveedor = @idProveedor;
END;
GO

-------------------------------------------------------------------------------------------
CREATE TABLE dbo.[UnidadesTransporte](
    [idUnidadTransporte] nvarchar(50) NOT NULL,
    [nombreUnidTransporte] nvarchar(50) NOT NULL,
    [placaUnidTransporte] nvarchar(15) NOT NULL,
	[marca] nvarchar (20) NOT NULL,
	[estUT] bit NULL,
    CONSTRAINT [PK_UndTransp] PRIMARY KEY CLUSTERED 
    (
        [idUnidadTransporte]
    ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];

DROP TABLE UnidadesTransporte 

CREATE PROCEDURE dbo.[spListarUT]
AS
BEGIN
    SELECT idUnidadTransporte, nombreUnidTransporte, placaUnidTransporte, marca, estUT
    FROM UnidadesTransporte
	WHERE estUT = 1;
END;
GO

DROP PROCEDURE spListarUT

CREATE PROCEDURE dbo.[spInsertarUT]
    @idUnidadTransporte nvarchar(50),
    @nombreUnidTransporte nvarchar(50),
    @placaUnidTransporte nvarchar(15),
    @marca nvarchar(20),
	@estUT bit
AS
BEGIN
    INSERT INTO UnidadesTransporte (idUnidadTransporte, nombreUnidTransporte, placaUnidTransporte, marca, estUT)
    VALUES (@idUnidadTransporte, @nombreUnidTransporte, @placaUnidTransporte, @marca, @estUT);
END;
GO

DROP PROCEDURE spInsertarUT

CREATE PROCEDURE dbo.[spEditaUT]
	@idUnidadTransporte nvarchar(50),
    @nombreUnidTransporte nvarchar(50),
    @placaUnidTransporte nvarchar(15),
    @marca nvarchar(20),
	@estUT bit
AS
BEGIN
    UPDATE UnidadesTransporte
    SET
        nombreUnidTransporte = @nombreUnidTransporte,
        placaUnidTransporte = @placaUnidTransporte,
        marca = @marca,
		estUT = @estUT
    WHERE idUnidadTransporte = @idUnidadTransporte;
END;
GO

DROP PROCEDURE spEditaUT


CREATE PROCEDURE dbo.[spDeshabilitaUT]
    @idUnidadTransporte nvarchar(50)
AS
BEGIN
    UPDATE UnidadesTransporte
    SET estUT = 0
    WHERE idUnidadTransporte = @idUnidadTransporte;
END;
GO