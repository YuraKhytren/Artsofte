USE [ArtSofteDB]
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmployers]    Script Date: 21.12.2022 10:16:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[GetAllEmployers]

AS
BEGIN

	SET NOCOUNT ON;

	select e.Id,
		   e.Name,
	       e.SurName,
	       e.Age,
		   e.Gender,
	       d.Name Department,
	       l.Name Language
	from Employers e (nolock)
	join Department d (nolock) on e.Department = d.id
	join Languages l (nolock) on e.Language = l.Id
		
END
