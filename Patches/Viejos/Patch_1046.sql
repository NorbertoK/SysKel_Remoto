USE [Datos]
GO

/****** Object:  Table [dbo].[ParametrosMal]    Script Date: 06/03/2020 11:36:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ParametrosMal]') AND type in (N'U'))
DROP TABLE [dbo].[ParametrosMal]
GO


