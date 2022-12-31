namespace BetterThanHome.Contracts._Menu;

public record CreateMenuRequest(
    string Name,
    string MenuDetails,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Food,
    List<string> Ingredients);