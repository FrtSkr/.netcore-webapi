using webapi_challenge.Models;

namespace webapi_challenge.Service
{
    public interface ICarService
    {
        Car Create(Car car);
        Car GetCar(int id);
        Car Delete(int id);
        List<Car> GetByColor(string color);
        Car UpdateById(Car car, int id);
        List<Car> GetAll();
    }
}
