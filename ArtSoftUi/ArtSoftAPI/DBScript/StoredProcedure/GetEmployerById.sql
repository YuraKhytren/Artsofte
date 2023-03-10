USE [ArtSofteDB]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployerById]    Script Date: 21.12.2022 11:53:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetEmployerById]
	@Id int
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
	where e.Id = @Id
		

END
