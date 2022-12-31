CREATE TABLE [dbo].[Payment]
(
	[PayId] INT NOT NULL PRIMARY KEY, 
    [OrderId] INT NOT NULL, 
    [PaymentType] VARCHAR(50) NOT NULL, 
    [Amount] MONEY NOT NULL, 
    [DateOfPay] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [GuestId] INT NOT NULL, 
    [DeliveryId] INT NOT NULL, 
    
)
