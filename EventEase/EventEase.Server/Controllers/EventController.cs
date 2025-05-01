using Microsoft.AspNetCore.Mvc;
using EventEase.Shared.Models;

namespace EventEase.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Event>> GetEvents()
        {
            var events = new List<Event>
            {
                new Event { Id = 1, Name = "Conferencia de Innovación", Date = DateTime.Now.AddDays(1), Location = "Ciudad de México", Description ="" },
                new Event { Id = 2, Name = "Taller de Desarrollo Web", Date = DateTime.Now.AddDays(7), Location = "Guadalajara", Description ="" }
            };
            return Ok(events);
        }
    }
}