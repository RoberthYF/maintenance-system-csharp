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
