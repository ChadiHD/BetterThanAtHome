namespace BetterThanHome.Contracts._Order
{
    public record OrderResponse(
        Guid Id,
        string OrderStatus,
        DateTime OrderDate,
        int GuestsNumber,
        List<Guest> Guests,
        List<Staff> StaffMembers,
        List<Dish> Dishes);
}
