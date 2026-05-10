SELECT * 
FROM dbo.Comprobantes comp
JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
WHERE comp.idComprobante = 365702