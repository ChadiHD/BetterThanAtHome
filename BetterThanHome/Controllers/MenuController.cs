using BetterThanHome.Contracts._Menu;
using BetterThanHome.Application.Services.Menus;
using ErrorOr;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using BetterThanHome.Application.Models.MenuModel;

namespace BetterThanHome.Controllers;

//attribute applies inference rules for the default data sources of action parameters
[ApiController]
[Route("[Controller]")]
public class MenuController : ControllerBase
{
    private readonly IMenuService _menuService;

    public MenuController(IMenuService menuService)
    {
        _menuService = menuService;
    }

    [HttpPost]
    public IActionResult CreateMenu(CreateMenuRequest request)
    {
        // Create new menu object
        Menu menu = Menu.From(request);

        //Save to Database
        _menuService.CreateMenu(menu);

        return CreateAtGetMenu(menu);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetMenu(Guid id)
    {
        Menu menu = _menuService.GetMenu(id);

        return Ok(MapMenuResponse(menu));
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertMenu(Guid id, UpsertMenuRequest request)
    {
        Menu menu = Menu.From(id,request);
        
        UpsertedMenu upsertMenuResult = _menuService.UpsertMenu(menu);

        // return 201 if a new menu was created and nothing was found
        return upsertMenuResult.IsNewlyCreated ? CreateAtGetMenu(menu) : NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteMenu(Guid id)
    {
        _menuService.DeleteMenu(id);
        return NoContent();
    }

    private static MenuResponse MapMenuResponse(Menu menu)
    {
        return new MenuResponse(
            menu.Id,
            menu.Name,
            menu.MenuDetails,
            menu.StartDateTime,
            menu.EndDateTime,
            menu.LastModifiedDateTime,
            menu.Food,
            menu.Ingredients);
    }

    private CreatedAtActionResult CreateAtGetMenu(Menu menu)
    {
        return CreatedAtAction(
            actionName: nameof(GetMenu),
            routeValues: new { id = menu.Id },
            value: MapMenuResponse(menu));
    }
}