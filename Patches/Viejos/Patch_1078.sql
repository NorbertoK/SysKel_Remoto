INSERT  INTO [Datos].[dbo].[TiposDeComprobante]
        ([Nombre], [Iniciales], [ImporteNegativo], [DiscriminaIVA],
         [EsFactura], [Serie], [Tipo], [TablaAFIP], [EsMiPyme])
VALUES  ('Factura C', 'F C', 0, 0, 1, 'C', 'Factura', NULL, 0),
        ('Nota de Crédito C', 'NCC', 1, 0, 0, 'C', 'NdeC', NULL, 0),
        ('Nota de Débito C', 'NDC', 0, 0, 0, 'C', 'NdeD', NULL, 0)
GO


