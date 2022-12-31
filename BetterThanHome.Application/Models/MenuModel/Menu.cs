using BetterThanHome.Contracts._Menu;
using System.ComponentModel.DataAnnotations;

namespace BetterThanHome.Application.Models.MenuModel;

public class Menu
{
    public Guid Id { get; }
    [MinLength(3)]
    [MaxLength(50)]
    public string Name { get; }
    [MinLength(50)]
    [MaxLength(150)]
    public string MenuDetails { get; }
    public DateTime StartDateTime { get; }
    public DateTime EndDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public List<string> Food { get; }
    public List<string> Ingredients { get; }

    public Menu(
        Guid id,
        string name,
        string description,
        DateTime startDateTime,
        DateTime endDateTime,
        DateTime lastModifiedDateTime,
        List<string> food,
        List<string> ingredients)
    {
        // enfroce any logic we want
        Id = id;
        Name = name;
        MenuDetails = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
        Food = food;
        Ingredients = ingredients;
    }

    private static Menu Create(
        string name,
        string description,
        DateTime startDateTime,
        DateTime endDateTime,
        List<string> food,
        List<string> ingredients,
        Guid? id = null)
    {
        return new Menu(
            id ?? Guid.NewGuid(),
            name,
            description,
            startDateTime,
            endDateTime,
            DateTime.UtcNow,
            food,
            ingredients);
    }

    public static Menu From(Guid id, UpsertMenuRequest request)
    {
        return Create(
            request.Name,
            request.MenuDetails,
            request.StartDateTime,
            request.EndDateTime,
            request.Food,
            request.Ingredients,
            id);
    }

    public static Menu From(CreateMenuRequest request)
    {
        return Create(
            request.Name,
            request.MenuDetails,
            request.StartDateTime,
            request.EndDateTime,
            request.Food,
            request.Ingredients);
    }
}