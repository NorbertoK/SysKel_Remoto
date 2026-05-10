UPDATE dbo.RenglonesFacturaProforma
SET PrecioUnitarioEscrito = ROUND(ISNULL(PrecioUnitarioEscrito,ISNULL(PrecioUnitario,0)) / (1+Porcentaje/100),2)
FROM dbo.RenglonesFacturaProforma rfp
JOIN dbo.PorcentajeIVA pIVA ON rfp.idPorcentajeIVA = pIVA.idPorcentajeIVA