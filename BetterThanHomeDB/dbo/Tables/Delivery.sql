CREATE TABLE [dbo].[Delivery]
(
	[DeliveryId] INT NOT NULL PRIMARY KEY, 
    [DateOfDelivery] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [OrderId] INT NOT NULL, 
)
