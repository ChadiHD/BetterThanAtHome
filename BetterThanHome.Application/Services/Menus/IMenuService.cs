using BetterThanHome.Application.Models.MenuModel;

namespace BetterThanHome.Application.Services.Menus;

public interface IMenuService
{
    void CreateMenu(Menu menu);
    void DeleteMenu(Guid id);
    Menu GetMenu(Guid id);
    UpsertedMenu UpsertMenu(Menu menu);
}