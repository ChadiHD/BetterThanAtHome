namespace BetterThanHome.Contracts._Menu;

public record MenuResponse(
    Guid Id,
    string Name,
    string MenuDetails,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Food,
    List<string> Ingredients);