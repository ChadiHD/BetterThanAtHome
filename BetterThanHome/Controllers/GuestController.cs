using BetterThanHome.Contracts._Guest;
using BetterThanHome.Application.Services.Guests;
using Microsoft.AspNetCore.Mvc;
using BetterThanHome.Application.Models.GuestModel;

namespace BetterThanHome.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        // GET api/<GuestController>/5
        [HttpGet("{id:guid}")]
        public IActionResult GetGuest(Guid id)
        {
            Guest guest = _guestService.GetGuest(id);

            return Ok(MapGuestResponse(guest));
        }

        // POST api/<GuestController>
        [HttpPost]
        public IActionResult CreateGuest(CreateGuestRequest request)
        {
            Guest guest = Guest.From(request);

            _guestService.CreateGuest(guest);

            return CreateAtGetGuest(guest);

        }

        // PUT api/<GuestController>/5
        [HttpPut("{id:guid}")]
        public IActionResult UpsertMenu(Guid id, UpsertGuestRequest request)
        {
            Guest guest = Guest.From(id, request);

            UpsertedGuest upsertGuestResult = _guestService.UpsertGuest(guest);

            return upsertGuestResult.IsNewlyCreated ? CreateAtGetGuest(guest) : NoContent();
        }

        // DELETE api/<GuestController>/5
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteGuest(Guid id)
        {
            _guestService.DeleteGuest(id);
            return NoContent();
        }

        private static GuestResponse MapGuestResponse(Guest guest)
        {
            return new GuestResponse(
                guest.Id,
                guest.FirstName,
                guest.LastName,
                guest.Email,
                guest.PhoneNr,
                guest.Location);
        }

        private IActionResult CreateAtGetGuest(Guest guest)
        {
            return CreatedAtAction(
                actionName: nameof(GetGuest),
                routeValues: new { id = guest.Id },
                value: MapGuestResponse(guest));
        }
    }
}
