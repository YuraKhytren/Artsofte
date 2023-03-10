USE [ArtSofteDB]
GO
/****** Object:  StoredProcedure [dbo].[CreateEmployer]    Script Date: 21.12.2022 10:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CreateEmployer]
	@Name varchar(50),
	@Surname varchar(50),
	@Age int,
	@Gender varchar(10),
	@Department int,
	@Language int

AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO Employers(Name,SurName,Age,Gender,Department,Language,Created,Changed)
    VALUES (@Name,@Surname, @Age, @Gender ,@Department,@Language, cast(getdate() as datetime) , cast(getdate() as datetime))
		

END
