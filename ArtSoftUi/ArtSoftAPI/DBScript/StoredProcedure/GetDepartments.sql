USE [ArtSofteDB]
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmployers]    Script Date: 21.12.2022 10:51:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[GetDepartments]

AS
BEGIN

	SET NOCOUNT ON;

	select d.Id,
		   d.Name
	from  Department d (nolock)
		

END
