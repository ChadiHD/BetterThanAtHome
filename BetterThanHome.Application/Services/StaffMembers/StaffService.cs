using BetterThanHome.Application.Models.StaffModel;

namespace BetterThanHome.Application.Services.StaffMembers
{
    public class StaffService : IStaffService
    {
        private static readonly Dictionary<Guid, Staff> _staff = new();

        public void CreateStaff(Staff staff)
        {
            _staff.Add(staff.Id, staff);
        }

        public void DeleteStaff(Guid id)
        {
            _staff.Remove(id);
        }

        public Staff GetOrder(Guid id)
        {
            return _staff[id];
        }

        public UpsertedStaff UpsertedStaff(Staff staff)
        {
            // checking if the _staff dictionary contains a key that is equal to the menu.Id property
            var IsNewlyCreated = !_staff.ContainsKey(staff.Id);
            _staff[staff.Id] = staff;
            return new UpsertedStaff(IsNewlyCreated);
        }
    }
}
