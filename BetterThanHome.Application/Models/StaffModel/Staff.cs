using BetterThanHome.Contracts._Staff;

namespace BetterThanHome.Application.Models.StaffModel
{
    public class Staff
    {
        /// <summary>
        /// The unique identifier for staff members
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// First name of the specified staff member
        /// </summary>
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public int PhoneNr { get; }
        public DateTime DateOfEmployment { get; }
        public float Salary { get; }

        public Staff(
            Guid id,
            string firstName,
            string lastName,
            string email,
            int phoneNr,
            DateTime dateOfEmployment,
            float salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNr = phoneNr;
            DateOfEmployment = dateOfEmployment;
            Salary = salary;
        }

        public static Staff Create(
            string firstName,
            string lastName,
            string email,
            int phoneNr,
            DateTime dateOfEmployment,
            float salary,
            Guid? id = null)
        {
            return new Staff(
                id ?? Guid.NewGuid(),
                firstName,
                lastName,
                email,
                phoneNr,
                dateOfEmployment,
                salary);
        }

        public static Staff From(Guid id, UpsertStaffRequest request)
        {
            return Create(
                request.FirstName,
                request.LastName,
                request.Email,
                request.PhoneNr,
                request.DateOfEmployment,
                request.Salary,
                id);
        }

        public static Staff From(CreateStaffRequest request)
        {
            return Create(
                request.FirstName,
                request.LastName,
                request.Email,
                request.PhoneNr,
                request.DateOfEmployment,
                request.Salary);
        }
    }
}
