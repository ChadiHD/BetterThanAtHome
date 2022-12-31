using BetterThanHome.Contracts._Dish;
using BetterThanHome.Application.Services.Dishes;
using Microsoft.AspNetCore.Mvc;
using BetterThanHome.Application.Models.DishModel;


namespace BetterThanHome.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly IDishService _dishService;

        public DishController(IDishService dishService)
        {
            _dishService = dishService;
        }
        
        // POST api/<DishController>
        [HttpPost]
        public IActionResult CreateDish(CreateDishRequest request)
        {
            Dish dish = Dish.From(request);

            _dishService.CreateDish(dish);

            return CreateAtGetDish(dish);
        }

        // GET api/<DishController>/5
        [HttpGet("{id:guid}")]
        public IActionResult GetDish(Guid id)
        {
            Dish dish = _dishService.GetDish(id);
            return Ok(MapDishResponse(dish));
        }

        // PUT api/<DishController>/5
        [HttpPut("{id:guid}")]
        public IActionResult UpsertDish(Guid id, UpsertDishRequest request)
        {
            Dish dish = Dish.From(id, request);
            UpsertedDish upsertDishResult = _dishService.UpsertedDish(dish);
            return upsertDishResult.IsNewlyCreated ? CreateAtGetDish(dish) : NoContent();
        }

        // DELETE api/<DishController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDish(Guid id)
        {
            _dishService.DeleteDish(id);
            return NoContent();
        }

        private static DishResponse MapDishResponse(Dish dish)
        {
            return new DishResponse(
                dish.Id,
                dish.DishName,
                dish.DishType,
                dish.Price,
                dish.PrepTime);
        }

        private IActionResult CreateAtGetDish(Dish dish)
        {
            return CreatedAtAction(
                actionName: nameof(GetDish),
                routeValues: new { id = dish.Id },
                value: MapDishResponse(dish));
        }
    }
}
