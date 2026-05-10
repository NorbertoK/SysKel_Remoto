SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION Permanencia
    (
     @desde DATE
    ,@hasta DATE
    )
RETURNS VARCHAR(30)
AS 
    BEGIN
        DECLARE @Result VARCHAR(30) = ''

        DECLARE @anyos INT
        DECLARE @meses INT
        DECLARE @dias INT
    
        SET @anyos = CASE WHEN MONTH(@desde) > MONTH(@hasta) THEN DATEDIFF(yyyy, @desde, @hasta) - 1
                          WHEN MONTH(@desde) < MONTH(@hasta) THEN DATEDIFF(yyyy, @desde, @hasta)
                          WHEN MONTH(@desde) = MONTH(@hasta) THEN CASE WHEN DAY(@desde) > DAY(@hasta) THEN DATEDIFF(yyyy, @desde, @hasta) - 1
                                                                       ELSE DATEDIFF(yyyy, @desde, @hasta)
                                                                  END
                     END
           
        SET @desde = DATEADD(YEAR, @anyos, @desde)  		
            
        SET @meses = CASE WHEN DAY(@desde) > DAY(@hasta) THEN DATEDIFF(month, @desde, @hasta) - 1
                          ELSE DATEDIFF(month, @desde, @hasta)
                     END
        SET @desde = DATEADD(MONTH, @meses, @desde)    
        SET @dias = DATEDIFF(day, @desde, @hasta)
        IF @anyos = 1 
            SET @Result = '1 año'	
        IF @anyos > 1 
            SET @Result = (CAST(@anyos AS VARCHAR(3)) + ' años')
        IF @meses = 1 
            SET @Result = CASE WHEN @Result = '' THEN '1 mes'
                               ELSE @Result + ' 1 mes'
                          END
        ELSE 
            IF @meses > 1 
                SET @Result = CASE WHEN @Result = '' THEN (CAST(@meses AS VARCHAR(2)) + ' meses')
                                   ELSE @Result + ' ' + (CAST(@meses AS VARCHAR(2)) + ' meses')
                              END
        IF @dias = 0 
            SET @Result = CASE WHEN @Result = '' THEN '0 días'
                               ELSE @Result
                          END
        ELSE IF @dias = 1 
            SET @Result = CASE WHEN @Result = '' THEN '1 día'
                               ELSE @Result + ' 1 día'
                          END    
        ELSE IF @dias > 1 
            SET @Result = CASE WHEN @Result = '' THEN (CAST(@dias AS VARCHAR(2)) + ' días')
                               ELSE @Result + ' ' + (CAST(@dias AS VARCHAR(2)) + ' días')
                          END
        RETURN @Result

    END
GO

