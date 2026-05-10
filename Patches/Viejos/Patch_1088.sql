SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION CompraRepetida
    (
     @idProveedor INT
    ,@idTipoDeComprobante INT
    ,@comprobante VARCHAR(13)
    )
RETURNS INT
AS 
    BEGIN

	-- Add the T-SQL statements to compute the return value here
        IF EXISTS ( SELECT  *
                    FROM    dbo.Compras
                    WHERE   idProveedor = @idProveedor
                            AND idTipoDeComprobante = @idTipoDeComprobante
                            AND Comprobante = @comprobante ) 
            RETURN 1
        RETURN 0
    END
GO

