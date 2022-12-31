CREATE TABLE [dbo].[Staff]
(
	[StaffId] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [SurName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [PhoneNr] INT NOT NULL, 
    [DateOfEmployment] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [Salary] MONEY NOT NULL
)
