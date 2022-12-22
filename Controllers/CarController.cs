using Microsoft.AspNetCore.Mvc;
using webapi_challenge.Models;
using webapi_challenge.Service;

namespace webapi_challenge.Controllers
{
    [Route("api/cars/")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            this._carService = carService;
        }

        [HttpPost]
        public ActionResult Create(Car car)
        {
            var response = _carService.Create(car);
            return Ok(response);
        }

        [HttpGet("colors/{color}")]
        public ActionResult GetByColor(string color)
        {
            var response = _carService.GetByColor(color);
            return Ok(response);
        }
        [HttpGet("id/{id}")]
        public ActionResult GetById(int id)
        {
            var response = _carService.GetCar(id);
            return Ok(response);
        }
        [HttpPost("{id}")]
        public ActionResult UpdateCar(Car car, int id) 
        { 
            var response = _carService.UpdateById(car, id);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteCar(int id)
        {
            var response = _carService.Delete(id);
            return Ok(response);
        }

        [HttpGet]
        public ActionResult GetAllCars(int id) {
            var response = _carService.GetAll();
            return Ok(response);
        }
    }
}
