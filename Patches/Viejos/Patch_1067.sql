UPDATE  dbo.TiposDeComprobante
SET     Nombre = 'Nota de Débito MiPyME A'
       ,iniciales = 'NDEA'
       ,ImporteNegativo = 0
       ,Tipo = 'NdeD'
WHERE   TablaAFIP = 202

UPDATE  dbo.TiposDeComprobante
SET     Nombre = 'Nota de Crédito MiPyME A'
       ,iniciales = 'NCEA'
       ,ImporteNegativo = 1
       ,Tipo = 'NdeC'
WHERE   TablaAFIP = 203

UPDATE  dbo.TiposDeComprobante
SET     Nombre = 'Nota de Débito MiPyME B'
       ,iniciales = 'NDEB'
       ,ImporteNegativo = 0
       ,Tipo = 'NdeD'
WHERE   TablaAFIP = 205

UPDATE  dbo.TiposDeComprobante
SET     Nombre = 'Nota de Crédito MiPyME B'
       ,iniciales = 'NCEB'
       ,ImporteNegativo = 1
       ,Tipo = 'NdeC'
WHERE   TablaAFIP = 206