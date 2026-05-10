USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[GuardarConsultaMiPyme]    Script Date: 06/25/2020 19:56:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GuardarConsultaMiPyme]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GuardarConsultaMiPyme]
GO


