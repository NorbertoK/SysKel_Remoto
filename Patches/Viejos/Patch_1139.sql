SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE BancoMacro 
	-- Add the parameters for the stored procedure here
    @jubilado INT = 0
   ,@periodo VARCHAR(7) = 0
AS 
    BEGIN
        SET NOCOUNT ON;

    -- Insert statements for procedure here
        SELECT  comp.NumeroTarjeta
               ,g.NombreTitularTarjeta
               ,g.NumeroDocumentoTitularTarjeta
               ,dbo.CantidadDeAfiliadosActivosDelGrupo(comp.idGrupo, GETDATE()) AS Afiliados
               ,comp.Saldo
        FROM    Comprobantes AS comp
        LEFT OUTER JOIN Grupos AS g ON comp.idGrupo = g.idGrupo
        WHERE   (comp.idEntidadDeCobranza = 1)
        --AND (CONVERT(BIT,ISNULL(g.Jubilado,0)) = CONVERT(BIT,@jubilado))
                AND g.Jubilado = @jubilado
                AND (g.Sucursal IS NOT NULL)
                AND (comp.Periodo = @periodo)
                AND (comp.Saldo > 0)
                AND (g.idTipoDeCobranza = 2)
        UNION ALL
        SELECT  comp.NumeroTarjeta
               ,cli.NombreTitularTarjeta
               ,cli.NumeroDocumentoTitularTarjeta
               ,NULL AS Afiliados
               ,comp.Saldo
        FROM    Comprobantes AS comp
        LEFT OUTER JOIN Clientes AS cli ON comp.idCliente = cli.idCliente
        WHERE   (comp.idEntidadDeCobranza = 1)
        --AND (CONVERT(BIT,ISNULL(cli.Jubilado,0)) = CONVERT(BIT,@jubilado))
                AND cli.Jubilado = @jubilado
                AND (cli.Sucursal IS NOT NULL)
                AND (comp.Periodo = @periodo)
                AND (comp.Saldo > 0)
                AND (cli.idTipoDeCobranza = 2)
    END
GO
