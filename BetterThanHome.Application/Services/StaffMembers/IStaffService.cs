using BetterThanHome.Application.Models.StaffModel;

namespace BetterThanHome.Application.Services.StaffMembers;
public interface IStaffService
{
    void CreateStaff(Staff staff);
    void DeleteStaff(Guid id);
    Staff GetOrder(Guid id);
    UpsertedStaff UpsertedStaff(Staff staff);
}

