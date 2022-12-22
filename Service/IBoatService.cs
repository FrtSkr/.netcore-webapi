using webapi_challenge.Models;

namespace webapi_challenge.Service
{
    public interface IBoatService
    {
        Boat Create(Boat boat);
        Boat GetBoat(int id);
        Boat Delete(int id);
        List<Boat> GetByColor(string color);
        Boat UpdateById(Boat boat, int id);
        List<Boat> GetAll();
    }
}
