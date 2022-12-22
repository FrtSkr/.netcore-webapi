using webapi_challenge.Models;

namespace webapi_challenge.Repository
{
    public interface ICarRepository
    {
        //CRUD
        Car Add(Car entity);
        Car Delete(Car entity);
        Car GetById(int id);
        List<Car> GetByColor(String color);
        List<Car> GetAll();
        Car UpdateById(Car entity, int id);
    }
}
