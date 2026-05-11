USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[FacturasSinCAE]    Script Date: 11/05/2026 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[FacturasSinCAE]
AS
    BEGIN
        SET NOCOUNT ON;
        DECLARE @token VARCHAR(MAX)
           ,@sign VARCHAR(MAX)
           ,@cuit VARCHAR(11)
        SELECT TOP 1
                @token = Token
               ,@sign = Sign_
        FROM    dbo.Parametros
        SELECT TOP 1
                @cuit = CUITEmpresa
        FROM    dbo.Sistemas
        SELECT  comp.idComprobante
               ,@token Token
               ,@sign _Sign
               ,CASE WHEN tc.Serie = 'A'
                          OR tc.Serie = 'M' THEN 80
                     ELSE CASE WHEN Importe >= 1000
                               THEN CASE WHEN LEN(comp.CUIT) = 11 THEN 80
                                         ELSE 96
                                    END
                               ELSE 99
                          END
                END tipoDoc
               ,@cuit CUIT
               ,comp.NombApel NombreCliente
               ,(SELECT ISNULL(comp.Direccion, '')
                        + CASE WHEN ISNULL(comp.Direccion, '') = '' THEN ''
                               ELSE ' '
                          END + CASE WHEN ISNULL(comp.Entre, '') = '' THEN ''
                                     ELSE comp.Entre
                                END
                        + CASE WHEN ISNULL(comp.Entre, '') = '' THEN ''
                               ELSE ' '
                          END
                        + CASE WHEN ISNULL(comp.ObservacionesDireccion, '') = ''
                               THEN ''
                               ELSE comp.ObservacionesDireccion
                          END
                ) DireccionCliente
               ,comp.Localidad LocalidadCliente
               ,prov.Nombre ProvinciaCliente
               ,catIVA.Nombre CategoriaIVA
               ,catIVA.idARCA CondicionIVAReceptorId
               ,CAST(tc.TablaAFIP AS INT) tipoCbte
               ,CAST(comp.Prefijo AS INT) puntoVta
               ,CASE WHEN tc.Serie = 'A'
                          OR tc.Serie = 'M'
                          OR Importe >= 1000 THEN comp.CUIT
                     ELSE '0'
                END nroDoc
               ,CAST(comp.NumeroDeComprobante AS BIGINT) cbtDesde
               ,CAST(comp.NumeroDeComprobante AS BIGINT) cbtHasta
               ,CAST(Importe AS VARCHAR(30)) impTotal
               ,CASE WHEN ISNULL(dbo.TotalNoGravado(idComprobante), 0) = 0
                     THEN '0'
                     ELSE CAST(dbo.TotalNoGravado(idComprobante) AS VARCHAR(30))
                END impTotConc
               ,CAST(dbo.TotalGravado(idComprobante) AS VARCHAR(30)) impNeto
               ,CAST(dbo.TotalIVA(idComprobante) AS VARCHAR(30)) impIVA
               ,'0.00' impTrib
               ,CAST(ISNULL(dbo.TotalExento(idComprobante), 0) AS VARCHAR(30)) impOpEx
               ,CONVERT(VARCHAR(8), Fecha, 112) fechaCbte
               ,CASE WHEN
                    tc.tipo = 'Factura'
                         OR
                         (tc.TablaAFIP IN (201, 204)
                              OR CONVERT(VARCHAR(8), CASE WHEN ServicioDesde IS NOT NULL
                                                          THEN ServicioDesde
                                                          ELSE CASE
                                                             WHEN Periodo IS NULL
                                                             OR Periodo = ''
                                                             THEN Fecha
                                                             ELSE dbo.PrimerDiaDelPeriodo(Periodo)
                                                             END
                                                     END, 112) IS NOT NULL
                           OR CONVERT(VARCHAR(8), CASE WHEN ServicioHasta IS NOT NULL
                                                          THEN ServicioHasta
                                                          ELSE CASE
                                                             WHEN Periodo IS NULL
                                                             OR Periodo = ''
                                                             THEN Fecha
                                                             ELSE dbo.UltimoDiaDelPeriodo(Periodo)
                                                             END
                                                     END, 112) IS NOT NULL
                              OR (Periodo IS NOT NULL
                                  AND Periodo != ''
                                 )
                             )
                    THEN CONVERT(VARCHAR(8), DATEADD(d, 10, Fecha), 112)
                END fechaVencPago
               ,CONVERT(VARCHAR(8), CASE WHEN ServicioDesde IS NOT NULL
                                         THEN ServicioDesde
                                         ELSE CASE WHEN Periodo IS NULL
                                                        OR Periodo = ''
                                                   THEN Fecha
                                                   ELSE dbo.PrimerDiaDelPeriodo(Periodo)
                                              END
                                    END, 112) fechaServDesde
               ,CONVERT(VARCHAR(8), CASE WHEN ServicioHasta IS NOT NULL
                                         THEN ServicioHasta
                                         ELSE CASE WHEN Periodo IS NULL
                                                        OR Periodo = ''
                                                   THEN Fecha
                                                   ELSE dbo.UltimoDiaDelPeriodo(Periodo)
                                              END
                                    END, 112) fechaServHasta
               ,CAST(dbo.TotalesIVA(idComprobante, 'Gravado', 3) AS VARCHAR(30)) baseImp3
               ,CAST(dbo.TotalesIVA(idComprobante, 'IVA', 3) AS VARCHAR(30)) importeIVA3
               ,CAST(dbo.TotalesIVA(idComprobante, 'Gravado', 4) AS VARCHAR(30)) baseImp4
               ,CAST(dbo.TotalesIVA(idComprobante, 'IVA', 4) AS VARCHAR(30)) importeIVA4
               ,CAST(dbo.TotalesIVA(idComprobante, 'Gravado', 5) AS VARCHAR(30)) baseImp5
               ,CAST(dbo.TotalesIVA(idComprobante, 'IVA', 5) AS VARCHAR(30)) importeIVA5
               ,CAST(dbo.TotalesIVA(idComprobante, 'Gravado', 6) AS VARCHAR(30)) baseImp6
               ,CAST(dbo.TotalesIVA(idComprobante, 'IVA', 6) AS VARCHAR(30)) importeIVA6
               ,CAST(dbo.TotalesIVA(idComprobante, 'Gravado', 8) AS VARCHAR(30)) baseImp8
               ,CAST(dbo.TotalesIVA(idComprobante, 'IVA', 8) AS VARCHAR(30)) importeIVA8
               ,CAST(dbo.TotalesIVA(idComprobante, 'Gravado', 9) AS VARCHAR(30)) baseImp9
               ,CAST(dbo.TotalesIVA(idComprobante, 'IVA', 9) AS VARCHAR(30)) importeIVA9
               ,CASE WHEN comp.idReferencia IS NULL THEN ''
                     ELSE (SELECT   tcr.TablaAFIP
                           FROM     dbo.Comprobantes compr
                                    JOIN dbo.TiposDeComprobante tcr ON compr.idTipoDeComprobante = tcr.idTipoDeComprobante
                           WHERE    idComprobante = comp.idReferencia
                          )
                END TipoCbteAsoc
               ,CASE WHEN comp.idReferencia IS NULL THEN ''
                     ELSE (SELECT   Prefijo
                           FROM     dbo.Comprobantes
                           WHERE    idComprobante = comp.idReferencia
                          )
                END PuntoVtaAsoc
               ,CASE WHEN comp.idReferencia IS NULL THEN ''
                     ELSE (SELECT   NumeroDeComprobante
                           FROM     dbo.Comprobantes
                           WHERE    idComprobante = comp.idReferencia
                          )
                END CbteNroAsoc
               ,CASE WHEN comp.idReferencia IS NULL THEN ''
                     ELSE (SELECT   CONVERT(VARCHAR(8), Fecha, 112)
                           FROM     dbo.Comprobantes
                           WHERE    idComprobante = comp.idReferencia
                          )
                END FechaCbteAsoc
               ,CASE WHEN comp.idReferencia IS NULL
                          OR CHARINDEX(CAST(tc.TablaAFIP AS VARCHAR(3)),
                                       '203 206') = 0 THEN ''
                     ELSE 'N'
                END NdeCEsAnulacion
               ,tc.Nombre TipoComprobante
               ,comp.idTipoDeComprobante
               ,CASE WHEN comp.idGrupo IS NOT NULL
                     THEN CASE WHEN (SELECT TOP 1
                                            email
                                     FROM   dbo.Emails
                                     WHERE  idGrupo = comp.idGrupo
                                    ) IS NULL
                               THEN (SELECT TOP 1
                                            email
                                     FROM   dbo.Emails
                                     WHERE  idAfiliado = [dbo].[AfiliadoTitularDelGrupoIdGrupo](comp.idGrupo)
                                    )
                               ELSE (SELECT TOP 1
                                            email
                                     FROM   dbo.Emails
                                     WHERE  idGrupo = comp.idGrupo
                                    )
                          END
                     WHEN comp.idCliente IS NOT NULL
                     THEN (SELECT TOP 1
                                    email
                           FROM     dbo.Emails
                           WHERE    idCliente = comp.idCliente
                          )
                     ELSE NULL
                END Email
        FROM    dbo.Comprobantes comp
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                JOIN dbo.PuntosDeVenta pv ON comp.Prefijo = pv.Prefijo
                LEFT JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
                LEFT JOIN dbo.Localidades loc ON comp.Localidad = loc.Nombre
                LEFT JOIN dbo.Municipios muni ON loc.idMunicipio = muni.idMunicipio
                LEFT JOIN dbo.Provincias prov ON muni.idProvincia = prov.idProvincia
        WHERE   ISNULL(pv.SolicitaCAE, 0) > 0
                AND CAST(tc.TablaAFIP AS INT) IS NOT NULL
                AND ISNULL(CAE, '') = ''
                AND ISNULL(Anulado, 0) = 0
        ORDER BY idComprobante
    END
