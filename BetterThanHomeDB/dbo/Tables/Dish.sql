CREATE TABLE [dbo].[Dish]
(
	[DishId] INT NOT NULL PRIMARY KEY, 
    [DishName] NVARCHAR(100) NOT NULL, 
    [DishType] NVARCHAR(100) NOT NULL, 
    [DishPrice] MONEY NOT NULL, 
    [PrepTime] TIME NOT NULL DEFAULT sysdatetime()
)
