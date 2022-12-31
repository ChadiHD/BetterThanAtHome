CREATE TABLE [dbo].[FinalTransactionReceipt]
(
	[TransactionId] INT NOT NULL PRIMARY KEY, 
    [TransactionDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [Details] NVARCHAR(MAX) NOT NULL, 
    [GuestId] INT NOT NULL, 
    [StaffId] INT NOT NULL, 
    [OrderId] INT NOT NULL
)
