USE [ArtSofteDB]
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployer]    Script Date: 21.12.2022 10:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[DeleteEmployer]
	@Id int

AS
BEGIN

	SET NOCOUNT ON;

	delete from Employers
	where id = @id
		
END