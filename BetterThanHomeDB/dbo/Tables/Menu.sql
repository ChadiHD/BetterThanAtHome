CREATE TABLE [dbo].[Menu]
(
	[MenuId] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [MenuDetails] NVARCHAR(200) NOT NULL, 
    [StartDate] DATETIME2 NOT NULL, 
    [EndDate] DATETIME2 NOT NULL, 
    [Food] NVARCHAR(MAX) NULL, 
    [Ingredients] NVARCHAR(MAX) NULL
)
