using Microsoft.AspNetCore.Mvc;
using webapi_challenge.Models;
using webapi_challenge.Service;

namespace webapi_challenge.Controllers
{
    [Route("api/buses/")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;

        public BusController(IBusService busService)
        {
            this._busService = busService;
        }

        [HttpPost]
        public ActionResult Create(Bus bus)
        {
            var response = _busService.Create(bus);
            return Ok(response);
        }

        [HttpGet("colors/{color}")]
        public ActionResult GetByColor(string color)
        {
            var response = _busService.GetByColor(color);
            return Ok(response);
        }
        [HttpGet("id/{id}")]
        public ActionResult GetById(int id)
        {
            var response = _busService.GetBus(id);
            return Ok(response);
        }
        [HttpPost("{id}")]
        public ActionResult UpdateBus(Bus bus, int id)
        {
            var response = _busService.UpdateById(bus, id);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteBus(int id)
        {
            var response = _busService.Delete(id);
            return Ok(response);
        }

        [HttpGet]
        public ActionResult GetAllBuses(int id)
        {
            var response = _busService.GetAll();
            return Ok(response);
        }
    }
}
