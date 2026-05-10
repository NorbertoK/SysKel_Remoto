UPDATE  dbo.Direcciones
SET     Real = 1
       ,Cobranza = 1
WHERE   idProveedor IS NOT NULL
        AND Real IS NULL
        AND Cobranza IS NULL
        
UPDATE  dbo.Direcciones
SET     Real = 0
WHERE   idProveedor IS NOT NULL
        AND Real IS NULL

UPDATE  dbo.Direcciones
SET     Cobranza = 0
WHERE   idProveedor IS NOT NULL
        AND Cobranza IS NULL        
        
