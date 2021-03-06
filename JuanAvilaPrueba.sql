USE [master]
GO
--Creación de la base de datos
CREATE DATABASE [JuanAvilaPrueba]
GO
USE [JuanAvilaPrueba]
GO
GO
--Creación de la tabla "Persona"
CREATE TABLE [dbo].[Persona](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaDeNacimiento] [date] NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
)
