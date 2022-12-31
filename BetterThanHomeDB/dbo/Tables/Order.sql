CREATE TABLE [dbo].[Order]
(
	[OrderId] INT NOT NULL PRIMARY KEY, 
    [OrderStatus] NVARCHAR(50) NOT NULL, 
    [OrderDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [GuestsNr] INT NOT NULL, 
    [GuestId] INT NOT NULL, 
    [StaffId] INT NOT NULL, 
    [FoodId] INT NOT NULL 
)
