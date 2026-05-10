UPDATE  dbo.Autorizaciones
SET     Descripcion = 'Reportes - Adm - IVA Ventas'
WHERE   idAutorizacion = 84

INSERT  INTO [Datos].[dbo].[Autorizaciones]
        ([Descripcion]
        ,[idTipoDeAutorizacion]
        ,[Codigo]
        )
VALUES  ('Reportes - Adm - IVA Compras'
        ,1
        ,'MA-9058'
        )
GO

