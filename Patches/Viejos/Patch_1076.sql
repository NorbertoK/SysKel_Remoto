INSERT INTO [Datos].[dbo].[TiposDeComprobante]
           ([Nombre]
           ,[Iniciales]
           ,[ImporteNegativo]
           ,[DiscriminaIVA]
           ,[EsFactura]
           ,[Serie]
           ,[Tipo]
           ,[TablaAFIP]
           ,[EsMiPyme])
     VALUES
           ('Sin Factura'
           ,'S/F'
           ,0
           ,0
           ,1
           ,'X'
           ,'Factura'
           ,NULL
           ,NULL)
GO


