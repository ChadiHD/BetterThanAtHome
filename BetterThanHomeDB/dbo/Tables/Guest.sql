CREATE TABLE [dbo].[Guest]
(
	[GuestId] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [SurName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [Password] NCHAR(100) NOT NULL, 
    [PhoneNr] INT NULL, 
    [Location] NVARCHAR(200) NULL
)
