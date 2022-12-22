using webapi_challenge.Models;
using webapi_challenge.Repository;

namespace webapi_challenge.Service
{
    public class CarService : ICarService
    {
        //Dependency Injection
        private readonly ICarRepository _carRepository;

        public CarService (ICarRepository carRepository)
        {
            this._carRepository = carRepository;
        }
        public Car Create(Car car)
        {
            //business  logics
            return _carRepository.Add(car);
        }

        public Car Delete(int id)
        {
            var deleteCar = _carRepository.GetById(id);
            return _carRepository.Delete(deleteCar);
        }

        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public List<Car> GetByColor(string color)
        {
            return _carRepository.GetByColor(color);
        }

        public Car GetCar(int id)
        {
            return _carRepository.GetById(id);
        }

        public Car UpdateById(Car car, int id)
        {
            return _carRepository.UpdateById(car, id);
        }
    }

   
    
  
}
