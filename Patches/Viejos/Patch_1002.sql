USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[ExportarImpresionFacturasNuevo]    Script Date: 05/24/2019 23:04:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExportarImpresionFacturasNuevo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ExportarImpresionFacturasNuevo]
GO


