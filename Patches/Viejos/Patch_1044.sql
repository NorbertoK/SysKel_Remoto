SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GuardarConsultaMiPyme
    @idComprobante INT
   ,@CUIT VARCHAR(11)
   ,@obligado VARCHAR(1)
   ,@montoDesde DECIMAL(2)
AS 
    BEGIN
        SET NOCOUNT ON;
        INSERT  INTO [Datos].[dbo].[ConsltasMiPyme]
                ([Fecha]
                ,[CUIT]
                ,[Obligado]
                ,[MontoDesde]
                ,[idComprobante]
                )
        VALUES  (GETDATE()
                ,@CUIT
                ,@obligado
                ,@montoDesde
                ,@idComprobante
                )
    END
GO
