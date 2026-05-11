USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[GuardarCAE]    Script Date: 11/05/2026 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GuardarCAE]
        @idComprobante          INT          = 0
      , @CAE                    VARCHAR(14)  = 0
      , @VencimientoCAE         VARCHAR(8)   = 0
      , @NumeroDeComprobante    VARCHAR(8)   = 0
      , @idtipodeComprobante    INT          = 0
AS
        BEGIN
                SET NOCOUNT ON;
                UPDATE     dbo.Comprobantes
                SET        CAE                    = @CAE
                         , VencimientoCAE         = @VencimientoCAE
                         , NumeroDeComprobante    = RIGHT(REPLICATE('0', 8) + @NumeroDeComprobante, 8)
                         , idTipoDeComprobante    = CASE WHEN @idtipodeComprobante = 0
                                                         THEN idTipoDeComprobante
                                                         ELSE @idtipodeComprobante
                                                    END
                WHERE      idComprobante          = @idComprobante
        END
