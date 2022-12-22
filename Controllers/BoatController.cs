using Microsoft.AspNetCore.Mvc;
using webapi_challenge.Models;
using webapi_challenge.Service;

namespace webapi_challenge.Controllers
{
    [Route("api/boats/")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _boatService;

        public BoatController(IBoatService boatService)
        {
            this._boatService= boatService;
        }

        [HttpPost]
        public ActionResult Create(Boat boat)
        {
            var response = _boatService.Create(boat);
            return Ok(response);
        }

        [HttpGet("colors/{color}")]
        public ActionResult GetByColor(string color)
        {
            var response = _boatService.GetByColor(color);
            return Ok(response);
        }
        [HttpGet("id/{id}")]
        public ActionResult GetById(int id)
        {
            var response = _boatService.GetBoat(id);
            return Ok(response);
        }
        [HttpPost("{id}")]
        public ActionResult UpdateBoat(Boat boat, int id)
        {
            var response = _boatService.UpdateById(boat, id);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteBoat(int id)
        {
            var response = _boatService.Delete(id);
            return Ok(response);
        }

        [HttpGet]
        public ActionResult GetAllCars(int id)
        {
            var response = _boatService.GetAll();
            return Ok(response);
        }
    }
}
