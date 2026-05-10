-- Sólo para SAE Jujuy
-- Listado de proveedores con rubro no válido.
SELECT  *
FROM    dbo.Proveedores p
        JOIN dbo.Rubros r ON p.idRubro = r.idRubro
WHERE   r.AdmiteValores <> 1