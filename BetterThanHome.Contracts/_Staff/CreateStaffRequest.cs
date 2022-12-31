namespace BetterThanHome.Contracts._Staff
{
    public record CreateStaffRequest(
        string FirstName,
        string LastName,
        string Email,
        int PhoneNr,
        DateTime DateOfEmployment,
        float Salary);
}
