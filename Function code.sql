-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
alter function [dbo].[Admin_Validation]( @adminId int, @adminPassword nvarchar(50) --@status bit output )returns intasbegindeclare @status int=0if exists(select * from Admin where adminId=@adminId and adminPassword=@adminPassword)begin set @status=1endreturn @status;end
