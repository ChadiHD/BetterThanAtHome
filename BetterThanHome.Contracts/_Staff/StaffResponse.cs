namespace BetterThanHome.Contracts._Staff
{
    public record StaffResponse(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        int PhoneNr,
        DateTime DateOfEmployment,
        float Salary);
}
