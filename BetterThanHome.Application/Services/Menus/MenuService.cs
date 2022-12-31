using BetterThanHome.Application.Models.MenuModel;

namespace BetterThanHome.Application.Services.Menus;

public class MenuServices : IMenuService
{
    private static readonly Dictionary<Guid, Menu> _menus = new();

    public void CreateMenu(Menu menu)
    {
        _menus.Add(menu.Id, menu);
    }

    public void DeleteMenu(Guid id)
    {
        _menus.Remove(id);
    }

    public Menu GetMenu(Guid id)
    {
        return _menus[id];
    }

    public UpsertedMenu UpsertMenu(Menu menu)
    {
        // checking if the _menus dictionary contains a key that is equal to the menu.Id property
        var isNewlyCreated = !_menus.ContainsKey(menu.Id);
        
        _menus[menu.Id] = menu;

        return new UpsertedMenu(isNewlyCreated);
    }
}