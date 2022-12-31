namespace BetterThanHome.Contracts
{
    public record Guest(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        int PhoneNr,
        string Location);

    public record Staff(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        int PhoneNr,
        DateTime DateOfEmployment,
        float Salary);

    public record Dish(
        Guid Id,
        string DishName,
        string DishType,
        float Price,
        DateTime PrepTime);

    public record Order(
        Guid Id,
        string orderStatus,
        DateTime orderDate,
        int guestsNumber,
        List<Guest> guests,
        List<Staff> staffMembers,
        List<Dish> dishes);
}

