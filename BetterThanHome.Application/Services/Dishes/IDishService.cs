using BetterThanHome.Application.Models.DishModel;

namespace BetterThanHome.Application.Services.Dishes
{
    public interface IDishService
    {
        void CreateDish(Dish dish);
        void DeleteDish(Guid id);
        Dish GetDish(Guid id);
        UpsertedDish UpsertedDish(Dish dish);
    }
}
