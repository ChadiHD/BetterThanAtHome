namespace BetterThanHome.Contracts._Dish
{
    public record DishResponse(
        Guid id,
        string DishName,
        string DishType,
        float Price,
        DateTime PrepTime);
}
