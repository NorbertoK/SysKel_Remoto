SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION DetalleComprobante
    (
     @idDetalleComprobante INT
    )
RETURNS INT
AS 
    BEGIN
        DECLARE @Result INT
        SELECT  @Result = CASE WHEN comp.idGrupo IS NULL THEN dc.Detalle
                               ELSE dc.Nombre + ' - '
                                    + ISNULL(( SELECT   NumeroDeDocumento
                                               FROM     dbo.Afiliados af
                                               WHERE    idAfiliado = dc.idAfiliado
                                             ), '') + ' - ' + pl.Nombre
                                    + ' - ' + comp.Periodo
                          END
        FROM    dbo.DetallesComprobantes dc
                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                LEFT JOIN dbo.Planes pl ON dc.idPlan = pl.idPlan
        WHERE   idDetalleComprobante = @idDetalleComprobante
        RETURN @Result
    END
GO

