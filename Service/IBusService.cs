using webapi_challenge.Models;

namespace webapi_challenge.Service
{
    public interface IBusService
    {
        Bus Create(Bus bus);
        Bus GetBus(int id);
        Bus Delete(int id);
        List<Bus> GetByColor(string color);
        Bus UpdateById(Bus bus, int id);
        List<Bus> GetAll();
    }
}
