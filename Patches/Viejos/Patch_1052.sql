SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdateIdTipoDeComprobanteMiPyme @idComprobante INT
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @idTipoDeComprobanteOld INT
           ,@Tipo VARCHAR(10)
           ,@Serie VARCHAR(1)
           ,@idTipoDeComprobanteNew INT
        SELECT  @idTipoDeComprobanteOld = idTipoDeComprobante
        FROM    dbo.Comprobantes
        WHERE   idComprobante = @idComprobante
        SELECT  @Tipo = Tipo
               ,@Serie = Serie
        FROM    dbo.TiposDeComprobante
        WHERE   idTipoDeComprobante = @idTipoDeComprobanteOld
        SELECT  @idTipoDeComprobanteNew = idTipoDeComprobante
        FROM    dbo.TiposDeComprobante
        WHERE   Tipo = @Tipo
                AND Serie = @Serie
                AND TablaAFIP > 200
        UPDATE  dbo.Comprobantes
        SET     idTipoDeComprobante = @idTipoDeComprobanteNew
        WHERE   idComprobante = @idComprobante
    END
GO
