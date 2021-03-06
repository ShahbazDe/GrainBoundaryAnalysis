USE [GBAnalysisDB]
GO
/****** Object:  StoredProcedure [dbo].[spSpecimens_Insert]    Script Date: 19-May-21 10:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- store procedure is defined for a specific table in a specific database
-- ================================================

-- =============================================
-- Author:		<Author,,Shahbaz Ahmed>
-- Create date: <Create Date,,19.05.2021>
-- Description:	<Description,,Store procedue which will store and read values from database and c# code>
-- =============================================
ALTER PROCEDURE [dbo].[spSpecimens_Insert]
--These are argument params which wil bridge sql objects with c# objects
@UserId int,
@UserName nvarchar(200),
@GBLabel nvarchar(50),
@GBEnergy float,
@SolidificationFactor float,
@ThermalFactor float,
@id int = 0 output

AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Specimens(UserID,UserName,GBLabel,GBEnergy,SolidificationFactor,ThermalFactor)--These are Columns in Table "dbo.Specimens" which wil be feed by below params
	values(@UserId,@UserName,@GBLabel,@GBEnergy,@SolidificationFactor,@ThermalFactor)-- These are argument param defined in c# and sql database both to communicate dbobject with c# object class

	select @id= SCOPE_IDENTITY();  -- this will send back id to c# as a last and updated id
END
