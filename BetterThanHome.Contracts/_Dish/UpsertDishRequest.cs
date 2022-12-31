namespace BetterThanHome.Contracts._Dish
{
    public record UpsertDishRequest(
        string DishName,
        string DishType,
        float Price,
        DateTime PrepTime);
}
