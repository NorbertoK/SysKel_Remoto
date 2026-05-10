USE [Datos]
GO

/****** Object:  UserDefinedFunction [dbo].[ObtenerNumeroDeComprobante]    Script Date: 07/16/2020 15:26:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObtenerNumeroDeComprobante]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[ObtenerNumeroDeComprobante]
GO


