SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION DireccionCompletaDelComprobante 
(
	@idComprobante int
)
RETURNS varchar(200)
AS
BEGIN
	DECLARE @Result varchar(200)

	SELECT @Result = CASE WHEN ISNULL(Direccion, '') = ''
             THEN CASE WHEN ISNULL(ObservacionesDireccion, '') = ''
                       THEN '' + CASE WHEN ISNULL(Barrio, '') = '' THEN ''
                                      ELSE Barrio
                                 END
                            + CASE WHEN ISNULL(Barrio, '') != ''
                                        AND ISNULL(Localidad, '') != ''
                                   THEN ' - '
                                   ELSE ''
                              END
                            + CASE WHEN ISNULL(Localidad, '') = '' THEN ''
                                   ELSE Localidad
                              END
                       ELSE ObservacionesDireccion
                            + CASE WHEN ISNULL(Barrio, '') = '' THEN ''
                                   ELSE ' ' + Barrio
                              END
                            + CASE WHEN ISNULL(ObservacionesDireccion, '') != ''
                                        AND ISNULL(Localidad, '') != ''
                                   THEN ' - '
                                   ELSE ''
                              END
                            + CASE WHEN ISNULL(Localidad, '') = '' THEN ''
                                   ELSE Localidad
                              END
                  END
             ELSE Direccion + CASE WHEN ISNULL(Entre, '') = '' THEN ''
                                   ELSE ' ' + Entre 
                              END 
                            + CASE WHEN ISNULL(Barrio, '') = '' THEN ''
                                   ELSE ' ' + Barrio
                              END
                            + CASE WHEN ISNULL(Barrio, '') != ''
                                        AND ISNULL(Localidad, '') != '' THEN ' - '
                                   ELSE ''
                              END 
                            + CASE WHEN ISNULL(Localidad, '') = '' THEN ''
                                   ELSE Localidad
                              END
                            + CASE WHEN ISNULL(ObservacionesDireccion,'') = '' THEN ''
                                   ELSE ' (' + ObservacionesDireccion + ')'
                              END      
        END
FROM    comprobantes
WHERE idComprobante = @idComprobante

	RETURN @Result

END
GO

