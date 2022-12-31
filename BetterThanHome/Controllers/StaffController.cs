using BetterThanHome.Contracts._Staff;
using BetterThanHome.Application.Services.StaffMembers;
using Microsoft.AspNetCore.Mvc;
using BetterThanHome.Application.Models.StaffModel;

namespace BetterThanHome.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        // GET api/<StaffController>/id
        [HttpGet("{id:guid}")]
        public IActionResult GetStaff(Guid id)
        {
            Staff staff = _staffService.GetOrder(id);

            return Ok(MapStaffResponse(staff));
        }

        // POST api/<StaffController>
        [HttpPost]
        public IActionResult CreateStaff(CreateStaffRequest request)
        {
            Staff staff = Staff.From(request);
            _staffService.CreateStaff(staff);
            return CreateAtGetStaff(staff);
        }

        // PUT api/<StaffController>/id
        [HttpPut("{id:guid}")]
        public IActionResult UpsertStaff(Guid id, UpsertStaffRequest request)
        {
            Staff staff = Staff.From(id,request);

            UpsertedStaff upsertStaffResult = _staffService.UpsertedStaff(staff);

            return upsertStaffResult.IsNewlyCreated ? CreateAtGetStaff(staff) : NoContent();
        }

        // DELETE api/<StaffController>/id
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteStaff(Guid id)
        {
            _staffService.DeleteStaff(id);
            return NoContent();
        }

        private static StaffResponse MapStaffResponse(Staff staff)
        {
            return new StaffResponse(
                staff.Id,
                staff.FirstName,
                staff.LastName,
                staff.Email,
                staff.PhoneNr,
                staff.DateOfEmployment,
                staff.Salary);
        }

        private IActionResult CreateAtGetStaff(Staff staff)
        {
            return CreatedAtAction(
                actionName: nameof(GetStaff),
                routeValues: new { id = staff.Id },
                value: MapStaffResponse(staff));
        }
    }
}
