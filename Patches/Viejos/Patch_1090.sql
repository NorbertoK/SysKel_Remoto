UPDATE  dbo.TiposDeComprobante
SET     Compra = 1
WHERE   idTipoDeComprobante IN (5, 9)
        OR idTipoDeComprobante > 11
        
UPDATE  dbo.TiposDeComprobante
SET     Compra = 0
WHERE   Compra IS NULL

DELETE  dbo.TiposDeComprobante
WHERE   idTipoDeComprobante = 10