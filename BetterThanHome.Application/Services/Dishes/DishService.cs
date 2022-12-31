using BetterThanHome.Application.Models.DishModel;

namespace BetterThanHome.Application.Services.Dishes
{
    public class DishService : IDishService
    {
        private static readonly Dictionary<Guid, Dish> _dishes = new();

        public void CreateDish(Dish dish)
        {
            _dishes.Add(dish.Id, dish);
        }

        public void DeleteDish(Guid id)
        {
            _dishes.Remove(id);
        }

        public Dish GetDish(Guid id)
        {
            return _dishes[id];
        }

        public UpsertedDish UpsertedDish(Dish dish)
        {
            var isNewlyCreated = !_dishes.ContainsKey(dish.Id);
            _dishes[dish.Id] = dish;
            return new UpsertedDish(isNewlyCreated);
        }
    }
}
