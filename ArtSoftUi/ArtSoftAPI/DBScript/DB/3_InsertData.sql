USE [ArtSofteDB]

INSERT INTO Employers(Name,SurName,Age,Gender,Department,Language,Created,Changed)
VALUES ('Ivan','Dydchuk', 35,'M',1,1, cast(getdate() as datetime) , cast(getdate() as datetime)),
	   ('Anna','Vitalina', 25,'F',2,2,cast(getdate() as datetime) , cast(getdate() as datetime)),
	   ('Dmitry','Komarov', 40,'M',3,3, cast(getdate() as datetime) , cast(getdate() as datetime))

INSERT INTO Department(Name,Floor)
VALUES ('IT',1),
	   ('UI',2),
	   ('Business Analytics',3)

	   INSERT INTO Languages(Name)
VALUES ('C#'),
	   ('JS'),
	   ('Java')