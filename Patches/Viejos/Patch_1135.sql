SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AfiliadosDeBaja]
    @Desde VARCHAR(8)
   ,@Hasta VARCHAR(8)
   ,@modo VARCHAR(8)
   ,@idPlan INT = 0
AS 
    BEGIN
        SET NOCOUNT ON;
        IF @modo = 'UnPlan' 
            SELECT  af.idafiliado
                   ,dbo.ApelNombTitular(af.idGrupo) [Nombre del Titular]
                   ,ApelNomb Nombre
                   ,[dbo].[EdadCompleta](af.FechaDeNacimiento, GETDATE()) Edad
                   ,pl.Nombre [Plan]
                   ,(SELECT CAST(sb.Fecha AS DATE)
                     FROM   dbo.Solicitudes sb
                     WHERE  sb.idSolicitud = (SELECT    MAX(idSolicitud)
                                              FROM      dbo.Solicitudes
                                              WHERE     AltaBajaSusp = 'A'
                                                        AND idAfiliado = af.idAfiliado
                                             )
                    ) [Fecha de Alta]
                   ,CAST(s.Fecha AS DATE) [Fecha de Baja]
                   ,dbo.Permanencia((SELECT CAST(sb.Fecha AS DATE)
                                     FROM   dbo.Solicitudes sb
                                     WHERE  sb.idSolicitud = (SELECT    MAX(idSolicitud)
                                                              FROM      dbo.Solicitudes
                                                              WHERE     AltaBajaSusp = 'A'
                                                                        AND idAfiliado = af.idAfiliado
                                                             )
                                    ), CAST(s.Fecha AS DATE)) Permanencia
                   ,mb.Nombre [Motivo de Baja]
                   ,dbo.TelefonosDelAfiliado(af.idAfiliado) Teléfono
                   ,CASE WHEN (SELECT TOP 1
                                        email
                               FROM     dbo.Emails
                               WHERE    idGrupo = af.idGrupo
                              ) IS NULL THEN (SELECT TOP 1
                                                        email
                                              FROM      dbo.Emails
                                              WHERE     idAfiliado = [dbo].[AfiliadoTitularDelGrupoIdGrupo](af.idGrupo)
                                             )
                         ELSE (SELECT TOP 1
                                        email
                               FROM     dbo.Emails
                               WHERE    idGrupo = af.idGrupo
                              )
                    END [e-mail]
                   ,CASE WHEN af.Titular = 1 THEN pl.Cuota
                         ELSE pl.CuotaAdherente
                    END Cuota
            FROM    dbo.Solicitudes s
            JOIN    dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
            JOIN    dbo.Planes pl ON ap.idPlan = pl.idPlan
            JOIN    dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
            JOIN    dbo.MotivosDeBaja mb ON s.idMotivoDeBaja = mb.idMotivoDeBaja
            WHERE   s.Fecha BETWEEN @desde AND dbo.Medianoche(@hasta)
                    AND s.AltaBajaSusp = 'B'
                    AND s.idSolicitud = (SELECT MAX(idSolicitud)
                                         FROM   dbo.Solicitudes
                                         WHERE  idAfiliado = af.idAfiliado
                                        )
                    AND ap.idPlan = @idPlan
            ORDER BY dbo.ApelNombTitular(idGrupo)
                   ,Titular DESC
                   ,ApelNomb 
        IF @modo = 'Todos' 
            SELECT  af.idafiliado
                   ,dbo.ApelNombTitular(af.idGrupo) [Nombre del Titular]
                   ,ApelNomb Nombre
                   ,[dbo].[EdadCompleta](af.FechaDeNacimiento, GETDATE()) Edad
                   ,pl.Nombre [Plan]
                   ,(SELECT CAST(sb.Fecha AS DATE)
                     FROM   dbo.Solicitudes sb
                     WHERE  sb.idSolicitud = (SELECT    MAX(idSolicitud)
                                              FROM      dbo.Solicitudes
                                              WHERE     AltaBajaSusp = 'A'
                                                        AND idAfiliado = af.idAfiliado
                                             )
                    ) [Fecha de Alta]
                   ,CAST(s.Fecha AS DATE) [Fecha de Baja]
                   ,dbo.Permanencia((SELECT CAST(sb.Fecha AS DATE)
                                     FROM   dbo.Solicitudes sb
                                     WHERE  sb.idSolicitud = (SELECT    MAX(idSolicitud)
                                                              FROM      dbo.Solicitudes
                                                              WHERE     AltaBajaSusp = 'A'
                                                                        AND idAfiliado = af.idAfiliado
                                                             )
                                    ), CAST(s.Fecha AS DATE)) Permanencia
                   ,mb.Nombre [Motivo de Baja]
                   ,dbo.TelefonosDelAfiliado(af.idAfiliado) Teléfono
                   ,CASE WHEN (SELECT TOP 1
                                        email
                               FROM     dbo.Emails
                               WHERE    idGrupo = af.idGrupo
                              ) IS NULL THEN (SELECT TOP 1
                                                        email
                                              FROM      dbo.Emails
                                              WHERE     idAfiliado = [dbo].[AfiliadoTitularDelGrupoIdGrupo](af.idGrupo)
                                             )
                         ELSE (SELECT TOP 1
                                        email
                               FROM     dbo.Emails
                               WHERE    idGrupo = af.idGrupo
                              )
                    END [e-mail]
                   ,CASE WHEN af.Titular = 1 THEN pl.Cuota
                         ELSE pl.CuotaAdherente
                    END Cuota
            FROM    dbo.Solicitudes s
            JOIN    dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
            JOIN    dbo.Planes pl ON ap.idPlan = pl.idPlan
            JOIN    dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
            JOIN    dbo.MotivosDeBaja mb ON s.idMotivoDeBaja = mb.idMotivoDeBaja
            WHERE   s.Fecha BETWEEN @desde AND dbo.Medianoche(@hasta)
                    AND s.AltaBajaSusp = 'B'
                    AND s.idSolicitud = (SELECT MAX(idSolicitud)
                                         FROM   dbo.Solicitudes
                                         WHERE  idAfiliado = af.idAfiliado
                                        )
            ORDER BY dbo.ApelNombTitular(idGrupo)
                   ,Titular DESC
                   ,ApelNomb 
        IF @modo = 'Contrato' 
            SELECT  af.idafiliado
                   ,dbo.ApelNombTitular(af.idGrupo) [Nombre del Titular]
                   ,ApelNomb Nombre
                   ,[dbo].[EdadCompleta](af.FechaDeNacimiento, GETDATE()) Edad
                   ,pl.Nombre [Plan]
                   ,(SELECT CAST(sb.Fecha AS DATE)
                     FROM   dbo.Solicitudes sb
                     WHERE  sb.idSolicitud = (SELECT    MAX(idSolicitud)
                                              FROM      dbo.Solicitudes
                                              WHERE     AltaBajaSusp = 'A'
                                                        AND idAfiliado = af.idAfiliado
                                             )
                    ) [Fecha de Alta]
                   ,CAST(s.Fecha AS DATE) [Fecha de Baja]
                   ,dbo.Permanencia((SELECT CAST(sb.Fecha AS DATE)
                                     FROM   dbo.Solicitudes sb
                                     WHERE  sb.idSolicitud = (SELECT    MAX(idSolicitud)
                                                              FROM      dbo.Solicitudes
                                                              WHERE     AltaBajaSusp = 'A'
                                                                        AND idAfiliado = af.idAfiliado
                                                             )
                                    ), CAST(s.Fecha AS DATE)) Permanencia
                   ,mb.Nombre [Motivo de Baja]
                   ,dbo.TelefonosDelAfiliado(af.idAfiliado) Teléfono
                   ,CASE WHEN (SELECT TOP 1
                                        email
                               FROM     dbo.Emails
                               WHERE    idGrupo = af.idGrupo
                              ) IS NULL THEN (SELECT TOP 1
                                                        email
                                              FROM      dbo.Emails
                                              WHERE     idAfiliado = [dbo].[AfiliadoTitularDelGrupoIdGrupo](af.idGrupo)
                                             )
                         ELSE (SELECT TOP 1
                                        email
                               FROM     dbo.Emails
                               WHERE    idGrupo = af.idGrupo
                              )
                    END [e-mail]
                   ,CASE WHEN af.Titular = 1 THEN pl.Cuota
                         ELSE pl.CuotaAdherente
                    END Cuota
            FROM    dbo.Solicitudes s
            JOIN    dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
            JOIN    dbo.Planes pl ON ap.idPlan = pl.idPlan
            JOIN    dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
            JOIN    dbo.MotivosDeBaja mb ON s.idMotivoDeBaja = mb.idMotivoDeBaja
            WHERE   s.Fecha BETWEEN @desde AND dbo.Medianoche(@hasta)
                    AND s.AltaBajaSusp = 'B'
                    AND s.idSolicitud = (SELECT MAX(idSolicitud)
                                         FROM   dbo.Solicitudes
                                         WHERE  idAfiliado = af.idAfiliado
                                        )
                    AND pl.idContrato IS NOT NULL
            ORDER BY dbo.ApelNombTitular(idGrupo)
                   ,Titular DESC
                   ,ApelNomb 
        IF @modo = 'Propios' 
            SELECT  af.idafiliado
                   ,dbo.ApelNombTitular(af.idGrupo) [Nombre del Titular]
                   ,ApelNomb Nombre
                   ,[dbo].[EdadCompleta](af.FechaDeNacimiento, GETDATE()) Edad
                   ,pl.Nombre [Plan]
                   ,(SELECT CAST(sb.Fecha AS DATE)
                     FROM   dbo.Solicitudes sb
                     WHERE  sb.idSolicitud = (SELECT    MAX(idSolicitud)
                                              FROM      dbo.Solicitudes
                                              WHERE     AltaBajaSusp = 'A'
                                                        AND idAfiliado = af.idAfiliado
                                             )
                    ) [Fecha de Alta]
                   ,CAST(s.Fecha AS DATE) [Fecha de Baja]
                   ,dbo.Permanencia((SELECT CAST(sb.Fecha AS DATE)
                                     FROM   dbo.Solicitudes sb
                                     WHERE  sb.idSolicitud = (SELECT    MAX(idSolicitud)
                                                              FROM      dbo.Solicitudes
                                                              WHERE     AltaBajaSusp = 'A'
                                                                        AND idAfiliado = af.idAfiliado
                                                             )
                                    ), CAST(s.Fecha AS DATE)) Permanencia
                   ,mb.Nombre [Motivo de Baja]
                   ,dbo.TelefonosDelAfiliado(af.idAfiliado) Teléfono
                   ,CASE WHEN (SELECT TOP 1
                                        email
                               FROM     dbo.Emails
                               WHERE    idGrupo = af.idGrupo
                              ) IS NULL THEN (SELECT TOP 1
                                                        email
                                              FROM      dbo.Emails
                                              WHERE     idAfiliado = [dbo].[AfiliadoTitularDelGrupoIdGrupo](af.idGrupo)
                                             )
                         ELSE (SELECT TOP 1
                                        email
                               FROM     dbo.Emails
                               WHERE    idGrupo = af.idGrupo
                              )
                    END [e-mail]
                   ,CASE WHEN af.Titular = 1 THEN pl.Cuota
                         ELSE pl.CuotaAdherente
                    END Cuota
            FROM    dbo.Solicitudes s
            JOIN    dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
            JOIN    dbo.Planes pl ON ap.idPlan = pl.idPlan
            JOIN    dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
            JOIN    dbo.MotivosDeBaja mb ON s.idMotivoDeBaja = mb.idMotivoDeBaja
            WHERE   s.Fecha BETWEEN @desde AND dbo.Medianoche(@hasta)
                    AND s.AltaBajaSusp = 'B'
                    AND s.idSolicitud = (SELECT MAX(idSolicitud)
                                         FROM   dbo.Solicitudes
                                         WHERE  idAfiliado = af.idAfiliado
                                        )
                    AND pl.idContrato IS NULL
            ORDER BY dbo.ApelNombTitular(idGrupo)
                   ,Titular DESC
                   ,ApelNomb
    END