USE [ArtSofteDB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployer]    Script Date: 21.12.2022 10:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[UpdateEmployer]
	@Id int,
	@Name varchar(50),
	@Surname varchar(50),
	@Age int,
	@Gender varchar(10),
	@Department int,
	@Language int

AS
BEGIN

	SET NOCOUNT ON;

	update Employers
	set Name = @Name,
	    SurName = @Surname,
		Age = @Age,
		Gender = @Gender,
		Department = @Department,
		Language = @Language,
		Changed = cast(getdate() as datetime)
	where id = @Id
		

END
