using BetterThanHome.Contracts._Dish;
using System.Runtime.InteropServices;

namespace BetterThanHome.Application.Models.DishModel
{
    public class Dish
    {
        public Guid Id { get; }
        public string DishName { get; }
        public string DishType { get; }
        public float Price { get; }
        public DateTime PrepTime { get; }

        public Dish(
        Guid id,
        string dishName,
        string dishType,
        float price,
        DateTime prepTime)
        {
            Id = id;
            DishName = dishName;
            DishType = dishType;
            Price = price;
            PrepTime = prepTime;
        }

        private static Dish Create(
            string dishName,
            string dishType,
            float price,
            DateTime prepTime,
            Guid? id = null)
        {
            return new Dish(
                id ?? Guid.NewGuid(),
                dishName,
                dishType,
                price,
                prepTime);
        }

        public static Dish From(Guid id, UpsertDishRequest request)
        {
            return Create(
                request.DishName,
                request.DishType,
                request.Price,
                request.PrepTime,
                id);
        }

        public static Dish From(CreateDishRequest request)
        {
            return Create(
                request.DishName,
                request.DishType,
                request.Price,
                request.PrepTime);
        }
    }



}
