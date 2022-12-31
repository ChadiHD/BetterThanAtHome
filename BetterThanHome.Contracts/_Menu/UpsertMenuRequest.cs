namespace BetterThanHome.Contracts._Menu;

public record UpsertMenuRequest(
    string Name,
    string MenuDetails,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Food,
    List<string> Ingredients);