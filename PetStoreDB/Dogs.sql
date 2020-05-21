CREATE TABLE [dbo].[Dogs]
(

	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [Gender] CHAR(1) NULL, 
    [Color] NVARCHAR(100) NULL, 
    [Age] int null
)
