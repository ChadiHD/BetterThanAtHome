namespace BetterThanHome.Contracts._Dish
{
    public record CreateDishRequest(
        string DishName,
        string DishType,
        float Price,
        DateTime PrepTime);
    
}
