USE [Datos]
GO

/****** Object:  UserDefinedFunction [dbo].[Subtotal]    Script Date: 01/17/2021 18:01:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subtotal]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Subtotal]
GO


