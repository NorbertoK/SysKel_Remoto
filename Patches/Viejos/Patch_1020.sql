INSERT  INTO [Datos].[dbo].[TiposDeComprobante]
        ([Nombre], [Iniciales], [ImporteNegativo], [DiscriminaIVA],
         [EsFactura], [Serie], [Tipo], [TablaAFIP])
VALUES  ('Factura de Crédito Electrónica MiPyME (FCE) A', 'FCEA', 0, 1, 1, 'A',
         'Factura', '201'),
        ('Nota de Crédito Electrónica MiPyME (FCE) A', 'NCEA', 1, 1, 0, 'A',
         'NdeC', '202'),
        ('Nota de Débito Electrónica MiPyME (FCE) A', 'NDEA', 1, 1, 0, 'A',
         'NdeD', '203'),
        ('Factura de Crédito Electrónica MiPyME (FCE) B', 'FCEB', 0, 1, 1, 'B',
         'Factura', '204'),
        ('Nota de Crédito Electrónica MiPyME (FCE) B', 'NCEB', 1, 1, 0, 'B',
         'NdeC', '205'),
        ('Nota de Débito Electrónica MiPyME (FCE) B', 'NDEB', 1, 1, 0, 'B',
         'NdeD', '206')
GO


