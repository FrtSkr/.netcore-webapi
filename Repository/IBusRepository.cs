using webapi_challenge.Models;

namespace webapi_challenge.Repository
{
    public interface IBusRepository
    {
        Bus Add(Bus entity);
        Bus Delete(Bus entity);
        Bus GetById(int id);
        List<Bus> GetByColor(String color);
        List<Bus> GetAll();
        Bus UpdateById(Bus entity, int id);
    }
}

